using System;
using System.Linq;
using CAFU.Core.Domain;
using UnityEngine;
using Object = UnityEngine.Object;
#pragma warning disable 618

namespace CAFU.Core.Presentation.View {

    [Obsolete("Please use MonoBehaviour.Awake() instead of this interface.")]
    public interface IViewBuilder {

        void Build();

    }

    [Obsolete("Please use IInjectableView<TModel> instead of this interface.")]
    public interface IViewBuilder<in TModel> where TModel : Domain.Model.IModel {

        void Build(TModel model);

    }

    public static class BackwardCompatibilityViewExtension {

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