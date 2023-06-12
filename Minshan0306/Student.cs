using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minshan0306
{
    internal class Student
    {
    }
    public class StuScore
    {
        public string Name { get; set; }
        public int Chinese { get; set; }
        public int English { get; set; }
        public int Math { get; set; }

        public StuScore(string name, int chinese, int english, int math)
        {
            Name = name;
            Chinese = chinese;
            English = english;
            Math = math;
        }

        public bool IsValid()
        {
            return Chinese <= 100 && English <= 100 && Math <= 100;
        }

        public int[] GetScoresArray()
        {
            return new int[] { Chinese, English, Math };
        }

        public int GetMaxScore()
        {
            return GetScoresArray().Max();
        }

        public int GetMinScore()
        {
            return GetScoresArray().Min();
        }

        public int GetAvgScore()
        {
            return (int)GetScoresArray().Average();
        }

        public int GetSumScore()
        {
            return (int)GetScoresArray().Sum();
        }

        public string GetScoreResult()
        {
            return $"{Name,15}{Chinese,20}{English,20}{Math,20}{GetSumScore(),20}{GetAvgScore(),20}{GetMinScore(),20}{GetMaxScore(),20}\n";
        }

       //"                    "
    }

}



