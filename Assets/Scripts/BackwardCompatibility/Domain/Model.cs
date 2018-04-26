using System;
using System.Collections.Generic;

namespace CAFU.Core.Domain {

    [Obsolete("Please use CAFU.Core.Data.Model.IModel instead of this interface.")]
    public interface IModel : Model.IModel {

    }

    [Obsolete("Please use CAFU.Core.Data.Model.IListModel<TModel> instead of this interface.")]
    public interface IListModel<TModel> : IModel, IList<TModel> {

    }

}