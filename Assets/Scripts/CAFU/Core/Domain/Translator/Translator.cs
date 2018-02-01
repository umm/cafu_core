using CAFU.Core.Data.Entity;
using UniRx;

namespace CAFU.Core.Domain.Translator {

    public interface IModelTranslator<in TEntity1, out TModel>
        where TEntity1 : IEntity
        where TModel : Model.IModel {

        TModel Translate(TEntity1 entity);

    }

    public interface IModelTranslator<in TEntity1, in TEntity2, out TModel>
        where TEntity1 : IEntity
        where TModel : Model.IModel {

        TModel Translate(TEntity1 entity1, TEntity2 entity2);

    }

    public interface IModelTranslator<in TEntity1, in TEntity2, in TEntity3, out TModel>
        where TEntity1 : IEntity
        where TModel : Model.IModel {

        TModel Translate(TEntity1 entity1, TEntity2 entity2, TEntity3 entity3);

    }

    public interface IModelTranslator<in TEntity1, in TEntity2, in TEntity3, in TEntity4, out TModel>
        where TEntity1 : IEntity
        where TModel : Model.IModel {

        TModel Translate(TEntity1 entity1, TEntity2 entity2, TEntity3 entity3, TEntity4 entity4);

    }

    public interface IModelTranslator<in TEntity1, in TEntity2, in TEntity3, in TEntity4, in TEntity5, out TModel>
        where TEntity1 : IEntity
        where TModel : Model.IModel {

        TModel Translate(TEntity1 entity1, TEntity2 entity2, TEntity3 entity3, TEntity4 entity4, TEntity5 entity5);

    }

    public interface IModelTranslator<in TEntity1, in TEntity2, in TEntity3, in TEntity4, in TEntity5, in TEntity6, out TModel>
        where TEntity1 : IEntity
        where TModel : Model.IModel {

        TModel Translate(TEntity1 entity1, TEntity2 entity2, TEntity3 entity3, TEntity4 entity4, TEntity5 entity5, TEntity6 entity6);

    }

    public interface IModelTranslator<in TEntity1, in TEntity2, in TEntity3, in TEntity4, in TEntity5, in TEntity6, in TEntity7, out TModel>
        where TEntity1 : IEntity
        where TModel : Model.IModel {

        TModel Translate(TEntity1 entity1, TEntity2 entity2, TEntity3 entity3, TEntity4 entity4, TEntity5 entity5, TEntity6 entity6, TEntity7 entity7);

    }

    public interface IModelTranslator<in TEntity1, in TEntity2, in TEntity3, in TEntity4, in TEntity5, in TEntity6, in TEntity7, in TEntity8, out TModel>
        where TEntity1 : IEntity
        where TModel : Model.IModel {

        TModel Translate(TEntity1 entity1, TEntity2 entity2, TEntity3 entity3, TEntity4 entity4, TEntity5 entity5, TEntity6 entity6, TEntity7 entity7, TEntity8 entity8);

    }

    public interface IModelTranslator<in TEntity1, in TEntity2, in TEntity3, in TEntity4, in TEntity5, in TEntity6, in TEntity7, in TEntity8, in TEntity9, out TModel>
        where TEntity1 : IEntity
        where TModel : Model.IModel {

        TModel Translate(TEntity1 entity1, TEntity2 entity2, TEntity3 entity3, TEntity4 entity4, TEntity5 entity5, TEntity6 entity6, TEntity7 entity7, TEntity8 entity8, TEntity9 entity9);

    }

    public interface IModelTranslator<in TEntity1, in TEntity2, in TEntity3, in TEntity4, in TEntity5, in TEntity6, in TEntity7, in TEntity8, in TEntity9, in TEntity10, out TModel>
        where TEntity1 : IEntity
        where TModel : Model.IModel {

        TModel Translate(TEntity1 entity1, TEntity2 entity2, TEntity3 entity3, TEntity4 entity4, TEntity5 entity5, TEntity6 entity6, TEntity7 entity7, TEntity8 entity8, TEntity9 entity9, TEntity10 entity10);

    }

    public interface IEntityTranslator<in TModel1, out TEntity>
        where TModel1 : Model.IModel
        where TEntity : IEntity {

        TEntity Translate(TModel1 Model);

    }

    public interface IEntityTranslator<in TModel1, in TModel2, out TEntity>
        where TModel1 : Model.IModel
        where TEntity : IEntity {

        TEntity Translate(TModel1 model1, TModel2 model2);

    }

    public interface IEntityTranslator<in TModel1, in TModel2, in TModel3, out TEntity>
        where TModel1 : Model.IModel
        where TEntity : IEntity {

        TEntity Translate(TModel1 model1, TModel2 model2, TModel3 model3);

    }

    public interface IEntity<in TModel1, in TModel2, in TModel3, in TModel4, out TEntity>
        where TModel1 : Model.IModel
        where TEntity : IEntity {

        TEntity Translate(TModel1 model1, TModel2 model2, TModel3 model3, TModel4 model4);

    }

    public interface IEntityTranslator<in TModel1, in TModel2, in TModel3, in TModel4, in TModel5, out TEntity>
        where TModel1 : Model.IModel
        where TEntity : IEntity {

        TEntity Translate(TModel1 model1, TModel2 model2, TModel3 model3, TModel4 model4, TModel5 model5);

    }

    public interface IEntityTranslator<in TModel1, in TModel2, in TModel3, in TModel4, in TModel5, in TModel6, out TEntity>
        where TModel1 : Model.IModel
        where TEntity : IEntity {

        TEntity Translate(TModel1 model1, TModel2 model2, TModel3 model3, TModel4 model4, TModel5 model5, TModel6 model6);

    }

    public interface IEntityTranslator<in TModel1, in TModel2, in TModel3, in TModel4, in TModel5, in TModel6, in TModel7, out TEntity>
        where TModel1 : Model.IModel
        where TEntity : IEntity {

        TEntity Translate(TModel1 model1, TModel2 model2, TModel3 model3, TModel4 model4, TModel5 model5, TModel6 model6, TModel7 model7);

    }

    public interface IEntityTranslator<in TModel1, in TModel2, in TModel3, in TModel4, in TModel5, in TModel6, in TModel7, in TModel8, out TEntity>
        where TModel1 : Model.IModel
        where TEntity : IEntity {

        TEntity Translate(TModel1 model1, TModel2 model2, TModel3 model3, TModel4 model4, TModel5 model5, TModel6 model6, TModel7 model7, TModel8 model8);

    }

    public interface IEntityTranslator<in TModel1, in TModel2, in TModel3, in TModel4, in TModel5, in TModel6, in TModel7, in TModel8, in TModel9, out TEntity>
        where TModel1 : Model.IModel
        where TEntity : IEntity {

        TEntity Translate(TModel1 model1, TModel2 model2, TModel3 model3, TModel4 model4, TModel5 model5, TModel6 model6, TModel7 model7, TModel8 model8, TModel9 model9);

    }

    public interface IEntityTranslator<in TModel1, in TModel2, in TModel3, in TModel4, in TModel5, in TModel6, in TModel7, in TModel8, in TModel9, in TModel10, out TEntity>
        where TModel1 : Model.IModel
        where TEntity : IEntity {

        TEntity Translate(TModel1 model1, TModel2 model2, TModel3 model3, TModel4 model4, TModel5 model5, TModel6 model6, TModel7 model7, TModel8 model8, TModel9 model9, TModel10 model10);

    }

    public interface IAsyncModelTranslator<in TEntity1, TModel>
        where TEntity1 : IEntity
        where TModel : Model.IModel {

        IObservable<TModel> TranslateAsObservable(TEntity1 entity);

    }

    public interface IAsyncModelTranslator<in TEntity1, in TEntity2, TModel>
        where TEntity1 : IEntity
        where TModel : Model.IModel {

        IObservable<TModel> TranslateAsObservable(TEntity1 entity1, TEntity2 entity2);

    }

    public interface IAsyncModelTranslator<in TEntity1, in TEntity2, in TEntity3, TModel>
        where TEntity1 : IEntity
        where TModel : Model.IModel {

        IObservable<TModel> TranslateAsObservable(TEntity1 entity1, TEntity2 entity2, TEntity3 entity3);

    }

    public interface IAsyncModelTranslator<in TEntity1, in TEntity2, in TEntity3, in TEntity4, TModel>
        where TEntity1 : IEntity
        where TModel : Model.IModel {

        IObservable<TModel> TranslateAsObservable(TEntity1 entity1, TEntity2 entity2, TEntity3 entity3, TEntity4 entity4);

    }

    public interface IAsyncModelTranslator<in TEntity1, in TEntity2, in TEntity3, in TEntity4, in TEntity5, TModel>
        where TEntity1 : IEntity
        where TModel : Model.IModel {

        IObservable<TModel> TranslateAsObservable(TEntity1 entity1, TEntity2 entity2, TEntity3 entity3, TEntity4 entity4, TEntity5 entity5);

    }

    public interface IAsyncModelTranslator<in TEntity1, in TEntity2, in TEntity3, in TEntity4, in TEntity5, in TEntity6, TModel>
        where TEntity1 : IEntity
        where TModel : Model.IModel {

        IObservable<TModel> TranslateAsObservable(TEntity1 entity1, TEntity2 entity2, TEntity3 entity3, TEntity4 entity4, TEntity5 entity5, TEntity6 entity6);

    }

    public interface IAsyncModelTranslator<in TEntity1, in TEntity2, in TEntity3, in TEntity4, in TEntity5, in TEntity6, in TEntity7, TModel>
        where TEntity1 : IEntity
        where TModel : Model.IModel {

        IObservable<TModel> TranslateAsObservable(TEntity1 entity1, TEntity2 entity2, TEntity3 entity3, TEntity4 entity4, TEntity5 entity5, TEntity6 entity6, TEntity7 entity7);

    }

    public interface IAsyncModelTranslator<in TEntity1, in TEntity2, in TEntity3, in TEntity4, in TEntity5, in TEntity6, in TEntity7, in TEntity8, TModel>
        where TEntity1 : IEntity
        where TModel : Model.IModel {

        IObservable<TModel> TranslateAsObservable(TEntity1 entity1, TEntity2 entity2, TEntity3 entity3, TEntity4 entity4, TEntity5 entity5, TEntity6 entity6, TEntity7 entity7, TEntity8 entity8);

    }

    public interface IAsyncModelTranslator<in TEntity1, in TEntity2, in TEntity3, in TEntity4, in TEntity5, in TEntity6, in TEntity7, in TEntity8, in TEntity9, TModel>
        where TEntity1 : IEntity
        where TModel : Model.IModel {

        IObservable<TModel> TranslateAsObservable(TEntity1 entity1, TEntity2 entity2, TEntity3 entity3, TEntity4 entity4, TEntity5 entity5, TEntity6 entity6, TEntity7 entity7, TEntity8 entity8, TEntity9 entity9);

    }

    public interface IAsyncModelTranslator<in TEntity1, in TEntity2, in TEntity3, in TEntity4, in TEntity5, in TEntity6, in TEntity7, in TEntity8, in TEntity9, in TEntity10, TModel>
        where TEntity1 : IEntity
        where TModel : Model.IModel {

        IObservable<TModel> TranslateAsObservable(TEntity1 entity1, TEntity2 entity2, TEntity3 entity3, TEntity4 entity4, TEntity5 entity5, TEntity6 entity6, TEntity7 entity7, TEntity8 entity8, TEntity9 entity9, TEntity10 entity10);

    }

    public interface IAsyncEntityTranslator<in TModel1, TEntity>
        where TModel1 : Model.IModel
        where TEntity : IEntity {

        IObservable<TEntity> TranslateAsObservable(TModel1 Model);

    }

    public interface IAsyncEntityTranslator<in TModel1, in TModel2, TEntity>
        where TModel1 : Model.IModel
        where TEntity : IEntity {

        IObservable<TEntity> TranslateAsObservable(TModel1 model1, TModel2 model2);

    }

    public interface IAsyncEntityTranslator<in TModel1, in TModel2, in TModel3, TEntity>
        where TModel1 : Model.IModel
        where TEntity : IEntity {

        IObservable<TEntity> TranslateAsObservable(TModel1 model1, TModel2 model2, TModel3 model3);

    }

    public interface IAsyncEntityTranslator<in TModel1, in TModel2, in TModel3, in TModel4, TEntity>
        where TModel1 : Model.IModel
        where TEntity : IEntity {

        IObservable<TEntity> TranslateAsObservable(TModel1 model1, TModel2 model2, TModel3 model3, TModel4 model4);

    }

    public interface IAsyncEntityTranslator<in TModel1, in TModel2, in TModel3, in TModel4, in TModel5, TEntity>
        where TModel1 : Model.IModel
        where TEntity : IEntity {

        IObservable<TEntity> TranslateAsObservable(TModel1 model1, TModel2 model2, TModel3 model3, TModel4 model4, TModel5 model5);

    }

    public interface IAsyncEntityTranslator<in TModel1, in TModel2, in TModel3, in TModel4, in TModel5, in TModel6, TEntity>
        where TModel1 : Model.IModel
        where TEntity : IEntity {

        IObservable<TEntity> TranslateAsObservable(TModel1 model1, TModel2 model2, TModel3 model3, TModel4 model4, TModel5 model5, TModel6 model6);

    }

    public interface IAsyncEntityTranslator<in TModel1, in TModel2, in TModel3, in TModel4, in TModel5, in TModel6, in TModel7, TEntity>
        where TModel1 : Model.IModel
        where TEntity : IEntity {

        IObservable<TEntity> TranslateAsObservable(TModel1 model1, TModel2 model2, TModel3 model3, TModel4 model4, TModel5 model5, TModel6 model6, TModel7 model7);

    }

    public interface IAsyncEntityTranslator<in TModel1, in TModel2, in TModel3, in TModel4, in TModel5, in TModel6, in TModel7, in TModel8, TEntity>
        where TModel1 : Model.IModel
        where TEntity : IEntity {

        IObservable<TEntity> TranslateAsObservable(TModel1 model1, TModel2 model2, TModel3 model3, TModel4 model4, TModel5 model5, TModel6 model6, TModel7 model7, TModel8 model8);

    }

    public interface IAsyncEntityTranslator<in TModel1, in TModel2, in TModel3, in TModel4, in TModel5, in TModel6, in TModel7, in TModel8, in TModel9, TEntity>
        where TModel1 : Model.IModel
        where TEntity : IEntity {

        IObservable<TEntity> TranslateAsObservable(TModel1 model1, TModel2 model2, TModel3 model3, TModel4 model4, TModel5 model5, TModel6 model6, TModel7 model7, TModel8 model8, TModel9 model9);

    }

    public interface IAsyncEntityTranslator<in TModel1, in TModel2, in TModel3, in TModel4, in TModel5, in TModel6, in TModel7, in TModel8, in TModel9, in TModel10, TEntity>
        where TModel1 : Model.IModel
        where TEntity : IEntity {

        IObservable<TEntity> TranslateAsObservable(TModel1 model1, TModel2 model2, TModel3 model3, TModel4 model4, TModel5 model5, TModel6 model6, TModel7 model7, TModel8 model8, TModel9 model9, TModel10 model10);

    }

}