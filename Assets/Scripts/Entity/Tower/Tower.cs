using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EMSYS.TowerDefence.Entity.Tower
{
    [RequireComponent(typeof(TowerInfo))]
    [RequireComponent(typeof(BoxCollider2D))]
    [RequireComponent(typeof(Animator))]
    public class Tower : MonoBehaviour
    {
        #region variable

        #endregion

        #region method

        #endregion

        #region logic
        private void Awake()
        {
            gameObject.layer = Constants.Int.towerLayer;
        }
        #endregion
    }
}