using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using EMSYS.TowerDefence.System;
using EMSYS.TowerDefence.UI;
namespace EMSYS.TowerDefence.IO
{
    public partial class StartIO : MonoBehaviour
    {
        private StartSys system;
        private StartUI ui;
        private void Awake()
        {
            system = GameObject.FindObjectOfType<StartSys>();
            ui = GameObject.FindObjectOfType<StartUI>();
        }
        private void Start()
        {
            if (Application.internetReachability == NetworkReachability.NotReachable)
            {

            }
            StartCoroutine(CheckVersion());
        }
        private void Update()
        {

        }
        private void LateUpdate()
        {
            
        }
    }
}