using System;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets._2D
{
    [RequireComponent(typeof (PlatformerCharacter2D))]
    public class Platformer2DUserControl : MonoBehaviour
    {
        private PlatformerCharacter2D m_Character;
        private bool m_Jump;

        private void Awake()
        {
            m_Character = GetComponent<PlatformerCharacter2D>();
        }


        private void Update()
        {
            if (!m_Jump)
            {
                m_Jump = CrossPlatformInputManager.GetButtonDown("Jump");
            }
        }


        private void FixedUpdate()
        {
            m_Character.Move(1, false, m_Jump);
            m_Jump = false;
        }

        void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Coin"))
            {
                HUDScript.scoreValue += 10;
                Destroy(collision.gameObject);
            }
            else if (collision.gameObject.CompareTag("SpeedUp"))
            {
                m_Character.m_MaxSpeed = m_Character.m_MaxSpeed * 3 / 2;
                Destroy(collision.gameObject);
            }
            else if (collision.gameObject.CompareTag("SpeedDown"))
            {
                m_Character.m_MaxSpeed = m_Character.m_MaxSpeed * 1 / 2;
                Destroy(collision.gameObject);
            }
            else if(collision.gameObject.CompareTag("Killer"))
            {
                Destroy(m_Character);
            }
        }
    }
}
