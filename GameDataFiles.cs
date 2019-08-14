using System;
using System.Collections.Generic;

namespace Assets.Scripts
{
    public class GameDataFiles 
    {
        public int level;
        public int totalStarsCount;
        public int coinsCollected;
        public int highScore;
        public bool isUnlocked;
    }

    public class GameDifficultyData
    {
        public List<GameDataFiles> easy;
        public List<GameDataFiles> medium;
        public List<GameDataFiles> hard;
    }

    public class GameChoiceData
    {
        public GameDifficultyData Maths;
        public GameDifficultyData Puzzle;
    }
}
