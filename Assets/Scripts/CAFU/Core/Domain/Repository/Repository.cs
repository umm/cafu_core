using CAFU.Core.Utility;

// ReSharper disable UnusedMember.Global

namespace CAFU.Core.Domain.Repository {

    public interface IRepository {

    }

    public interface IRepositoryFactory<out TRepository> : IFactory<TRepository> where TRepository : IRepository {

    }

    public class DefaultRepositoryFactory<TRepository> : DefaultRepositoryFactory<DefaultRepositoryFactory<TRepository>, TRepository>
        where TRepository : IRepository, new() {

    }

    public class DefaultRepositoryFactory<TFactory, TRepository> : DefaultFactory<TFactory, TRepository>, IRepositoryFactory<TRepository>
        where TFactory : DefaultFactory<TFactory, TRepository>, new()
        where TRepository : IRepository, new() {

    }

}