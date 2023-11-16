using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;
namespace EMSYS.TowerDefence.Unit
{
    public class Entity : MonoBehaviour
    {
        public IObjectPool<GameObject> pool = null;
    }
}