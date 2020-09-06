using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GamesApp
{
    class Players
    {
        private string playerName;
        private int playerId;
        private string password;
        private string[] difficultyLevel;
        private string filepath;
        private string userInput;
        private string playerCha;
        public List<Coordinates> coordinates = new List<Coordinates>();
        public Players(string playerName, int playerId, string aPassword)
        {
            PlayerName = playerName;
            PlayerId = playerId;
            Password = aPassword;

            createrPlayer(PlayerName, PlayerId, Password);
        }
        public Players()
        {

        }
        public string[] DifficultyLevel { get; } = { "Easy", "Hard" };
        public string PlayerName { get; set; }
        public int PlayerId { get; set; }
        public string Password { get; set; }
        public void AddCoordinates(Coordinates coordinates)
        {
            this.coordinates.Add(coordinates);
            
        }
        public void createrPlayer(string playerName, int playerId, string password)
        {
            /*
             * Implement to check if file exist. Return error messages as required.
             */
            FileInfo fileInfo = new FileInfo(@Environment.CurrentDirectory + $"..\\..\\..\\..\\userFiles\\{playerName}.txt");
            StreamWriter streamWriter = fileInfo.CreateText();
            streamWriter.WriteLine($"PlayerName:{playerName};PlayerId{playerId};PlayerPassword:{password}");
            Console.WriteLine("Player Created!");
            streamWriter.Close();
        }
        public void ValidatePlayer(string playerName)
        {

        /*
         * This method takes user name as an argument and checking if an user file exist for that name. If exist, prompting user to enter password.
         * check the input password against the extracted password from the text file. If successful move on to another player.
         */
            string[] userDetailsLineInTextFile = new string[] { };
            FileInfo fileInfo = new FileInfo(@Environment.CurrentDirectory + $"..\\..\\..\\..\\userFiles\\{playerName}.txt");
            if (fileInfo.Name == playerName + ".txt")
            {
                StreamReader streamReader = fileInfo.OpenText(); //File not existing exception needs to be handled.
                string lines;
                while ((lines = streamReader.ReadLine()) != null)
                {
                    var passwordAttribute = lines.Split(';');
                    userDetailsLineInTextFile = passwordAttribute[2].Split(':');
                }
                bool exit = false;
                do
                {
                    Console.Write("Enter Password for {0} >>> ", playerName);
                    userInput = GetConsolePassword();
                    if (userDetailsLineInTextFile[1] == userInput)
                        exit = true;
                    else
                        Console.Write("\nIncorrect Password.Please try again...\n");
                }
                while (!exit);
                exit = false;
            }
        }
        
        public string GetConsolePassword()
        {
            StringBuilder stringBuilder = new StringBuilder();
            while (true)
            {
                ConsoleKeyInfo cki = Console.ReadKey(true);
                if (cki.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    break;
                }

                if (cki.Key == ConsoleKey.Backspace)
                {
                    if (stringBuilder.Length > 0)
                    {
                        Console.Write("\b\0\b");
                        stringBuilder.Length--;
                    }

                    continue;
                }

                Console.Write('*');
                stringBuilder.Append(cki.KeyChar);
            }

            return stringBuilder.ToString();
        }

    }


}

