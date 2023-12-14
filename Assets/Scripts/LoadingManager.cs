using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace EMSYS.TowerDefence.System
{
    public class LoadingManager : MonoBehaviour
    {
        private static string nextScene = null;
        [SerializeField]
        private Image progress;
        private void Start()
        {
            if (nextScene == null) SceneManager.LoadScene("02.Lobby");
            StartCoroutine(LoadScene());
        }
        public static void LoadScene(string sceneName)
        {
            nextScene = sceneName;
            SceneManager.LoadScene("00.Loading");
        }
        IEnumerator LoadScene()
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
                    progress.fillAmount = Mathf.Lerp(progress.fillAmount, operation.progress, timer);
                    if (progress.fillAmount >= operation.progress)
                    {
                        timer = 0f;
                    }
                }
                else
                {
                    progress.fillAmount = Mathf.Lerp(progress.fillAmount, 1f, timer);
                    if (progress.fillAmount == 1.0f)
                    {
                        operation.allowSceneActivation = true;
                        yield break;
                    }
                }
            }
        }
    }
}