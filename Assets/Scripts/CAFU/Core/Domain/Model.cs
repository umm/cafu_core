using System.Collections;

namespace CAFU.Core.Domain {

    /// <summary>
    /// Model インタフェース
    /// </summary>
    public interface IModel {

    }

    /// <summary>
    /// ListModel インタフェース
    /// </summary>
    /// <inheritdoc cref="IModel" />
    /// <inheritdoc cref="IList" />
    public interface IListModel : IModel, IList {

    }

}