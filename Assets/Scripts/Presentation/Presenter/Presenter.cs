using CAFU.Core.Utility;
using JetBrains.Annotations;

namespace CAFU.Core.Presentation.Presenter
{
    [PublicAPI]
    public interface IPresenter
    {
    }

    [PublicAPI]
    public interface IPresenterFactory<out TPresenter> : IFactory<TPresenter> where TPresenter : IPresenter
    {
    }

    [PublicAPI]
    public class DefaultPresenterFactory<TPresenter> : DefaultFactory<TPresenter>, IPresenterFactory<TPresenter>
        where TPresenter : IPresenter, new()
    {
    }

    [PublicAPI]
    public static class PresenterExtension
    {
        public static TPresenter As<TPresenter>(this IPresenter presenter) where TPresenter : class, IPresenter
        {
            return presenter as TPresenter;
        }
    }
}