using UnityEngine;

namespace CAFU.Core.Presentation {

    public interface IViewController {

    }

    public interface IViewControllerPresenter<out TPresenter> {

        TPresenter Presenter { get; }

    }

    public interface IViewControllerBuilder {

        void Build();

    }

    public abstract class ViewControllerBase<TPresenter> : MonoBehaviour,
        IViewControllerPresenter<TPresenter>
        where TPresenter : IPresenter {

        public TPresenter Presenter { get; protected set; }

        protected virtual void Awake() {
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

        protected override void Awake() {
            Instance = (TViewController)this;
            base.Awake();
        }

    }

}