using System.Collections.Generic;

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

}