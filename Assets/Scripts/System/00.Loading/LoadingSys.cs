using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using EMSYS.TowerDefence.IO;
using EMSYS.TowerDefence.UI;
namespace EMSYS.TowerDefence.System
{
    public class LoadingSys : MonoBehaviour
    {
        private LoadingIO io;
        private LoadingUI ui;
        public float loadingPercent;
        private static string nextScene = "01.Start";
        public static void LoadScene(string nextName)
        {
            nextScene = nextName;
            SceneManager.LoadScene("00.Loading");
        }
        private void Awake()
        {
            
        }
        private void Start()
        {
            StartCoroutine(Load());
        }
        private void Update()
        {
            
        }
        private void LateUpdate()
        {
            
        }

        private IEnumerator Load()
        {
            yield return null;
            AsyncOperation operation = SceneManager.LoadSceneAsync(nextScene);
            operation.allowSceneActivation = false;
            float timer = 0.0f;
            while (!operation.isDone)
            {
                yield return null;
                timer += Time.deltaTime;
                if (operation.progress < 0.9f)
                {
                    loadingPercent = Mathf.Lerp(loadingPercent, operation.progress, timer);
                    if (loadingPercent >= operation.progress)
                    {
                        timer = 0f;
                    }
                }
                else
                {
                    loadingPercent = Mathf.Lerp(loadingPercent, 1f, timer);
                    if (loadingPercent == 1.0f)
                    {
                        operation.allowSceneActivation = true;
                        yield break;
                    }
                }
            }
        }
    }
}