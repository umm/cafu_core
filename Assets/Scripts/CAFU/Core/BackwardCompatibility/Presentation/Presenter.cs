using System;

namespace CAFU.Core.Presentation {

    [Obsolete("Please use IPresenterFactory<TPresenter> instead of this interface.")]
    public interface IPresenterBuilder {

        void Build();

    }

    [Obsolete("Please use DefaultPresenterFactory<TPresenter> instead of this class.")]
    public static class PresenterFactory {

        public static TPresenter CreateInstance<TPresenter>() where TPresenter : IPresenter, new() {
            TPresenter instance = new TPresenter();
            // ReSharper disable once SuspiciousTypeConversion.Global
            IPresenterBuilder builder = instance as IPresenterBuilder;
            if (builder != default(IPresenterBuilder)) {
                builder.Build();
            }
            return instance;
        }

    }

}