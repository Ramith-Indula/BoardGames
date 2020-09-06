using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace GamesApp
{
    class GameBoard
    {

        private List<Coordinates> coordinates = new List<Coordinates>();
        private string[,] arr = new string[30, 30];

        public GameBoard()
        {

        }


        /*public void Grid()
        {
            int y, x, z = 0;
            string[,] arr1 = new string[10, 10];


            for (y = 0; y < 10; y++)
            {
                for (x = 0; x < 10; x++)
                {
                    // Console.Write("element - [{0},{1}] : \n", y, x);
                    arr1[y, x] = "|";
                }
            }

            Console.Write("__________________________________");
            for (y = 0; y < 10; y++)
            {
                Console.Write("\n{0}  |_", y);
                for (x = 0; x < 10; x++)
                {
                    Console.Write("_{0}_", arr1[y, x]);
                }

                Console.Write("_|");
            }

            Console.Write("\n\n");
        
    } */
        

        public void Grid()
        {


            int countY = 0;

            for (int y = 0; y < 30; y++)
            {
                if (y % 2 == 0)
                {
                    for (int i = 0; i < 30; i++)
                    {
                        arr[y, i] = "-";
                    }
                }
                else
                {
                    int countX = 0;
                    for (int i = 0; i < 30; i++)
                    {

                        if (i % 2 == 0)
                            arr[y, i] = "|";
                        else
                        {
                            arr[y, i] = " ";
                        }
                    }
                }
            }
            // x and y position is arr[2y+1][2x+1]

            // Print
           
        }

        public void UpdateGrid(int row, int col, int currentIndex)

        {
            Grid();
            coordinates.Add(new Coordinates(row, col, currentIndex == 0 ? "W" : "B"));
            int y, x, z = 0;


            foreach (var coordinate in coordinates)
            {
                arr[2 * coordinate.Col + 1, 2 * coordinate.Row + 1] = coordinate.Cha; ;
            }

            printGrid();
        }

        public void printGrid()
        {
            for (int y = 0; y < 30; y++)
            {
                for (int i = 0; i < 30; i++)
                {
                    Console.Write(arr[y, i]);
                }

                Console.WriteLine();
            }
        }

    }
}



