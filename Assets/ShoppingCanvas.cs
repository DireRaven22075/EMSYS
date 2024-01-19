using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EMSYS.TowerDefence.Manager;
namespace EMSYS.TowerDefence.UI
{
    public class ShoppingCanvas : MonoBehaviour
    {
        #region variable
        private GameManager manager;
        #endregion

        #region method
        
        #endregion

        #region logic
        private void Awake()
        {
            manager = GameObject.FindObjectOfType<GameManager>();
        }
        private void Update()
        {

        }
        #endregion
    }
}