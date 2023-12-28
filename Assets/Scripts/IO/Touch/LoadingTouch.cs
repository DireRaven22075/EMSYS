using UnityEngine;
using EMSYS.TowerDefence.Manager;
using TMPro;
namespace EMSYS.TowerDefence.IO
{
    public class LoadingTouch : MonoBehaviour
    {
        #region variable
        private LoadingManager manager;
        #endregion

        #region method

        #endregion

        #region logic
        private void Awake()
        {
            manager = GameObject.FindObjectOfType<LoadingManager>();
        }
        private void Update()
        {
            for (int i = 0; i < Input.touchCount; i++)
            {
                if (Input.GetTouch(i).phase == TouchPhase.Began)
                {
                    manager.NextTip();
                }
            }
        }
        #endregion
    }
}