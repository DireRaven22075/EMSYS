using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace EMSYS.TowerDefence.UserInput
{
    public class StartInteract : MonoBehaviour
    {
        private void Start()
        {

        }
        private void Update()
        {

        }
        public void OnClick()
        {
            SceneManager.LoadSceneAsync("02.Lobby");
        }
    }
}