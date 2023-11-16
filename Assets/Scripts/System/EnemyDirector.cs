using System.Collections.Generic;
using UnityEngine;
namespace EMSYS.TowerDefence.System
{
    public class EnemyDirector : MonoBehaviour
    {

        [SerializeField]
        private GameObject[] objects = null;
        [SerializeField]
        private string[] ids = null;
        public bool available { get; private set; }
        private Dictionary<string, Pool> pools = new Dictionary<string, Pool>();

        private void Awake()
        {
            for (int i = 0; i < objects.Length; i++)
            {
                Add(ids[i], objects[i], 10, 20);
            }
        }
        private void Update()
        {

        }
        public void Add(string id, GameObject enemy, int capacity, int maxSize)
        {
            available = false;
            if (pools.ContainsKey(id))
            {
                Debug.Log(Constants.Errormsg.pool_already_contains_key);
                available = true;
                return;
            }

            GameObject obj = new GameObject(string.Format("<{0}> Pooling Parent", id));
            obj.AddComponent<Pool>();
            Pool pool = obj.GetComponent<Pool>();
            pool.Init(enemy, capacity, maxSize);
            pools.Add(id, pool);
            available = true;
        }
        public void Summon(string id)
        {
            available = false;
            if (!pools.ContainsKey(id))
            {
                Debug.Log(Constants.Errormsg.pool_not_contains_key);
                available = true;
                return;
            }
            pools[id].pool.Get();
            available = true;
        }
    }
}