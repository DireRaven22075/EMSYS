using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EMSYS.TowerDefence.GameScene
{
    public class Tower : MonoBehaviour
    {
        #region variable
        public bool isUsing { get; private set; }

        public bool isSelect = false;
        #endregion

        #region method
        private void Drag()
        {

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
        private void OnEnable()
        {
            
        }

        //Loop
        private void Update()
        {
            if (isSelect)
            {
                Touch touch = Input.GetTouch(0);
                Vector2 pos = Camera.main.ScreenToWorldPoint(touch.position);
                transform.position = pos;
            }
        }
        private void LateUpdate()
        {
            
        }

        //Event
        private void OnTriggerEnter2D(Collider2D collision)
        {
            isSelect = true;
        }
        private void OnTriggerExit2D(Collider2D collision)
        {
            isSelect = false;
        }
        #endregion
    }
}