using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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

        }
        public void GamePlay()
        {
            Stack userInput = new Stack();
            int playerIndex = (0 ^ 1);
            int currentPlayerIndex = 0;
            bool playerWins = false;
            do
            {
                gameControl.MakeAMove(getPlayers[currentPlayerIndex], currentPlayerIndex);
                playerWins = checkForAStrike(getPlayers[currentPlayerIndex]);
                currentPlayerIndex ^= playerIndex;

            } while (!playerWins);

            playerWins = false;

        }
        public bool checkForAStrike(Players player)
        {
            bool found = false;
            Coordinates existingCoordinateObj = player.coordinates.Last();
            Coordinates coordinates = new Coordinates(existingCoordinateObj.Row, existingCoordinateObj.Col, existingCoordinateObj.Cha);
            //top
            if (CheckDirection(0, -1, 
                player, new Coordinates(existingCoordinateObj.Row, existingCoordinateObj.Col, existingCoordinateObj.Cha)))
            {
                return true;
            }
            //bottom
            if (CheckDirection(0, +1, 
                player, new Coordinates(existingCoordinateObj.Row, existingCoordinateObj.Col, existingCoordinateObj.Cha)))
            {
                return true;
            }
            //Right
            if (CheckDirection(+1, 0, 
                player, new Coordinates(existingCoordinateObj.Row, existingCoordinateObj.Col, existingCoordinateObj.Cha)))
            {
                return true;
            }
            //left
            if (CheckDirection(-1, 0, 
                player, new Coordinates(existingCoordinateObj.Row, existingCoordinateObj.Col, existingCoordinateObj.Cha)))
            {
                return true;
            }
            //north east
            if (CheckDirection(+1, -1,
                player, new Coordinates(existingCoordinateObj.Row, existingCoordinateObj.Col, existingCoordinateObj.Cha)))
            {
                return true;
            }
            //north west
            if (CheckDirection(-1, -1,
                player, new Coordinates(existingCoordinateObj.Row, existingCoordinateObj.Col, existingCoordinateObj.Cha)))
            {
                return true;
            }
            //south east
            if (CheckDirection(+1, +1,
                player, new Coordinates(existingCoordinateObj.Row, existingCoordinateObj.Col, existingCoordinateObj.Cha)))
            {
                return true;
            }
            //south west
            if (CheckDirection(-1, +1, 
                player, new Coordinates(existingCoordinateObj.Row, existingCoordinateObj.Col, existingCoordinateObj.Cha)))
            {
                return true;
            }

            return false;
        }
        public bool CheckDirection(int xIncrement, int yIncrement, Players player, Coordinates coordinates)
        {

            int count = 1;
            bool found = false;
            bool hasAMatch = false;
            do
            {
                hasAMatch = false;
                if (CheckCoordinateExist(player.coordinates, coordinates))
                {
                    hasAMatch = true;
                    if (count >= 5)
                    {
                        found = true;
                        break;
                    }

                    count++;
                    coordinates.Row += xIncrement;
                    coordinates.Col += yIncrement;
                }
            } while (hasAMatch);

            return found;
        }
        public bool CheckCoordinateExist(List<Coordinates> coordinates, Coordinates currentCoordinates)
        {
            foreach (var coordinate in coordinates)
            {
                if (coordinate.Row == currentCoordinates.Row && coordinate.Col == currentCoordinates.Col)
                {
                    return true;
                }
            }

            return false;
        }
    }

}
