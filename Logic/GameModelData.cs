using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Logic
{
    class GameModelData: MonoBehaviour
    {
        TextAsset fileData;
        public GameDifficultyData difficultyData;
        EnumBase.Difficulties difficulties;
        public string fileName = " ";

        private void Start()
        {
        }

        private void SaveGameMode(GameDataFiles LevelData)
        {
            fileName = "GameModel";
            fileData = Resources.Load<TextAsset>(fileName);

            switch (difficulties)
            {
                case EnumBase.Difficulties.easy:
                    difficultyData.easy[LevelData.level - 1].coinsCollected = LevelData.coinsCollected;
                    break;
                case EnumBase.Difficulties.medium:
                    difficultyData.medium[LevelData.level - 1].coinsCollected = LevelData.coinsCollected;
                    break;
                case EnumBase.Difficulties.hard:
                    difficultyData.hard[LevelData.level - 1].coinsCollected = LevelData.coinsCollected;
                    break;
                default:
                    break;
            }


        }

      
    }
}

