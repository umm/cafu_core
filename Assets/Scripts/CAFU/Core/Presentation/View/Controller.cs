using System;
using System.Collections.Generic;
using UniRx;
// ReSharper disable VirtualMemberNeverOverridden.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global

namespace CAFU.Core.Presentation.View {

    public interface IController {

        IPresenter Presenter { get; set; }

    }

    public abstract class Controller<TPresenter> : ObservableLifecycleMonoBehaviour, IController
        where TPresenter : IPresenter, new() {

        private static IPresenterFactory<TPresenter> presenterFactory = new DefaultPresenterFactory<TPresenter>();

        public static IPresenterFactory<TPresenter> PresenterFactory {
            get {
                return presenterFactory;
            }
            set {
                presenterFactory = value;
            }
        }

        IPresenter IController.Presenter { get; set; }

        protected override void OnAwake() {
            base.OnAwake();
            ControllerInstanceManager.Instance.Register(this);
            ((IController)this).Presenter = PresenterFactory.Factory();
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

    [Obsolete("Please use Zenject instead of this.")]
    public interface IControllerBuilder {

        void Build();

    }

    [Obsolete("Please use Controller<TPresenter> instead of this.")]
    public abstract class ControllerAsSingleton<TViewController, TPresenter> : Controller<TPresenter>
        where TViewController : ControllerAsSingleton<TViewController, TPresenter>
        where TPresenter : IPresenter, new() {

        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public static TViewController Instance { get; private set; }

        protected override void OnAwake() {
            base.OnAwake();
            Instance = (TViewController)this;
        }

        protected override void OnDestroy() {
            Instance = null;
        }

    }

    // コンパイルエラー回避のために残してあります
    [Obsolete("Please use Controller<TPresenter> instead of this.")]
    public abstract class ViewControllerBaseAsSingleton<TViewController, TPresenter> : ControllerAsSingleton<TViewController, TPresenter>
        where TViewController : ControllerAsSingleton<TViewController, TPresenter>
        where TPresenter : IPresenter, new() {

    }

}