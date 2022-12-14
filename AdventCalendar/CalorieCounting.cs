using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventCalendar
{
    public class CalorieCounting
    {
        public static void CalloriesForElfs()
        {
            var oneElfCalorie = CalorieCountingData.elfsCalories.Split("\r\n\r\n");
            var sumOfCaloriesForOneElfList = new List<int>();

            for (int i = 0; i < oneElfCalorie.Length; i++)
            {
                var sumOfCaloriesForOneElf = 0;

                sumOfCaloriesForOneElf = oneElfCalorie[i].Split("\r\n").Sum(x => Convert.ToInt32(x));
                sumOfCaloriesForOneElfList.Add(sumOfCaloriesForOneElf);

            }

            var max = sumOfCaloriesForOneElfList.Max();
            Console.WriteLine("Max: " + max);

            var sortedList = sumOfCaloriesForOneElfList.OrderByDescending(v => v);

            var topThreeSum = sortedList.Take(3).ToList().Sum();
            Console.WriteLine("Top 3 sum: " + topThreeSum);


        }

    }
}
