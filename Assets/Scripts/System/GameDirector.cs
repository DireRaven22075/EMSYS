using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

namespace EMSYS.TowerDefence.System
{
    public class GameDirector : MonoBehaviour
    {
        private Dictionary<string, IObjectPool<GameObject>> enemeyPools =
            new Dictionary<string, IObjectPool<GameObject>>();
        private void Start()
        {

        }
        private void Update()
        {

        }
    }

}