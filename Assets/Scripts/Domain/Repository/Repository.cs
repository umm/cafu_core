using CAFU.Core.Utility;

namespace CAFU.Core.Domain.Repository
{
    public interface IRepository
    {
    }

    public interface ISingletonRepository : IRepository, ISingleton
    {
    }

    public interface IRepositoryFactory<out TRepository> : IFactory<TRepository> where TRepository : IRepository
    {
    }

    public class DefaultRepositoryFactory<TRepository> : DefaultFactory<TRepository>, IRepositoryFactory<TRepository>
        where TRepository : IRepository, new()
    {
    }
}