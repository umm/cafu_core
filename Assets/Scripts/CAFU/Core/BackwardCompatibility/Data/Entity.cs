using System.Collections.Generic;

namespace CAFU.Core.Data {

    public interface IEntity : Entity.IEntity {

    }

    public interface IListEntity<TEntity> : IEntity, IList<TEntity> {

    }

}