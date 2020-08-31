using System;
using System.Collections.Generic;
using System.Text;

namespace GamesApp
{
    class Players
    {
        private string playerName;
        private int playerId;
        private string[] difficultyLevel;

        public Players(string playerName, int playerId)
        {
            PlayerName = playerName;
            PlayerId = playerId;
        }


        public string[] DifficultyLevel { get; } = {"Easy", "Hard"};


        public string PlayerName { get; set; }

        public int PlayerId { get; set; }



        public void createrPlayer()
        {

        }

        public void openGame()
        {

        }
    }
}
