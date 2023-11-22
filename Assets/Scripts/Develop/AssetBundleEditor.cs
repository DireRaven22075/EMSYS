using System.IO;
using UnityEditor;

namespace EMSYS.TowerDefence.Develop
{
    public class AssetBundleEditor : Editor
    {

        [MenuItem("Tool/Asset Bundle Build")]
        public static void BundleBuild()
        {
            const string path = "./AssetBundle";
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);
            BuildPipeline.BuildAssetBundles(path, BuildAssetBundleOptions.None, BuildTarget.Android);
        }
    }
}