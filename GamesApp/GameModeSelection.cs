using System;
using System.Collections.Generic;
using System.Text;

namespace GamesApp
{
    class GameModeSelection
    {
        //required data fields
        private const string mainMenuOption1 = "Human vs Human";
        private const string mainMenuOption2 = "Human vs Computer";
        private const string secondaryMenuOption1 = "New Game";
        private const string secondaryMenuOption2 = "Load Game";
        private const string thirdMenuOption1 = "Creat New Players";
        private const string thirdMenuOption2 = "Use Existing Players";
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
            Console.WriteLine("Please Select one of the options below:\n 0 {0}\n 1 {1}\n 2 Exit", mainMenuOption1, mainMenuOption2);

            bool exit = false; // set the exit variable again to false state
            do
            {
                Console.Write("Enter option number >>> ");//prompt the user to enter the number of participants

                userInput = Console.ReadLine();

                if (int.TryParse(userInput, out option))//check whether the input is an Integer
                {
                    if (option == 0 || option == 1 || option == 2)//check the input is between 0-40 
                        exit = true;//if true exit the loop
                    else
                        Console.Write("\nPlease enter a valid option number.\n");//if not prompt the user again

                }

                else
                    Console.Write("\nPlease enter a valid option number.\n");// if the input in not an integer prompt user again
            }
            while (!exit);
            exit = false;


            return option;
        }
        public int SecondaryMenu()
        {
            Console.WriteLine("Please Select one of the options below:\n 0 {0}\n 1 {1}\n 2 Go Back", secondaryMenuOption1, secondaryMenuOption2);

            bool exit = false; // set the exit variable again to false state
            do
            {
                Console.Write("Enter option number >>> ");//prompt the user to enter the number of participants

                userInput = Console.ReadLine();

                if (int.TryParse(userInput, out option))//check whether the input is an Integer
                {
                    if (option == 0 || option == 1 || option == 2)//check the input is between 0-2 
                        exit = true;//if true exit the loop
                    else
                        Console.Write("\nPlease enter a valid option number.\n");//if not prompt the user again

                }

                else
                    Console.Write("\nPlease enter a valid option number.\n");// if the input in not an integer prompt user again
            }
            while (!exit);
            exit = false;


            return option;
        }
        public int ThirdMenu()
        {
            Console.WriteLine("Please Select one of the options below:\n 0 {0}\n 1 {1}\n 2 Exit to Main Menu", thirdMenuOption1, thirdMenuOption2);

            bool exit = false; // set the exit variable again to false state
            do
            {
                Console.Write("Enter option number >>> ");//prompt the user to enter the number of participants

                userInput = Console.ReadLine();

                if (int.TryParse(userInput, out option))//check whether the input is an Integer
                {
                    if (option == 0 || option == 1 || option == 2)//check the input is between 0-2 
                        exit = true;//if true exit the loop
                    else
                        Console.Write("\nPlease enter a valid option number \n>>> ");//if not prompt the user again

                }

                else
                    Console.Write("\nPlease enter a valid option number \n>>> ");// if the input in not an integer prompt user again
            }
            while (!exit);
            exit = false;


            return option;
        }

    }
}
