using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace EMSYS.TowerDefence.LoadingScene.UI
{
    [RequireComponent(typeof(Image))]
    public class LoadingBar : MonoBehaviour
    {
        #region variable
        private Image image;
        private LoadingManager manager;
        #endregion

        #region method

        #endregion

        #region logic
        private void Awake()
        {
            image = GetComponent<Image>();
            manager = GameObject.FindObjectOfType<LoadingManager>();
        }
        void Start()
        {

        }
        void Update()
        {
            image.fillAmount = manager.progress;
        }
        #endregion
    }
}