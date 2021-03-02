using System;

namespace Session12Battleship
{
    class Program
    {
        static void Main(string[] args)
        {
            // Play battleship!

            // [Define] the `playfield`
            // [Add] `ships` to the `playfield`
            // [Show] the `playfield`
            // [Ask] the user for a `userRow`
            // [Ask] the user for a `userColumn`
            // [See] if the `cell` on the `playfield` at `userRow, userColumn` was a "hit"
            // If so, that ship is gone/sunk (say "Hit!")
            // If not, it says "miss!"
            // [See] if there are any ships left
            // If so, [Do it all again] from `show the playfield`
            // If not, Stop looping and show "you won!"

            // things still to do
            // Make it so it ends?
            // Make it so the user can't see where all the ships are?
            // Show near misses?
            // Play a sound when we hit a ship?
            // Deal with user numbers that are out of range, or not numbers?
            // Refactor into functions?


            // define playfield
            // int[,] playfield = new int[8, 8];
            string[,] playfield;
            playfield = new string[8, 8];

            // playfield defaults to all 0s
            // 0 will be my open water
            // 1 will be my miss
            // 2 will be my hit ship
            // 3 will be my hidden ship
            string water = null;
            string miss = "Q";
            string hitShip = "blazzle";
            string hiddenShip = "shhh, don't look here";


            // add ships
            playfield[2, 3] = hiddenShip;
            bool keepLooping = true;
            while (keepLooping == true)
            {
                // show the playfield
                // If I see a 0, put a ?
                // If I see a 1, put a W
                // If I see a 2, put a *
                // If I see a 3, put a ?
                for (int row = 0; row < 8; row++)
                {
                    for (int col = 0; col < 8; col++)
                    {
                        // show the user-y version of the current cell
                        string currentCell = playfield[row, col];
                        if (currentCell == water || currentCell == hiddenShip)
                        {
                            Console.Write("?");
                        }

                        if (currentCell == miss)
                        {
                            Console.Write(".");
                        }

                        if (currentCell == hitShip)
                        {
                            Console.Write("*");
                        }
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }

                // ask for a userRow
                Console.WriteLine("Please give me a number from 0-7 for a row");
                int userRow = Convert.ToInt32(Console.ReadLine());

                // ask for a userColumn
                Console.WriteLine("Please give me a number from 0-7 for a column");
                int userColumn = Convert.ToInt32(Console.ReadLine());

                // [See] if the `cell` on the `playfield` at `userRow, userColumn` was a "hit"
                if (playfield[userRow, userColumn] == hiddenShip)
                {
                    // say hit then change/take away the ship
                    Console.WriteLine("Hit!");
                    playfield[userRow, userColumn] = hitShip;
                }
                else
                {
                    Console.WriteLine("Miss!");
                    playfield[userRow, userColumn] = miss;
                }

                // [See] if any ships are left
                int howManyShips = 0;
                for (int row = 0; row < 8; row++)
                {
                    for (int col = 0; col < 8; col++)
                    {
                        if(playfield[row, col] == hiddenShip)
                        {
                            // I found a ship!
                            howManyShips += 1;
                        }
                    }
                }
                if(howManyShips > 0)
                {
                    // there are ships
                    Console.WriteLine("You have ships left to shoot!");
                }
                else
                {
                    // there are no ships left
                    keepLooping = false;
                    Console.WriteLine("You got them all, good job!");
                }

            }

        }
    }
}
