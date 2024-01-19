using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EMSYS.TowerDefence.Manager;
namespace EMSYS.TowerDefence.Entity.Tower
{
    public class TowerInfo : MonoBehaviour
    {
        #region variable
        /// <summary>
        /// 현재 타워의 상태
        /// </summary>
        public TowerStatus status;

        /// <summary>
        /// 타워의 금액
        /// 판매시 해당 금액만큼 돌려받음
        /// </summary>
        public int coin;

        /// <summary>
        /// 다음 레벨의 타워
        /// 만약 null이 리턴된다면 최종 레벨의 타워로 인식
        /// </summary>
        public GameObject nextTower;
        #endregion
    }

}