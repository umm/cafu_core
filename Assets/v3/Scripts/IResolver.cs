
using System;
using System.Threading.Tasks;
// ReSharper disable UnusedMember.Global

namespace CAFU.Core
{
    public interface IResolver
    {
    }

    public interface IObservableResolver : IResolver
    {
    }

    public interface IAsyncResolver : IResolver
    {
    }

    public interface IResolver<out TResult> : IResolver
    {
        TResult Resolve();
    }

    public interface IResolver<in TParam1, out TResult> : IResolver
    {
        TResult Resolve(TParam1 param1);
    }

    public interface IResolver<in TParam1, in TParam2, out TResult> : IResolver
    {
        TResult Resolve(TParam1 param1, TParam2 param2);
    }

    public interface IResolver<in TParam1, in TParam2, in TParam3, out TResult> : IResolver
    {
        TResult Resolve(TParam1 param1, TParam2 param2, TParam3 param3);
    }

    public interface IResolver<in TParam1, in TParam2, in TParam3, in TParam4, out TResult> : IResolver
    {
        TResult Resolve(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4);
    }

    public interface IResolver<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, out TResult> : IResolver
    {
        TResult Resolve(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5);
    }

    public interface IResolver<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, out TResult> : IResolver
    {
        TResult Resolve(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6);
    }

    public interface IResolver<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, out TResult> : IResolver
    {
        TResult Resolve(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7);
    }

    public interface IResolver<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, in TParam8, out TResult> : IResolver
    {
        TResult Resolve(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8);
    }

    public interface IResolver<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, in TParam8, in TParam9, out TResult> : IResolver
    {
        TResult Resolve(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8, TParam9 param9);
    }

    public interface IResolver<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, in TParam8, in TParam9, in TParam10, out TResult> : IResolver
    {
        TResult Resolve(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8, TParam9 param9, TParam10 param10);
    }

    public interface IObservableResolver<out TResult> : IObservableResolver
    {
        IObservable<TResult> ResolveAsObservable();
    }

    public interface IObservableResolver<in TParam1, out TResult> : IObservableResolver
    {
        IObservable<TResult> ResolveAsObservable(TParam1 param1);
    }

    public interface IObservableResolver<in TParam1, in TParam2, out TResult> : IObservableResolver
    {
        IObservable<TResult> ResolveAsObservable(TParam1 param1, TParam2 param2);
    }

    public interface IObservableResolver<in TParam1, in TParam2, in TParam3, out TResult> : IObservableResolver
    {
        IObservable<TResult> ResolveAsObservable(TParam1 param1, TParam2 param2, TParam3 param3);
    }

    public interface IObservableResolver<in TParam1, in TParam2, in TParam3, in TParam4, out TResult> : IObservableResolver
    {
        IObservable<TResult> ResolveAsObservable(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4);
    }

    public interface IObservableResolver<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, out TResult> : IObservableResolver
    {
        IObservable<TResult> ResolveAsObservable(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5);
    }

    public interface IObservableResolver<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, out TResult> : IObservableResolver
    {
        IObservable<TResult> ResolveAsObservable(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6);
    }

    public interface IObservableResolver<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, out TResult> : IObservableResolver
    {
        IObservable<TResult> ResolveAsObservable(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7);
    }

    public interface IObservableResolver<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, in TParam8, out TResult> : IObservableResolver
    {
        IObservable<TResult> ResolveAsObservable(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8);
    }

    public interface IObservableResolver<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, in TParam8, in TParam9, out TResult> : IObservableResolver
    {
        IObservable<TResult> ResolveAsObservable(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8, TParam9 param9);
    }

    public interface IObservableResolver<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, in TParam8, in TParam9, in TParam10, out TResult> : IObservableResolver
    {
        IObservable<TResult> ResolveAsObservable(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8, TParam9 param9, TParam10 param10);
    }

    public interface IAsyncResolver<TResult> : IAsyncResolver
    {
        Task<TResult> ResolveAsync();
    }

    public interface IAsyncResolver<in TParam1, TResult> : IAsyncResolver
    {
        Task<TResult> ResolveAsync(TParam1 param1);
    }

    public interface IAsyncResolver<in TParam1, in TParam2, TResult> : IAsyncResolver
    {
        Task<TResult> ResolveAsync(TParam1 param1, TParam2 param2);
    }

    public interface IAsyncResolver<in TParam1, in TParam2, in TParam3, TResult> : IAsyncResolver
    {
        Task<TResult> ResolveAsync(TParam1 param1, TParam2 param2, TParam3 param3);
    }

    public interface IAsyncResolver<in TParam1, in TParam2, in TParam3, in TParam4, TResult> : IAsyncResolver
    {
        Task<TResult> ResolveAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4);
    }

    public interface IAsyncResolver<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, TResult> : IAsyncResolver
    {
        Task<TResult> ResolveAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5);
    }

    public interface IAsyncResolver<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, TResult> : IAsyncResolver
    {
        Task<TResult> ResolveAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6);
    }

    public interface IAsyncResolver<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, TResult> : IAsyncResolver
    {
        Task<TResult> ResolveAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7);
    }

    public interface IAsyncResolver<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, in TParam8, TResult> : IAsyncResolver
    {
        Task<TResult> ResolveAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8);
    }

    public interface IAsyncResolver<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, in TParam8, in TParam9, TResult> : IAsyncResolver
    {
        Task<TResult> ResolveAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8, TParam9 param9);
    }

    public interface IAsyncResolver<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, in TParam8, in TParam9, in TParam10, TResult> : IAsyncResolver
    {
        Task<TResult> ResolveAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8, TParam9 param9, TParam10 param10);
    }
}