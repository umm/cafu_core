using System.IO;
using System.Text.RegularExpressions;
using UnityEngine;

namespace CAFU.Core.Data {

    public interface IDataStore {
    }

    public interface IScriptableObjectDataStore : IDataStore {

        string Path { get; }

    }

    public interface IScriptableObjectInResourcesDataStore : IScriptableObjectDataStore {
    }

    public interface IScriptableObjectInStreamingAssetsDataStore : IScriptableObjectDataStore {
    }

    public static class ScriptableObjectDataStoreExtension {

        private const string EXTENSION = ".asset";

        public static string CreatePathInRuntime(this IScriptableObjectInResourcesDataStore self) {
            return Regex.Replace(self.CreatePath(), string.Format("{0}$", EXTENSION), string.Empty);
        }

        public static string CreatePathInRuntime(this IScriptableObjectInStreamingAssetsDataStore self) {
            return Path.Combine(UnityEngine.Application.streamingAssetsPath, self.CreatePath());
        }

        private static string CreatePath(this IScriptableObjectDataStore self) {
            if (Regex.IsMatch(self.Path, string.Format("{0}$", EXTENSION))) {
                return self.Path;
            }
            return string.Format("{0}{1}", self.Path, EXTENSION);
        }

#if UNITY_EDITOR
        public static void CreateScriptableObjectAsset<T>(this IScriptableObjectInResourcesDataStore self) where T : ScriptableObject {
            CreateScriptableObjectAsset<T>(Path.Combine(Path.Combine(UnityEngine.Application.dataPath, "Resources"), self.CreatePath()));
        }

        public static void CreateScriptableObjectAsset<T>(this IScriptableObjectInStreamingAssetsDataStore self) where T : ScriptableObject {
            CreateScriptableObjectAsset<T>(Path.Combine(Path.Combine(UnityEngine.Application.dataPath, "StreamingAssets"), self.CreatePath()));
        }

        private static void CreateScriptableObjectAsset<T>(string fullPath) where T : ScriptableObject {
            if (File.Exists(fullPath)) {
                Debug.LogWarningFormat("ScriptableObject for type of '{0}' is already exists in '{1}'.", typeof(T).FullName, fullPath);
                return;
            }
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
                        Path.GetDirectoryName(UnityEngine.Application.dataPath)
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
