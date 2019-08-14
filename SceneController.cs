using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
     public class SceneController : MonoBehaviour
     {

        public static SceneController instance;

        public Button startGameButton;
        public Button exitButton;
        public Button yesButton;
        public Button noButton;
        public Button goBackToMainPanelButton;
        public Button goBackToChallengePanelButton;
        public Button easyToDifficultyPanelButton;
        public Button mediumToDifficultyPanelButton;
        public Button hardToDifficultyPanelButton;
        public Button easyButton;
        public Button mediumButton;
        public Button hardButton;
        public Button level1Button;
        public Button level2Button;
        public Button level3Button;
        public Button level4Button;
        public Button level5Button;
        public Button level6Button;
        public Button level7Button;
        public Button level8Button;
        public Button level9Button;
        public Button level10Button;
        public Button level11Button;
        public Button level12Button;

       

        public Toggle beginner;
        public Toggle advanced;

        public Text text;

        public Text level2Text;
        public Text level3Text;
        public Text level4Text;
        public Text level5Text;
        public Text level6Text;
        public Text level7Text;
        public Text level8Text;
        public Text level9Text;
        public Text level10Text;
        public Text level11Text;
        public Text level12Text;

        public bool boolean;

        public bool isLevelFinished;

        public GameObject exitGamepanel;
        public GameObject mainMenuPanel;
        public GameObject chooseDifficultyPanel;
        public GameObject easyPanel;
        public GameObject mediumPanel;
        public GameObject hardPanel;

        public GameObject lvl1GoldStar;
        public GameObject lvl2GoldStar;
        public GameObject lvl3GoldStar;
        public GameObject lvl4GoldStar;
        public GameObject lvl5GoldStar;
        public GameObject lvl6GoldStar;
        public GameObject lvl7GoldStar;
        public GameObject lvl8GoldStar;
        public GameObject lvl9GoldStar;
        public GameObject lvl10GoldStar;
        public GameObject lvl11GoldStar;
        public GameObject lvl12GoldStar;

        public GameObject padlockImage2;
        public GameObject padlockImage3;
        public GameObject padlockImage4;
        public GameObject padlockImage5;
        public GameObject padlockImage6;
        public GameObject padlockImage7;
        public GameObject padlockImage8;
        public GameObject padlockImage9;
        public GameObject padlockImage10;
        public GameObject padlockImage11;
        public GameObject padlockImage12;

        public GameObject easyHeader;
        public GameObject mediumHeader;
        public GameObject hardHeader;

        private bool isAdvanced;
        private bool isBeginner;

        public void Start()
        {
            AssignButtons();

        }

        public void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
        }

        public void Update()
        {
            //UpdateMainPanel();
        }

        //public void OnBeginnerEnter(bool Value)
        //{
        //    isBeginner = Value;
        //    if (Value && !isAdvanced)
        //    {
        //        text.text = "Beginner";
        //    }
        //    else if(Value && isAdvanced)
        //    {
        //        text.text = "Advanced";
        //    }
        //    else if (!Value && isAdvanced)
        //    {
        //        text.text = "Advanced";
        //    }
        //    else
        //    {
        //        text.text = "";
        //    }          
        //}

        //public void OnAdvancedEnter(bool value)
        //{
        //    isAdvanced = value;
        //    if (value && !isBeginner)
        //    {
        //        text.text = "Advanced";
        //    }
        //    else if (value && isBeginner)
        //    {
        //        text.text = "Advanced";
        //    }
        //    else if (!value && isBeginner)
        //    {
        //        text.text = "Beginner";
        //    }
        //    else
        //    {
        //        text.text = "";
        //    }          
        //}

        public void StartGame()
        {
            mainMenuPanel.SetActive(false);
            chooseDifficultyPanel.SetActive(true);
        }

        public void DisplayExitPanel()
        {
            exitGamepanel.SetActive(true);
        }

        public void ExitGame()
        {
            Application.Quit();
        }

        public void DontExitGame()
        {
            exitGamepanel.SetActive(false);
        }
                      
        public void GoBackToMainPanel()
        {
            chooseDifficultyPanel.SetActive(false);
            mainMenuPanel.SetActive(true);
        }

        //public void ChooseMathsDifficulty()
        //{
        //    PlayerManager.gameChoice = EnumBase.GameChoice.maths;
        //    mainMenuPanel.SetActive(false);
        //    selectChallengePanel.SetActive(false);
        //    chooseDifficultyPanel.SetActive(true);
        //}

        //public void ChoosePuzzleDifficulty()
        //{
        //    PlayerManager.gameChoice = EnumBase.GameChoice.puzzle;
        //    mainMenuPanel.SetActive(false);
        //    selectChallengePanel.SetActive(true);
        //    //gameStatePanel.SetActive(true);
        //    chooseDifficultyPanel.SetActive(true);
        //}
        
        //public void GoBackToGameStatePanel()
        //{
        //    chooseDifficultyPanel.SetActive(false);
        //    mainMenuPanel.SetActive(false);
        //    //gameStatePanel.SetActive(true);
        //}

        public void GoBackToChallengePanel()
        {
            //gameStatePanel.SetActive(false);
            chooseDifficultyPanel.SetActive(true);
            mainMenuPanel.SetActive(false);
        }

        public void ActivateEasyPanel()
        {
            chooseDifficultyPanel.SetActive(false);
            easyPanel.SetActive(true);
            Debug.Log("Easy Button was Clicked");
        }

        public void ActivateMediumPanel()
        {
            mediumPanel.SetActive(true);
        }

        public void ActivateHardPanel()
        {
            hardPanel.SetActive(true);
        }

        public void GoBackToDifficultyPanel()
        {
            easyPanel.SetActive(false);
            mediumPanel.SetActive(false);
            hardPanel.SetActive(false);
            chooseDifficultyPanel.SetActive(true);
        }

        public void LoadLevel()
        {
            if (PlayerManager.difficulties == EnumBase.Difficulties.easy)
            {
                SceneManager.LoadScene(1);
            }
            else if (PlayerManager.difficulties == EnumBase.Difficulties.medium)
            {
                SceneManager.LoadScene(13);
            }
            else if (PlayerManager.difficulties == EnumBase.Difficulties.hard)
            {
                SceneManager.LoadScene(25);
            }
            
        }

        public void LoadLeveel1()
        {
            PlayerManager.level = 1;
        }

        public void LoadLeveel2()
        {
            PlayerManager.level = 2;
        }

        public void LoadLeveel3()
        {
            PlayerManager.level = 3;
        }

        public void LoadLeveel4()
        {
            PlayerManager.level = 4;
        }

        public void LoadLeveel5()
        {
            PlayerManager.level = 5;
        }

        public void LoadLeveel6()
        {
            PlayerManager.level = 6;
        }
        public void LoadLeveel7()
        {
            PlayerManager.level = 7;
        }
        public void LoadLeveel8()
        {
            PlayerManager.level = 8;
        }
        public void LoadLeveel9()
        {
            PlayerManager.level = 9;
        }
        public void LoadLeveel10()
        {
            PlayerManager.level = 10;
        }
        public void LoadLeveel11()
        {
            PlayerManager.level = 11;
        }
        public void LoadLeveel12()
        {
            PlayerManager.level = 12;
        }

        public void ActivateEasyHeader()
        {
            PlayerManager.difficulties = EnumBase.Difficulties.easy;
            //numberOfDoorCollisions = 2;
            easyHeader.SetActive(true);
            mediumHeader.SetActive(false);
            hardHeader.SetActive(false);
            chooseDifficultyPanel.SetActive(false);
            easyPanel.SetActive(true);
        }

        public void ActivateMediumHeader()
        {
            PlayerManager.difficulties = EnumBase.Difficulties.medium;
            //numberOfDoorCollisions = 3;
            easyHeader.SetActive(false);
            mediumHeader.SetActive(true);
            hardHeader.SetActive(false);
            chooseDifficultyPanel.SetActive(false);
            easyPanel.SetActive(true);
        }

        public void ActivateHardHeader()
        {
            PlayerManager.difficulties = EnumBase.Difficulties.hard;
            //numberOfDoorCollisions = 4;
            easyHeader.SetActive(false);
            mediumHeader.SetActive(false);
            hardHeader.SetActive(true);
            chooseDifficultyPanel.SetActive(false);
            easyPanel.SetActive(true);
        }

        //public void UpdateMainPanel()
        //{
        //    if (CoinManager.totalNumberOfPickupsCollected == UIManager.instance.currentLevelTotalNumberOfPickups && PlayerManager.level == 1)
        //    {
        //        lvl1GoldStar.SetActive(true);
        //    }
        //    else if (CoinManager.totalNumberOfPickupsCollected == UIManager.instance.currentLevelTotalNumberOfPickups && PlayerManager.level == 2)
        //    {
        //        lvl2GoldStar.SetActive(true);
        //        padlockImage2.SetActive(false);
        //        level2Text.text = "2";
        //    }
        //    else if (CoinManager.totalNumberOfPickupsCollected == UIManager.instance.currentLevelTotalNumberOfPickups && PlayerManager.level == 3)
        //    {
        //        lvl3GoldStar.SetActive(true);
        //        padlockImage3.SetActive(false);
        //        level3Text.text = "3";
        //    }
        //    else if (CoinManager.totalNumberOfPickupsCollected == UIManager.instance.currentLevelTotalNumberOfPickups && PlayerManager.level == 4)
        //    {
        //        lvl4GoldStar.SetActive(true);
        //        padlockImage4.SetActive(false);
        //        level4Text.text = "4";
        //    }
        //    else if (CoinManager.totalNumberOfPickupsCollected == UIManager.instance.currentLevelTotalNumberOfPickups && PlayerManager.level == 5)
        //    {
        //        lvl5GoldStar.SetActive(true);
        //        padlockImage5.SetActive(false);
        //        level5Text.text = "5";
        //    }
        //    else if (CoinManager.totalNumberOfPickupsCollected == UIManager.instance.currentLevelTotalNumberOfPickups && PlayerManager.level == 6)
        //    {
        //        lvl1GoldStar.SetActive(true);
        //        padlockImage6.SetActive(false);
        //        level6Text.text = "6";
        //    }
        //    else if (CoinManager.totalNumberOfPickupsCollected == UIManager.instance.currentLevelTotalNumberOfPickups && PlayerManager.level == 7)
        //    {
        //        lvl1GoldStar.SetActive(true);
        //        padlockImage7.SetActive(false);
        //        level7Text.text = "7";
        //    }
        //    else if (CoinManager.totalNumberOfPickupsCollected == UIManager.instance.currentLevelTotalNumberOfPickups && PlayerManager.level == 8)
        //    {
        //        lvl8GoldStar.SetActive(true);
        //        padlockImage8.SetActive(false);
        //        level8Text.text = "8";
        //    }
        //    else if (CoinManager.totalNumberOfPickupsCollected == UIManager.instance.currentLevelTotalNumberOfPickups && PlayerManager.level == 9)
        //    {
        //        lvl1GoldStar.SetActive(true);
        //        padlockImage9.SetActive(false);
        //        level9Text.text = "9";
        //    }
        //    else if (CoinManager.totalNumberOfPickupsCollected == UIManager.instance.currentLevelTotalNumberOfPickups && PlayerManager.level == 10)
        //    {
        //        lvl10GoldStar.SetActive(true);
        //        padlockImage10.SetActive(false);
        //        level10Text.text = "10";
        //    }
        //    else if (CoinManager.totalNumberOfPickupsCollected == UIManager.instance.currentLevelTotalNumberOfPickups && PlayerManager.level == 11)
        //    {
        //        lvl11GoldStar.SetActive(true);
        //        padlockImage11.SetActive(false);
        //        level11Text.text = "11";
        //    }
        //    else if (CoinManager.totalNumberOfPickupsCollected == UIManager.instance.currentLevelTotalNumberOfPickups && PlayerManager.level == 12)
        //    {
        //        lvl12GoldStar.SetActive(true);
        //        padlockImage12.SetActive(false);
        //        level12Text.text = "12";
        //    }
        //    else
        //    {
        //        return;
        //    }
        //}



        public void AssignButtons()
        {
            startGameButton.onClick.AddListener(delegate { StartGame(); });
            exitButton.onClick.AddListener(delegate { DisplayExitPanel(); });
            yesButton.onClick.AddListener(delegate { ExitGame(); });
            noButton.onClick.AddListener(delegate { DontExitGame(); });
            //goBackToMainPanelButton.onClick.AddListener(delegate { GoBackToMainPanel(); });
            //mathsButton.onClick.AddListener(delegate { ChooseMathsDifficulty(); });
            //puzzleButton.onClick.AddListener(delegate { ChoosePuzzleDifficulty(); });
            goBackToChallengePanelButton.onClick.AddListener(delegate { GoBackToMainPanel(); });
            //goBackTogameChoicePanelButton.onClick.AddListener(delegate { GoBackToChallengePanel(); });
            //beginner.onValueChanged.AddListener(x => OnBeginnerEnter(x));
            //advanced.onValueChanged.AddListener(x => OnAdvancedEnter(x));

            easyButton.onClick.AddListener(delegate { ActivateEasyHeader(); });
            mediumButton.onClick.AddListener(delegate { ActivateMediumHeader(); });
            hardButton.onClick.AddListener(delegate { ActivateHardHeader(); });
            easyToDifficultyPanelButton.onClick.AddListener(delegate { GoBackToDifficultyPanel(); });
            mediumToDifficultyPanelButton.onClick.AddListener(delegate { GoBackToDifficultyPanel(); });
            hardToDifficultyPanelButton.onClick.AddListener(delegate { GoBackToDifficultyPanel(); });
            //newGameButton.onClick.AddListener(delegate { ChooseGameState(); });

            level1Button.onClick.AddListener(delegate { LoadLevel(); });
        }
     }
}
