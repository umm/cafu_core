using CAFU.Core.Data;
using UniRx;

namespace CAFU.Core.Domain {

    public interface ITranslator<TEntity, TModel>
        where TEntity : IEntity
        where TModel : IModel {

        TModel Translate(TEntity entity);

        TEntity Translate(TModel model);

        IObservable<TModel> TranslateAsync(TEntity entity);

        IObservable<TEntity> TranslateAsync(TModel model);

    }

}