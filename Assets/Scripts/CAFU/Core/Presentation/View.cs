using System.Linq;
using CAFU.Core.Domain;
using UnityEngine;

namespace CAFU.Core.Presentation.View {

    // 本当は IMonoBehaviour 的なモノを継承したいところだが、そんな inteface ないので規約ベースで頑張る
    public interface IView {

    }

    public interface IViewWithModel<TModel> : IView where TModel : IModel {

        TModel Model { get; set; }

        void Render();

    }

    public static class ViewExtension {

        public static IView InstantiateChild(this IView self, GameObject prefab) {
            return self.InstantiateChild<IView>(prefab);
        }

        public static IViewWithModel<TModel> InstantiateChild<TModel>(this IView self, GameObject prefab, TModel model)
            where TModel : IModel {
            return self.InstantiateChild<IViewWithModel<TModel>, TModel>(prefab, model);
        }

        private static TView InstantiateChild<TView>(this IView self, GameObject prefab)
            where TView : IView {
            MonoBehaviour monoBehaviour = self as MonoBehaviour;
            if (monoBehaviour == default(MonoBehaviour)) {
                throw new System.InvalidOperationException(string.Format("'{0}' is not inheritance MonoBehaviour.", typeof(TView).FullName));
            }
            GameObject child = Object.Instantiate(prefab, monoBehaviour.transform);
            TView childView = child.gameObject.GetComponent<TView>();
            if (childView == null) {
                throw new System.InvalidOperationException(string.Format("GameObject '{0}' has not attached component '{1}'.", child.name, typeof(TView).FullName));
            }
            return childView;
        }

        private static TView InstantiateChild<TView, TModel>(this IView self, GameObject prefab, TModel model)
            where TView : IViewWithModel<TModel>
            where TModel : IModel {
            TView childView = self.InstantiateChild<TView>(prefab);
            MonoBehaviour monoBehaviour = childView as MonoBehaviour;
            if (monoBehaviour == default(MonoBehaviour)) {
                throw new System.InvalidOperationException(string.Format("'{0}' is not inheritance MonoBehaviour.", typeof(TView).FullName));
            }
            monoBehaviour.gameObject.GetComponents<IViewWithModel<TModel>>().ToList().ForEach(
                (x) => {
                    childView.Model = model;
                    childView.Render();
                }
            );
            return childView;
        }

    }

}