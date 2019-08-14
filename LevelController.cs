using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts
{
    
    public class LevelController
    {
        
        public static LevelModel LevelDifficulty(EnumBase.Difficulties difficulties, int level)
        {
            LevelModel model = new LevelModel();
            
            switch (difficulties)
            {
                case EnumBase.Difficulties.easy:
                    if (difficulties == EnumBase.Difficulties.easy && level > 0 && level < 5)
                    {
                        model.operators = new List<string>() { "+" };
                        model.minNumber = 1;
                        model.maxNUmber = 10;
                        model.operatorIndex = 1;
                    }
                    else if (difficulties == EnumBase.Difficulties.easy && level >= 5 && level < 9)
                    {
                        model.operators = new List<string>() { "+", "-" };
                        model.minNumber = 1;
                        model.maxNUmber = 20;
                        model.operatorIndex = 1;
                    }
                    else if (difficulties == EnumBase.Difficulties.easy && level >= 9 && level < 13)
                    {
                        model.operators = new List<string>() { "+", "-" };
                        model.minNumber = 1;
                        model.maxNUmber = 100;
                        model.operatorIndex = 1;
                    }
                    break;
                case EnumBase.Difficulties.medium:
                    if (difficulties == EnumBase.Difficulties.medium && level > 0 && level < 5)
                    {
                        model.operators = new List<string>() { "+", "-" };
                        model.minNumber = 1;
                        model.maxNUmber = 100;
                        model.operatorIndex = 1;
                    }
                    else if (difficulties == EnumBase.Difficulties.medium && level >= 5 && level < 9)
                    {
                        model.operatorIndex = 1;
                        model.operators = new List<string>() { "+", "-" };
                        model.minNumber = 1;
                        model.maxNUmber = 100;
                        model.operatorIndex = 1;
                    }
                    else if (difficulties == EnumBase.Difficulties.medium && level >= 9 && level < 13)
                    {
                        model.operators = new List<string>() { "+", "-", "*", "/" };
                        model.minNumber = 1;
                        model.maxNUmber = 100;
                        model.operatorIndex = 2;
                    }
                    break;
                case EnumBase.Difficulties.hard:
                    if(difficulties == EnumBase.Difficulties.hard && level > 0 && level < 5)
                    {
                        model.operators = new List<string>() { "+", "-", "*", "/"};
                        model.minNumber = 1;
                        model.maxNUmber = 100;
                        model.operatorIndex = 2;
                    }
                    else if (difficulties == EnumBase.Difficulties.hard && level >= 5 && level < 9)
                    {
                        model.operatorIndex = 2;
                        model.operators = new List<string>() { "+", "-", "*", "/" };
                        model.minNumber = 1;
                        model.maxNUmber = 100;
                    }
                    else if (difficulties == EnumBase.Difficulties.hard && level >= 9 && level < 13)
                    {
                        model.operatorIndex = 2;
                        model.operators = new List<string>() { "+", "-", "*", "/" };
                        model.minNumber = 1;
                        model.maxNUmber = 100;
                    }
                    break;
                default:
                    break;
            }
            return model;
        }
    }

    

}
