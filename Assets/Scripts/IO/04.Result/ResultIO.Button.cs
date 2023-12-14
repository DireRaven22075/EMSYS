using UnityEngine;
using EMSYS.TowerDefence.System;
namespace EMSYS.TowerDefence.IO
{
    public partial class ResultIO : MonoBehaviour
    {
        public void Btn_Replay()
        {
            LoadingManager.LoadScene("03.Game");
        }
        public void Btn_GotoLobby()
        {
            LoadingManager.LoadScene("02.Lobby");
        }
    }
}