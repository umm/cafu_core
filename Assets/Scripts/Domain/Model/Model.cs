using System.Collections.Generic;
using CAFU.Core.Utility;

// ReSharper disable UnusedMember.Global

namespace CAFU.Core.Domain.Model {

    /// <summary>
    /// Model インタフェース
    /// </summary>
    public interface IModel {

    }

    public interface ISingletonModel : IModel, ISingleton {

    }

    /// <summary>
    /// ListModel インタフェース
    /// </summary>
    /// <inheritdoc cref="IModel" />
    public interface IListModel<TModel> : IModel, IList<TModel> {

    }

    public interface ISingletonListModel<TModel> : IListModel<TModel>, ISingleton {

    }

    public interface IModelFactory<out TModel> : IFactory<TModel> where TModel : IModel {

    }

    public class DefaultModelFactory<TModel> : DefaultFactory<TModel>, IModelFactory<TModel>
        where TModel : IModel, new() {

    }

}