#define NETWORK
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
namespace EMSYS.TowerDefence.UI
{
    public partial class StartUI : MonoBehaviour
    {
        private void Awake()
        {
            switch (Application.internetReachability)
            {
                case NetworkReachability.ReachableViaCarrierDataNetwork:
                    //만약 인터넷 연결을 데이터로 진행할 경우

                    break;
                case NetworkReachability.NotReachable:
                    //만약 인터넷 연결이 되어 있지 않을 경우

                    break;
                case NetworkReachability.ReachableViaLocalAreaNetwork:
                    //만약 인터넷 연결을 Wi-Fi로 진행할 경우

                    break;
            }
        }
        private void Update()
        {
            Debug.Log(SystemInfo.batteryLevel);
        }
    }
}