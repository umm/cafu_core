using CAFU.Core.Utility;

// ReSharper disable UnusedMember.Global

namespace CAFU.Core.Domain.Repository {

    public interface IRepository {
    }

    public interface IRepositoryFactory<out TRepository> where TRepository : IRepository {

        TRepository Create();

    }

    public class DefaultRepositoryFactory<TFactory, TRepository> : DefaultFactory<TFactory, TRepository>, IRepositoryFactory<TRepository> where TRepository : IRepository, new() where TFactory : DefaultFactory<TFactory, TRepository>, new() {

    }

}
