using System.IO;
using System.Text.RegularExpressions;
using CAFU.Core.Utility;
using UnityEngine;

// ReSharper disable UnusedMember.Global

namespace CAFU.Core.Data.DataStore {

    public interface IDataStore {

    }

    public interface IScriptableObjectDataStore : IDataStore {

    }

    public interface IScriptableObjectDataStoreInScene : IScriptableObjectDataStore {

    }

    public interface IScriptableObjectDataStoreInResources : IScriptableObjectDataStore {

    }

    public interface IScriptableObjectDataStoreInStreamingAssets : IScriptableObjectDataStore {

    }

    public interface IDataStoreFactory<out TDataStore> : IFactory<TDataStore> where TDataStore : IDataStore {

    }

    public class DefaultDataStoreFactory<TDataStore> : DefaultDataStoreFactory<DefaultDataStoreFactory<TDataStore>, TDataStore>
        where TDataStore : IDataStore, new() {

    }

    public class DefaultDataStoreFactory<TFactory, TDataStore> : DefaultFactory<TFactory, TDataStore>, IDataStoreFactory<TDataStore>
        where TFactory : DefaultFactory<TFactory, TDataStore>, new()
        where TDataStore : IDataStore, new() {

    }

    public class SceneDataStoreFactory<TFactory, TDataStore> : SingletonFactory<TFactory>, IDataStoreFactory<TDataStore>
        where TFactory : SceneDataStoreFactory<TFactory, TDataStore>, IFactory<TDataStore>, new()
        where TDataStore : Object, IDataStore {

        public TDataStore Create() {
            return Object.FindObjectOfType<TDataStore>();
        }

    }

    public static class ScriptableObjectDataStoreExtension {

        private const string BASE_DIRECTORY_NAME = "Entities";

        private const string EXTENSION = ".asset";

        private static string CreatePath<T>() where T : ScriptableObject {
            return Path.Combine(BASE_DIRECTORY_NAME, string.Format("{0}{1}", typeof(T).Name, EXTENSION));
        }

        public static string CreatePathInRuntime<T>(this IScriptableObjectDataStoreInResources self) where T : ScriptableObject {
            return Regex.Replace(CreatePath<T>(), string.Format("{0}$", EXTENSION), string.Empty);
        }

        public static string CreatePathInRuntime<T>(this IScriptableObjectDataStoreInStreamingAssets self) where T : ScriptableObject {
            return Path.Combine(Application.streamingAssetsPath, CreatePath<T>());
        }

    }

}