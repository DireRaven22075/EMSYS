using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;
namespace EMSYS.TowerDefence.Unit
{
    [AddComponentMenu("TowerDefence/Unit/TowerBase")]
    public class Tower : Entity
    {
        [Tooltip("Bullet Damage"), SerializeField]
        private int damage;
        [Tooltip("BPM"), SerializeField]
        private int bpm;
        [Tooltip(""), SerializeField]
        private GameObject bullet;

        protected IObjectPool<GameObject> pool { get; private set; }
        private void Awake()
        {
            pool = new ObjectPool<GameObject>(
                createFunc: ObjectCreate,
                actionOnGet: ObjectGet,
                actionOnRelease: ObjectRelease,
                actionOnDestroy: ObjectDestroy,
                collectionCheck: true,
                defaultCapacity: 30,
                maxSize: 50
            );
        }
        private GameObject ObjectCreate()
        {
            GameObject obj = Instantiate<GameObject>(bullet, this.transform.position, Quaternion.identity, this.transform);
            obj.GetComponent<Projectile>().pool = this.pool;
            return obj;
        }
        private void ObjectGet(GameObject obj) => obj.SetActive(true);
        private void ObjectRelease(GameObject obj) => obj.SetActive(false);
        private void ObjectDestroy(GameObject obj) => Destroy(obj);
        /*
        #region variable
        //Start Public Area //

        //To Show the targetpriority
        public TargetPriority priority { get; protected set; }
        //To describe the max distance of targeting.
        public int range { get; protected set; }
        //To calculate shoot time
        public int bpm { get; protected set; }
        //To store the attack damage
        public int attack { get; protected set; }

        //End Public Area //

        //Start Protected Area//

        //To control the animation
        protected Animator animator { get; private set; }

        //To store the target
        [SerializeField]
        protected Enemy target;

        protected Transform child { get; private set; }
        //End Protected Area//


        //Start Private Area//

        private bool isAttacking = false;
        //End Private Area//
        #endregion
        private Animator childAnimator;
        private void OnEnable()
        {
            Init();
        }
        private void UpdateTargetByHealthPoint()
        {

        }
        private void UpdateTarget()
        {

        }
        private void UpdateTargetByDistance()
        {

        }
        void Update()
        {
            if (!target)
            {
                CancelInvoke("Attack");
            }
            switch (priority)
            {
                case TargetPriority.Default:
                    UpdateTargetByDistance(); break;

                case TargetPriority.Distance:
                    UpdateTargetByDistance(); break;

                case TargetPriority.HealthPoint:
                    UpdateTargetByHealthPoint(); break;
            }
            target = GetClosestEnemy(GameObject.FindGameObjectsWithTag("Enemy"), range);
            //LookAt2D(target.transform);
        }
        private void Attack()
        {
            if (target != null)
            {
                target.Damage(attack);
                animator.SetTrigger("Attack");
            }
            else return;
            if (target.gameObject.activeSelf == false)
                target = null;
        }
        void LookAt2D(Transform target)
        {
            Vector2 value = target.position - child.position;
            float angle = Mathf.Atan2(value.y, value.x) * Mathf.Rad2Deg;
            Quaternion axis = Quaternion.AngleAxis(angle - 90f, Vector3.forward);
            child.rotation = axis;
        }
        protected void UpdateTarget(int a)
        {
            Enemy[] enemies = GameObject.FindObjectsOfType<Enemy>();

            Enemy obj = null;
            Vector3 position = transform.position;
            float distance = Mathf.Infinity;
            switch (this.priority)
            {
                case TargetPriority.Default:
                    {
                        foreach (Enemy enemy in enemies)
                        {
                            float dist = Vector3.Distance(position, enemy.transform.position);
                            if (dist < distance && dist <= range)
                            {
                                if (!obj)
                                {
                                    if (obj.point <= enemy.point)
                                    {
                                        obj = enemy;
                                        distance = dist;
                                    }
                                }
                            }
                        }
                    }
                    break;

                case TargetPriority.Distance:
                    {
                        foreach (Enemy enemy in enemies)
                        {
                            float dist = Vector3.Distance(position, enemy.transform.position);
                            if (dist < Vector3.Distance(obj.transform.position, transform.position) &&
                                dist <= range)
                            {
                                obj = enemy;
                            }
                        }
                    }
                    break;

                case TargetPriority.HealthPoint:
                    {

                    }
                    break;
            }
            target = obj;
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
        protected virtual void Init() {}
        Enemy GetClosestEnemy(GameObject[] enemies, float far)
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
            if (min == null)
                return null;
            else
                return min.GetComponent<Enemy>();
        }
        */
    }
}