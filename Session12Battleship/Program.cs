﻿using System;

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
            // [Do it all again] from `show the playfield`


            // define playfield
            // int[,] playfield = new int[8, 8];
            int[,] playfield;
            playfield = new int[8, 8];

            // playfield defaults to all 0s
            // 0 will be my open water
            // 1 will be my miss
            // 2 will be my hit
            // 3 will be my ship

            // add ships
            playfield[2, 3] = 3;

            while (true)
            {
                // show the playfield
                for (int row = 0; row < 8; row++)
                {
                    for (int col = 0; col < 8; col++)
                    {
                        // show the current cell
                        Console.Write(playfield[row, col]);
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
                if (playfield[userRow, userColumn] == 3)
                {
                    // say hit then change/take away the ship
                    Console.WriteLine("Hit!");
                    playfield[userRow, userColumn] = 2;
                }
                else
                {
                    Console.WriteLine("Miss!");
                    playfield[userRow, userColumn] = 1;
                }

            }

        }
    }
}
