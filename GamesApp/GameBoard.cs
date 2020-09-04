using System;
using System.Collections.Generic;
using System.Text;

namespace GamesApp
{
    class GameBoard
    {

        private List<Coordinates> coordinates = new List<Coordinates>();

        public GameBoard()
        {

        }


        public void Grid()
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
        
    } 
        public void UpdateGrid(int row, int col, int currentIndex)
        {
            coordinates.Add(new Coordinates(row,col, currentIndex == 0 ? "W" : "B"));
            int y, x, z = 0;
            string[,] arr1 = new string[10, 10];


          /*  for (y = 0; y < 10; y++)
            {
                for (x = 0; x < 10; x++)
                {
                   // Console.Write("element - [{0},{1}] : \n", y, x);
                    arr1[row, col] = "W";
                }
            }*/



          foreach (var coordinate in coordinates)
          {
              arr1[coordinate.Row, coordinate.Col] = coordinate.Cha;
            }


            Console.Write("__________________________________");
            for (x = 0; x < 10; x++)
            {
                Console.Write("\n{0}  |_", x);
                for (y = 0; y < 10; y++)
                {
                    Console.Write("_{0}_", arr1[x, y]);
                }
                Console.Write("_|");
            }
            Console.Write("\n\n");
        }


    }
}



