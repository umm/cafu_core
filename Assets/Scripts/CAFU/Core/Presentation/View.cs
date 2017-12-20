using System;
using System.Linq;
using CAFU.Core.Domain;
using UnityEngine;
using Object = UnityEngine.Object;

namespace CAFU.Core.Presentation.View {

    // 本当は IMonoBehaviour 的なモノを継承したいところだが、そんな inteface ないので規約ベースで頑張る
    public interface IView {

    }

    public interface IViewBuilder {

        void Build();

    }

    public interface IViewBuilder<in TModel> where TModel : IModel {

        void Build(TModel model);

    }

    public static class ViewExtension {

        public static IView AddChildView(this Transform transform, GameObject prefab) {
            return transform.AddChildView<IView>(prefab);
        }

        public static IView AddChildView<TModel>(this Transform transform, GameObject prefab, TModel model)
            where TModel : IModel {
            return transform.AddChildView<IView, TModel>(prefab, model);
        }

        public static TView AddChildView<TView>(this Transform transform, GameObject prefab)
            where TView : IView {
            GameObject child = Object.Instantiate(prefab, transform);
            TView childView = child.gameObject.GetComponent<TView>();
            if (childView == null) {
                throw new InvalidOperationException(string.Format("GameObject '{0}' has not attached component '{1}'.", child.name, typeof(TView).FullName));
            }
            return childView;
        }

        public static TView AddChildView<TView, TModel>(this Transform transform, GameObject prefab, TModel model)
            where TView : IView
            where TModel : IModel {
            TView childView = transform.AddChildView<TView>(prefab);
            MonoBehaviour childMonoBehaviour = childView as MonoBehaviour;
            if (childMonoBehaviour == default(MonoBehaviour)) {
                throw new InvalidOperationException(string.Format("'{0}' is not inheritance MonoBehaviour.", typeof(TView).FullName));
            }
            // Model 不要の IViewBuilder.Build() をコール
            childMonoBehaviour.gameObject.GetComponents<IViewBuilder>().ToList().ForEach(
                (x) => {
                    x.Build();
                }
            );
            if (model != null) {
                // Model を要する IViewBuilder<TModel>.Build(TModel model) をコール
                childMonoBehaviour.gameObject.GetComponents<IViewBuilder<TModel>>().ToList().ForEach(
                    (x) => {
                        x.Build(model);
                    }
                );
            }
            return childView;
        }

        [Obsolete("Please use `AddChildView()` instead of `InstantiateChild()`.")]
        public static IView InstantiateChild(this IView self, GameObject prefab) {
            return self.InstantiateChild<IView>(prefab);
        }

        [Obsolete("Please use `AddChildView()` instead of `InstantiateChild()`.")]
        public static IView InstantiateChild<TModel>(this IView self, GameObject prefab, TModel model)
            where TModel : IModel {
            return self.InstantiateChild<IView, TModel>(prefab, model);
        }

        [Obsolete("Please use `AddChildView()` instead of `InstantiateChild()`.")]
        public static TView InstantiateChild<TView>(this IView self, GameObject prefab)
            where TView : IView {
            MonoBehaviour monoBehaviour = self as MonoBehaviour;
            if (monoBehaviour == default(MonoBehaviour)) {
                throw new InvalidOperationException(string.Format("'{0}' is not inheritance MonoBehaviour.", typeof(TView).FullName));
            }
            GameObject child = Object.Instantiate(prefab, monoBehaviour.transform);
            TView childView = child.gameObject.GetComponent<TView>();
            if (childView == null) {
                throw new InvalidOperationException(string.Format("GameObject '{0}' has not attached component '{1}'.", child.name, typeof(TView).FullName));
            }
            return childView;
        }

        [Obsolete("Please use `AddChildView()` instead of `InstantiateChild()`.")]
        public static TView InstantiateChild<TView, TModel>(this IView self, GameObject prefab, TModel model, Transform parent = null)
            where TView : IView
            where TModel : IModel {
            TView childView = self.InstantiateChild<TView>(prefab);
            MonoBehaviour monoBehaviour = childView as MonoBehaviour;
            if (monoBehaviour == default(MonoBehaviour)) {
                throw new InvalidOperationException(string.Format("'{0}' is not inheritance MonoBehaviour.", typeof(TView).FullName));
            }
            // Model 不要の IViewBuilder.Build() をコール
            monoBehaviour.gameObject.GetComponents<IViewBuilder>().ToList().ForEach(
                (x) => {
                    x.Build();
                }
            );
            // Model を要する IViewBuilder<TModel>.Build(TModel model) をコール
            monoBehaviour.gameObject.GetComponents<IViewBuilder<TModel>>().ToList().ForEach(
                (x) => {
                    x.Build(model);
                }
            );
            return childView;
        }

    }

}