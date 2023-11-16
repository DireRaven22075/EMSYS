using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
namespace EMSYS.TowerDefence.UI
{
    public class InitUI : MonoBehaviour
    {
        private GameObject obj;
        private bool isReady = false;

        private void Start()
        {
            obj = transform.GetChild(0).gameObject;
        }
        void Update()
        {
            if (isReady)
            {
                obj.SetActive(true);
            }
        }
    }

}
