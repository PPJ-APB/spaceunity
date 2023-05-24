using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace apbcs {
    public class Enemy : MonoBehaviour {

        [SerializeField] private int m_health;

        [SerializeField] private int m_damage;

        // Start is called before the first frame update
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        private void OnTriggerEnter2D(Collider2D collision) {
            if (collision.CompareTag("Player")) {
                TakeDamage(m_health);
                collision.GetComponent<PlayerStatus>().TakeDamage(m_damage);
            }
        }

        public void TakeDamage(int damage) {
            m_health -= damage;
            if (m_health <= 0) {
                Destroy(gameObject);
            }
        }
    }
}