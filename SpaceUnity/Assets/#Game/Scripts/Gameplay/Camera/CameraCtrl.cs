using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace apbcs
{
    //seguir jogador verticalmente e horizontalmente
    public class CameraCtrl : MonoBehaviour
    {
        [SerializeField] private PlayerCtrl m_player;

        private void UpdateCamPos()
        {
            Vector2 newCamPos = m_player.transform.position;
            transform.position = new Vector3(newCamPos.x, newCamPos.y, transform.position.z);
        }

        void LateUpdate() //cada frame
        {
            UpdateCamPos();
        }
    }
}
