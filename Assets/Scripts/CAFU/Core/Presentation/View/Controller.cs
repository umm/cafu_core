using System.Collections.Generic;
using CAFU.Core.Presentation.Presenter;
using UniRx;

// ReSharper disable VirtualMemberNeverOverridden.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global

namespace CAFU.Core.Presentation.View {

    public interface IController : IView {

        Presenter.IPresenter Presenter { get; set; }

    }

    public abstract class Controller<TPresenter> : Controller<TPresenter, DefaultPresenterFactory<TPresenter>>
        where TPresenter : Presenter.IPresenter, new() {
    }

    public abstract class Controller<TPresenter, TPresenterFactory> : ObservableLifecycleMonoBehaviour, IController
        where TPresenter : Presenter.IPresenter, new()
        where TPresenterFactory : IPresenterFactory<TPresenter>, new() {

        Presenter.IPresenter IController.Presenter { get; set; }

        protected override void OnAwake() {
            base.OnAwake();
            ControllerInstanceManager.Instance.Register(this);
            ((IController)this).Presenter = new TPresenterFactory().Create();
        }

        protected override void OnDestroy() {
            ControllerInstanceManager.Instance.Unregister(this);
        }

    }

    internal class ControllerInstanceManager {

        private static ControllerInstanceManager instance;

        public static ControllerInstanceManager Instance {
            get {
                if (instance == default(ControllerInstanceManager)) {
                    instance = new ControllerInstanceManager();
                }
                return instance;
            }
        }

        private readonly Dictionary<string, IController> controllerMap = new Dictionary<string, IController>();

        private Dictionary<string, IController> ControllerMap {
            get {
                return this.controllerMap;
            }
        }

        public IController Get(string key) {
            return this.ControllerMap[key];
        }

        public void Register(IController controller) {
            string key = controller.GetType().Namespace;
            if (key != null) {
                this.ControllerMap[key] = controller;
            }
        }

        public void Unregister(IController controller) {
            string key = controller.GetType().Namespace;
            if (key != null && this.ControllerMap.ContainsKey(key)) {
                this.ControllerMap.Remove(key);
            }
        }

    }

    public static class ControllerExtension {

        public static TController As<TController>(this IController controller) where TController : class, IController {
            return controller as TController;
        }

    }

}
