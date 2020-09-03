using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace GamesApp
{
    class Game
    {
        private GameControl gameControl = new GameControl();
        private Players players = new Players();
        private Program program = new Program();
        private Players[] getPlayers;


        public Game()
        {


       
            
        }



        public void LoadPlayers()
        {
            getPlayers = program.GetPlayers();
            GamePlay();

            /*foreach (Players player in getPlayers)
            {
                Console.WriteLine(player.PlayerName);
            }*/

        }

        public void GamePlay()
        {
            Stack userInput = new Stack();
            int[] Index = new[] {0, 1};
            int playerIndex = Index[0];
            gameControl.MakeAMove(getPlayers[playerIndex].PlayerName);
            

        }

    }

}
