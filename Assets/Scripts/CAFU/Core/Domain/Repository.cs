
namespace CAFU.Core.Domain {

    public interface IRepository {
    }

    public interface IRepositoryBuilder {

        void Build();

    }

    public static class RepositoryFactory {

        public static T CreateInstance<T>() where T : IRepository, new() {
            T instance = new T();
            IRepositoryBuilder builder = instance as IRepositoryBuilder;
            if (builder != default(IRepositoryBuilder)) {
                builder.Build();
            }
            return instance;
        }

    }

}
