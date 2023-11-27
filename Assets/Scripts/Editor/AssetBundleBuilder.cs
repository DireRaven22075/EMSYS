using System.IO;
using UnityEditor;
public class AssetBundleBuilder : Editor
{
    [MenuItem("Tool/Build Asset Bundle")]
    public static void Build()
    {
        const string path = "./Assets/Bundle";
        if (!Directory.Exists(path))
        {
            Directory.CreateDirectory(path);
        }
        BuildPipeline.BuildAssetBundles(path, BuildAssetBundleOptions.None, BuildTarget.Android);
    }
}
