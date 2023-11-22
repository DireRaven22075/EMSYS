using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace EMSYS.TowerDefence.Unit
{
    [AddComponentMenu("TowerDefence/Unit/Enemy/Base")]
    [RequireComponent(typeof(Rigidbody2D))]
    public class Enemy : MonoBehaviour
    {
        protected Rigidbody2D rigid { get; private set; }
        /// <summary>
        /// 1 : Up, 2: Right, 3: Down, 4: Left
        /// </summary>
        protected List<int> path = new List<int>();
        private void OnEnable()
        {
            if (!rigid) rigid = GetComponent<Rigidbody2D>();
        }
        void Start()
        {
            
        }
        void Update()
        {
            
        }
        public void Damage(int value)
        {

        }
        protected void SetPath(params int[] n)
        {
            path.Clear();
            path.AddRange(n);
        }
    }
}