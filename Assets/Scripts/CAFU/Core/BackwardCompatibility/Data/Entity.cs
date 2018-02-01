using System;
using System.Collections.Generic;

namespace CAFU.Core.Data {

    [Obsolete("Please use CAFU.Core.Data.Entity.IEntity instead of this interface.")]
    public interface IEntity : Entity.IEntity {

    }

    [Obsolete("Please use CAFU.Core.Data.Entity.IListEntity<TEntity> instead of this interface.")]
    public interface IListEntity<TEntity> : IEntity, IList<TEntity> {

    }

}