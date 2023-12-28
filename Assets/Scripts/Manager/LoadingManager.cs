using System.Xml;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace EMSYS.TowerDefence.Manager
{
    [AddComponentMenu("TowerDefence/LoadingSceneManager")]
    public class LoadingManager : MonoBehaviour
    {
        #region variable
        /// <summary>
        /// 다음 씬의 로드 진행상황을 나타내는 변수입니다 (read only)
        /// </summary>
        public float progress { get; private set; }
        /// <summary>
        /// 랜덤으로 생성되는 팁 텍스트입니다 (read only)
        /// </summary>
        public string tip 
        {
            get
            {
                return tips[index];
            }
        }
        /// <summary>
        /// 팁이 저장되어 있는 배열입니다.
        /// </summary>
        private string[] tips;
        /// <summary>
        /// 중복으로 팁 텍스트를 가져오지 않기 위한 변수입니다.
        /// </summary>
        private int index = 1;
        #endregion
        #region method
        private void InitTips()
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(Resources.Load<TextAsset>("Text/Tip").text);
            tips = doc.DocumentElement.InnerText.Split('\n');
        }
        public void NextTip()
        {
            if (index >= tips.Length - 1) index = 1;
            else index++;
        }
        private IEnumerator LoadScene()
        {
            yield return null;
            AsyncOperation operation = SceneManager.LoadSceneAsync("03.Game");
            operation.allowSceneActivation = false;
            float time = 0f;
            while (!operation.isDone)
            {
                yield return null;
                time += Time.deltaTime;
                if (operation.progress < 0.9f)
                {
                    progress = Mathf.Lerp(progress, operation.progress, time);
                    if (progress >= operation.progress)
                    {
                        time = 0f;
                    }
                }
                else
                {
                    progress = Mathf.Lerp(progress, 1f, time);
                    if (progress == 1.0f)
                    {
                        operation.allowSceneActivation = true;
                        yield break;
                    }
                }
            }
        }
        #endregion

        #region logic
        //Init
        private void Awake()
        {
            InitTips();
        }
        private void Start()
        {
            StartCoroutine(LoadScene());
        }
        #endregion
    }
}