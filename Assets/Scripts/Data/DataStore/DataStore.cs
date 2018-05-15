using System;
using System.IO;
using System.Text.RegularExpressions;
using CAFU.Core.Utility;
using UnityEngine;
using Object = UnityEngine.Object;

// ReSharper disable UnusedMember.Global

namespace CAFU.Core.Data.DataStore
{
    public interface IDataStore
    {
    }

    public interface ISingletonDataStore : IDataStore, ISingleton
    {
    }

    public interface IScriptableObjectDataStore : IDataStore
    {
    }

    public interface IScriptableObjectDataStoreInScene : IScriptableObjectDataStore
    {
    }

    public interface IScriptableObjectDataStoreInResources : IScriptableObjectDataStore
    {
    }

    public interface IScriptableObjectDataStoreInStreamingAssets : IScriptableObjectDataStore
    {
    }

    public interface IDataStoreFactory<out TDataStore> : IFactory<TDataStore> where TDataStore : IDataStore
    {
    }

    public class DefaultDataStoreFactory<TDataStore> : DefaultFactory<TDataStore>, IDataStoreFactory<TDataStore>
        where TDataStore : IDataStore, new()
    {
    }

    public class SceneDataStoreFactory<TDataStore> : SceneFactory<TDataStore>, IDataStoreFactory<TDataStore>
        where TDataStore : Object, IDataStore
    {
    }

    public static class ScriptableObjectDataStoreExtension
    {
        private const string BaseDirectoryName = "Entities";

        private const string Extension = ".asset";

        private static string CreatePath<T>() where T : ScriptableObject
        {
            return Path.Combine(BaseDirectoryName, string.Format("{0}{1}", typeof(T).Name, Extension));
        }

        public static string CreatePathInRuntime<T>(this IScriptableObjectDataStoreInResources self) where T : ScriptableObject
        {
            return Regex.Replace(CreatePath<T>(), string.Format("{0}$", Extension), string.Empty);
        }

        public static string CreatePathInRuntime<T>(this IScriptableObjectDataStoreInStreamingAssets self) where T : ScriptableObject
        {
            return Path.Combine(Application.streamingAssetsPath, CreatePath<T>());
        }
    }
}