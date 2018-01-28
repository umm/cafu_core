using System.Collections.Generic;
// ReSharper disable UnusedMember.Global

namespace CAFU.Core.Data {

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

        TEntity Factory();

    }

    public class DefaultEntityFactory<TEntity> : IEntityFactory<TEntity> where TEntity : IEntity, new() {

        public TEntity Factory() {
            return new TEntity();
        }

    }

}