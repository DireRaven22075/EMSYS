using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EMSYS.TowerDefence.Entity.Tower
{
    public class TowerTransform : MonoBehaviour
    {
        #region variable
        private Vector3 oldPos;
        #endregion

        #region method
        /// <summary>
        /// 드랍시 움직일 위치를 저장하는 함수
        /// </summary>
        /// <param name="pos"> 드랍시 움직일 장소 </param>
        public void Change(Vector3 pos) => this.oldPos = pos;
        public void Move(Vector3 pos) => this.transform.position = pos;
        public void Drop()
        {
            this.transform.position = oldPos;
        }
        #endregion

        #region logic

        #endregion
    }
}