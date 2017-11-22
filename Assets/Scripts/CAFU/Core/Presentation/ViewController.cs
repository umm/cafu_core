using UnityEngine;

namespace CAFU.Core.Presentation {

    public interface IViewController {

    }

    public abstract class ViewControllerBase<TPresenter> : MonoBehaviour, IViewController
        where TPresenter : IPresenter {

        public TPresenter Presenter { get; protected set; }

        protected virtual void Build() {
            // Do nothing.
        }

        protected virtual void Awake() {
            this.Build();
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