using System;
using System.Threading.Tasks;
using CAFU.Core.Data.Entity;
using CAFU.Core.Utility;
using JetBrains.Annotations;
using UniRx;

namespace CAFU.Core.Domain.Translator
{
    [PublicAPI]
    public interface ITranslator
    {
    }

    [PublicAPI]
    public interface ISingletonTranslator : ITranslator, ISingleton
    {
    }

    [PublicAPI]
    public interface IObservableTranslator
    {
    }

    [PublicAPI]
    public interface IAsyncTranslator
    {
    }

    [PublicAPI]
    public interface IModelTranslator : ITranslator
    {
    }

    [PublicAPI]
    public interface IEntityTranslator : ITranslator
    {
    }

    [PublicAPI]
    public interface IObservableModelTranslator : IObservableTranslator, IModelTranslator
    {
    }

    [PublicAPI]
    public interface IObservableEntityTranslator : IObservableTranslator, IEntityTranslator
    {
    }

    [PublicAPI]
    public interface IAsyncModelTranslator : IAsyncTranslator, IModelTranslator
    {
    }

    [PublicAPI]
    public interface IAsyncEntityTranslator : IAsyncTranslator, IEntityTranslator
    {
    }

    [PublicAPI]
    public interface IModelTranslator<in TEntity1, out TModel> : IModelTranslator
        where TModel : Model.IModel
    {
        TModel Translate(TEntity1 entity);
    }

    [PublicAPI]
    public interface IModelTranslator<in TEntity1, in TEntity2, out TModel> : IModelTranslator
        where TModel : Model.IModel
    {
        TModel Translate(TEntity1 entity1, TEntity2 entity2);
    }

    [PublicAPI]
    public interface IModelTranslator<in TEntity1, in TEntity2, in TEntity3, out TModel> : IModelTranslator
        where TModel : Model.IModel
    {
        TModel Translate(TEntity1 entity1, TEntity2 entity2, TEntity3 entity3);
    }

    [PublicAPI]
    public interface IModelTranslator<in TEntity1, in TEntity2, in TEntity3, in TEntity4, out TModel> : IModelTranslator
        where TModel : Model.IModel
    {
        TModel Translate(TEntity1 entity1, TEntity2 entity2, TEntity3 entity3, TEntity4 entity4);
    }

    [PublicAPI]
    public interface IModelTranslator<in TEntity1, in TEntity2, in TEntity3, in TEntity4, in TEntity5, out TModel> : IModelTranslator
        where TModel : Model.IModel
    {
        TModel Translate(TEntity1 entity1, TEntity2 entity2, TEntity3 entity3, TEntity4 entity4, TEntity5 entity5);
    }

    [PublicAPI]
    public interface IModelTranslator<in TEntity1, in TEntity2, in TEntity3, in TEntity4, in TEntity5, in TEntity6, out TModel> : IModelTranslator
        where TModel : Model.IModel
    {
        TModel Translate(TEntity1 entity1, TEntity2 entity2, TEntity3 entity3, TEntity4 entity4, TEntity5 entity5, TEntity6 entity6);
    }

    [PublicAPI]
    public interface IModelTranslator<in TEntity1, in TEntity2, in TEntity3, in TEntity4, in TEntity5, in TEntity6, in TEntity7, out TModel> : IModelTranslator
        where TModel : Model.IModel
    {
        TModel Translate(TEntity1 entity1, TEntity2 entity2, TEntity3 entity3, TEntity4 entity4, TEntity5 entity5, TEntity6 entity6, TEntity7 entity7);
    }

    [PublicAPI]
    public interface IModelTranslator<in TEntity1, in TEntity2, in TEntity3, in TEntity4, in TEntity5, in TEntity6, in TEntity7, in TEntity8, out TModel> : IModelTranslator
        where TModel : Model.IModel
    {
        TModel Translate(TEntity1 entity1, TEntity2 entity2, TEntity3 entity3, TEntity4 entity4, TEntity5 entity5, TEntity6 entity6, TEntity7 entity7, TEntity8 entity8);
    }

    [PublicAPI]
    public interface IModelTranslator<in TEntity1, in TEntity2, in TEntity3, in TEntity4, in TEntity5, in TEntity6, in TEntity7, in TEntity8, in TEntity9, out TModel> : IModelTranslator
        where TModel : Model.IModel
    {
        TModel Translate(TEntity1 entity1, TEntity2 entity2, TEntity3 entity3, TEntity4 entity4, TEntity5 entity5, TEntity6 entity6, TEntity7 entity7, TEntity8 entity8, TEntity9 entity9);
    }

    [PublicAPI]
    public interface IModelTranslator<in TEntity1, in TEntity2, in TEntity3, in TEntity4, in TEntity5, in TEntity6, in TEntity7, in TEntity8, in TEntity9, in TEntity10, out TModel> : IModelTranslator
        where TModel : Model.IModel
    {
        TModel Translate(TEntity1 entity1, TEntity2 entity2, TEntity3 entity3, TEntity4 entity4, TEntity5 entity5, TEntity6 entity6, TEntity7 entity7, TEntity8 entity8, TEntity9 entity9, TEntity10 entity10);
    }

    [PublicAPI]
    public interface IEntityTranslator<in TModel1, out TEntity> : IEntityTranslator
        where TEntity : IEntity
    {
        TEntity Translate(TModel1 model);
    }

    [PublicAPI]
    public interface IEntityTranslator<in TModel1, in TModel2, out TEntity> : IEntityTranslator
        where TEntity : IEntity
    {
        TEntity Translate(TModel1 model1, TModel2 model2);
    }

    [PublicAPI]
    public interface IEntityTranslator<in TModel1, in TModel2, in TModel3, out TEntity> : IEntityTranslator
        where TEntity : IEntity
    {
        TEntity Translate(TModel1 model1, TModel2 model2, TModel3 model3);
    }

    [PublicAPI]
    public interface IEntityTranslator<in TModel1, in TModel2, in TModel3, in TModel4, out TEntity> : IEntityTranslator
        where TEntity : IEntity
    {
        TEntity Translate(TModel1 model1, TModel2 model2, TModel3 model3, TModel4 model4);
    }

    [PublicAPI]
    public interface IEntityTranslator<in TModel1, in TModel2, in TModel3, in TModel4, in TModel5, out TEntity> : IEntityTranslator
        where TEntity : IEntity
    {
        TEntity Translate(TModel1 model1, TModel2 model2, TModel3 model3, TModel4 model4, TModel5 model5);
    }

    [PublicAPI]
    public interface IEntityTranslator<in TModel1, in TModel2, in TModel3, in TModel4, in TModel5, in TModel6, out TEntity> : IEntityTranslator
        where TEntity : IEntity
    {
        TEntity Translate(TModel1 model1, TModel2 model2, TModel3 model3, TModel4 model4, TModel5 model5, TModel6 model6);
    }

    [PublicAPI]
    public interface IEntityTranslator<in TModel1, in TModel2, in TModel3, in TModel4, in TModel5, in TModel6, in TModel7, out TEntity> : IEntityTranslator
        where TEntity : IEntity
    {
        TEntity Translate(TModel1 model1, TModel2 model2, TModel3 model3, TModel4 model4, TModel5 model5, TModel6 model6, TModel7 model7);
    }

    [PublicAPI]
    public interface IEntityTranslator<in TModel1, in TModel2, in TModel3, in TModel4, in TModel5, in TModel6, in TModel7, in TModel8, out TEntity> : IEntityTranslator
        where TEntity : IEntity
    {
        TEntity Translate(TModel1 model1, TModel2 model2, TModel3 model3, TModel4 model4, TModel5 model5, TModel6 model6, TModel7 model7, TModel8 model8);
    }

    [PublicAPI]
    public interface IEntityTranslator<in TModel1, in TModel2, in TModel3, in TModel4, in TModel5, in TModel6, in TModel7, in TModel8, in TModel9, out TEntity> : IEntityTranslator
        where TEntity : IEntity
    {
        TEntity Translate(TModel1 model1, TModel2 model2, TModel3 model3, TModel4 model4, TModel5 model5, TModel6 model6, TModel7 model7, TModel8 model8, TModel9 model9);
    }

    [PublicAPI]
    public interface IEntityTranslator<in TModel1, in TModel2, in TModel3, in TModel4, in TModel5, in TModel6, in TModel7, in TModel8, in TModel9, in TModel10, out TEntity> : IEntityTranslator
        where TEntity : IEntity
    {
        TEntity Translate(TModel1 model1, TModel2 model2, TModel3 model3, TModel4 model4, TModel5 model5, TModel6 model6, TModel7 model7, TModel8 model8, TModel9 model9, TModel10 model10);
    }

    [PublicAPI]
    public interface IObservableModelTranslator<in TEntity1, TModel> : IObservableModelTranslator
        where TModel : Model.IModel
    {
        IObservable<TModel> TranslateAsObservable(TEntity1 entity);
    }

    [PublicAPI]
    public interface IObservableModelTranslator<in TEntity1, in TEntity2, TModel> : IObservableModelTranslator
        where TModel : Model.IModel
    {
        IObservable<TModel> TranslateAsObservable(TEntity1 entity1, TEntity2 entity2);
    }

    [PublicAPI]
    public interface IObservableModelTranslator<in TEntity1, in TEntity2, in TEntity3, TModel> : IObservableModelTranslator
        where TModel : Model.IModel
    {
        IObservable<TModel> TranslateAsObservable(TEntity1 entity1, TEntity2 entity2, TEntity3 entity3);
    }

    [PublicAPI]
    public interface IObservableModelTranslator<in TEntity1, in TEntity2, in TEntity3, in TEntity4, TModel> : IObservableModelTranslator
        where TModel : Model.IModel
    {
        IObservable<TModel> TranslateAsObservable(TEntity1 entity1, TEntity2 entity2, TEntity3 entity3, TEntity4 entity4);
    }

    [PublicAPI]
    public interface IObservableModelTranslator<in TEntity1, in TEntity2, in TEntity3, in TEntity4, in TEntity5, TModel> : IObservableModelTranslator
        where TModel : Model.IModel
    {
        IObservable<TModel> TranslateAsObservable(TEntity1 entity1, TEntity2 entity2, TEntity3 entity3, TEntity4 entity4, TEntity5 entity5);
    }

    [PublicAPI]
    public interface IObservableModelTranslator<in TEntity1, in TEntity2, in TEntity3, in TEntity4, in TEntity5, in TEntity6, TModel> : IObservableModelTranslator
        where TModel : Model.IModel
    {
        IObservable<TModel> TranslateAsObservable(TEntity1 entity1, TEntity2 entity2, TEntity3 entity3, TEntity4 entity4, TEntity5 entity5, TEntity6 entity6);
    }

    [PublicAPI]
    public interface IObservableModelTranslator<in TEntity1, in TEntity2, in TEntity3, in TEntity4, in TEntity5, in TEntity6, in TEntity7, TModel> : IObservableModelTranslator
        where TModel : Model.IModel
    {
        IObservable<TModel> TranslateAsObservable(TEntity1 entity1, TEntity2 entity2, TEntity3 entity3, TEntity4 entity4, TEntity5 entity5, TEntity6 entity6, TEntity7 entity7);
    }

    [PublicAPI]
    public interface IObservableModelTranslator<in TEntity1, in TEntity2, in TEntity3, in TEntity4, in TEntity5, in TEntity6, in TEntity7, in TEntity8, TModel> : IObservableModelTranslator
        where TModel : Model.IModel
    {
        IObservable<TModel> TranslateAsObservable(TEntity1 entity1, TEntity2 entity2, TEntity3 entity3, TEntity4 entity4, TEntity5 entity5, TEntity6 entity6, TEntity7 entity7, TEntity8 entity8);
    }

    [PublicAPI]
    public interface IObservableModelTranslator<in TEntity1, in TEntity2, in TEntity3, in TEntity4, in TEntity5, in TEntity6, in TEntity7, in TEntity8, in TEntity9, TModel> : IObservableModelTranslator
        where TModel : Model.IModel
    {
        IObservable<TModel> TranslateAsObservable(TEntity1 entity1, TEntity2 entity2, TEntity3 entity3, TEntity4 entity4, TEntity5 entity5, TEntity6 entity6, TEntity7 entity7, TEntity8 entity8, TEntity9 entity9);
    }

    [PublicAPI]
    public interface IObservableModelTranslator<in TEntity1, in TEntity2, in TEntity3, in TEntity4, in TEntity5, in TEntity6, in TEntity7, in TEntity8, in TEntity9, in TEntity10, TModel> : IObservableModelTranslator
        where TModel : Model.IModel
    {
        IObservable<TModel> TranslateAsObservable(TEntity1 entity1, TEntity2 entity2, TEntity3 entity3, TEntity4 entity4, TEntity5 entity5, TEntity6 entity6, TEntity7 entity7, TEntity8 entity8, TEntity9 entity9, TEntity10 entity10);
    }

    [PublicAPI]
    public interface IObservableEntityTranslator<in TModel1, TEntity> : IObservableEntityTranslator
        where TEntity : IEntity
    {
        IObservable<TEntity> TranslateAsObservable(TModel1 model);
    }

    [PublicAPI]
    public interface IObservableEntityTranslator<in TModel1, in TModel2, TEntity> : IObservableEntityTranslator
        where TEntity : IEntity
    {
        IObservable<TEntity> TranslateAsObservable(TModel1 model1, TModel2 model2);
    }

    [PublicAPI]
    public interface IObservableEntityTranslator<in TModel1, in TModel2, in TModel3, TEntity> : IObservableEntityTranslator
        where TEntity : IEntity
    {
        IObservable<TEntity> TranslateAsObservable(TModel1 model1, TModel2 model2, TModel3 model3);
    }

    [PublicAPI]
    public interface IObservableEntityTranslator<in TModel1, in TModel2, in TModel3, in TModel4, TEntity> : IObservableEntityTranslator
        where TEntity : IEntity
    {
        IObservable<TEntity> TranslateAsObservable(TModel1 model1, TModel2 model2, TModel3 model3, TModel4 model4);
    }

    [PublicAPI]
    public interface IObservableEntityTranslator<in TModel1, in TModel2, in TModel3, in TModel4, in TModel5, TEntity> : IObservableEntityTranslator
        where TEntity : IEntity
    {
        IObservable<TEntity> TranslateAsObservable(TModel1 model1, TModel2 model2, TModel3 model3, TModel4 model4, TModel5 model5);
    }

    [PublicAPI]
    public interface IObservableEntityTranslator<in TModel1, in TModel2, in TModel3, in TModel4, in TModel5, in TModel6, TEntity> : IObservableEntityTranslator
        where TEntity : IEntity
    {
        IObservable<TEntity> TranslateAsObservable(TModel1 model1, TModel2 model2, TModel3 model3, TModel4 model4, TModel5 model5, TModel6 model6);
    }

    [PublicAPI]
    public interface IObservableEntityTranslator<in TModel1, in TModel2, in TModel3, in TModel4, in TModel5, in TModel6, in TModel7, TEntity> : IObservableEntityTranslator
        where TEntity : IEntity
    {
        IObservable<TEntity> TranslateAsObservable(TModel1 model1, TModel2 model2, TModel3 model3, TModel4 model4, TModel5 model5, TModel6 model6, TModel7 model7);
    }

    [PublicAPI]
    public interface IObservableEntityTranslator<in TModel1, in TModel2, in TModel3, in TModel4, in TModel5, in TModel6, in TModel7, in TModel8, TEntity> : IObservableEntityTranslator
        where TEntity : IEntity
    {
        IObservable<TEntity> TranslateAsObservable(TModel1 model1, TModel2 model2, TModel3 model3, TModel4 model4, TModel5 model5, TModel6 model6, TModel7 model7, TModel8 model8);
    }

    [PublicAPI]
    public interface IObservableEntityTranslator<in TModel1, in TModel2, in TModel3, in TModel4, in TModel5, in TModel6, in TModel7, in TModel8, in TModel9, TEntity> : IObservableEntityTranslator
        where TEntity : IEntity
    {
        IObservable<TEntity> TranslateAsObservable(TModel1 model1, TModel2 model2, TModel3 model3, TModel4 model4, TModel5 model5, TModel6 model6, TModel7 model7, TModel8 model8, TModel9 model9);
    }

    [PublicAPI]
    public interface IObservableEntityTranslator<in TModel1, in TModel2, in TModel3, in TModel4, in TModel5, in TModel6, in TModel7, in TModel8, in TModel9, in TModel10, TEntity> : IObservableEntityTranslator
        where TEntity : IEntity
    {
        IObservable<TEntity> TranslateAsObservable(TModel1 model1, TModel2 model2, TModel3 model3, TModel4 model4, TModel5 model5, TModel6 model6, TModel7 model7, TModel8 model8, TModel9 model9, TModel10 model10);
    }

    [PublicAPI]
    public interface IAsyncModelTranslator<in TEntity1, TModel> : IAsyncModelTranslator
        where TModel : Model.IModel
    {
        Task<TModel> TranslateAsync(TEntity1 entity);
    }

    [PublicAPI]
    public interface IAsyncModelTranslator<in TEntity1, in TEntity2, TModel> : IAsyncModelTranslator
        where TModel : Model.IModel
    {
        Task<TModel> TranslateAsync(TEntity1 entity1, TEntity2 entity2);
    }

    [PublicAPI]
    public interface IAsyncModelTranslator<in TEntity1, in TEntity2, in TEntity3, TModel> : IAsyncModelTranslator
        where TModel : Model.IModel
    {
        Task<TModel> TranslateAsync(TEntity1 entity1, TEntity2 entity2, TEntity3 entity3);
    }

    [PublicAPI]
    public interface IAsyncModelTranslator<in TEntity1, in TEntity2, in TEntity3, in TEntity4, TModel> : IAsyncModelTranslator
        where TModel : Model.IModel
    {
        Task<TModel> TranslateAsync(TEntity1 entity1, TEntity2 entity2, TEntity3 entity3, TEntity4 entity4);
    }

    [PublicAPI]
    public interface IAsyncModelTranslator<in TEntity1, in TEntity2, in TEntity3, in TEntity4, in TEntity5, TModel> : IAsyncModelTranslator
        where TModel : Model.IModel
    {
        Task<TModel> TranslateAsync(TEntity1 entity1, TEntity2 entity2, TEntity3 entity3, TEntity4 entity4, TEntity5 entity5);
    }

    [PublicAPI]
    public interface IAsyncModelTranslator<in TEntity1, in TEntity2, in TEntity3, in TEntity4, in TEntity5, in TEntity6, TModel> : IAsyncModelTranslator
        where TModel : Model.IModel
    {
        Task<TModel> TranslateAsync(TEntity1 entity1, TEntity2 entity2, TEntity3 entity3, TEntity4 entity4, TEntity5 entity5, TEntity6 entity6);
    }

    [PublicAPI]
    public interface IAsyncModelTranslator<in TEntity1, in TEntity2, in TEntity3, in TEntity4, in TEntity5, in TEntity6, in TEntity7, TModel> : IAsyncModelTranslator
        where TModel : Model.IModel
    {
        Task<TModel> TranslateAsync(TEntity1 entity1, TEntity2 entity2, TEntity3 entity3, TEntity4 entity4, TEntity5 entity5, TEntity6 entity6, TEntity7 entity7);
    }

    [PublicAPI]
    public interface IAsyncModelTranslator<in TEntity1, in TEntity2, in TEntity3, in TEntity4, in TEntity5, in TEntity6, in TEntity7, in TEntity8, TModel> : IAsyncModelTranslator
        where TModel : Model.IModel
    {
        Task<TModel> TranslateAsync(TEntity1 entity1, TEntity2 entity2, TEntity3 entity3, TEntity4 entity4, TEntity5 entity5, TEntity6 entity6, TEntity7 entity7, TEntity8 entity8);
    }

    [PublicAPI]
    public interface IAsyncModelTranslator<in TEntity1, in TEntity2, in TEntity3, in TEntity4, in TEntity5, in TEntity6, in TEntity7, in TEntity8, in TEntity9, TModel> : IAsyncModelTranslator
        where TModel : Model.IModel
    {
        Task<TModel> TranslateAsync(TEntity1 entity1, TEntity2 entity2, TEntity3 entity3, TEntity4 entity4, TEntity5 entity5, TEntity6 entity6, TEntity7 entity7, TEntity8 entity8, TEntity9 entity9);
    }

    [PublicAPI]
    public interface IAsyncModelTranslator<in TEntity1, in TEntity2, in TEntity3, in TEntity4, in TEntity5, in TEntity6, in TEntity7, in TEntity8, in TEntity9, in TEntity10, TModel> : IAsyncModelTranslator
        where TModel : Model.IModel
    {
        Task<TModel> TranslateAsync(TEntity1 entity1, TEntity2 entity2, TEntity3 entity3, TEntity4 entity4, TEntity5 entity5, TEntity6 entity6, TEntity7 entity7, TEntity8 entity8, TEntity9 entity9, TEntity10 entity10);
    }

    [PublicAPI]
    public interface IAsyncEntityTranslator<in TModel1, TEntity> : IAsyncEntityTranslator
        where TEntity : IEntity
    {
        Task<TEntity> TranslateAsync(TModel1 model);
    }

    [PublicAPI]
    public interface IAsyncEntityTranslator<in TModel1, in TModel2, TEntity> : IAsyncEntityTranslator
        where TEntity : IEntity
    {
        Task<TEntity> TranslateAsync(TModel1 model1, TModel2 model2);
    }

    [PublicAPI]
    public interface IAsyncEntityTranslator<in TModel1, in TModel2, in TModel3, TEntity> : IAsyncEntityTranslator
        where TEntity : IEntity
    {
        Task<TEntity> TranslateAsync(TModel1 model1, TModel2 model2, TModel3 model3);
    }

    [PublicAPI]
    public interface IAsyncEntityTranslator<in TModel1, in TModel2, in TModel3, in TModel4, TEntity> : IAsyncEntityTranslator
        where TEntity : IEntity
    {
        Task<TEntity> TranslateAsync(TModel1 model1, TModel2 model2, TModel3 model3, TModel4 model4);
    }

    [PublicAPI]
    public interface IAsyncEntityTranslator<in TModel1, in TModel2, in TModel3, in TModel4, in TModel5, TEntity> : IAsyncEntityTranslator
        where TEntity : IEntity
    {
        Task<TEntity> TranslateAsync(TModel1 model1, TModel2 model2, TModel3 model3, TModel4 model4, TModel5 model5);
    }

    [PublicAPI]
    public interface IAsyncEntityTranslator<in TModel1, in TModel2, in TModel3, in TModel4, in TModel5, in TModel6, TEntity> : IAsyncEntityTranslator
        where TEntity : IEntity
    {
        Task<TEntity> TranslateAsync(TModel1 model1, TModel2 model2, TModel3 model3, TModel4 model4, TModel5 model5, TModel6 model6);
    }

    [PublicAPI]
    public interface IAsyncEntityTranslator<in TModel1, in TModel2, in TModel3, in TModel4, in TModel5, in TModel6, in TModel7, TEntity> : IAsyncEntityTranslator
        where TEntity : IEntity
    {
        Task<TEntity> TranslateAsync(TModel1 model1, TModel2 model2, TModel3 model3, TModel4 model4, TModel5 model5, TModel6 model6, TModel7 model7);
    }

    [PublicAPI]
    public interface IAsyncEntityTranslator<in TModel1, in TModel2, in TModel3, in TModel4, in TModel5, in TModel6, in TModel7, in TModel8, TEntity> : IAsyncEntityTranslator
        where TEntity : IEntity
    {
        Task<TEntity> TranslateAsync(TModel1 model1, TModel2 model2, TModel3 model3, TModel4 model4, TModel5 model5, TModel6 model6, TModel7 model7, TModel8 model8);
    }

    [PublicAPI]
    public interface IAsyncEntityTranslator<in TModel1, in TModel2, in TModel3, in TModel4, in TModel5, in TModel6, in TModel7, in TModel8, in TModel9, TEntity> : IAsyncEntityTranslator
        where TEntity : IEntity
    {
        Task<TEntity> TranslateAsync(TModel1 model1, TModel2 model2, TModel3 model3, TModel4 model4, TModel5 model5, TModel6 model6, TModel7 model7, TModel8 model8, TModel9 model9);
    }

    [PublicAPI]
    public interface IAsyncEntityTranslator<in TModel1, in TModel2, in TModel3, in TModel4, in TModel5, in TModel6, in TModel7, in TModel8, in TModel9, in TModel10, TEntity> : IAsyncEntityTranslator
        where TEntity : IEntity
    {
        Task<TEntity> TranslateAsync(TModel1 model1, TModel2 model2, TModel3 model3, TModel4 model4, TModel5 model5, TModel6 model6, TModel7 model7, TModel8 model8, TModel9 model9, TModel10 model10);
    }

    [PublicAPI]
    public interface ITranslatorFactory<out TTranslator> : IFactory<TTranslator> where TTranslator : ITranslator
    {
    }

    [PublicAPI]
    public class DefaultTranslatorFactory<TTranslator> : DefaultFactory<TTranslator>, ITranslatorFactory<TTranslator>
        where TTranslator : ITranslator, new()
    {
    }
}