using System.Collections.Generic;
using CAFU.Core.Utility;
using JetBrains.Annotations;

namespace CAFU.Core.Domain.Model
{
    /// <summary>
    /// Model インタフェース
    /// </summary>
    [PublicAPI]
    public interface IModel
    {
    }

    [PublicAPI]
    public interface ISingletonModel : IModel, ISingleton
    {
    }

    /// <summary>
    /// ListModel インタフェース
    /// </summary>
    /// <inheritdoc cref="IModel" />
    [PublicAPI]
    public interface IListModel<TModel> : IModel, IList<TModel>
    {
    }

    [PublicAPI]
    public interface ISingletonListModel<TModel> : IListModel<TModel>, ISingleton
    {
    }

    [PublicAPI]
    public interface IModelFactory<out TModel> : IFactory<TModel> where TModel : IModel
    {
    }

    [PublicAPI]
    public class DefaultModelFactory<TModel> : DefaultFactory<TModel>, IModelFactory<TModel>
        where TModel : IModel, new()
    {
    }
}