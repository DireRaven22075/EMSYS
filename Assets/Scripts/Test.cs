using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using EMSYS.TowerDefence.GameScene;
public class Test : MonoBehaviour
{
    private Tower tower;
    private void Update()
    {
        if (Input.touchCount == 0) return;
        Touch touch = Input.GetTouch(0);

        Vector2 pos = Camera.main.ScreenToWorldPoint(touch.position);
        Ray2D ray = new Ray2D(pos, Vector2.zero);
        RaycastHit2D hit;
        hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity);
        if (hit)
        {
            if (tower == null)
            {
                tower = hit.collider.GetComponent<Tower>();
                tower.isSelect = true;
            }
            else if (hit.collider.gameObject != tower.gameObject)
            {
                tower.isSelect = false;
                tower = hit.collider.GetComponent<Tower>();
                tower.isSelect = true;
            }
        }
    }
    public GameObject GetClicked2DObject(int layer = -1)
    {
        GameObject target = null;

        int mask = 1 << layer;

        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Ray2D ray = new Ray2D(pos, Vector2.zero);
        RaycastHit2D hit;
        hit = layer == -1 ? Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity) : Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity, mask);

        if (hit) //마우스 근처에 오브젝트가 있는지 확인
        {
            //있으면 오브젝트를 저장한다.
            target = hit.collider.gameObject;
        }
        return target;
    }
    private void Btn()
    {
        Debug.Log("Hello");
    }
    /*
    private bool isSelected = false;
    private float tim = 0;
    private int clickCount = 0;
    private int oldTouchCount = 0;
    private void Update()
    {
        if (clickCount != 0) tim += Time.deltaTime;
        if (tim > 1f) clickCount = 0;
        if (clickCount >= 4)
        {
            Debug.Log("Double Click");
            clickCount = 0;
            tim = 0;
        }
        if (oldTouchCount != Input.touchCount)
        {
            clickCount++;
            oldTouchCount = Input.touchCount;
        }
        return;

        if (Input.touchCount == 0) return;
        Touch touch = Input.GetTouch(0);
        Vector2 pos = Camera.main.ScreenToWorldPoint(touch.position);
        transform.position = pos;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        isSelected = true;
    }
    //*/
}
