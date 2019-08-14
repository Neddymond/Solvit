using Assets.Scripts;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class PuzzleController : MonoBehaviour
{
    //PlayerManager playerManager;

    public GameObject puzzleQuestionBackground;
    public GameObject explanationPanel;
    public GameObject correctText;
    public GameObject questionPanel;
    public GameObject correctPanel;

    public Button answerButton;
    public Button wrongAnswer1Button;
    public Button wrongAnswer2Button;
    public Button wrongAnswer3Button;

    public static PuzzleController instance;


    //public EnumBase.GameChoice gameChoice;
    public EnumBase.Difficulties difficulties;

    private void Awake()
    {
        instance = this;
    }

    
    public void DisplayPuzzleQuestion()
    {
        puzzleQuestionBackground.SetActive(true);
    }

   
    public void ShowExplanationPanel()
    {
        explanationPanel.SetActive(true);
    }

    public class PuzzleContoller
    {
        public string puzzleQuestions;
    }

   
}
