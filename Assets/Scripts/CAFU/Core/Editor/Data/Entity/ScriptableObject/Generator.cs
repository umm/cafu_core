using System.IO;
using UnityEditor;
// ReSharper disable UseStringInterpolation

namespace CAFU.Core.Data.Entity.ScriptableObject {

    public static class Generator {

        private const string EXTENSION = ".asset";

        public static void Generate<T>() where T : UnityEngine.ScriptableObject {
            string path = ResolvePath<T>();
            AssetDatabase.CreateAsset(UnityEngine.ScriptableObject.CreateInstance<T>(), path);
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
            Selection.activeObject = AssetDatabase.LoadAssetAtPath<T>(path);
        }

        private static string ResolvePath<T>() where T : UnityEngine.ScriptableObject {
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
            string basePath = Path.Combine(directoryName, typeof(T).Name);
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

}