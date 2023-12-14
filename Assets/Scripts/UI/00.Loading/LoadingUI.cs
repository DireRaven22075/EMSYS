using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EMSYS.TowerDefence.IO;
using EMSYS.TowerDefence.System;
namespace EMSYS.TowerDefence.UI
{
    public partial class LoadingUI : MonoBehaviour
    {
        private LoadingSys sys;
        private LoadingIO io;
        private void Awake()
        {
            sys = GameObject.FindObjectOfType<LoadingSys>();
            io = GameObject.FindObjectOfType<LoadingIO>();
        }
        void Start()
        {

        }
        void Update()
        {
            progress.fillAmount = sys.loadingPercent;
        }
    }
}