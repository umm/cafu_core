using System;
using CAFU.Core.Domain.Model;
using UnityEngine;
using Object = UnityEngine.Object;

namespace CAFU.Core.Presentation.View
{
    // 本当は IMonoBehaviour 的なモノを継承したいところだが、そんな inteface ないので規約ベースで頑張る
    public interface IView
    {
    }

    public interface IInjectableView<in TModel> : IView where TModel : IModel
    {
        void Inject(TModel model);
    }

    public static class ViewExtension
    {
        public static IView AddChildView(this Transform transform, GameObject prefab)
        {
            return transform.AddChildView<IView>(prefab);
        }

        public static IView AddChildView<TModel>(this Transform transform, GameObject prefab, TModel model)
            where TModel : IModel
        {
            return transform.AddChildView<IView, TModel>(prefab, model);
        }

        public static TView AddChildView<TView>(this Transform transform, GameObject prefab)
            where TView : IView
        {
            var child = Object.Instantiate(prefab, transform);
            var childView = child.gameObject.GetComponent<TView>();
            if (childView == null)
            {
                throw new InvalidOperationException(string.Format("GameObject '{0}' has not attached component '{1}'.", child.name, typeof(TView).FullName));
            }

            return childView;
        }

        public static TView AddChildView<TView, TModel>(this Transform transform, GameObject prefab, TModel model)
            where TView : IView
            where TModel : IModel
        {
            var childView = transform.AddChildView<TView>(prefab);
            var childMonoBehaviour = childView as MonoBehaviour;
            if (childMonoBehaviour == default(MonoBehaviour))
            {
                throw new InvalidOperationException(string.Format("'{0}' is not inheritance MonoBehaviour.", typeof(TView).FullName));
            }

            if (childView is IInjectableView<TModel>)
            {
                ((IInjectableView<TModel>) childView).Inject(model);
            }

            return childView;
        }
    }
}