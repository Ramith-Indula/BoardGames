using System;

namespace GamesApp
{
    class Program
    {

        private static GameModeSelection gameModeSelection = new GameModeSelection();
        private static int gameOption;


        static void Main(string[] args)
        {
            gameOption = gameModeSelection.MainMenu();

        }
    }
}


