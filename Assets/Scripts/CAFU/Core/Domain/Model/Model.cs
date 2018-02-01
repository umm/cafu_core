using System.Collections.Generic;
using CAFU.Core.Utility;

// ReSharper disable UnusedMember.Global

namespace CAFU.Core.Domain.Model {

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

    public interface IModelFactory<out TModel> where TModel : IModel {

        TModel Create();

    }

    public class DefaultModelFactory<TModel> : DefaultFactory<TModel>, IModelFactory<TModel> where TModel : IModel, new() {

    }

}