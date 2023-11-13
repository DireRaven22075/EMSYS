using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.Tilemaps;
using UnityEngine.Pool;
using UnityEngine.UI;
using EMSYS.TowerDefence.Unit;
namespace EMSYS.TowerDefence.TEST
{
    public class PROTO_INPUT : MonoBehaviour
    {
        [SerializeField]
        private Transform parent;
        #region Pooling
        private GameObject PoolCreate()
        {
            GameObject enemy;
            GameObject source = Resources.Load<GameObject>(Constants.Path.enemey);
            enemy = Instantiate<GameObject>(source, new Vector3(-6, 6), Quaternion.identity, parent);
            enemy.GetComponent<Enemy>().pool = this.pool;
            return enemy;
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

        private IObjectPool<GameObject> pool = null;
        private void Awake()
        {
            pool = new ObjectPool<GameObject>(
                createFunc: PoolCreate,
                actionOnGet: PoolActionOnGet,
                actionOnRelease: PoolActionOnRelease,
                actionOnDestroy: PoolActDestroy,
                collectionCheck: true,
                defaultCapacity: 40,
                maxSize: 70
            );
        }
        void Start()
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

        }
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.F1))
            {
                pool.Get();
            }
        }
    }

}
