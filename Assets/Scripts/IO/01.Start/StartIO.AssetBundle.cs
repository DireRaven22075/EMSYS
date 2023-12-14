using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using EMSYS.TowerDefence.System;
namespace EMSYS.TowerDefence.IO
{
    public partial class StartIO : MonoBehaviour
    {
        
        private IEnumerator CheckVersion()
        {
#if UNITY_EDITOR
            UnityWebRequest request = new UnityWebRequest("http://localhost:80/Asset/version");
#else
            UnityWebRequest request = new UnityWebRequest("https://raven.iptime.org/version");
#endif
            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.Success)
            {

            }
        }
    }
}