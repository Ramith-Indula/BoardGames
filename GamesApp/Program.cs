using System;
using System.Net.Mime;
using System.Security;
using System.Text;

namespace GamesApp
{
    class Program
    {

        private static GameModeSelection gameModeSelection = new GameModeSelection();
        private static Players players = new Players();
        private static ScoreCard scoreCard = new ScoreCard();
        private static GameControl gameControl = new GameControl();
        private static Game game = new Game();
        public static Players[] PlayerList;
        private static string playerName;
        private static int gameOption;
        private static int id = 1;
        static void Main(string[] args)
        {
           StartGame();
            // scoreCard.DisplayScoreCard();
            game.LoadPlayers();
            

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
                    gameControl.NewGame();
                    
                }
                else if (gameOption == 1)
                {
                    InitializePlayers(gameOption);
                    gameControl.LoadGame();
                }
                else if (gameOption == 2)
                {
                    StartGame();
                }


            }
            else if (gameOption == 1)
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
            string password = "";


            if (gameOption == 0)
            {
                PlayerList = new Players[2];
                for (int i = 0; i < PlayerList.Length; i++)
                {
                    Console.Write("...................................\n" + "Enter Player{0} Name   >>> ", i + 1);
                    playerName = Console.ReadLine();
                    Console.Write("Enter Password for {0}   >>> ", playerName);
                    password = players.GetConsolePassword();
                    Players player = new Players(playerName, generateId(), password);
                    PlayerList[i] = player;
                   

                }

                /*for (int i = 0; i < PlayerList.Length; i++)
                {
                    Console.WriteLine("Player Name: {0}\n Player ID: {1}\n Password: {2}", PlayerList[i].PlayerName, PlayerList[i].PlayerId,PlayerList[i].Password);
                }*/
            }
            else if (gameOption == 1)
            {
                for (int i = 0; i < 2; i++)
                {
                    Console.Write("...................................\n" + "Enter Player Name   >>> ");
                    playerName = Console.ReadLine();
                    players.ValidatePlayer(playerName);
                }

                Console.WriteLine("Players Loaded!");
                /*
                 * Staring point of a new Human vs Human game by using existing players.....
                 */

            }
            else
            {
                StartGame();
            }




        }
        static int generateId()
        {
            int randomId = id++;
            return 000 + randomId;
        }

        public Players[] GetPlayers()
        {
            return PlayerList;
        }


    }



}


