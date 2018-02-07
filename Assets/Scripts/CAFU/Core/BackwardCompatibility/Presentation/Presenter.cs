using System;
using CAFU.Core.Presentation.Presenter;
using CAFU.Core.Utility;

namespace CAFU.Core.Presentation {

    [Obsolete("Please use CAFU.Core.Presentation.Presenter.IPresenter instead of this interface.")]
    public interface IPresenter : Presenter.IPresenter {

    }

    [Obsolete("Please use IPresenterFactory<TPresenter> instead of this interface.")]
    public interface IPresenterBuilder {

        void Build();

    }

    [Obsolete("Please use DefaultPresenterFactory<TPresenter> instead of this class.")]
    public static class PresenterFactory {

        public static TPresenter CreateInstance<TPresenter>() where TPresenter : class, IPresenter, new() {
            return Factory.InvokeCreate<TPresenter>() ?? PresenterFactory<TPresenter>.Instance.Create();
        }

    }

    [Obsolete("Please use DefaultPresenterFactory<TPresenter> instead of this class.")]
    public class PresenterFactory<TPresenter> : DefaultPresenterFactory<PresenterFactory<TPresenter>, TPresenter> where TPresenter : IPresenter, new() {

        protected override void Initialize(TPresenter instance) {
            base.Initialize(instance);
            IPresenterBuilder builder = instance as IPresenterBuilder;
            if (builder != default(IPresenterBuilder)) {
                builder.Build();
            }
        }

    }

}