using UnityEngine;
// ReSharper disable VirtualMemberNeverOverridden.Global

namespace CAFU.Core.Presentation {

    public interface IViewController {

    }

    public interface IViewControllerPresenter<out TPresenter> : IViewController {

        TPresenter Presenter { get; }

    }

    public interface IViewControllerBuilder {

        void Build();

    }

    public abstract class ViewControllerBase<TPresenter> : MonoBehaviour,
        IViewControllerPresenter<TPresenter>
        where TPresenter : IPresenter {

        public TPresenter Presenter { get; protected set; }

        protected virtual void Start() {
            IViewControllerBuilder builder = this as IViewControllerBuilder;
            if (builder != default(IViewControllerBuilder)) {
                builder.Build();
            }
        }

    }

    public abstract class ViewControllerBaseAsSingleton<TViewController, TPresenter> : ViewControllerBase<TPresenter>
        where TViewController : ViewControllerBaseAsSingleton<TViewController, TPresenter>
        where TPresenter : IPresenter {

        public static TViewController Instance { get; private set; }

        protected virtual void Awake() {
            Instance = (TViewController)this;
        }

        protected virtual void OnDestroy() {
            Instance = null;
        }

    }

}