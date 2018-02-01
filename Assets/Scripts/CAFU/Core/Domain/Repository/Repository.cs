using CAFU.Core.Utility;

// ReSharper disable UnusedMember.Global

namespace CAFU.Core.Domain.Repository {

    public interface IRepository {
    }

    public interface IRepositoryFactory<out TRepository> where TRepository : IRepository {

        TRepository Create();

    }

    public class DefaultRepositoryFactory<TRepository> : DefaultFactory<TRepository>, IRepositoryFactory<TRepository> where TRepository : IRepository, new() {

    }

}
