using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;
namespace EMSYS.TowerDefence.Unit
{
    [AddComponentMenu("TowerDefence/Unit/ProjectileBase")]
    [RequireComponent(typeof(Rigidbody2D))]
    public class Projectile : Entity
    {
        private Rigidbody2D rigid;
        private Transform parent;
        private int damage;
        public Transform target;
        private IObjectPool<GameObject> pool = null;
        private void OnEnable()
        {
            if (!rigid) rigid = GetComponent<Rigidbody2D>();

        }
        private void Update()
        {
            if (!target)
                pool.Release(this.gameObject);
        }
        public void Init(IObjectPool<GameObject> pool, Transform target, Transform parent)
        {
            this.pool = pool;
            this.transform.position = parent.position;
        }
        
    }
}