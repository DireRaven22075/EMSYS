using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using EMSYS.TowerDefence.Manager;
namespace EMSYS.TowerDefence.UI
{
    [RequireComponent(typeof(TMP_Text))]
    public class TipText : MonoBehaviour
    {
        #region variable
        private TMP_Text text;
        private LoadingManager manager;
        #endregion

        #region method

        #endregion

        #region logic
        private void Awake()
        {
            text = GetComponent<TMP_Text>();
            manager = GameObject.FindObjectOfType<LoadingManager>();
        }
        private void Update()
        {
            text.text = manager.tip;
        }
        #endregion
    }
}