using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace apbcs
{
    public class Bullet : MonoBehaviour
    {
        private void Move()
        {
            transform.position += (transform.up * 10.0f * Time.deltaTime); 
            //transform.Translate(Vector3.up * 10.0f * Time.deltaTime, Space.Self);
        }
        private void Update()
        {
            Move();
        }
    }
}
