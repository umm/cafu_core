using System.Collections.Generic;

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
    public interface IListModel<TModel> : IModel, IList<TModel> {

    }

}