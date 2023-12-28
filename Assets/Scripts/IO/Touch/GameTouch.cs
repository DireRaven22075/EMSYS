using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using EMSYS.TowerDefence.Entity.Tower;
namespace EMSYS.TowerDefence.IO
{

    public class GameTouch : MonoBehaviour
    {
        #region variable
        //Public

        //Private
        private TowerTransform tower;
        private Camera camera;
        private bool isTouching = false;
        //Protected

        #endregion

        #region method
        private GameObject GetObject(Ray2D ray, int layer = -1)
        {
            int mask = 1 << layer;
            RaycastHit2D hit;
            hit = layer == -1 ? Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity) : Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity, mask);

            return hit ? hit.collider.gameObject : null;
        }
        #endregion

        #region logic

        private void Awake()
        {
            camera = Camera.main;
        }
        private void Update()
        {
            if (Input.touchCount == 0) return;
            UnityEngine.Touch touch = Input.GetTouch(0);
            Vector3 pos = camera.ScreenToWorldPoint(touch.position);
            Ray2D ray = new Ray2D(pos, Vector2.zero);
            RaycastHit2D systemHits = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity, 1 << 5);
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    //만약 터치가 시작되었을 경우
                    //타워를 선택한 터치일 경우 index, gameobject를 저장한다
                    GameObject obj;
                    if ((obj = GetObject(ray, 6)) != null && (tower = obj.GetComponent<TowerTransform>()) != null)
                    {
                        isTouching = true;
                    }
                    break;
                case TouchPhase.Stationary:
                case TouchPhase.Moved:
                    //만약 터치가 움직일 경우 || 터치가 가만히 있을 경우
                    //움직이는 터치가 타워를 선택한 터치일 경우 타워를 움직인다.
                    if (systemHits)
                    {
                        Debug.Log(systemHits.collider.name);
                        tower.Change(systemHits.collider.transform.position);

                    }
                    if (isTouching)
                    {
                        tower.Move(pos + Vector3.forward);
                    }

                    break;
                case TouchPhase.Ended:
                case TouchPhase.Canceled:
                    //만약 터치가 끝날 경우
                    //타워를 움직이던 건 칸에 고정시켜주고 다른건 모르겠다
                    if (isTouching)
                    {
                        tower.Drop();
                        isTouching = false;
                        tower = null;
                    }
                    break;
            }
        }
        #endregion
    }
}