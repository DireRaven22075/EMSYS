using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EMSYS.TowerDefence.IO
{
    public partial class GameInput : MonoBehaviour
    {
        #region variable
        
        #endregion

        #region method
        public void Btn_Accept()
        {
            manager.observer.Invoke("Accept");
        }
        public void Btn_Decline()
        {
            manager.observer.Invoke("Decline");
        }
        #endregion
    }
}
