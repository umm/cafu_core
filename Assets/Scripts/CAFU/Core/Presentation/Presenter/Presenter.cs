using CAFU.Core.Utility;

// ReSharper disable UnusedMember.Global

namespace CAFU.Core.Presentation.Presenter {

    public interface IPresenter {

    }

    public interface IPresenterFactory<out TPresenter> : IFactory<TPresenter> where TPresenter : IPresenter {

    }

    public class DefaultPresenterFactory<TPresenter> : DefaultPresenterFactory<DefaultPresenterFactory<TPresenter>, TPresenter>
        where TPresenter : IPresenter, new() {

    }

    public class DefaultPresenterFactory<TFactory, TPresenter> : DefaultFactory<TFactory, TPresenter>, IPresenterFactory<TPresenter>
        where TFactory : DefaultFactory<TFactory, TPresenter>, new()
        where TPresenter : IPresenter, new() {

    }

    public static class PresenterExtension {

        public static TPresenter As<TPresenter>(this IPresenter presenter) where TPresenter : class, IPresenter {
            return presenter as TPresenter;
        }

    }

}