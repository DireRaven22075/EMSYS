using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EMSYS.TowerDefence.UI
{
    public class LobbyUI : MonoBehaviour
    {
        [SerializeField]
        Canvas[] canvas;
        void Start()
        {
            canvas = new Canvas[transform.childCount];
            for (int i = 0; i < transform.childCount; i++)
            {
                canvas[i] = transform.GetChild(i).GetComponent<Canvas>();
            }
        }
        public void SetCanvasActive(int target, bool value) => canvas[target].enabled = value;
    }
}