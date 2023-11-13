using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EMSYS.TowerDefence.Unit
{
    public class Tower : MonoBehaviour
    {
        #region variable
        //Start Public Area //

        //To Show the targetpriority
        public TargetPriority priority = TargetPriority.Default;
        //To describe the max distance of targeting.
        public int range { get; protected set; }
        //To calculate shoot time
        public int bpm { get; protected set; }
        //To store the attack damage
        public int attack { get; protected set; }

        //End Public Area //


        //Start Protected Area//

        //To store the target
        protected GameObject target { get; private set; }

        protected Transform child { get; private set; }

        //End Protected Area//


        //Start Private Area//

        //End Private Area//
        #endregion
        private Animator childAnimator;
        private void OnEnable()
        {
            child = transform.GetChild(0);

            Init();
        }
        void Update()
        {
            GameObject temp = GetClosestEnemy(GameObject.FindGameObjectsWithTag("Enemy"), range);
            if (!target)
            {
                GameObject.FindObjectsByType<Enemy>(FindObjectsSortMode.InstanceID);
                target = GetClosestEnemy(GameObject.FindGameObjectsWithTag("Enemy"), range);
            }
            if (Vector3.Distance(target.transform.position, transform.position) > range)
            {
                target = null;
                return;
            }
            LookAt2D(target.transform);
        }
        void LookAt2D(Transform target)
        {
            Vector2 value = target.position - child.position;
            float angle = Mathf.Atan2(value.y, value.x) * Mathf.Rad2Deg;
            Quaternion axis = Quaternion.AngleAxis(angle - 90f, Vector3.forward);
            child.rotation = axis;
        }
        protected void UpdateTarget(GameObject[] enemies, float maxDistance)
        {
          
            GameObject obj = null;
            float targetDistance = Mathf.Infinity;
            Vector3 position = transform.position;
            float max = Mathf.NegativeInfinity;
            switch (priority)
            {
                //Choose Target which is point is dangerous
                case TargetPriority.Default:

                    return;

                case TargetPriority.Distance:


                    float dist1 = Vector3.Distance(transform.position, obj.transform.position);
                    float dist2 = Vector3.Distance(transform.position, target.transform.position);
                    return;
            }
            foreach (GameObject enemy in enemies)
            {
                switch (priority)
                {
                    case TargetPriority.Default:
                        
                        break;
                }
            }
        }

        protected virtual void Init()
        {

        }
        GameObject GetClosestEnemy(GameObject[] enemies, float far)
        {
            GameObject min = null;
            float distance = Mathf.Infinity;
            Vector3 currentPos = transform.position;
            foreach (GameObject obj in enemies)
            {
                float dist = Vector3.Distance(obj.transform.position, currentPos);
                if (dist < distance && dist < far)
                {
                    min = obj;
                    distance = dist;
                }
            }
            return min;
        }
    }

}
