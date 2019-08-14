using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    class BasicController : MonoBehaviour
    {
        private Animator anim;

        public float speed = 1.0f;
        public float transmissionTime = 0.25f;
        private float h;
        private float v;

        private void Start()
        {
            anim = GetComponent<Animator>();
        }

        private void Update()
        {
            h = Input.GetAxis("Horizontal");
            v = Input.GetAxis("Vertical");

            float xSpeed = h * speed;
            float ySpeed = v * speed;

            anim.SetFloat("xSpeed", xSpeed, transmissionTime, Time.deltaTime);
            anim.SetFloat("ySpeed", ySpeed, transmissionTime, Time.deltaTime);
            anim.SetFloat("speed", speed, transmissionTime, Time.deltaTime);
        }
    }
}
