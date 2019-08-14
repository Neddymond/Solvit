using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    class DoorOpenner : MonoBehaviour
    {
        public GameObject door;

        PlayerManager player;

        public void Start()
        {
            player = new PlayerManager();
        }

        public void Update()
        {

        }

        public void OnCollisionEnter2D(Collision2D obstacle)
        {
            if (obstacle.gameObject.CompareTag("Door"))
            {
                player.runSpeed = 0f;
                player.ShowQuestion();
            }
        }
    }
}
