using AdventCalendar.Data;

namespace AdventCalendar
{
    public class SupplyStacks
    {

        public static void GetCratesFromTopOfStacks()
        {

            var crates = new List<string>[9]{
                new List<string>(){"H", "T","Z", "D"},
                new List<string>(){"Q", "R", "W", "T", "G", "C", "S" },
                new List<string>(){"P", "B", "F", "Q", "N", "R", "C", "H"},
                new List<string>(){"L", "C", "N", "F", "H", "Z"},
                new List<string>(){"G", "L", "F", "Q", "S"},
                new List<string>(){"V", "P", "W", "Z", "B", "R", "C", "S" },
                new List<string>(){"Z", "F", "J"},
                new List<string>(){"D", "L", "V", "Z", "R", "H", "Q"},
                new List<string>(){"B", "H", "G", "N", "F", "Z", "L", "D"}
            };

            var moves = SupplyStacksData.moves.Split("\r\n");


            foreach (var move in moves)
            {
                var moveValues = move.Split(" ");

                int cratesToMove = Convert.ToInt32(moveValues[0]);
                int moveFrom = Convert.ToInt32(moveValues[1]) - 1;
                int moveTo = Convert.ToInt32(moveValues[2]) - 1;


                var currentStack = crates[moveFrom];


                for (int i = 1; i <= cratesToMove; i++)
                {
                    var crateToMove = currentStack[currentStack.Count - 1];
                    crates[moveTo].Add(crateToMove);
                    currentStack.RemoveAt(currentStack.Count - 1);

                }

            }

            var result = "";

            foreach (var crate in crates)
            {
                result += crate[crate.Count - 1];
            }

            Console.WriteLine(result);
        }

        public static void GetCratesFromStacks()
        {
            var crates = new List<string>[9]{
                new List<string>(){"H", "T","Z", "D"},
                new List<string>(){"Q", "R", "W", "T", "G", "C", "S" },
                new List<string>(){"P", "B", "F", "Q", "N", "R", "C", "H"},
                new List<string>(){"L", "C", "N", "F", "H", "Z"},
                new List<string>(){"G", "L", "F", "Q", "S"},
                new List<string>(){"V", "P", "W", "Z", "B", "R", "C", "S" },
                new List<string>(){"Z", "F", "J"},
                new List<string>(){"D", "L", "V", "Z", "R", "H", "Q"},
                new List<string>(){"B", "H", "G", "N", "F", "Z", "L", "D"}
            };

            var moves = SupplyStacksData.moves.Split("\r\n");


            foreach (var move in moves)
            {
                var moveValues = move.Split(" ");

                int cratesToMove = Convert.ToInt32(moveValues[0]);
                int moveFrom = Convert.ToInt32(moveValues[1]) - 1;
                int moveTo = Convert.ToInt32(moveValues[2]) - 1;


                var currentStack = crates[moveFrom];

                var cratesToAdd = new List<string>();

                for (int i = 1; i <= cratesToMove; i++)
                {
                    var crateToMove = currentStack[currentStack.Count - 1];
                    cratesToAdd.Add(crateToMove);
                    currentStack.RemoveAt(currentStack.Count - 1);

                }

                cratesToAdd.Reverse();

                foreach (var crate in cratesToAdd)
                {
                    crates[moveTo].Add(crate);
                }


            }

            var result = "";

            foreach (var crate in crates)
            {
                result += crate[crate.Count - 1];
            }

            Console.WriteLine(result);
        }
    }
}
