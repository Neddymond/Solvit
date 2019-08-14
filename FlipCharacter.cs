using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    class FlipCharacter : MonoBehaviour
    {
        private bool facingRight = true;

        private void Update()
        {
            if (Input.GetKey(KeyCode.LeftArrow) && facingRight)
            {
                Flip();
            }
            if (Input.GetKey(KeyCode.RightArrow) && !facingRight)
            {
                Flip();
            }

        }

        private void Flip()
        {
            facingRight = !facingRight;
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
        }
    }
}
