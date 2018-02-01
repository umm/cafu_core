using System;

namespace CAFU.Core.Domain {

    [Obsolete("Please use IRepository instead of this interface.")]
    public interface IRepository : Repository.IRepository {
    }

    [Obsolete("Please use IRepositoryFactory<TUseCase> instead of this interface.")]
    public interface IRepositoryBuilder {

        void Build();

    }

    [Obsolete("Please use DefaultRepositoryFactory instead of this class.")]
    public static class RepositoryFactory {

        public static T CreateInstance<T>() where T : IRepository, new() {
            T instance = new T();
            // ReSharper disable once SuspiciousTypeConversion.Global
            IRepositoryBuilder builder = instance as IRepositoryBuilder;
            if (builder != default(IRepositoryBuilder)) {
                builder.Build();
            }
            return instance;
        }

    }

}