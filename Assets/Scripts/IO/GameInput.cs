using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using EMSYS.TowerDefence.Entity.Tower;
using EMSYS.TowerDefence.Manager;
namespace EMSYS.TowerDefence.IO
{
    /// <summary>
    /// Only Detect For Tower Movement
    /// </summary>
    public partial class GameInput : MonoBehaviour
    {
        #region variable
        //Private
        private GameManager manager;
        private TowerTransform tower;
        private Camera camera;
        private bool isTouching = false;

        /// <summary>
        /// time += Time.deltaTime
        /// </summary>
        private float time = 0;
        /// <summary>
        /// Detect Click Count For Double Click Func
        /// </summary>
        private int clickCount = 0;
        #endregion

        #region method
        public void Btn_Unpause()
        {
            manager.observer.Invoke("Unpause");
        }
        private void ClickCountFunc()
        {
            if (clickCount >= 2)
            {
                manager.observer.Invoke("Pause");
                clickCount = 0;
                time = 0;
            }
            if (clickCount != 0)
            {
                time += Time.deltaTime;
            }
            if (time > 1f)
            {
                clickCount = 0;
                time = 0;
            }
            
        }
        private void TouchBegan(Touch touch, Ray2D ray)
        {
            GameObject obj;
            if ((obj = GetObject(ray, Constants.Int.towerLayer)) != null)
            {
                isTouching = true;
                tower = obj.GetComponent<TowerTransform>();
            }
        }
        private void TouchMoved(Touch touch, Ray2D ray)
        {
            GameObject obj;
            if (!isTouching) return;
            if ((obj = GetObject(ray, Constants.Int.interactLayer)) != null)
            {
                tower.Change(obj.transform.position);
            }
            tower.Move((Vector3)ray.origin + Vector3.forward);
        }
        private void TouchStationary(Touch touch, Ray2D ray)
        {
            GameObject obj;
            if (!isTouching) return;
            if ((obj = GetObject(ray, Constants.Int.interactLayer)) != null)
            {
                tower.Change(obj.transform.position);
            }
            Vector3 pos = camera.ScreenToWorldPoint(touch.position);
            tower.Move(pos + Vector3.forward);
        }
        private void TouchEnded(Touch touch, Ray2D ray)
        {
            clickCount++;
            if (!isTouching) return;
            clickCount = 0;
            tower.Drop();
            tower = null;
            isTouching = false;
        }
        private void TouchCanceled(Touch touch, Ray2D ray)
        {
            clickCount++;
            if (!isTouching) return;
            clickCount = 0;
            tower.Drop();
            tower = null;
            isTouching = false;
        }
        private GameObject GetObject(Ray2D ray, int layer = -1)
        {
            int mask = 1 << layer;
            RaycastHit2D hit;
            hit = layer == -1 ? Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity) : Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity, mask);

            return hit ? hit.collider.gameObject : null;
        }
        #endregion

        #region logic
        //Init
        private void Awake()
        {
            camera = Camera.main;
            manager = GameObject.FindObjectOfType<GameManager>();
        }

        //Loop
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
                manager.observer.Invoke("Trial");
            ClickCountFunc();
            if (Input.touchCount == 0) return;
            Touch touch = Input.GetTouch(0);
            Ray2D ray = new Ray2D(camera.ScreenToWorldPoint(touch.position), Vector3.zero);
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    TouchBegan(touch, ray);
                    return;
                case TouchPhase.Moved:
                    TouchMoved(touch, ray);
                    return;
                case TouchPhase.Stationary:
                    TouchStationary(touch, ray);
                    return;
                case TouchPhase.Ended:
                    TouchEnded(touch, ray);
                    return;
                case TouchPhase.Canceled:
                    TouchCanceled(touch, ray);
                    return;
            }
        }
        #endregion
    }
}