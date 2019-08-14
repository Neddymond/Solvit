using UnityEngine;
using System.Collections;
using Newtonsoft.Json;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Linq;
using Assets.Scripts;

public class PuzzleManager : MonoBehaviour
{
    public GameObject puzzleQuestionBackground;
    public GameObject explanationPanel;
    public GameObject correctText;
    public GameObject questionPanel;

    public Text questionText;
    public Text answerButtonText;
    public Text wrongAnswer1ButtonText;
    public Text wrongAnswer2ButtonText;
    public Text wrongAnswer3ButtonText;

    public GameObject correctPanel;
    public Button answerButton;
    public Button wrongAnswer1Button;
    public Button wrongAnswer2Button;
    public Button wrongAnswer3Button;

    //public static PuzzleManager instance;

    //public EnumBase.GameChoice gameChoice;
    public EnumBase.Difficulties difficulties;
    public EnumBase.GameLevels gameLevels;

    public string[] reshuffledData;
    public string puzzleAnswer;
 

    public List<PuzzleData> puzzleData;
    TextAsset fileData;
    string fileName = "";
    public void Awake()
    {
        //instance = this;
    }

    // Use this for initialization
    void Start()
    {
        fileData = Resources.Load<TextAsset>("EasyLevel1");
        puzzleData = JsonConvert.DeserializeObject<List<PuzzleData>>(fileData.text);
        Debug.Log(puzzleData[0].question);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public PuzzleData GetPuzzleQuestion(EnumBase.Difficulties Difficulty, int Level)
    {
        
        puzzleData = new List<PuzzleData>();
        switch (Difficulty)
        {
            case EnumBase.Difficulties.easy:
                fileName = "EasyLevel" + Level;
                fileData = Resources.Load<TextAsset>(fileName);
                puzzleData = JsonConvert.DeserializeObject<List<PuzzleData>>(fileData.text);
                System.Random rand = new System.Random();
                int index = rand.Next(0,3);
                return puzzleData[index];
                
            case EnumBase.Difficulties.medium:
                fileName = "MediumLevel" + Level;
                fileData = Resources.Load<TextAsset>(fileName);
                puzzleData = JsonConvert.DeserializeObject<List<PuzzleData>>(fileData.text);
                System.Random random = new System.Random();
                int i = random.Next(0, 3);
                return puzzleData[i];

            case EnumBase.Difficulties.hard:
                fileName = "HardLevel" + Level;
                fileData = Resources.Load<TextAsset>(fileName);
                puzzleData = JsonConvert.DeserializeObject<List<PuzzleData>>(fileData.text);
                System.Random randomm = new System.Random();
                int num = randomm.Next(0, 3);
                return puzzleData[num];
        }

        return puzzleData[0];
    }


    
    public void AssignPuzzleData(PuzzleData puzzleData)
    {
        //puzzleData = new List<PuzzleData>();
        questionText.text = puzzleData.question;
        puzzleAnswer = puzzleData.answer;

        System.Random random = new System.Random();
        string[] puzzleButtonOptions = new string[]
        {
            puzzleData.answer,
            puzzleData.wrongAnswer1,
            puzzleData.wrongAnswer2,
            puzzleData.wrongAnswer3,
        };

        if (puzzleData.answer == puzzleData.wrongAnswer1 || puzzleData.answer == puzzleData.wrongAnswer2 || puzzleData.answer == puzzleData.wrongAnswer3 || puzzleData.wrongAnswer1 == puzzleData.wrongAnswer2 || puzzleData.wrongAnswer1 == puzzleData.wrongAnswer3 || puzzleData.wrongAnswer2 == puzzleData.wrongAnswer3)
        {
            AssignPuzzleData(puzzleData);
            return;
        }

        reshuffledData = puzzleButtonOptions.OrderBy(x => random.Next()).ToArray();

        answerButtonText.text = reshuffledData[0];
        wrongAnswer1ButtonText.text = reshuffledData[1];
        wrongAnswer2ButtonText.text = reshuffledData[2];
        wrongAnswer3ButtonText.text = reshuffledData[3];

        //answerButton.onClick.AddListener(delegate { PlayerManager.instance.checkPuzzleAnswer(reshuffledData[0]); });
        //wrongAnswer1Button.onClick.AddListener(delegate { PlayerManager.instance.checkPuzzleAnswer(reshuffledData[1]); });
        //wrongAnswer2Button.onClick.AddListener(delegate { PlayerManager.instance.checkPuzzleAnswer(reshuffledData[2]); });
        //wrongAnswer3Button.onClick.AddListener(delegate { PlayerManager.instance.checkPuzzleAnswer(reshuffledData[3]); });

        puzzleQuestionBackground.SetActive(true);
    }
}
