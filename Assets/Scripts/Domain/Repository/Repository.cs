using CAFU.Core.Utility;
using JetBrains.Annotations;

namespace CAFU.Core.Domain.Repository
{
    [PublicAPI]
    public interface IRepository
    {
    }

    [PublicAPI]
    public interface ISingletonRepository : IRepository, ISingleton
    {
    }

    [PublicAPI]
    public interface IRepositoryFactory<out TRepository> : IFactory<TRepository> where TRepository : IRepository
    {
    }

    [PublicAPI]
    public class DefaultRepositoryFactory<TRepository> : DefaultFactory<TRepository>, IRepositoryFactory<TRepository>
        where TRepository : IRepository, new()
    {
    }
}