using CAFU.Core.Presentation.Presenter;
using JetBrains.Annotations;
using UniRx;
using UnityEngine;
using IPresenter = CAFU.Core.Presentation.Presenter.IPresenter;

namespace CAFU.Core.Presentation.View
{
    [PublicAPI]
    public interface IController : IView
    {
    }

    [PublicAPI]
    public abstract class Controller<TController, TPresenter, TPresenterFactory> : ObservableLifecycleMonoBehaviour, IController
        where TController : Controller<TController, TPresenter, TPresenterFactory>
        where TPresenter : IPresenter, new()
        where TPresenterFactory : DefaultPresenterFactory<TPresenter>, IPresenterFactory<TPresenter>, new()
    {
        public static TController Instance { get; set; }

        protected override void OnAwake()
        {
            base.OnAwake();
            PresenterContainer.Instance.SetPresenter(this.GetSceneName(), new TPresenterFactory().Create());
            Instance = (TController) this;
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
            Instance = null;
            PresenterContainer.Instance.RemovePresenter(this.GetSceneName());
            Resources.UnloadUnusedAssets();
        }
    }
}