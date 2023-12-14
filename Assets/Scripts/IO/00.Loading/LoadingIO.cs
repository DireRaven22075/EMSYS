using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EMSYS.TowerDefence.UI;
using EMSYS.TowerDefence.System;
namespace EMSYS.TowerDefence.IO
{
    public partial class LoadingIO : MonoBehaviour
    {
        public delegate void Loop(string a);
        public static Loop events;
        void Start()
        {

        }
        void Update()
        {
            events.Invoke("");
        }
    }
}