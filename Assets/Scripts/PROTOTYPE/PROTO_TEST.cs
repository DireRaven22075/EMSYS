using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;
namespace EMSYS.TowerDefence.TEST
{
    public class PROTO_TEST : MonoBehaviour
    {
        #region pooling
        private IObjectPool<GameObject> pool;
        private GameObject PoolCreate()
        {
            GameObject obj = new GameObject("");
            return obj;
        }
        private void PoolActionOnGet(GameObject pool)
        {
            pool.SetActive(true);
        }
        private void PoolActionOnRelease(GameObject pool)
        {
            pool.SetActive(false);
        }
        private void PoolActDestroy(GameObject pool)
        {
            Destroy(pool);
        }
        #endregion
        private void Awake()
        {
            pool = new ObjectPool<GameObject>(
                createFunc: PoolCreate,
                actionOnGet:PoolActionOnGet,
                actionOnRelease: PoolActionOnRelease,
                actionOnDestroy: PoolActDestroy,
                collectionCheck: true,
                defaultCapacity: 10,
                maxSize: 30
            );
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.F1))
                SummonEnemy();
        }
        private void SummonEnemy()
        {

        }
        
    }

}