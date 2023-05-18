using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace apbcs
{
    public class PlayerCtrl : MonoBehaviour
    {
        private const string k_rotationAxis = "Horizontal";
        private const string k_translationAxis = "Vertical";

        [SerializeField] private float m_rotationSpeed = 100;
        [SerializeField] private float m_translateSpeed = 40;
        [SerializeField] private GameObject m_gun1;
        [SerializeField] private GameObject m_gun2;
        [SerializeField] private Bullet m_bulletPrefab;

        //Mover o player com rotacao (A-D) e translacao (W-S)
        private void Awake()
        {

        }
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            GetInput();
        }

        void TranslateShip(float _translationInput)
        {
            transform.Translate(new Vector3(0, _translationInput * Time.deltaTime * m_translateSpeed, 0));
        }
        void RotateShip(float _rotationInput)
        {
            transform.Rotate(new Vector3(0, 0, -_rotationInput * Time.deltaTime * m_rotationSpeed));
        }
        void Shoot()
        {
            Bullet bullet1 = Instantiate(m_bulletPrefab, m_gun1.transform.position, transform.rotation);
            Bullet bullet2 = Instantiate(m_bulletPrefab, m_gun2.transform.position, transform.rotation);
        }
        void GetInput()
        {
            float rotationInput = Input.GetAxis(k_rotationAxis);
            float translationInput = Input.GetAxis(k_translationAxis);

            if (Input.GetKeyDown(KeyCode.Space)) Shoot();
            RotateShip(rotationInput);
            TranslateShip(translationInput);
        }
    }
}
