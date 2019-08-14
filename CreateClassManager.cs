using System;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    class CreateClassManager : MonoBehaviour
    {
        public Toggle isWarrior;
        public Toggle isMage;
        public Toggle isPriest;

        public Button submit;

        public void Start()
        {
            AssignButton();
        }

        public void ToggleCheck()
        {
            if (isWarrior.isOn)
            {
                Debug.Log("Player Selected Warrior");
            }
            else if (isMage.isOn)
            {
                Debug.Log("Player Selected Mage");
            }
            else if (isPriest.isOn)
            {
                Debug.Log("Player Selected Priest");
            }
        }

        public void SubmitSelect()
        {
            Debug.Log("Selecting Toggle");
            ToggleCheck();
        }

        public void AssignButton()
        {
            submit.onClick.AddListener(delegate { SubmitSelect(); });
        }
    }
}
