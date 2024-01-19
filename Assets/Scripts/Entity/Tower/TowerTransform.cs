using System.Collections;
using System.Collections.Generic;
using EMSYS.TowerDefence.Manager;
using UnityEngine;

namespace EMSYS.TowerDefence.Entity.Tower
{
    public class TowerTransform : MonoBehaviour
    {
        #region variable
        /// <summary>
        /// 클래스 연동용 변수
        /// </summary>
        private TowerInfo info;
        /// <summary>
        /// 처음 타워의 위치를 저장하기 위한 변수.
        /// </summary>
        private Vector3 oldPos;
        /// <summary>
        /// 다음으로 움직일 타워의 위치를 저장하기 위한 변수.
        /// </summary>
        private Vector3 nextPos;
        #endregion

        #region method
        public void Change(Vector3 pos)
        {
            this.nextPos = pos;
        }
        public void Move(Vector3 pos)
        {
            this.transform.position = pos;
        }
        public void Drop()
        {

            this.transform.position = nextPos;
            return;
            switch (info.status)
            {
                case TowerStatus.Buying:
                    break;
                case TowerStatus.Selling:
                    Destroy(this.gameObject);
                    break;
                case TowerStatus.Idle:
                    this.transform.position = nextPos;
                    break;
                case TowerStatus.InShop:

                    break;
                case TowerStatus.Merging:
                    
                    break;
                case TowerStatus.BuyingCancel:
                    this.transform.position = oldPos;
                    break;

            }
            oldPos = this.transform.position;
        }
        #endregion

        #region logic
        //Init
        private void Awake()
        {
            oldPos = this.transform.position;
        }
        private void Start()
        {

        }

        //Loop
        private void Update()
        {

        }
        private void LateUpdate()
        {

        }
        #endregion
    }
}