using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EMSYS.TowerDefence.Interact
{
    public class GameInput : MonoBehaviour
    {
        void Start()
        {

        }
        void Update()
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(ray.origin, ray.direction * 1000, Color.blue);
            RaycastHit data;
            if (Physics.Raycast(ray, out data))
            {
                Debug.Log(data.collider.name);
            }
            if (Input.GetMouseButtonDown(0))
            {
                
            }
        }
    }
}

/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRaycast : MonoBehaviour
{
    RaycastHit hit;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(ray.origin, ray.direction * 1000, Color.blue);

            if(Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.collider.name);
            }
        }
    }
}
 */