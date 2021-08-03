using System;
using System.Numerics;

namespace ChessLibrary.MatchComponents
{
    class Board
    {
        ChessPiece[,] chessPieces;



        public ChessPiece this[int x, int y]
        {
            get
            {
                return chessPieces[x, y];
            }
            set
            {

            }
        }
    }
}
