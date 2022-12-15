using AdventCalendar.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventCalendar
{
    public class RockPaperScissors
    {
        public static void CalculateTotalScore()
        {
            var gameData = RockPaperScissorsData.input.Split("\r\n");
            var totalScore = 0;

            for (int i = 0; i < gameData.Length; i++)
            {
                var calculateData = gameData[i].Split(" ");

                if(calculateData[0] == "A" && calculateData[1] == "X")
                {
                    totalScore += 4;
                   
                }
                else if (calculateData[0] == "B" && calculateData[1] == "Y")
                {
                    totalScore += 5;

                }
                else if (calculateData[0] == "C" && calculateData[1] == "Z")
                {
                    totalScore += 6;

                }
                else if (calculateData[0] == "A" && calculateData[1] == "Y")
                {
                    totalScore += 8;

                }
                else if (calculateData[0] == "B" && calculateData[1] == "Z")
                {
                    totalScore += 9;

                }
                else if (calculateData[0] == "C" && calculateData[1] == "X")
                {
                    totalScore += 7;

                }
                else if (calculateData[0] == "A" && calculateData[1] == "Z")
                {
                    totalScore += 3;

                }
                else if (calculateData[0] == "B" && calculateData[1] == "X")
                {
                    totalScore += 1;

                }
                else
                {
                    totalScore += 2;

                }
                Console.WriteLine(gameData[i]);
            }
                Console.WriteLine(totalScore);
        }

        public static void CalculateScoreWithInstructions()
        {
            var gameData = RockPaperScissorsData.input.Split("\r\n");
            var totalScore = 0;

            for (int i = 0; i < gameData.Length; i++)
            {
                var calculateData = gameData[i].Split(" ");

                if(calculateData[0] == "A" && calculateData[1] == "X")
                {
                    totalScore += 3;
                }
                else if (calculateData[0] == "A" && calculateData[1] == "Y")
                {
                    totalScore += 4;
                }
                else if (calculateData[0] == "A" && calculateData[1] == "Z")
                {
                    totalScore += 8;
                }
                else if (calculateData[0] == "B" && calculateData[1] == "X")
                {
                    totalScore += 1;
                }
                else if (calculateData[0] == "B" && calculateData[1] == "Y")
                {
                    totalScore += 5;
                }
                else if (calculateData[0] == "B" && calculateData[1] == "Z")
                {
                    totalScore += 9;
                }
                else if (calculateData[0] == "C" && calculateData[1] == "X")
                {
                    totalScore += 2;
                }
                else if (calculateData[0] == "C" && calculateData[1] == "Y")
                {
                    totalScore += 6;
                }
                else
                {
                    totalScore += 7;
                }
            }

            Console.WriteLine(totalScore);
        }
    }
}
