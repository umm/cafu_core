using System;
using System.IO;
using UnityEditor;
// ReSharper disable UseStringInterpolation

namespace CAFU.Core.Data.Entity {

    public static class Generator {

        private const string EXTENSION = ".asset";

        public static void Generate<T>() where T : UnityEngine.ScriptableObject {
            Generate(typeof(T));
        }

        public static void Generate(Type type) {
            string path = ResolvePath(type);
            AssetDatabase.CreateAsset(UnityEngine.ScriptableObject.CreateInstance(type), path);
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
            Selection.activeObject = AssetDatabase.LoadAssetAtPath<UnityEngine.ScriptableObject>(path);
        }

        private static string ResolvePath(Type type) {
            string directoryName = "Assets";
            if (Selection.objects.Length != 0) {
                string path = AssetDatabase.GetAssetPath(Selection.objects[0]);
                if (AssetDatabase.IsValidFolder(path)) {
                    // ディレクトリの場合は、それをそのまま採用
                    directoryName = path;
                } else if (!string.IsNullOrEmpty(path)) {
                    // 空文字ではない場合は、ディレクトリ以外を選択していると見なす
                    // Hierarchy 上の GameObject などを選択している場合、空文字が返される
                    directoryName = Path.GetDirectoryName(path);
                }
            }
            // ReSharper disable once AssignNullToNotNullAttribute
            string basePath = Path.Combine(directoryName, type.Name);
            // ファイルが存在しないなら確定
            if (AssetDatabase.LoadAssetAtPath<UnityEngine.ScriptableObject>(string.Format("{0}{1}", basePath, EXTENSION)) == null) {
                return string.Format("{0}{1}", basePath, EXTENSION);
            }
            // ファイルが存在する場合はサフィックスとして数字を付ける
            int index = 0;
            while (AssetDatabase.LoadAssetAtPath<UnityEngine.ScriptableObject>(string.Format("{0} {1}{2}", basePath, ++index, EXTENSION)) != null) {
            }
            return string.Format("{0} {1}{2}", basePath, index, EXTENSION);
        }

    }

    namespace ScriptableObject {

        [Obsolete("Please use 'CAFU.Core.Data.Entity.Generator' instead of this class.")]
        public static class Generator {

            public static void Generate<T>() where T : UnityEngine.ScriptableObject {
                Entity.Generator.Generate<T>();
            }

        }

    }

}