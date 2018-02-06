using System;
using CAFU.Core.Domain.Repository;
using CAFU.Core.Utility;
#pragma warning disable 618

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

        public static TRepository CreateInstance<TRepository>() where TRepository : class, Repository.IRepository, new() {
            return Factory.InvokeCreate<TRepository>() ?? RepositoryFactory<TRepository>.Instance.Create();
        }

    }

    public class RepositoryFactory<TRepository> : DefaultRepositoryFactory<RepositoryFactory<TRepository>, TRepository> where TRepository : Repository.IRepository, new() {

        protected override void Initialize(TRepository instance) {
            base.Initialize(instance);
            // ReSharper disable once SuspiciousTypeConversion.Global
            IRepositoryBuilder builder = instance as IRepositoryBuilder;
            if (builder != default(IRepositoryBuilder)) {
                builder.Build();
            }
        }

    }

}