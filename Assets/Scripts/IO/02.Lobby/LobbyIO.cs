using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using EMSYS.TowerDefence.UI;
using EMSYS.TowerDefence.System;
namespace EMSYS.TowerDefence.IO
{
    public partial class LobbyIO: MonoBehaviour
    {
        private LobbyUI uiManager;
        private void Start()
        {
            uiManager = GameObject.FindObjectOfType<LobbyUI>();
        }
    }
}