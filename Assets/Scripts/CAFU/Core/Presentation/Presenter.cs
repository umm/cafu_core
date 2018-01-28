using System;
// ReSharper disable UnusedMember.Global

namespace CAFU.Core.Presentation {

    public interface IPresenter {

    }

    public interface IPresenterFactory<out TPresenter> where TPresenter : IPresenter {

        TPresenter Factory();

    }

    public class DefaultPresenterFactory<TPresenter> : IPresenterFactory<TPresenter> where TPresenter : IPresenter, new() {

        public TPresenter Factory() {
            return new TPresenter();
        }

    }

    public static class PresenterExtension {

        public static TPresenter As<TPresenter>(this IPresenter presenter) where TPresenter : class, IPresenter {
            return presenter as TPresenter;
        }

    }

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