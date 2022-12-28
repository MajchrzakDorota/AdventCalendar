using AdventCalendar.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventCalendar
{
    public class CampCleanup
    {
        public static void CalculateFullyContainedRanges()
        {
            var pairsOFElfsRanges = CampCleanupData.cleanupPairs.Split("\r\n");
            var containedRangesCounter = 0;

            for (int i = 0; i < pairsOFElfsRanges.Length; i++)
            {
                var pairs = pairsOFElfsRanges[i].Split(",");

                var elfOneRange = pairs[0].Split("-");

                var elfTwoRange = pairs[1].Split("-");

                var elfOneStartRange = Convert.ToInt32(elfOneRange[0]);
                var elfOneEndRange = Convert.ToInt32(elfOneRange[1]);

                var elfTwoStartRange = Convert.ToInt32(elfTwoRange[0]);
                var elfTwoEndRange = Convert.ToInt32(elfTwoRange[1]);

                if (elfOneStartRange >= elfTwoStartRange && elfOneEndRange <= elfTwoEndRange)
                {
                    containedRangesCounter++;

                }
                else if (elfTwoStartRange >= elfOneStartRange && elfTwoEndRange <= elfOneEndRange)
                {
                    containedRangesCounter++;
                }

            }
            Console.WriteLine(containedRangesCounter);
        }

        public static void CalculateOverlapedRanges()
        {
            var pairsOFElfsRanges = CampCleanupData.cleanupPairs.Split("\r\n");
            var overlapedRangesCounter = 0;

            for (int i = 0; i < pairsOFElfsRanges.Length; i++)
            {
                var pairs = pairsOFElfsRanges[i].Split(",");

                var elfOneRange = pairs[0].Split("-");

                var elfTwoRange = pairs[1].Split("-");

                var elfOneStartRange = Convert.ToInt32(elfOneRange[0]);
                var elfOneEndRange = Convert.ToInt32(elfOneRange[1]);

                var elfTwoStartRange = Convert.ToInt32(elfTwoRange[0]);
                var elfTwoEndRange = Convert.ToInt32(elfTwoRange[1]);

                if ((elfTwoStartRange <= elfOneStartRange && elfOneStartRange <= elfTwoEndRange) || (elfTwoStartRange <= elfOneEndRange && elfOneEndRange <= elfTwoEndRange) || (elfOneStartRange <= elfTwoStartRange && elfTwoStartRange <= elfOneEndRange) || (elfOneStartRange <= elfTwoEndRange && elfTwoEndRange <= elfOneEndRange))
                {
                    overlapedRangesCounter++;
                }

            }
            Console.WriteLine(overlapedRangesCounter);
        }
    }
}
