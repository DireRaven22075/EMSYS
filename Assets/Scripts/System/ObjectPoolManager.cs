using System.Xml;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;
namespace EMSYS.TowerDefence.System
{
    public class ObjectPoolManager : MonoBehaviour
    {
        public bool available { get; private set; }
        private Dictionary<string, IObjectPool<GameObject>> pools = new Dictionary<string, IObjectPool<GameObject>>();
        #region Singleton
        private static ObjectPoolManager _instance;
        public static ObjectPoolManager instance
        {
            get
            {
                if (!_instance)
                {
                    _instance = GameObject.FindAnyObjectByType<ObjectPoolManager>();
                    if (!_instance)
                    {
                        GameObject obj = new GameObject("GameObject Pooling Manager");
                        DontDestroyOnLoad(obj);
                        obj.AddComponent<ObjectPoolManager>();
                        _instance = obj.GetComponent<ObjectPoolManager>();
                    }
                }
                return _instance;
            }
        }
        private void Awake()
        {
            available = false;
            if (!_instance)
            {
                _instance = this;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }

            available = true;
        }
        #endregion
    }

}