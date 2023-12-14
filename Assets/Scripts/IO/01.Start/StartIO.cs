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
        private delegate void Events();
        private StartSys system;
        private StartUI ui;
        Events events;
        private void Awake()
        {
            system = GameObject.FindObjectOfType<StartSys>();
            ui = GameObject.FindObjectOfType<StartUI>();
            events += A;
            events += A;
        }
        private void Start()
        {
            StartCoroutine(CheckVersion());
            events.Invoke();
        }
        private void Update()
        {
        }
        private void LateUpdate()
        {
            
        }
        private void A()
        {
            Debug.Log("Test");
        }
    }
}