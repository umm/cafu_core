using CAFU.Core.Utility;

// ReSharper disable UnusedMember.Global

namespace CAFU.Core.Presentation.Presenter {

    public interface IPresenter {

    }

    public interface IPresenterFactory<out TPresenter> where TPresenter : IPresenter {

        TPresenter Create();

    }

    public class DefaultPresenterFactory<TFactory, TPresenter> : DefaultFactory<TFactory, TPresenter>, IPresenterFactory<TPresenter> where TPresenter : IPresenter, new() where TFactory : DefaultFactory<TFactory, TPresenter>, new() {

    }

    public static class PresenterExtension {

        public static TPresenter As<TPresenter>(this IPresenter presenter) where TPresenter : class, IPresenter {
            return presenter as TPresenter;
        }

    }

}