using CAFU.Core.Utility;

// ReSharper disable UnusedMember.Global

namespace CAFU.Core.Presentation.Presenter {

    public interface IPresenter {

    }

    public interface IPresenterFactory<out TPresenter> : IFactory<TPresenter> where TPresenter : IPresenter {

    }

    public class DefaultPresenterFactory<TPresenter> : DefaultFactory<TPresenter>, IPresenterFactory<TPresenter>
        where TPresenter : IPresenter, new() {

    }

    public static class PresenterExtension {

        public static TPresenter As<TPresenter>(this IPresenter presenter) where TPresenter : class, IPresenter {
            return presenter as TPresenter;
        }

    }

}