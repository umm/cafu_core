using System.Collections.Generic;
// ReSharper disable UnusedMember.Global

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

    public interface IModelFactory<out TModel> where TModel : IModel {

        TModel Create();

    }

    public class DefaultModelFactory<TModel> : IModelFactory<TModel> where TModel : IModel, new() {

        public TModel Create() {
            return new TModel();
        }

    }

}