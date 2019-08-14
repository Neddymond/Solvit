using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using System.Text;

namespace Assets.Scripts
{
    class LapTimeManager : MonoBehaviour
    {
        public static float milliCount;
        public static int secondCount = 0;
        public static int minuteCount = 5;

        public Text milliText;
        public Text secondText;
        public Text minuteText;


        public void Start()
        {
            StartCoroutine("CountDown");
        }

        private IEnumerator CountDown()
        {
            //secondCount = 59;
            //minuteCount = 1;

            while (true)
            {
                minuteText.text = minuteCount.ToString("F0") + ":"; 
                secondText.text = secondCount.ToString("F0");

                //if (secondCount <= -1)
                //{
                //    secondCount = 60;
                //    minuteCount -= 1;
                //}

                if (secondCount == 0)
                {
                    secondCount = 59;
                    minuteCount--;
                }
                else
                {
                    secondCount--;
                }

                if (secondCount <= 9)
                {
                    secondText.text = "0" + secondCount;
                }
                else
                {
                    secondText.text = "" + secondCount;
                }

                yield return new WaitForSeconds(1);
                secondCount -= 1;

                //if (minuteCount == -1)
                //{
                //    //secondText.text = "00";
                //    yield break;
                //}

                if (minuteCount == 0 && secondCount == 0)
                {
                    yield break;
                }
            }

        }

       









    }
}
