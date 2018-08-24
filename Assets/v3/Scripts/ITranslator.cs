using System;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Zenject;

namespace CAFU.Core
{
    public interface ITranslator : IFactory
    {
    }

    public interface IObservableTranslator : ITranslator
    {
    }

    public interface IAsyncTranslator : ITranslator
    {
    }

    [PublicAPI]
    public interface ITranslator<out TEntity> : ITranslator
        where TEntity : IEntity
    {
        TEntity Translate();
    }

    [PublicAPI]
    public interface ITranslator<in TParam, out TEntity> : ITranslator
        where TEntity : IEntity
    {
        TEntity Translate(TParam param);
    }

    [PublicAPI]
    public interface ITranslator<in TParam1, in TParam2, out TEntity> : ITranslator
        where TEntity : IEntity
    {
        TEntity Translate(TParam1 param1, TParam2 param2);
    }

    [PublicAPI]
    public interface ITranslator<in TParam1, in TParam2, in TParam3, out TEntity> : ITranslator
        where TEntity : IEntity
    {
        TEntity Translate(TParam1 param1, TParam2 param2, TParam3 param3);
    }

    [PublicAPI]
    public interface ITranslator<in TParam1, in TParam2, in TParam3, in TParam4, out TEntity> : ITranslator
        where TEntity : IEntity
    {
        TEntity Translate(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4);
    }

    [PublicAPI]
    public interface ITranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, out TEntity> : ITranslator
        where TEntity : IEntity
    {
        TEntity Translate(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5);
    }

    [PublicAPI]
    public interface ITranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, out TEntity> : ITranslator
        where TEntity : IEntity
    {
        TEntity Translate(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6);
    }

    [PublicAPI]
    public interface ITranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, out TEntity> : ITranslator
        where TEntity : IEntity
    {
        TEntity Translate(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7);
    }

    [PublicAPI]
    public interface ITranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, in TParam8, out TEntity> : ITranslator
        where TEntity : IEntity
    {
        TEntity Translate(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8);
    }

    [PublicAPI]
    public interface ITranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, in TParam8, in TParam9, out TEntity> : ITranslator
        where TEntity : IEntity
    {
        TEntity Translate(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8, TParam9 param9);
    }

    [PublicAPI]
    public interface ITranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, in TParam8, in TParam9, in TParam10, out TEntity> : ITranslator
        where TEntity : IEntity
    {
        TEntity Translate(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8, TParam9 param9, TParam10 param10);
    }

    [PublicAPI]
    public interface IObservableTranslator<out TEntity> : IObservableTranslator
        where TEntity : IEntity
    {
        IObservable<TEntity> TranslateAsObservable();
    }

    [PublicAPI]
    public interface IObservableTranslator<in TParam, out TEntity> : IObservableTranslator
        where TEntity : IEntity
    {
        IObservable<TEntity> TranslateAsObservable(TParam param);
    }

    [PublicAPI]
    public interface IObservableTranslator<in TParam1, in TParam2, out TEntity> : IObservableTranslator
        where TEntity : IEntity
    {
        IObservable<TEntity> TranslateAsObservable(TParam1 param1, TParam2 param2);
    }

    [PublicAPI]
    public interface IObservableTranslator<in TParam1, in TParam2, in TParam3, out TEntity> : IObservableTranslator
        where TEntity : IEntity
    {
        IObservable<TEntity> TranslateAsObservable(TParam1 param1, TParam2 param2, TParam3 param3);
    }

    [PublicAPI]
    public interface IObservableTranslator<in TParam1, in TParam2, in TParam3, in TParam4, out TEntity> : IObservableTranslator
        where TEntity : IEntity
    {
        IObservable<TEntity> TranslateAsObservable(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4);
    }

    [PublicAPI]
    public interface IObservableTranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, out TEntity> : IObservableTranslator
        where TEntity : IEntity
    {
        IObservable<TEntity> TranslateAsObservable(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5);
    }

    [PublicAPI]
    public interface IObservableTranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, out TEntity> : IObservableTranslator
        where TEntity : IEntity
    {
        IObservable<TEntity> TranslateAsObservable(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6);
    }

    [PublicAPI]
    public interface IObservableTranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, out TEntity> : IObservableTranslator
        where TEntity : IEntity
    {
        IObservable<TEntity> TranslateAsObservable(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7);
    }

    [PublicAPI]
    public interface IObservableTranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, in TParam8, out TEntity> : IObservableTranslator
        where TEntity : IEntity
    {
        IObservable<TEntity> TranslateAsObservable(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8);
    }

    [PublicAPI]
    public interface IObservableTranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, in TParam8, in TParam9, out TEntity> : IObservableTranslator
        where TEntity : IEntity
    {
        IObservable<TEntity> TranslateAsObservable(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8, TParam9 param9);
    }

    [PublicAPI]
    public interface IObservableTranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, in TParam8, in TParam9, in TParam10, out TEntity> : IObservableTranslator
        where TEntity : IEntity
    {
        IObservable<TEntity> TranslateAsObservable(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8, TParam9 param9, TParam10 param10);
    }

    [PublicAPI]
    public interface IAsyncTranslator<TEntity> : IAsyncTranslator
        where TEntity : IEntity
    {
        Task<TEntity> TranslateAsync();
    }

    [PublicAPI]
    public interface IAsyncTranslator<in TParam, TEntity> : IAsyncTranslator
        where TEntity : IEntity
    {
        Task<TEntity> TranslateAsync(TParam param);
    }

    [PublicAPI]
    public interface IAsyncTranslator<in TParam1, in TParam2, TEntity> : IAsyncTranslator
        where TEntity : IEntity
    {
        Task<TEntity> TranslateAsync(TParam1 param1, TParam2 param2);
    }

    [PublicAPI]
    public interface IAsyncTranslator<in TParam1, in TParam2, in TParam3, TEntity> : IAsyncTranslator
        where TEntity : IEntity
    {
        Task<TEntity> TranslateAsync(TParam1 param1, TParam2 param2, TParam3 param3);
    }

    [PublicAPI]
    public interface IAsyncTranslator<in TParam1, in TParam2, in TParam3, in TParam4, TEntity> : IAsyncTranslator
        where TEntity : IEntity
    {
        Task<TEntity> TranslateAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4);
    }

    [PublicAPI]
    public interface IAsyncTranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, TEntity> : IAsyncTranslator
        where TEntity : IEntity
    {
        Task<TEntity> TranslateAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5);
    }

    [PublicAPI]
    public interface IAsyncTranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, TEntity> : IAsyncTranslator
        where TEntity : IEntity
    {
        Task<TEntity> TranslateAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6);
    }

    [PublicAPI]
    public interface IAsyncTranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, TEntity> : IAsyncTranslator
        where TEntity : IEntity
    {
        Task<TEntity> TranslateAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7);
    }

    [PublicAPI]
    public interface IAsyncTranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, in TParam8, TEntity> : IAsyncTranslator
        where TEntity : IEntity
    {
        Task<TEntity> TranslateAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8);
    }

    [PublicAPI]
    public interface IAsyncTranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, in TParam8, in TParam9, TEntity> : IAsyncTranslator
        where TEntity : IEntity
    {
        Task<TEntity> TranslateAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8, TParam9 param9);
    }

    [PublicAPI]
    public interface IAsyncTranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, in TParam8, in TParam9, in TParam10, TEntity> : IAsyncTranslator
        where TEntity : IEntity
    {
        Task<TEntity> TranslateAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8, TParam9 param9, TParam10 param10);
    }
}