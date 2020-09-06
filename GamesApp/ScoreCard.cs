using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GamesApp
{
    class ScoreCard
    {
        public ScoreCard()
        {

        }
        static int tableWidth = 75;
        public void DisplayScoreCard(Players winner)
        {
            Console.Clear();
            PrintLine();
            PrintRow("WINNER!");
            PrintLine();
            PrintRow($"{winner.PlayerName} won the game!" );
            PrintRow($"************ Congratulations {winner.PlayerName}! ************");
            PrintLine();
            Console.ReadLine();
        }
        static void PrintLine()
        {
            Console.WriteLine(new string('-', tableWidth));
        }
        static void PrintRow(params string[] columns)
        {
            int width = (tableWidth - columns.Length) / columns.Length;
            string row = "|";

            foreach (string column in columns)
            {
                row += AlignCentre(column, width) + "|";
            }

            Console.WriteLine(row);
        }
        static string AlignCentre(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else
            {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        }



        /* Winner should be passed into the ScoreCard to display the winner!
         * Create a new constructor to get the winner.
         * Pass the winner to DisplayScoreCard method.
         */


    }
}

