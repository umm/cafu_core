using System;
using System.Collections.Generic;
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
    public class PresenterContainer
    {
        private IDictionary<string, IPresenter> PresenterMap { get; set; }

        private static PresenterContainer instance;

        public static PresenterContainer Instance =>
            instance ?? (
                instance = new PresenterContainer
                {
                    PresenterMap = new Dictionary<string, IPresenter>()
                }
            );

        public TPresenter GetPresenter<TPresenter>(string sceneName) where TPresenter : IPresenter
        {
            if (!PresenterMap.ContainsKey(sceneName))
            {
                throw new KeyNotFoundException($"Key '{sceneName}' does not found in PresenterMap.");
            }

            if (!(PresenterMap[sceneName] is TPresenter))
            {
                throw new InvalidCastException($"'{PresenterMap[sceneName]}' does not implements '{typeof(TPresenter).FullName}'");
            }

            return (TPresenter) PresenterMap[sceneName];
        }

        public void SetPresenter(string sceneName, IPresenter presenter)
        {
            PresenterMap[sceneName] = presenter;
        }

        public void RemovePresenter(string sceneName)
        {
            PresenterMap.Remove(sceneName);
        }
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