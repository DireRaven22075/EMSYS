using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using System.IO;
using System.Collections.Generic;

namespace EMSYS.TowerDefence.Network
{
    public class ResourceManager : MonoBehaviour
    {
        private void Awake()
        {
            if (Application.internetReachability == NetworkReachability.NotReachable)
            {
                //If Network connect is lost

                Debug.Log("Network Connection Error");

            }
            else
            {
#if UNITY_EDITOR
                StartCoroutine(Get("http://localhost/AssetBundle/version"));
#else
                StartCoroutine(Get("http://james101.kro.kr:5555/AssetBundle/version"));
#endif
            }
        }
        private void Update()
        {
            
        }
        IEnumerator Get(string path)
        {
            UnityWebRequest request = UnityWebRequest.Get(path);
            yield return request.SendWebRequest();
            if (request.result == UnityWebRequest.Result.Success)
            {
#if UNITY_EDITOR
                string path1 = Application.dataPath + "/Version/function";
#else
                const string path1 = "";
#endif
                StreamWriter writer = new StreamWriter(path1);
                writer.Write(request.downloadHandler.text);
                writer.Close();
            }
        }
    }
}