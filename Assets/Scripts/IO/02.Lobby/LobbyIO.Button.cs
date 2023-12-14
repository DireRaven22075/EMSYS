using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EMSYS.TowerDefence.System;
using EMSYS.TowerDefence.UI;
namespace EMSYS.TowerDefence.IO
{
    //로비 입력중 버튼과 관련된 함수는 여기에 실체화
    public partial class LobbyIO: MonoBehaviour
    {
        //함수명은 Btn_<설명>
        public void Btn_ShowSetting()
        {
            GameObject.Find("Lobby Setting").SetActive(true);
        }
        public void Btn_GameStart()
        {
            LoadingManager.LoadScene("03.Game");
        }
        public void Btn_SelectStage(int value)
        {
            uiManager.SetCanvasActive(3, true);

        }
        public void Btn_ShowStageList()
        {
            uiManager.SetCanvasActive(1, false);
            uiManager.SetCanvasActive(2, true);
        }
        public void Btn_Back()
        {
            
            //uiManager.PreviouseUI();
        }
    }
}