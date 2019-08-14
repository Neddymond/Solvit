using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class EnnemyManager : MonoBehaviour
    {
        public static EnnemyManager instance;

        Rigidbody2D enemyRigidBody;

        public bool attack = true;
        public bool dirLeft = true;
        private bool m_FacingRight = true;

        public static float speed = 5.0f;
        public float rightPosition = 122.05f;
        public float leftPosition = 89.0f;

        public void Start()
        {
            
        }

        public void Update()
        {
           
            if (dirLeft)
            {
                //MOve on the left direction
                transform.Translate(Vector2.left * speed * Time.deltaTime);
                transform.eulerAngles = new Vector2(0, 0);
            }
            else
            {
                //Flip to move on the opposite direction
                transform.Translate(Vector2.left * speed * Time.deltaTime);
                transform.eulerAngles = new Vector2(0, 180);
            }

            if (transform.position.x >= rightPosition)
            {
                dirLeft = true;
            }

            if (transform.position.x <= leftPosition)
            {
                dirLeft = false;
            }
        }
    }
}
