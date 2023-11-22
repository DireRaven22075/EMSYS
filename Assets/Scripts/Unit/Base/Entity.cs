using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;
namespace EMSYS.TowerDefence.Unit
{
    public class Entity : MonoBehaviour
    {
        public int health { get; protected set; }
        public int maxHealth { get; protected set; }
        public IObjectPool<GameObject> linkedPool = null;

        public void Damage(int value)
        {
            health -= value;
        }
    }
}