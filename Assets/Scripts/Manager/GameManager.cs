using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EMSYS.TowerDefence.Entity.Tower;

namespace EMSYS.TowerDefence.Manager
{

    [AddComponentMenu("TowerDefence/GameSceneManager")]
    public partial class GameManager : MonoBehaviour
    {
        public delegate void Event(string @event);
        #region variable
        public Event observer;
        public int coin { get; private set; }
        #endregion

        #region method
        public bool AbleToBuy(TowerInfo info)
        {
            return coin >= info.coin;
        }
        public bool AbleToBuy(int value)
        {
            return coin >= value;
        }
        public void AddCoin(TowerInfo info)
        {
            coin += info.coin;
        }
        public void AddCoin(int value)
        {
            coin += value;
        }
        public void RemoveCoin(int value)
        {
            coin -= value;
        }
        public void RemoveCoin(TowerInfo info)
        {
            coin -= info.coin;
        }
        #endregion

        #region logic
        //Init
        private void Awake()
        {

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