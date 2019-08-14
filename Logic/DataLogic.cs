using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Logical
{
    public static class DataLogic
    {
        public static string GenerateQuestionString(List<int> numbers, List<string> operators)
        {
            string Question = "";
            for (int i = 0; i < operators.Count; i++)
            {
                Question += numbers[i];
                Question += " ";
                Question += operators[i];
                Question += " ";
            }
            Question += numbers[numbers.Count - 1];

            Question += " =_";
            return Question;
        }

    }
}
    
 
