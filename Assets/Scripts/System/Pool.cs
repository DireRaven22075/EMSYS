using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;
using EMSYS.TowerDefence.Unit;
namespace EMSYS.TowerDefence.System
{
    public class Pool : MonoBehaviour
    {
        public IObjectPool<GameObject> pool { get; private set; }
        private GameObject prefab;
        public void Init(GameObject prefab, int defaultCapacity, int maxSize)
        {
            this.transform.parent = null;
            this.transform.position = Vector3.zero;
            this.prefab = prefab;
            this.pool = new ObjectPool<GameObject>(
                createFunc: Create,
                actionOnGet: OnGet,
                actionOnRelease: OnRelease,
                actionOnDestroy: OnDest,
                collectionCheck: true,
                defaultCapacity: defaultCapacity,
                maxSize: maxSize
            );
            for (int i = 0; i < defaultCapacity; i++)
            {
                GameObject obj = pool.Get();
                pool.Release(obj);
            }
        }
        public GameObject Create()
        {
            GameObject obj = Instantiate<GameObject>(prefab, this.transform);
            obj.GetComponent<Entity>().pool = this.pool;
            return obj;
        }
        private void OnGet(GameObject obj) => obj.SetActive(true);
        private void OnRelease(GameObject obj) => obj.SetActive(false);
        private void OnDest(GameObject obj) => Destroy(obj);
    }
}