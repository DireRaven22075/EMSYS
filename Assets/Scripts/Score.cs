using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace EMSYS.TowerDefence
{
    public class Score : MonoBehaviour
    {
        public int score { get; private set; }
        public void AddScore(int value)
        {
            score += value;
        }
        private void Awake()
        {
            score = 0;
            DontDestroyOnLoad(this.gameObject);
        }
    }
}
