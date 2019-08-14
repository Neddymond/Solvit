using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    class CameraController : MonoBehaviour
    {
        //public float rightLimit;
        //public float leftLimit;
        //public Transform player;
        //public Vector3 offset;
        //private float smoothSpeed = 0.125f;

        public static CameraController instance;

        public void Awake()
        {
            if (instance == null)
            { 
                instance = this;
            }
        }
        public void Update()
        {
            //transform.position = new Vector3(Mathf.Clamp(transform.position.x, leftLimit, rightLimit), 1.82f, -25.65395f);
        }

        //public void FixedUpdate()
        //{
        //    Vector2 desiredPosition = player.transform.position + offset;
        //    Vector2 smoothedPosition = Vector2.Lerp(transform.position, desiredPosition, smoothSpeed);
        //    transform.position = smoothedPosition;
        //    transform.LookAt(player.transform.position);
        //}


        ////stores the offset distance between the player and the camera
        public Vector3 offset;
        public GameObject player;

        private void Start()
        {
            player = GameObject.FindGameObjectWithTag("Player");
            //calculate and store the offset value by finding the distance between the player's position and the camera's position
            offset = transform.position - player.transform.position;
        }

        private void LateUpdate()
        {
            //Set the camera's transform to be the same as the player's, but offset by the calculated offset distance
            transform.position = player.transform.position + offset;
            transform.LookAt(player.transform.position);
        }
    }
}
