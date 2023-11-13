using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

namespace EMSYS.TowerDefence.Unit
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Enemy : MonoBehaviour
    {
        #region value
        public int point { get; private set; }
        public static float speed;
        public static float maxHealth = 30;
        public float health;

        #endregion
        public IObjectPool<GameObject> pool;

        private Rigidbody2D rigid;
        private void OnEnable()
        {
            rigid = GetComponent<Rigidbody2D>();
            point = 0;
            health = maxHealth;
            transform.position = new Vector2(-6, 6);
        }
        public void Damage(int value)
        {
            health -= value;
        }
        private void FixedUpdate()
        {
            if (health <= 0) pool.Release(this.gameObject);
        }
        void Update()
        {
            speed = 5;
            switch (point)
            {
                case 0: case 4: case 8:
                    rigid.velocity = Vector2.down * speed;
                    break;
                case 1: case 5: case 9:
                    rigid.velocity = Vector2.right * speed;
                    break;
                case 2: case 6: case 10:
                    rigid.velocity = Vector2.up * speed;
                    break;
                case 3: case 7:
                    rigid.velocity = Vector2.left * speed;
                    break;
            }
        }
        private void LateUpdate()
        {
            Vector2 pos = transform.position;
            pos.x = Mathf.Clamp(pos.x, Constants.IntArr.enemyX[point, 0], Constants.IntArr.enemyX[point, 1]);
            pos.y = Mathf.Clamp(pos.y, Constants.IntArr.enemyY[point, 0], Constants.IntArr.enemyY[point, 1]);
            transform.position = pos;
            switch (point)
            {
                case 0: if (transform.position.y == 2) point++; break;
                case 1: if (transform.position.x == 6) point++; break;
                case 2: if (transform.position.y == 6) point++; break;
                case 3: if (transform.position.x == 2) point++; break;
                case 4: if (transform.position.y == -6) point++; break;
                case 5: if (transform.position.x == 6) point++; break;
                case 6: if (transform.position.y == -2) point++; break;
                case 7: if (transform.position.x == -6) point++; break;
                case 8: if (transform.position.y == -6) point++; break;
                case 9: if (transform.position.x == -2) point++; break;
                case 10: if (transform.position.y == 7) pool.Release(this.gameObject); break;
            }
        }
    }
}