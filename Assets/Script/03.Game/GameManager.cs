using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EMSYS.TowerDefence.GameScene
{
    [AddComponentMenu("TowerDefence/GameSceneManager")]
    public partial class GameManager : MonoBehaviour
    {
        #region variable
        public int coin { get; private set; }
        #endregion

        #region method
        public bool AbleToBuy(int value)
        {
            return coin >= value;
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