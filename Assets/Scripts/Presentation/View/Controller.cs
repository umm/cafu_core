using CAFU.Core.Presentation.Presenter;
using JetBrains.Annotations;
using UniRx;
using UnityEngine;

namespace CAFU.Core.Presentation.View
{
    [PublicAPI]
    public interface IController : IView
    {
    }

    [PublicAPI]
    public interface IController<TPresenter> : IController
    {
        TPresenter Presenter { get; set; }
    }

    [PublicAPI]
    public abstract class Controller<TController, TPresenter, TPresenterFactory> : ObservableLifecycleMonoBehaviour, IController<TPresenter>
        where TController : Controller<TController, TPresenter, TPresenterFactory>
        where TPresenter : Presenter.IPresenter, new()
        where TPresenterFactory : DefaultPresenterFactory<TPresenter>, IPresenterFactory<TPresenter>, new()
    {
        private static TController instance;

        public static TController Instance
        {
            get { return instance; }
            set { instance = value; }
        }

        public TPresenter Presenter { get; set; }

        protected TPresenter GetPresenter()
        {
            return ((IController<TPresenter>) this).Presenter;
        }

        protected override void OnAwake()
        {
            base.OnAwake();
            ((IController<TPresenter>) this).Presenter = new TPresenterFactory().Create();
            Instance = (TController) this;
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
            Instance = null;
            Resources.UnloadUnusedAssets();
        }
    }
}