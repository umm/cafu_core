using System.IO;
using System.Text.RegularExpressions;
using UnityEditor;
using UnityEngine;

namespace CAFU.Core.Data.DataStore {

    public static class ScriptableObjectDataStoreGenerator {

        private const string BASE_DIRECTORY_NAME = "Entities";

        private const string EXTENSION = ".asset";

        public static void CreateScriptableObjectAssetInScene<T>() where T : ScriptableObject {
            CreateScriptableObjectAsset<T>(Path.Combine(Application.dataPath, CreatePath<T>()));
        }

        public static void CreateScriptableObjectAssetInResources<T>() where T : ScriptableObject {
            CreateScriptableObjectAsset<T>(Path.Combine(Path.Combine(Application.dataPath, "Resources"), CreatePath<T>()));
        }

        public static void CreateScriptableObjectAssetInStreamingAssets<T>() where T : ScriptableObject {
            CreateScriptableObjectAsset<T>(Path.Combine(Path.Combine(Application.dataPath, "StreamingAssets"), CreatePath<T>()));
        }

        private static string CreatePath<T>() where T : ScriptableObject {
            return Path.Combine(BASE_DIRECTORY_NAME, string.Format("{0}{1}", typeof(T).Name, EXTENSION));
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
            AssetDatabase.CreateAsset(
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
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
        }

    }

}
