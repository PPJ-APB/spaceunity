using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace apbcs {
    public class EnemySpawner : MonoBehaviour {

        [SerializeField] private GameObject m_enemyPrefab;
        [SerializeField] private BoxCollider2D m_boxCollider;

        [SerializeField] private float m_delaySpawnEnemy;
        [SerializeField] private float m_enemySpeed;

        private GameObject _player;

        private void Start() {
            _player = GameObject.FindGameObjectWithTag("Player");

            StartCoroutine(DelaySpawnEnemy());
        }

        private IEnumerator DelaySpawnEnemy() {
            while (true) {
                GameObject enemySpawned = Instantiate(m_enemyPrefab, GetSpawnPositionRandom(), Quaternion.identity);

                Vector3 movementDirection = _player.transform.position - enemySpawned.transform.position;
                enemySpawned.GetComponent<Rigidbody2D>().velocity = movementDirection.normalized * m_enemySpeed;

                yield return new WaitForSeconds(m_delaySpawnEnemy);
            }
        }

        private Vector2 GetSpawnPositionRandom() {
            return new Vector2(
                    transform.position.x + Random.Range(-m_boxCollider.size.x / 2, m_boxCollider.size.x / 2),
                    transform.position.y + Random.Range(-m_boxCollider.size.y / 2, m_boxCollider.size.x / 2)
                );
        }
    }
}