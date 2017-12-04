namespace CAFU.Core.Presentation {

    public interface IPresenter {

    }

    public interface IPresenterBuilder {

        void Build();

    }

    public static class PresenterFactory {

        public static T CreateInstance<T>() where T : IPresenter, new() {
            T instance = new T();
            IPresenterBuilder builder = instance as IPresenterBuilder;
            if (builder != default(IPresenterBuilder)) {
                builder.Build();
            }
            return instance;
        }

    }

}