using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EMSYS.TowerDefence.Manager;
namespace EMSYS.TowerDefence.UI
{
    public class PauseCanvas : MonoBehaviour
    {
        #region variable
        private Canvas canvas;
        #endregion

        #region method
        private void AA(string msg)
        {
            if (msg.Equals("Pause"))
            {
                canvas.enabled = true;
            }
            else if (msg.Equals("Unpause"))
            {
                canvas.enabled = false;
            }
        }
        #endregion

        #region logic
        private void Awake()
        {
            Debug.Log("Access");
            canvas = GetComponent<Canvas>();
            GameObject.FindObjectOfType<GameManager>().observer += AA;
        }
        
        #endregion

    }
}
