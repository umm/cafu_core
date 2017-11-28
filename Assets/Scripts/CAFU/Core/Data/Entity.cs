using System.Collections;

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
    /// <inheritdoc cref="IList" />
    public interface IListEntity : IEntity, IList {

    }

}