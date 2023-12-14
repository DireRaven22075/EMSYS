using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EMSYS.TowerDefence.System
{
    public partial class StartSys : MonoBehaviour
    {
        public enum State
        {
            Init,
            InternetError,
            Loading,
            Ready
        }
        public State state = State.Init;

        private void Awake()
        {
            if (Application.internetReachability == NetworkReachability.NotReachable)
            {
                this.state = State.InternetError;
                
            }
        }
    }
}