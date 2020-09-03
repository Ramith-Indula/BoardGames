using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GamesApp
{
    class GameControl
    {

        private GameBoard gameBoard = new GameBoard();
        private string[] userInputs;
        private string inputString;
        private int row;
        private int col;



        public GameControl()
        {

        }

        /*public void LoadPlayers(string playerName)
        {
            int i = 1;
            Console.WriteLine($"Player {0} : {playerName}");
            i++;
            NewGame();
        }*/

        public void NewGame()
        {
            Console.WriteLine("Creating a new game.......\t");
            gameBoard.Grid();
        }

        public void LoadGame()
        {
            Console.WriteLine("Loading Game......\t");
            gameBoard.Grid();
        }

        /*public void SaveGame()
        {
            FileInfo fileInfo = new FileInfo(@Environment.CurrentDirectory + $"..\\..\\..\\..\\userFiles\\{playerName}.txt");
            //StreamWriter streamWriter = fileInfo.CreateText();
            //streamWriter.($"PlayerName:{playerName};PlayerId{playerId};PlayerPassword:{password}");
            Console.WriteLine("Player Created!");
            streamWriter.Close();
        }*/



        public string[] GetUserInput(string playerName)
        {


            /*
             * validationn
             */
            Console.WriteLine("{0}'s Next Move >>> ", playerName);
            inputString = Console.ReadLine();
            userInputs = (inputString.Split(','));
            return userInputs;
        }


        public void MakeAMove(string playerName)
        {
            userInputs = GetUserInput(playerName);
            row = Convert.ToInt32(userInputs[0]);
            col = Convert.ToInt32(userInputs[1]);
            gameBoard.UpdateGrid(row, col);
        }
    }
}
