using System;
using CAFU.Core.Domain.Model;
using CAFU.Core.Presentation.Presenter;
using JetBrains.Annotations;
using UnityEngine;
using Object = UnityEngine.Object;

namespace CAFU.Core.Presentation.View
{
    // 本当は IMonoBehaviour 的なモノを継承したいところだが、そんな inteface ないので規約ベースで頑張る
    [PublicAPI]
    public interface IView
    {
    }

    [PublicAPI]
    public interface IInjectableView<in TModel> : IView where TModel : IModel
    {
        void Inject(TModel model);
    }

    [PublicAPI]
    public static class ViewExtension
    {
        public static string GetSceneName(this IView view)
        {
            var component = view as Component;
            if (component == null)
            {
                throw new InvalidCastException($"View '{view.GetType().FullName}' does not extends UnityEngine.Component.");
            }

            return component.gameObject.scene.name;
        }

        public static TPresenter GetPresenter<TPresenter>(this IView view) where TPresenter : IPresenter
        {
            return PresenterContainer.Instance.GetPresenter<TPresenter>(view.GetSceneName());
        }

        public static IView AddChildView(this Transform transform, Component prefab)
        {
            return transform.AddChildView(prefab.gameObject);
        }

        public static IView AddChildView(this Transform transform, GameObject prefab)
        {
            return transform.AddChildView<IView>(prefab);
        }

        public static IView AddChildView<TModel>(this Transform transform, Component prefab, TModel model)
            where TModel : IModel
        {
            return transform.AddChildView(prefab.gameObject, model);
        }

        public static IView AddChildView<TModel>(this Transform transform, GameObject prefab, TModel model)
            where TModel : IModel
        {
            return transform.AddChildView<IView, TModel>(prefab, model);
        }

        public static TView AddChildView<TView>(this Transform transform, TView prefab)
            where TView : Component, IView
        {
            return transform.AddChildView<TView>(prefab.gameObject);
        }

        public static TView AddChildView<TView>(this Transform transform, GameObject prefab)
            where TView : IView
        {
            var child = Object.Instantiate(prefab, transform);
            var childView = child.gameObject.GetComponent<TView>();
            if (childView == null)
            {
                throw new InvalidOperationException($"GameObject '{child.name}' has not attached component '{typeof(TView).FullName}'.");
            }

            return childView;
        }

        public static TView AddChildView<TView, TModel>(this Transform transform, TView prefab, TModel model)
            where TView : Component, IView
            where TModel : IModel
        {
            return transform.AddChildView<TView, TModel>(prefab.gameObject, model);
        }

        public static TView AddChildView<TView, TModel>(this Transform transform, GameObject prefab, TModel model)
            where TView : IView
            where TModel : IModel
        {
            var childView = transform.AddChildView<TView>(prefab);
            var childMonoBehaviour = childView as MonoBehaviour;
            if (childMonoBehaviour == default(MonoBehaviour))
            {
                throw new InvalidOperationException($"'{typeof(TView).FullName}' is not inheritance MonoBehaviour.");
            }

            (childView as IInjectableView<TModel>)?.Inject(model);

            return childView;
        }
    }
}