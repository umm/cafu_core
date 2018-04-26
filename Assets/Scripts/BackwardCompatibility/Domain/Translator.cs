using System;
using CAFU.Core.Data;

namespace CAFU.Core.Domain {

    [Obsolete("Please use CAFU.Core.Domain.Translator.I***Translator<> instead of this interface.")]
    public interface ITranslator<TEntity, TModel>
        where TEntity : Data.Entity.IEntity
        where TModel : Model.IModel {

        TModel Translate(TEntity entity);

        TEntity Translate(TModel model);

        UniRx.IObservable<TModel> TranslateAsync(TEntity entity);

        UniRx.IObservable<TEntity> TranslateAsync(TModel model);

    }

}