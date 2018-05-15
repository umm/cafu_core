using System.Collections.Generic;
using CAFU.Core.Utility;
using JetBrains.Annotations;

namespace CAFU.Core.Data.Entity
{
    /// <summary>
    /// Entity インタフェース
    /// </summary>
    [PublicAPI]
    public interface IEntity
    {
    }

    [PublicAPI]
    public interface ISingletonEntity : IEntity, ISingleton
    {
    }

    /// <summary>
    /// ListEntity インタフェース
    /// </summary>
    /// <inheritdoc cref="IEntity" />
    [PublicAPI]
    public interface IListEntity<TEntity> : IEntity, IList<TEntity>
    {
    }

    [PublicAPI]
    public interface ISingletonListEntity<TEntity> : IListEntity<TEntity>, ISingleton
    {
    }

    [PublicAPI]
    public interface IEntityFactory<out TEntity> where TEntity : IEntity
    {
        TEntity Create();
    }

    [PublicAPI]
    public class DefaultEntityFactory<TEntity> : DefaultFactory<TEntity>, IEntityFactory<TEntity>
        where TEntity : IEntity, new()
    {
    }
}