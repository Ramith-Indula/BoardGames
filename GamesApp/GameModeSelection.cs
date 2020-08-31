using System;
using System.Collections.Generic;
using System.Text;

namespace GamesApp
{
    class GameModeSelection
    {

        //required data fields
        private const string option1 = "Human vs Human";
        private const string option2 = "Human vs Computer";
        private int option;
        private const string gomoku = "GOMOKU";
        private static string userInput;



        //constructors
        public GameModeSelection()
        {

        }

        public int MainMenu()
        {
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("+++++++++++++++++++++++ Welcome to {0}  ++++++++++++++++++++++++", gomoku);
            Console.WriteLine("-------------------------------------------------------------------\n");
            Console.WriteLine("Please Select one of the options below:\n 0 {0}\n 1 {1}\n 2 Exit", option1, option2);

            bool exit = false; // set the exit variable again to false state
            do
            {
                Console.Write("Enter option number >>>");//prompt the user to enter the number of participants

                userInput = Console.ReadLine();

                if (int.TryParse(userInput, out option))//check whether the input is an Integer
                {
                    if (option == 0 || option == 1 || option == 2)//check the input is between 0-40 
                        exit = true;//if true exit the loop
                    else
                        Console.Write("\nPlease enter a valid option number >>> ");//if not prompt the user again

                }

                else
                    Console.Write("\nPlease enter a valid option number >>> ");// if the input in not an integer prompt user again
            }
            while (!exit);
            exit = false;


            return option;
        }

    }


}
