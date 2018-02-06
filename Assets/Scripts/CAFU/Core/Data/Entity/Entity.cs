using System.Collections.Generic;
using CAFU.Core.Utility;

// ReSharper disable UnusedMember.Global

namespace CAFU.Core.Data.Entity {

    /// <summary>
    /// Entity インタフェース
    /// </summary>
    public interface IEntity {

    }

    /// <summary>
    /// ListEntity インタフェース
    /// </summary>
    /// <inheritdoc cref="IEntity" />
    public interface IListEntity<TEntity> : IEntity, IList<TEntity> {

    }

    public interface IEntityFactory<out TEntity> where TEntity : IEntity {

        TEntity Create();

    }

    public class DefaultEntityFactory<TFactory, TEntity> : DefaultFactory<TFactory, TEntity>, IEntityFactory<TEntity> where TEntity : IEntity, new() where TFactory : DefaultFactory<TFactory, TEntity>, new() {

    }

}