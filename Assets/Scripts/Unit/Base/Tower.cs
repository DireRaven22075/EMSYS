using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EMSYS.TowerDefence.Unit
{
    public class Tower : Entity
    {
        public int bpm { get; protected set; }

        private void FixedUpdate()
        {
            if (health <= 0) Dead();
                
        }


        public void Dead()
        {
            linkedPool.Release(this.gameObject);
        }
    }

}
