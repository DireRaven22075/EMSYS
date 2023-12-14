using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
namespace EMSYS.TowerDefence.IO
{
    public partial class LobbyIO : MonoBehaviour
    {
        [SerializeField]
        AudioMixer mixer;

        private Slider master, sfx, bgm;
        private void SliderUpdate()
        {

        }
        public void Slid_Master(Slider slider)
        {
            float sound = slider.value;
            if (sound == -40f) mixer.SetFloat("Master", -80f);
            else mixer.SetFloat("Master", sound);
        }
        public void Slid_BGM(Slider slider)
        {
            float sound = slider.value;
            if (sound == -40f) mixer.SetFloat("BGM", -80f);
            else mixer.SetFloat("BGM", sound);
        }
        public void Slid_SFX(Slider slider)
        {
            float sound = slider.value;
            if (sound == -40f) mixer.SetFloat("SFX", -40f);
            else mixer.SetFloat("SFX", sound);
        }
    }
}