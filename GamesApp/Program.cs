using System;
using System.Net.Mime;

namespace GamesApp
{
    class Program
    {

        private static GameModeSelection gameModeSelection = new GameModeSelection();
        private static Players[] PlayerList;
        private static string playerName;
        private static int gameOption;
        private static int id = 1;


        static void Main(string[] args)
        {
            StartGame();

        }




        static void StartGame()
        {
            gameOption = gameModeSelection.MainMenu();
            if (gameOption == 0)
            {
                gameOption = gameModeSelection.SecondaryMenu();
                if (gameOption == 0)
                {
                    gameOption = gameModeSelection.ThirdMenu();
                    InitializePlayers(gameOption);
                }else if (gameOption == 1 )
                {
                    /* Implementation or call of Load Game function to be done here !
                   * Refer ToDoList.txt
                   */
                }
                else if(gameOption == 2)
                {
                    StartGame();
                }
                

            }else if (gameOption == 1)
            {
                /* Implementation or call of Human vs Computer function to be done here !
                   * Refer ToDoList.txt
                   */
            }
            else
            {
                Console.WriteLine("----------------------------------------------------Good Bye!----------------------------------------------");
                Environment.Exit(0);
            }

            
        }

        static void InitializePlayers(int gameOption)
        {
            
            if (gameOption == 0)
            {
                PlayerList = new Players[2];
                for (int i = 0; i < PlayerList.Length; i++)
                {
                    Console.Write("...................................\n" + "Enter Player{0} Name   >>> ", i + 1);
                    playerName = Console.ReadLine();
                    Players player = new Players(playerName,generateId());
                    PlayerList[i] = player;
                }

                for (int i = 0; i < PlayerList.Length; i++)
                {
                    Console.WriteLine("Player Name: {0}\n Player ID: {1}", PlayerList[i].PlayerName, PlayerList[i].PlayerId);
                }
            }else if (gameOption == 1)
            {
                 /* Implementation of using existing players function to be done here !
                  * Refer ToDoList.txt
                  */
            }

            
        }

        static int generateId()
        {
            int randomId = id++;
            return 000 + randomId;
        }
    }
}


