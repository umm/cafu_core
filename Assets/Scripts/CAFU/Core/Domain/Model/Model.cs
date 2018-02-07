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

    public interface IModelFactory<out TModel> : IFactory<TModel> where TModel : IModel {

    }

    public class DefaultModelFactory<TModel> : DefaultModelFactory<DefaultModelFactory<TModel>, TModel>
        where TModel : IModel, new() {

    }

    public class DefaultModelFactory<TFactory, TModel> : DefaultFactory<TFactory, TModel>, IModelFactory<TModel>
        where TFactory : DefaultFactory<TFactory, TModel>, new()
        where TModel : IModel, new() {

    }

}