using System;
using UnityEngine;
// ReSharper disable VirtualMemberNeverOverridden.Global
#pragma warning disable 618

namespace CAFU.Core {

    // ReSharper disable once PartialTypeWithSinglePart
    /// <summary>
    /// [DefaultExecutionOrder] 属性に渡す値を管理する
    /// </summary>
    /// <remarks>どうしてもスクリプトの実行順を制御する必要がある場合に利用します。</remarks>
    public static partial class DefaultExecutionOrders {

        public const int ViewController = -1;

    }

}

namespace CAFU.Core.Presentation {

    [Obsolete("Please use CAFU.Core.Presentation.View.IController instead of this interface.")]
    public interface IViewController {

    }

    [Obsolete("Please use CAFU.Core.Presentation.View.IController instead of this interface.")]
    public interface IViewControllerPresenter<out TPresenter> : IViewController {

        TPresenter Presenter { get; }

    }

    [Obsolete("Please use CAFU.Core.Presentation.View.IController instead of this interface.")]
    public interface IViewControllerBuilder {

        void Build();

    }

    // Singleton インスタンスを確定させるために、あらゆるクラスよりも先に Awake() が実行されて欲しいので [DefaultExecutionOrder(-1)] を設定
    // 一応簡単なコードで abstract クラスでも効くことは確認済
    [DefaultExecutionOrder(DefaultExecutionOrders.ViewController)]
    public abstract class ViewControllerBase<TPresenter> : View.Controller<ViewControllerBase<TPresenter>, TPresenter, PresenterFactory<TPresenter>>,
        IViewControllerPresenter<TPresenter>
        where TPresenter : IPresenter, new() {

        public new TPresenter Presenter { get; protected set; }

        protected override void Awake() {
            base.Awake();
            IViewControllerBuilder builder = this as IViewControllerBuilder;
            if (builder != default(IViewControllerBuilder)) {
                builder.Build();
            }
        }

    }

    public abstract class ViewControllerBaseAsSingleton<TViewController, TPresenter> : ViewControllerBase<TPresenter>
        where TViewController : ViewControllerBaseAsSingleton<TViewController, TPresenter>
        where TPresenter : IPresenter, new() {

        public new static TViewController Instance { get; private set; }

        protected override void Awake() {
            Instance = (TViewController)this;
            base.Awake();
        }

        protected override void OnDestroy() {
            Instance = null;
        }

    }

}