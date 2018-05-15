using System.IO;
using System.Text.RegularExpressions;
using CAFU.Core.Utility;
using JetBrains.Annotations;
using UnityEngine;

namespace CAFU.Core.Data.DataStore
{
    [PublicAPI]
    public interface IDataStore
    {
    }

    [PublicAPI]
    public interface ISingletonDataStore : IDataStore, ISingleton
    {
    }

    [PublicAPI]
    public interface IScriptableObjectDataStore : IDataStore
    {
    }

    [PublicAPI]
    public interface IScriptableObjectDataStoreInScene : IScriptableObjectDataStore
    {
    }

    [PublicAPI]
    public interface IScriptableObjectDataStoreInResources : IScriptableObjectDataStore
    {
    }

    [PublicAPI]
    public interface IScriptableObjectDataStoreInStreamingAssets : IScriptableObjectDataStore
    {
    }

    [PublicAPI]
    public interface IDataStoreFactory<out TDataStore> : IFactory<TDataStore> where TDataStore : IDataStore
    {
    }

    [PublicAPI]
    public class DefaultDataStoreFactory<TDataStore> : DefaultFactory<TDataStore>, IDataStoreFactory<TDataStore>
        where TDataStore : IDataStore, new()
    {
    }

    [PublicAPI]
    public class SceneDataStoreFactory<TDataStore> : SceneFactory<TDataStore>, IDataStoreFactory<TDataStore>
        where TDataStore : Object, IDataStore
    {
    }

    [PublicAPI]
    public static class ScriptableObjectDataStoreExtension
    {
        private const string BaseDirectoryName = "Entities";

        private const string Extension = ".asset";

        private static string CreatePath<T>() where T : ScriptableObject
        {
            return Path.Combine(BaseDirectoryName, $"{typeof(T).Name}{Extension}");
        }

        public static string CreatePathInRuntime<T>(this IScriptableObjectDataStoreInResources self) where T : ScriptableObject
        {
            return Regex.Replace(CreatePath<T>(), $"{Extension}$", string.Empty);
        }

        public static string CreatePathInRuntime<T>(this IScriptableObjectDataStoreInStreamingAssets self) where T : ScriptableObject
        {
            return Path.Combine(Application.streamingAssetsPath, CreatePath<T>());
        }
    }
}