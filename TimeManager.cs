using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    class TimeManager : MonoBehaviour
    {
        UIManager iManager;
        public Text timerText;
        public static float countDownTime = 299;

        public void Start()
        {
            StartCoroutine(CountDown());
            iManager = GetComponent<UIManager>();
        }
        
        public IEnumerator CountDown()
        {
            while (true)
            {
                int minutes = Mathf.FloorToInt(countDownTime / 60f);
                int seconds = Mathf.FloorToInt(countDownTime - minutes * 60);

                string niceTime = string.Format("{0:0}:{1:00}", minutes, seconds);
                timerText.text = niceTime;

                yield return new WaitForSeconds(1);
                countDownTime--;

                if (minutes == 0 && seconds == 0)
                {
                    UIManager.instance.SetGameOverPanelTrue();
                    UIManager.instance.sound.PlayOneShot(AudioManager.instance.gameoverSound);
                    yield break;                   
                }
            }
        }
    }
}
