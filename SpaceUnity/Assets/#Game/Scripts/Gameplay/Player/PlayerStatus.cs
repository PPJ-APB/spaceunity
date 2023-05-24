using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace apbcs {
    public class PlayerStatus : MonoBehaviour {

        [SerializeField] private int m_health;

        // Start is called before the first frame update
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        public void TakeDamage(int damage) {
            m_health -= damage;
            if (m_health <= 0) {
                Destroy(gameObject);
            }
        }
    }
}