using System;
using System.Threading.Tasks;
// ReSharper disable UnusedMember.Global

namespace CAFU.Core
{
    public interface ITranslator
    {
    }

    public interface ITranslatable
    {
    }

    public interface IObservableTranslator : ITranslator
    {
    }

    public interface IAsyncTranslator : ITranslator
    {
    }

    public interface ITranslator<out TTranslatable> : ITranslator
        where TTranslatable : ITranslatable
    {
        TTranslatable Translate();
    }

    public interface ITranslator<in TParam1, out TTranslatable> : ITranslator
        where TTranslatable : ITranslatable
    {
        TTranslatable Translate(TParam1 param1);
    }

    public interface ITranslator<in TParam1, in TParam2, out TTranslatable> : ITranslator
        where TTranslatable : ITranslatable
    {
        TTranslatable Translate(TParam1 param1, TParam2 param2);
    }

    public interface ITranslator<in TParam1, in TParam2, in TParam3, out TTranslatable> : ITranslator
        where TTranslatable : ITranslatable
    {
        TTranslatable Translate(TParam1 param1, TParam2 param2, TParam3 param3);
    }

    public interface ITranslator<in TParam1, in TParam2, in TParam3, in TParam4, out TTranslatable> : ITranslator
        where TTranslatable : ITranslatable
    {
        TTranslatable Translate(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4);
    }

    public interface ITranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, out TTranslatable> : ITranslator
        where TTranslatable : ITranslatable
    {
        TTranslatable Translate(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5);
    }

    public interface ITranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, out TTranslatable> : ITranslator
        where TTranslatable : ITranslatable
    {
        TTranslatable Translate(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6);
    }

    public interface ITranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, out TTranslatable> : ITranslator
        where TTranslatable : ITranslatable
    {
        TTranslatable Translate(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7);
    }

    public interface ITranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, in TParam8, out TTranslatable> : ITranslator
        where TTranslatable : ITranslatable
    {
        TTranslatable Translate(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8);
    }

    public interface ITranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, in TParam8, in TParam9, out TTranslatable> : ITranslator
        where TTranslatable : ITranslatable
    {
        TTranslatable Translate(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8, TParam9 param9);
    }

    public interface ITranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, in TParam8, in TParam9, in TParam10, out TTranslatable> : ITranslator
        where TTranslatable : ITranslatable
    {
        TTranslatable Translate(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8, TParam9 param9, TParam10 param10);
    }

    public interface IObservableTranslator<out TTranslatable> : IObservableTranslator
        where TTranslatable : ITranslatable
    {
        IObservable<TTranslatable> TranslateAsObservable();
    }

    public interface IObservableTranslator<in TParam1, out TTranslatable> : IObservableTranslator
        where TTranslatable : ITranslatable
    {
        IObservable<TTranslatable> TranslateAsObservable(TParam1 param1);
    }

    public interface IObservableTranslator<in TParam1, in TParam2, out TTranslatable> : IObservableTranslator
        where TTranslatable : ITranslatable
    {
        IObservable<TTranslatable> TranslateAsObservable(TParam1 param1, TParam2 param2);
    }

    public interface IObservableTranslator<in TParam1, in TParam2, in TParam3, out TTranslatable> : IObservableTranslator
        where TTranslatable : ITranslatable
    {
        IObservable<TTranslatable> TranslateAsObservable(TParam1 param1, TParam2 param2, TParam3 param3);
    }

    public interface IObservableTranslator<in TParam1, in TParam2, in TParam3, in TParam4, out TTranslatable> : IObservableTranslator
        where TTranslatable : ITranslatable
    {
        IObservable<TTranslatable> TranslateAsObservable(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4);
    }

    public interface IObservableTranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, out TTranslatable> : IObservableTranslator
        where TTranslatable : ITranslatable
    {
        IObservable<TTranslatable> TranslateAsObservable(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5);
    }

    public interface IObservableTranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, out TTranslatable> : IObservableTranslator
        where TTranslatable : ITranslatable
    {
        IObservable<TTranslatable> TranslateAsObservable(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6);
    }

    public interface IObservableTranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, out TTranslatable> : IObservableTranslator
        where TTranslatable : ITranslatable
    {
        IObservable<TTranslatable> TranslateAsObservable(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7);
    }

    public interface IObservableTranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, in TParam8, out TTranslatable> : IObservableTranslator
        where TTranslatable : ITranslatable
    {
        IObservable<TTranslatable> TranslateAsObservable(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8);
    }

    public interface IObservableTranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, in TParam8, in TParam9, out TTranslatable> : IObservableTranslator
        where TTranslatable : ITranslatable
    {
        IObservable<TTranslatable> TranslateAsObservable(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8, TParam9 param9);
    }

    public interface IObservableTranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, in TParam8, in TParam9, in TParam10, out TTranslatable> : IObservableTranslator
        where TTranslatable : ITranslatable
    {
        IObservable<TTranslatable> TranslateAsObservable(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8, TParam9 param9, TParam10 param10);
    }

    public interface IAsyncTranslator<TTranslatable> : IAsyncTranslator
        where TTranslatable : ITranslatable
    {
        Task<TTranslatable> TranslateAsync();
    }

    public interface IAsyncTranslator<in TParam1, TTranslatable> : IAsyncTranslator
        where TTranslatable : ITranslatable
    {
        Task<TTranslatable> TranslateAsync(TParam1 param1);
    }

    public interface IAsyncTranslator<in TParam1, in TParam2, TTranslatable> : IAsyncTranslator
        where TTranslatable : ITranslatable
    {
        Task<TTranslatable> TranslateAsync(TParam1 param1, TParam2 param2);
    }

    public interface IAsyncTranslator<in TParam1, in TParam2, in TParam3, TTranslatable> : IAsyncTranslator
        where TTranslatable : ITranslatable
    {
        Task<TTranslatable> TranslateAsync(TParam1 param1, TParam2 param2, TParam3 param3);
    }

    public interface IAsyncTranslator<in TParam1, in TParam2, in TParam3, in TParam4, TTranslatable> : IAsyncTranslator
        where TTranslatable : ITranslatable
    {
        Task<TTranslatable> TranslateAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4);
    }

    public interface IAsyncTranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, TTranslatable> : IAsyncTranslator
        where TTranslatable : ITranslatable
    {
        Task<TTranslatable> TranslateAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5);
    }

    public interface IAsyncTranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, TTranslatable> : IAsyncTranslator
        where TTranslatable : ITranslatable
    {
        Task<TTranslatable> TranslateAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6);
    }

    public interface IAsyncTranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, TTranslatable> : IAsyncTranslator
        where TTranslatable : ITranslatable
    {
        Task<TTranslatable> TranslateAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7);
    }

    public interface IAsyncTranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, in TParam8, TTranslatable> : IAsyncTranslator
        where TTranslatable : ITranslatable
    {
        Task<TTranslatable> TranslateAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8);
    }

    public interface IAsyncTranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, in TParam8, in TParam9, TTranslatable> : IAsyncTranslator
        where TTranslatable : ITranslatable
    {
        Task<TTranslatable> TranslateAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8, TParam9 param9);
    }

    public interface IAsyncTranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, in TParam8, in TParam9, in TParam10, TTranslatable> : IAsyncTranslator
        where TTranslatable : ITranslatable
    {
        Task<TTranslatable> TranslateAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8, TParam9 param9, TParam10 param10);
    }
}