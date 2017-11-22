using CAFU.Core.Data;
using UniRx;

namespace CAFU.Core.Domain {

    public interface ITranslator<TEntity, TModel>
        where TEntity : IEntity
        where TModel : IModel {

        TModel Translate(TEntity entity);

        TEntity Translate(TModel model);

        IObservable<TModel> TranslateAsObservable(TEntity entity);

        IObservable<TEntity> TranslateAsObservable(TModel model);

    }

}