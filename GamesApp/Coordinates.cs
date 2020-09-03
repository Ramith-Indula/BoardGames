using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace GamesApp
{
    class Coordinates
    {
        private int row;
        private int col;
        private string cha;

        public Coordinates(int aRow, int aCol, string aCha)
        {
            Row = aRow;
            Col = aCol;
            Cha = aCha;
        }


        public int Row { get; set; }
        public int Col { get; set; }
        public string Cha { get; set; }





    }
}
