using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace apbcs
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private int m_damage;

        private void Move()
        {
            transform.position += (transform.up * 10.0f * Time.deltaTime); 
            //transform.Translate(Vector3.up * 10.0f * Time.deltaTime, Space.Self);
        }
        private void Update()
        {
            Move();
        }

        private void OnTriggerEnter2D(Collider2D collision) {
            if (collision.CompareTag("Enemy")) {
                collision.GetComponent<Enemy>().TakeDamage(m_damage);
                Destroy(gameObject);
            }
        }
    }
}
