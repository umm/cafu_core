using System.Collections.Generic;

namespace CAFU.Core.Domain {

    public interface IModel : Model.IModel {

    }

    public interface IListModel<TModel> : IModel, IList<TModel> {

    }

}