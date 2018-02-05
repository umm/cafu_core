using System;
using System.Reflection;
using CAFU.Core.Presentation.Presenter;

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

        public static TPresenter CreateInstance<TPresenter>() where TPresenter : IPresenter, new() {
            Assembly assembly = Assembly.GetAssembly(typeof(TPresenter));
            Type factoryType = assembly.GetType($"{typeof(TPresenter).FullName}+Factory");
            if (factoryType != null) {
                return ((IPresenterFactory<TPresenter>)Activator.CreateInstance(factoryType)).Create();
            }
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