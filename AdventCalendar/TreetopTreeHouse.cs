using AdventCalendar.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventCalendar
{
    public class TreetopTreeHouse
    {
        public static void CalculateVisibleTrees()
        {

            var input = TreetopTreeHouseData.treeInput.Split("\r\n");

            int visibleTrees = 0;

            var forest = new List<List<int>>();

            foreach (var line in input)
            {
                var row = new List<int>();

                foreach (char tree in line)
                {
                    row.Add(int.Parse(tree.ToString()));
                }

                forest.Add(row);
            }

            visibleTrees += (forest.Count * 2) + (forest[0].Count * 2) - 4;

            for (int row = 1; row < forest.Count - 1; row++)
            {
                for (int column = 1; column < forest[row].Count - 1; column++)
                {
                    int currentTreeHeight = forest[row][column];

                    bool isTreeVisible = true;

                    //Checking left side

                    for (int leftColumn = column - 1; leftColumn >= 0; leftColumn--)
                    {
                        if (forest[row][leftColumn] >= currentTreeHeight)
                        {
                            isTreeVisible = false;
                            break;
                        }
                    }
                    if (isTreeVisible)
                    {
                        visibleTrees++;
                        continue;
                    }
                    isTreeVisible = true;

                    //Checking right side

                    for (int rightColumn = column + 1; rightColumn < forest[row].Count; rightColumn++)
                    {
                        if (forest[row][rightColumn] >= currentTreeHeight)
                        {
                            isTreeVisible = false;
                            break;
                        }
                    }
                    if (isTreeVisible)
                    {
                        visibleTrees++;
                        continue;
                    }
                    isTreeVisible = true;

                    //Checking above

                    for (int rowAbove = row - 1; rowAbove >= 0; rowAbove--)
                    {
                        if (forest[rowAbove][column] >= currentTreeHeight)
                        {
                            isTreeVisible = false;
                            break;
                        }
                    }
                    if (isTreeVisible)
                    {
                        visibleTrees++;
                        continue;
                    }
                    isTreeVisible = true;

                    //Checking Below

                    for (int rowBelow = row + 1; rowBelow < forest.Count; rowBelow++)
                    {
                        if (forest[rowBelow][column] >= currentTreeHeight)
                        {
                            isTreeVisible = false;
                            break;
                        }
                    }
                    if (isTreeVisible)
                    {
                        visibleTrees++;
                    }
                }
            }

            Console.WriteLine(visibleTrees.ToString());
        }

        public static void CalculateScenicScore()
        {
            var input = TreetopTreeHouseData.treeInput.Split("\r\n");

            var forest = new List<List<int>>();

            foreach (var line in input)
            {
                var row = new List<int>();

                foreach (char tree in line)
                {
                    row.Add(int.Parse(tree.ToString()));
                }

                forest.Add(row);
            }

            var scenicScores = new List<int>();

            for (int row = 1; row < forest.Count - 1; row++)
            {
                for (int column = 1; column < forest[row].Count - 1; column++)
                {
                    int currentTreeHeight = forest[row][column];

                    int leftCounter = 0;
                    int rightCounter = 0;
                    int upCounter = 0;
                    int downCounter = 0;

                    int scenicScore = 0;

                    //Checking left side

                    for (int leftColumn = column - 1; leftColumn >= 0; leftColumn--)
                    {
                        if (forest[row][leftColumn] >= currentTreeHeight)
                        {
                            leftCounter++;
                            break;
                        }
                        else
                        {
                            leftCounter++;
                        }
                    }

                    //Checking right side

                    for (int rightColumn = column + 1; rightColumn < forest[row].Count; rightColumn++)
                    {
                        if(forest[row][rightColumn] >= currentTreeHeight)
                        {
                            rightCounter++;
                            break;
                        }
                        else
                        {
                            rightCounter++;
                        }
                    }


                    //Checking above

                    for (int rowAbove = row - 1; rowAbove >= 0; rowAbove--)
                    {
                        if (forest[rowAbove][column] >= currentTreeHeight)
                        {
                            upCounter++;
                            break;
                        }
                        else
                        {
                            upCounter++;
                        }
                    }

                    //Checking Below

                    for (int rowBelow = row + 1; rowBelow < forest.Count; rowBelow++)
                    {
                        if (forest[rowBelow][column] >= currentTreeHeight)
                        {
                            downCounter++;
                            break;
                        }
                        else
                        {
                            downCounter++;
                        }
                    }


                    scenicScore = leftCounter * rightCounter * upCounter * downCounter;

                    scenicScores.Add(scenicScore);
                }
            }


            var max = scenicScores.Max();

            Console.WriteLine(max);
            
        }
    }
}
