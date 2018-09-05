using System;
using System.Threading.Tasks;
// ReSharper disable UnusedMember.Global

namespace CAFU.Core
{
    public interface ITranslator
    {
    }

    public interface IObservableTranslator : ITranslator
    {
    }

    public interface IAsyncTranslator : ITranslator
    {
    }

    public interface IEntityTranslator : ITranslator
    {
    }

    public interface IStructureTranslator : ITranslator
    {
    }

    public interface IObservableEntityTranslator : IEntityTranslator, IObservableTranslator
    {
    }

    public interface IObservableStructureTranslator : IStructureTranslator, IObservableTranslator
    {
    }

    public interface IAsyncEntityTranslator : IEntityTranslator, IAsyncTranslator
    {
    }

    public interface IAsyncStructureTranslator : IStructureTranslator, IAsyncTranslator
    {
    }

    public interface IEntityTranslator<out TEntity> : IEntityTranslator
        where TEntity : IEntity
    {
        TEntity Translate();
    }

    public interface IEntityTranslator<in TParam1, out TEntity> : IEntityTranslator
        where TEntity : IEntity
    {
        TEntity Translate(TParam1 param1);
    }

    public interface IEntityTranslator<in TParam1, in TParam2, out TEntity> : IEntityTranslator
        where TEntity : IEntity
    {
        TEntity Translate(TParam1 param1, TParam2 param2);
    }

    public interface IEntityTranslator<in TParam1, in TParam2, in TParam3, out TEntity> : IEntityTranslator
        where TEntity : IEntity
    {
        TEntity Translate(TParam1 param1, TParam2 param2, TParam3 param3);
    }

    public interface IEntityTranslator<in TParam1, in TParam2, in TParam3, in TParam4, out TEntity> : IEntityTranslator
        where TEntity : IEntity
    {
        TEntity Translate(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4);
    }

    public interface IEntityTranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, out TEntity> : IEntityTranslator
        where TEntity : IEntity
    {
        TEntity Translate(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5);
    }

    public interface IEntityTranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, out TEntity> : IEntityTranslator
        where TEntity : IEntity
    {
        TEntity Translate(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6);
    }

    public interface IEntityTranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, out TEntity> : IEntityTranslator
        where TEntity : IEntity
    {
        TEntity Translate(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7);
    }

    public interface IEntityTranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, in TParam8, out TEntity> : IEntityTranslator
        where TEntity : IEntity
    {
        TEntity Translate(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8);
    }

    public interface IEntityTranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, in TParam8, in TParam9, out TEntity> : IEntityTranslator
        where TEntity : IEntity
    {
        TEntity Translate(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8, TParam9 param9);
    }

    public interface IEntityTranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, in TParam8, in TParam9, in TParam10, out TEntity> : IEntityTranslator
        where TEntity : IEntity
    {
        TEntity Translate(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8, TParam9 param9, TParam10 param10);
    }

    public interface IObservableEntityTranslator<out TEntity> : IObservableEntityTranslator
        where TEntity : IEntity
    {
        IObservable<TEntity> TranslateAsObservable();
    }

    public interface IObservableEntityTranslator<in TParam1, out TEntity> : IObservableEntityTranslator
        where TEntity : IEntity
    {
        IObservable<TEntity> TranslateAsObservable(TParam1 param1);
    }

    public interface IObservableEntityTranslator<in TParam1, in TParam2, out TEntity> : IObservableEntityTranslator
        where TEntity : IEntity
    {
        IObservable<TEntity> TranslateAsObservable(TParam1 param1, TParam2 param2);
    }

    public interface IObservableEntityTranslator<in TParam1, in TParam2, in TParam3, out TEntity> : IObservableEntityTranslator
        where TEntity : IEntity
    {
        IObservable<TEntity> TranslateAsObservable(TParam1 param1, TParam2 param2, TParam3 param3);
    }

    public interface IObservableEntityTranslator<in TParam1, in TParam2, in TParam3, in TParam4, out TEntity> : IObservableEntityTranslator
        where TEntity : IEntity
    {
        IObservable<TEntity> TranslateAsObservable(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4);
    }

    public interface IObservableEntityTranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, out TEntity> : IObservableEntityTranslator
        where TEntity : IEntity
    {
        IObservable<TEntity> TranslateAsObservable(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5);
    }

    public interface IObservableEntityTranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, out TEntity> : IObservableEntityTranslator
        where TEntity : IEntity
    {
        IObservable<TEntity> TranslateAsObservable(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6);
    }

    public interface IObservableEntityTranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, out TEntity> : IObservableEntityTranslator
        where TEntity : IEntity
    {
        IObservable<TEntity> TranslateAsObservable(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7);
    }

    public interface IObservableEntityTranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, in TParam8, out TEntity> : IObservableEntityTranslator
        where TEntity : IEntity
    {
        IObservable<TEntity> TranslateAsObservable(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8);
    }

    public interface IObservableEntityTranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, in TParam8, in TParam9, out TEntity> : IObservableEntityTranslator
        where TEntity : IEntity
    {
        IObservable<TEntity> TranslateAsObservable(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8, TParam9 param9);
    }

    public interface IObservableEntityTranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, in TParam8, in TParam9, in TParam10, out TEntity> : IObservableEntityTranslator
        where TEntity : IEntity
    {
        IObservable<TEntity> TranslateAsObservable(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8, TParam9 param9, TParam10 param10);
    }

    public interface IAsyncEntityTranslator<TEntity> : IAsyncEntityTranslator
        where TEntity : IEntity
    {
        Task<TEntity> TranslateAsync();
    }

    public interface IAsyncEntityTranslator<in TParam1, TEntity> : IAsyncEntityTranslator
        where TEntity : IEntity
    {
        Task<TEntity> TranslateAsync(TParam1 param1);
    }

    public interface IAsyncEntityTranslator<in TParam1, in TParam2, TEntity> : IAsyncEntityTranslator
        where TEntity : IEntity
    {
        Task<TEntity> TranslateAsync(TParam1 param1, TParam2 param2);
    }

    public interface IAsyncEntityTranslator<in TParam1, in TParam2, in TParam3, TEntity> : IAsyncEntityTranslator
        where TEntity : IEntity
    {
        Task<TEntity> TranslateAsync(TParam1 param1, TParam2 param2, TParam3 param3);
    }

    public interface IAsyncEntityTranslator<in TParam1, in TParam2, in TParam3, in TParam4, TEntity> : IAsyncEntityTranslator
        where TEntity : IEntity
    {
        Task<TEntity> TranslateAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4);
    }

    public interface IAsyncEntityTranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, TEntity> : IAsyncEntityTranslator
        where TEntity : IEntity
    {
        Task<TEntity> TranslateAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5);
    }

    public interface IAsyncEntityTranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, TEntity> : IAsyncEntityTranslator
        where TEntity : IEntity
    {
        Task<TEntity> TranslateAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6);
    }

    public interface IAsyncEntityTranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, TEntity> : IAsyncEntityTranslator
        where TEntity : IEntity
    {
        Task<TEntity> TranslateAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7);
    }

    public interface IAsyncEntityTranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, in TParam8, TEntity> : IAsyncEntityTranslator
        where TEntity : IEntity
    {
        Task<TEntity> TranslateAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8);
    }

    public interface IAsyncEntityTranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, in TParam8, in TParam9, TEntity> : IAsyncEntityTranslator
        where TEntity : IEntity
    {
        Task<TEntity> TranslateAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8, TParam9 param9);
    }

    public interface IAsyncEntityTranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, in TParam8, in TParam9, in TParam10, TEntity> : IAsyncEntityTranslator
        where TEntity : IEntity
    {
        Task<TEntity> TranslateAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8, TParam9 param9, TParam10 param10);
    }

    public interface IStructureTranslator<out TStructure> : IStructureTranslator
        where TStructure : IStructure
    {
        TStructure Translate();
    }

    public interface IStructureTranslator<in TParam1, out TStructure> : IStructureTranslator
        where TStructure : IStructure
    {
        TStructure Translate(TParam1 param1);
    }

    public interface IStructureTranslator<in TParam1, in TParam2, out TStructure> : IStructureTranslator
        where TStructure : IStructure
    {
        TStructure Translate(TParam1 param1, TParam2 param2);
    }

    public interface IStructureTranslator<in TParam1, in TParam2, in TParam3, out TStructure> : IStructureTranslator
        where TStructure : IStructure
    {
        TStructure Translate(TParam1 param1, TParam2 param2, TParam3 param3);
    }

    public interface IStructureTranslator<in TParam1, in TParam2, in TParam3, in TParam4, out TStructure> : IStructureTranslator
        where TStructure : IStructure
    {
        TStructure Translate(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4);
    }

    public interface IStructureTranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, out TStructure> : IStructureTranslator
        where TStructure : IStructure
    {
        TStructure Translate(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5);
    }

    public interface IStructureTranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, out TStructure> : IStructureTranslator
        where TStructure : IStructure
    {
        TStructure Translate(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6);
    }

    public interface IStructureTranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, out TStructure> : IStructureTranslator
        where TStructure : IStructure
    {
        TStructure Translate(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7);
    }

    public interface IStructureTranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, in TParam8, out TStructure> : IStructureTranslator
        where TStructure : IStructure
    {
        TStructure Translate(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8);
    }

    public interface IStructureTranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, in TParam8, in TParam9, out TStructure> : IStructureTranslator
        where TStructure : IStructure
    {
        TStructure Translate(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8, TParam9 param9);
    }

    public interface IStructureTranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, in TParam8, in TParam9, in TParam10, out TStructure> : IStructureTranslator
        where TStructure : IStructure
    {
        TStructure Translate(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8, TParam9 param9, TParam10 param10);
    }

    public interface IObservableStructureTranslator<out TStructure> : IObservableStructureTranslator
        where TStructure : IStructure
    {
        IObservable<TStructure> TranslateAsObservable();
    }

    public interface IObservableStructureTranslator<in TParam1, out TStructure> : IObservableStructureTranslator
        where TStructure : IStructure
    {
        IObservable<TStructure> TranslateAsObservable(TParam1 param1);
    }

    public interface IObservableStructureTranslator<in TParam1, in TParam2, out TStructure> : IObservableStructureTranslator
        where TStructure : IStructure
    {
        IObservable<TStructure> TranslateAsObservable(TParam1 param1, TParam2 param2);
    }

    public interface IObservableStructureTranslator<in TParam1, in TParam2, in TParam3, out TStructure> : IObservableStructureTranslator
        where TStructure : IStructure
    {
        IObservable<TStructure> TranslateAsObservable(TParam1 param1, TParam2 param2, TParam3 param3);
    }

    public interface IObservableStructureTranslator<in TParam1, in TParam2, in TParam3, in TParam4, out TStructure> : IObservableStructureTranslator
        where TStructure : IStructure
    {
        IObservable<TStructure> TranslateAsObservable(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4);
    }

    public interface IObservableStructureTranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, out TStructure> : IObservableStructureTranslator
        where TStructure : IStructure
    {
        IObservable<TStructure> TranslateAsObservable(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5);
    }

    public interface IObservableStructureTranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, out TStructure> : IObservableStructureTranslator
        where TStructure : IStructure
    {
        IObservable<TStructure> TranslateAsObservable(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6);
    }

    public interface IObservableStructureTranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, out TStructure> : IObservableStructureTranslator
        where TStructure : IStructure
    {
        IObservable<TStructure> TranslateAsObservable(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7);
    }

    public interface IObservableStructureTranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, in TParam8, out TStructure> : IObservableStructureTranslator
        where TStructure : IStructure
    {
        IObservable<TStructure> TranslateAsObservable(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8);
    }

    public interface IObservableStructureTranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, in TParam8, in TParam9, out TStructure> : IObservableStructureTranslator
        where TStructure : IStructure
    {
        IObservable<TStructure> TranslateAsObservable(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8, TParam9 param9);
    }

    public interface IObservableStructureTranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, in TParam8, in TParam9, in TParam10, out TStructure> : IObservableStructureTranslator
        where TStructure : IStructure
    {
        IObservable<TStructure> TranslateAsObservable(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8, TParam9 param9, TParam10 param10);
    }

    public interface IAsyncStructureTranslator<TStructure> : IAsyncStructureTranslator
        where TStructure : IStructure
    {
        Task<TStructure> TranslateAsync();
    }

    public interface IAsyncStructureTranslator<in TParam1, TStructure> : IAsyncStructureTranslator
        where TStructure : IStructure
    {
        Task<TStructure> TranslateAsync(TParam1 param1);
    }

    public interface IAsyncStructureTranslator<in TParam1, in TParam2, TStructure> : IAsyncStructureTranslator
        where TStructure : IStructure
    {
        Task<TStructure> TranslateAsync(TParam1 param1, TParam2 param2);
    }

    public interface IAsyncStructureTranslator<in TParam1, in TParam2, in TParam3, TStructure> : IAsyncStructureTranslator
        where TStructure : IStructure
    {
        Task<TStructure> TranslateAsync(TParam1 param1, TParam2 param2, TParam3 param3);
    }

    public interface IAsyncStructureTranslator<in TParam1, in TParam2, in TParam3, in TParam4, TStructure> : IAsyncStructureTranslator
        where TStructure : IStructure
    {
        Task<TStructure> TranslateAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4);
    }

    public interface IAsyncStructureTranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, TStructure> : IAsyncStructureTranslator
        where TStructure : IStructure
    {
        Task<TStructure> TranslateAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5);
    }

    public interface IAsyncStructureTranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, TStructure> : IAsyncStructureTranslator
        where TStructure : IStructure
    {
        Task<TStructure> TranslateAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6);
    }

    public interface IAsyncStructureTranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, TStructure> : IAsyncStructureTranslator
        where TStructure : IStructure
    {
        Task<TStructure> TranslateAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7);
    }

    public interface IAsyncStructureTranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, in TParam8, TStructure> : IAsyncStructureTranslator
        where TStructure : IStructure
    {
        Task<TStructure> TranslateAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8);
    }

    public interface IAsyncStructureTranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, in TParam8, in TParam9, TStructure> : IAsyncStructureTranslator
        where TStructure : IStructure
    {
        Task<TStructure> TranslateAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8, TParam9 param9);
    }

    public interface IAsyncStructureTranslator<in TParam1, in TParam2, in TParam3, in TParam4, in TParam5, in TParam6, in TParam7, in TParam8, in TParam9, in TParam10, TStructure> : IAsyncStructureTranslator
        where TStructure : IStructure
    {
        Task<TStructure> TranslateAsync(TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4, TParam5 param5, TParam6 param6, TParam7 param7, TParam8 param8, TParam9 param9, TParam10 param10);
    }
}