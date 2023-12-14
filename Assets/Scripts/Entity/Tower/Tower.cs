using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace EMSYS.TowerDefence.Entity
{
    [RequireComponent(typeof(Animator), typeof(BoxCollider2D))]
    [RequireComponent(typeof(SpriteRenderer), typeof(AudioSource))]
    public class Tower : MonoBehaviour
    {
        #region component
        protected Animator animator { get; private set; }
        protected SpriteRenderer renderer { get; private set; }
        protected AudioSource audio { get; private set; }
        #endregion
        private void OnEnable() => OnActive();
        private void Awake() => OnAwake();
        private void Start() => OnStart();
        private void Update() => OnUpdate();
        private void LateUpdate() => OnLateUpdate();
        protected virtual void OnAwake()
        {
            animator = GetComponent<Animator>();
            renderer = GetComponent<SpriteRenderer>();
            audio = GetComponent<AudioSource>();
        }
        protected virtual void OnStart() { }
        protected virtual void OnUpdate() { }
        protected virtual void OnLateUpdate() { }
        protected virtual void OnActive()
        {
            if (!animator) animator = GetComponent<Animator>();
            if (!renderer) renderer = GetComponent<SpriteRenderer>();
            if (!audio) audio = GetComponent<AudioSource>();
        }
    }
}