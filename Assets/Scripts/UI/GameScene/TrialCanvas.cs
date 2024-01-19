using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EMSYS.TowerDefence.Manager;
namespace EMSYS.TowerDefence.UI
{
    public class TrialCanvas : MonoBehaviour
    {
        #region variable
        private Canvas component;
        #endregion

        #region method
        private void Alert(string msg)
        {
            if (msg.Equals("Accept") || msg.Equals("Decline"))
            {
                component.enabled = false;
            }
            else if (msg.Equals("Trial"))
            {
                component.enabled = true;
            }
        }
        #endregion

        void Start()
        {
            component = GetComponent<Canvas>();
            GameObject.FindObjectOfType<GameManager>().observer += Alert;
        }
    }
}