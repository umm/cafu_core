using System;
using System.IO;
using System.Text.RegularExpressions;
using UnityEngine;

namespace CAFU.Core.Data {

    [Obsolete("Please use CAFU.Core.Data.DataStore.IDataStore instead of this.")]
    public interface IDataStore {
    }

    // ReSharper disable once UnusedTypeParameter
    [Obsolete("Please use CAFU.Core.Data.DataStore.IDataStore instead of this.")]
    public interface IScriptableObjectDataStoreHandler<T> where T : ScriptableObject {

        string Path { get; }

    }

    [Obsolete("Please use CAFU.Core.Data.DataStore.IDataStore instead of this.")]
    public interface IScriptableObjectDataStoreHandlerInScene<T> : IScriptableObjectDataStoreHandler<T> where T : ScriptableObject {
    }

    [Obsolete("Please use CAFU.Core.Data.DataStore.IDataStore instead of this.")]
    public interface IScriptableObjectDataStoreHandlerInResources<T> : IScriptableObjectDataStoreHandler<T> where T : ScriptableObject {
    }

    [Obsolete("Please use CAFU.Core.Data.DataStore.IDataStore instead of this.")]
    public interface IScriptableObjectDataStoreHandlerInStreamingAssets<T> : IScriptableObjectDataStoreHandler<T> where T : ScriptableObject {
    }

    public static class ScriptableObjectDataStoreHandlerExtension {

        private const string EXTENSION = ".asset";

        [Obsolete("Please use CAFU.Core.Data.Entity.ScriptableObject.Generator instead of this.")]
        public static string CreatePathInRuntime<T>(this IScriptableObjectDataStoreHandlerInResources<T> self) where T : ScriptableObject {
            return Regex.Replace(self.CreatePath(), string.Format("{0}$", EXTENSION), string.Empty);
        }

        [Obsolete("Please use CAFU.Core.Data.Entity.ScriptableObject.Generator instead of this.")]
        public static string CreatePathInRuntime<T>(this IScriptableObjectDataStoreHandlerInStreamingAssets<T> self) where T : ScriptableObject {
            return Path.Combine(Application.streamingAssetsPath, self.CreatePath());
        }

        [Obsolete("Please use CAFU.Core.Data.Entity.ScriptableObject.Generator instead of this.")]
        private static string CreatePath<T>(this IScriptableObjectDataStoreHandler<T> self) where T : ScriptableObject {
            if (Regex.IsMatch(self.Path, string.Format("{0}$", EXTENSION))) {
                return self.Path;
            }
            return string.Format("{0}{1}", self.Path, EXTENSION);
        }

#if UNITY_EDITOR
        [Obsolete("Please use CAFU.Core.Data.Entity.ScriptableObject.Generator instead of this.")]
        public static void CreateScriptableObjectAsset<T>(this IScriptableObjectDataStoreHandlerInScene<T> self) where T : ScriptableObject {
            CreateScriptableObjectAsset<T>(Path.Combine(Application.dataPath, self.CreatePath()));
        }

        [Obsolete("Please use CAFU.Core.Data.Entity.ScriptableObject.Generator instead of this.")]
        public static void CreateScriptableObjectAsset<T>(this IScriptableObjectDataStoreHandlerInResources<T> self) where T : ScriptableObject {
            CreateScriptableObjectAsset<T>(Path.Combine(Path.Combine(Application.dataPath, "Resources"), self.CreatePath()));
        }

        [Obsolete("Please use CAFU.Core.Data.Entity.ScriptableObject.Generator instead of this.")]
        public static void CreateScriptableObjectAsset<T>(this IScriptableObjectDataStoreHandlerInStreamingAssets<T> self) where T : ScriptableObject {
            CreateScriptableObjectAsset<T>(Path.Combine(Path.Combine(Application.dataPath, "StreamingAssets"), self.CreatePath()));
        }

        [Obsolete("Please use CAFU.Core.Data.Entity.ScriptableObject.Generator instead of this.")]
        private static void CreateScriptableObjectAsset<T>(string fullPath) where T : ScriptableObject {
            if (File.Exists(fullPath)) {
                Debug.LogWarningFormat("ScriptableObject for type of '{0}' is already exists in '{1}'.", typeof(T).FullName, fullPath);
                return;
            }
            // ReSharper disable once AssignNullToNotNullAttribute
            if (!Directory.Exists(Path.GetDirectoryName(fullPath))) {
                // ReSharper disable once AssignNullToNotNullAttribute
                Directory.CreateDirectory(Path.GetDirectoryName(fullPath));
            }
            T entity = ScriptableObject.CreateInstance<T>();
            UnityEditor.AssetDatabase.CreateAsset(
                entity,
                Regex.Replace(
                    fullPath,
                    string.Format(
                        "^{0}/",
                        Path.GetDirectoryName(Application.dataPath)
                    ),
                    string.Empty
                )
            );
            UnityEditor.AssetDatabase.SaveAssets();
            UnityEditor.AssetDatabase.Refresh();
        }
#endif

    }

}