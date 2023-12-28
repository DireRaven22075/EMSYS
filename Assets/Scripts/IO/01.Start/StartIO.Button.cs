using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
namespace EMSYS.TowerDefence.IO
{
    public partial class StartIO : MonoBehaviour
    {
        /// <summary>
        /// 시작 씬에서 로비씬으로 넘어가기 위한 버튼용 함수입니다
        /// </summary>
        public void Btn_Start()
        {
            SceneManager.LoadScene("02.Lobby", LoadSceneMode.Single);
            Debug.Log("Move To Lobby Scene");
        }
        /// <summary>
        /// 인터넷 연결을 감지하지 못하였을 경우 게임 종료 버튼용 함수입니다
        /// </summary>
        public void Btn_Quit()
        {
            Application.Quit();
        }
        /// <summary>
        /// 인터넷 연결을 감지하지 못하였을 경우 인터넷에 연결 재시도 버튼용 함수
        /// </summary>
        public void Btn_Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}