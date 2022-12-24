using AdventCalendar.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventCalendar
{
    public static class RucksackReorganization
    {
        public static void PrioritiesOfItemsInRucksacksCalculate()
        {
            var rucksacksContent = RucksackReorganizationData.rucksackContent.Split("\r\n");
            var priorities = new List<char>();
            var sumOfThePriorities = 0;

            foreach (var item in rucksacksContent)
            {
                StringBuilder sb = new StringBuilder(item);
                int firstHalfLength = item.Length / 2;
                int secondHalfLength = item.Length - firstHalfLength;

                var firstHalfString = item.Substring(0, firstHalfLength);
                var secondHalfString = item.Substring(firstHalfLength, secondHalfLength);

                foreach (var l in firstHalfString)
                {
                    if (secondHalfString.Contains(l))
                    {
                        priorities.Add(l);
                        break;
                    }
                }
            }

            foreach (var letter in priorities)
            {

                if (letter == 'a')
                {
                    sumOfThePriorities += 1;
                }
                else if (letter == 'b')
                {
                    sumOfThePriorities += 2;
                }
                else if (letter == 'c')
                {
                    sumOfThePriorities += 3;
                }
                else if (letter == 'd')
                {
                    sumOfThePriorities += 4;
                }
                else if (letter == 'e')
                {
                    sumOfThePriorities += 5;
                }
                else if (letter == 'f')
                {
                    sumOfThePriorities += 6;
                }
                else if (letter == 'g')
                {
                    sumOfThePriorities += 7;
                }
                else if (letter == 'h')
                {
                    sumOfThePriorities += 8;
                }
                else if (letter == 'i')
                {
                    sumOfThePriorities += 9;
                }
                else if (letter == 'j')
                {
                    sumOfThePriorities += 10;
                }
                else if (letter == 'k')
                {
                    sumOfThePriorities += 11;
                }
                else if (letter == 'l')
                {
                    sumOfThePriorities += 12;
                }
                else if (letter == 'm')
                {
                    sumOfThePriorities += 13;
                }
                else if (letter == 'n')
                {
                    sumOfThePriorities += 14;
                }
                else if (letter == 'o')
                {
                    sumOfThePriorities += 15;
                }
                else if (letter == 'p')
                {
                    sumOfThePriorities += 16;
                }
                else if (letter == 'q')
                {
                    sumOfThePriorities += 17;
                }
                else if (letter == 'r')
                {
                    sumOfThePriorities += 18;
                }
                else if (letter == 's')
                {
                    sumOfThePriorities += 19;
                }
                else if (letter == 't')
                {
                    sumOfThePriorities += 20;
                }
                else if (letter == 'u')
                {
                    sumOfThePriorities += 21;
                }
                else if (letter == 'v')
                {
                    sumOfThePriorities += 22;
                }
                else if (letter == 'w')
                {
                    sumOfThePriorities += 23;
                }
                else if (letter == 'x')
                {
                    sumOfThePriorities += 24;
                }
                else if (letter == 'y')
                {
                    sumOfThePriorities += 25;
                }
                else if (letter == 'z')
                {
                    sumOfThePriorities += 26;
                }
                else if (letter == 'A')
                {
                    sumOfThePriorities += 27;
                }
                else if (letter == 'B')
                {
                    sumOfThePriorities += 28;
                }
                else if (letter == 'C')
                {
                    sumOfThePriorities += 29;
                }
                else if (letter == 'D')
                {
                    sumOfThePriorities += 30;
                }
                else if (letter == 'E')
                {
                    sumOfThePriorities += 31;
                }
                else if (letter == 'F')
                {
                    sumOfThePriorities += 32;
                }
                else if (letter == 'G')
                {
                    sumOfThePriorities += 33;
                }
                else if (letter == 'H')
                {
                    sumOfThePriorities += 34;
                }
                else if (letter == 'I')
                {
                    sumOfThePriorities += 35;
                }
                else if (letter == 'J')
                {
                    sumOfThePriorities += 36;
                }
                else if (letter == 'K')
                {
                    sumOfThePriorities += 37;
                }
                else if (letter == 'L')
                {
                    sumOfThePriorities += 38;
                }
                else if (letter == 'M')
                {
                    sumOfThePriorities += 39;
                }
                else if (letter == 'N')
                {
                    sumOfThePriorities += 40;
                }
                else if (letter == 'O')
                {
                    sumOfThePriorities += 41;
                }
                else if (letter == 'P')
                {
                    sumOfThePriorities += 42;
                }
                else if (letter == 'Q')
                {
                    sumOfThePriorities += 43;
                }
                else if (letter == 'R')
                {
                    sumOfThePriorities += 44;
                }
                else if (letter == 'S')
                {
                    sumOfThePriorities += 45;
                }
                else if (letter == 'T')
                {
                    sumOfThePriorities += 46;
                }
                else if (letter == 'U')
                {
                    sumOfThePriorities += 47;
                }
                else if (letter == 'V')
                {
                    sumOfThePriorities += 48;
                }
                else if (letter == 'W')
                {
                    sumOfThePriorities += 49;
                }
                else if (letter == 'X')
                {
                    sumOfThePriorities += 50;
                }
                else if (letter == 'Y')
                {
                    sumOfThePriorities += 51;
                }
                else
                {
                    sumOfThePriorities += 52;
                }
            }


            Console.WriteLine("Suma: " + sumOfThePriorities);
        }

        public static void PrioritiesOfGroupsCalculate()
        {
            var rucksacksContent = RucksackReorganizationData.rucksackContent.Split("\r\n");
            var groupRucksacks = new List<List<string>>();
            var tempList = new List<string>();
            var priorities = new List<char>();
            var sumOfThePriorities = 0;

            for (int i = 0; i < rucksacksContent.Length; i++)
            {
                tempList.Add(rucksacksContent[i]);

                if (tempList.Count == 3)
                {
                    groupRucksacks.Add(tempList.Select(item => item).ToList());
                    tempList.Clear();
                }
            }

            foreach (var group in groupRucksacks)
            {

                for (int i = 0; i < group.Count; i++)
                {
                    foreach (var letter in group[i])
                    {
                        if(group[0].Contains(letter) && group[1].Contains(letter) && group[2].Contains(letter))
                        {
                            priorities.Add(letter);
                            break;
                        }
                    }
                    break;
                }
            }

            foreach (var letter in priorities)
            {
                if (letter == 'a')
                {
                    sumOfThePriorities += 1;
                }
                else if (letter == 'b')
                {
                    sumOfThePriorities += 2;
                }
                else if (letter == 'c')
                {
                    sumOfThePriorities += 3;
                }
                else if (letter == 'd')
                {
                    sumOfThePriorities += 4;
                }
                else if (letter == 'e')
                {
                    sumOfThePriorities += 5;
                }
                else if (letter == 'f')
                {
                    sumOfThePriorities += 6;
                }
                else if (letter == 'g')
                {
                    sumOfThePriorities += 7;
                }
                else if (letter == 'h')
                {
                    sumOfThePriorities += 8;
                }
                else if (letter == 'i')
                {
                    sumOfThePriorities += 9;
                }
                else if (letter == 'j')
                {
                    sumOfThePriorities += 10;
                }
                else if (letter == 'k')
                {
                    sumOfThePriorities += 11;
                }
                else if (letter == 'l')
                {
                    sumOfThePriorities += 12;
                }
                else if (letter == 'm')
                {
                    sumOfThePriorities += 13;
                }
                else if (letter == 'n')
                {
                    sumOfThePriorities += 14;
                }
                else if (letter == 'o')
                {
                    sumOfThePriorities += 15;
                }
                else if (letter == 'p')
                {
                    sumOfThePriorities += 16;
                }
                else if (letter == 'q')
                {
                    sumOfThePriorities += 17;
                }
                else if (letter == 'r')
                {
                    sumOfThePriorities += 18;
                }
                else if (letter == 's')
                {
                    sumOfThePriorities += 19;
                }
                else if (letter == 't')
                {
                    sumOfThePriorities += 20;
                }
                else if (letter == 'u')
                {
                    sumOfThePriorities += 21;
                }
                else if (letter == 'v')
                {
                    sumOfThePriorities += 22;
                }
                else if (letter == 'w')
                {
                    sumOfThePriorities += 23;
                }
                else if (letter == 'x')
                {
                    sumOfThePriorities += 24;
                }
                else if (letter == 'y')
                {
                    sumOfThePriorities += 25;
                }
                else if (letter == 'z')
                {
                    sumOfThePriorities += 26;
                }
                else if (letter == 'A')
                {
                    sumOfThePriorities += 27;
                }
                else if (letter == 'B')
                {
                    sumOfThePriorities += 28;
                }
                else if (letter == 'C')
                {
                    sumOfThePriorities += 29;
                }
                else if (letter == 'D')
                {
                    sumOfThePriorities += 30;
                }
                else if (letter == 'E')
                {
                    sumOfThePriorities += 31;
                }
                else if (letter == 'F')
                {
                    sumOfThePriorities += 32;
                }
                else if (letter == 'G')
                {
                    sumOfThePriorities += 33;
                }
                else if (letter == 'H')
                {
                    sumOfThePriorities += 34;
                }
                else if (letter == 'I')
                {
                    sumOfThePriorities += 35;
                }
                else if (letter == 'J')
                {
                    sumOfThePriorities += 36;
                }
                else if (letter == 'K')
                {
                    sumOfThePriorities += 37;
                }
                else if (letter == 'L')
                {
                    sumOfThePriorities += 38;
                }
                else if (letter == 'M')
                {
                    sumOfThePriorities += 39;
                }
                else if (letter == 'N')
                {
                    sumOfThePriorities += 40;
                }
                else if (letter == 'O')
                {
                    sumOfThePriorities += 41;
                }
                else if (letter == 'P')
                {
                    sumOfThePriorities += 42;
                }
                else if (letter == 'Q')
                {
                    sumOfThePriorities += 43;
                }
                else if (letter == 'R')
                {
                    sumOfThePriorities += 44;
                }
                else if (letter == 'S')
                {
                    sumOfThePriorities += 45;
                }
                else if (letter == 'T')
                {
                    sumOfThePriorities += 46;
                }
                else if (letter == 'U')
                {
                    sumOfThePriorities += 47;
                }
                else if (letter == 'V')
                {
                    sumOfThePriorities += 48;
                }
                else if (letter == 'W')
                {
                    sumOfThePriorities += 49;
                }
                else if (letter == 'X')
                {
                    sumOfThePriorities += 50;
                }
                else if (letter == 'Y')
                {
                    sumOfThePriorities += 51;
                }
                else
                {
                    sumOfThePriorities += 52;
                }
            }
            Console.WriteLine(sumOfThePriorities);

        }
    }
}



