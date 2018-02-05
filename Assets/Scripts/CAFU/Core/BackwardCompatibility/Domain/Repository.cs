using System;
using System.Reflection;
using CAFU.Core.Domain.Repository;

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

        public static TRepository CreateInstance<TRepository>() where TRepository : IRepository, new() {
            Assembly assembly = Assembly.GetAssembly(typeof(TRepository));
            Type factoryType = assembly.GetType($"{typeof(TRepository).FullName}+Factory");
            if (factoryType != null) {
                return ((IRepositoryFactory<TRepository>)Activator.CreateInstance(factoryType)).Create();
            }
            TRepository instance = new TRepository();
            // ReSharper disable once SuspiciousTypeConversion.Global
            IRepositoryBuilder builder = instance as IRepositoryBuilder;
            if (builder != default(IRepositoryBuilder)) {
                builder.Build();
            }
            return instance;
        }

    }

}