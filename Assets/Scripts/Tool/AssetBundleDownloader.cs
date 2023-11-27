using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
namespace EMSYS.TowerDefence.IO
{
    public class AssetBundleDownloader : MonoBehaviour
    {
        void Start()
        {
            StartCoroutine(Download());
        }
        IEnumerator Download()
        {
#if UNITY_EDITOR
            const string path = "http://localhost/test";
#else
            const string path = "http://<IP>";
#endif
            UnityWebRequest www = UnityWebRequestAssetBundle.GetAssetBundle(path);
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(www.error);
            }
            else
            {
                AssetBundle bundle = DownloadHandlerAssetBundle.GetContent(www);
            }
        }
    }
}