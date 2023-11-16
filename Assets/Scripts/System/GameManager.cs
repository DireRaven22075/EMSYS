using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EMSYS.TowerDefence.System
{
    public class GameManager : MonoBehaviour
    {
        private static GameManager _instance;
        public static GameManager instance
        {
            get
            {
                if (!_instance)
                {
                    _instance = GameObject.FindObjectOfType<GameManager>();
                    if (!_instance)
                    {
                        GameObject obj = new GameObject("GameManager");
                        DontDestroyOnLoad(obj);
                        _instance = obj.GetComponent<GameManager>();
                    }
                }
                return _instance;
            }
        }
        private void Awake()
        {
            if (!_instance)
            {
                _instance = this;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }
        private void Start()
        {

        }
    }
}