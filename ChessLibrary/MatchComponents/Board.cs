using System;
using System.Numerics;

namespace ChessLibrary.MatchComponents
{
    class Board
    {
        ChessPiece[,] chessPieces;

        public enum ChessPieceName
        {
            Pawn = 1,
            Rook,
            Knight,
            Bishop,
            Queen,
            King
        }
        public static ChessPieceName convertPieceToEnum (ChessPiece piece)
        {
            switch (piece)
            {
                case Pawn pawn:
                    return ChessPieceName.Pawn;
                case Rook pawn:
                    return ChessPieceName.Pawn;
                case Knight pawn:
                    return ChessPieceName.Pawn;
                case Bishop pawn:
                    return ChessPieceName.Pawn;
                case Queen pawn:
                    return ChessPieceName.Pawn;
                case King pawn:
                    return ChessPieceName.Pawn;
                default:
                    throw new Exception();
            }
        }

        public ChessPiece this[int x, int y]
        {
            get
            {
                return chessPieces[x, y];
            }
            set
            {
                chessPieces[x, y] = value;
            }
        }

        public ChessPiece this[Vector2 vector2]
        {
            get 
            {
                return this[Convert.ToInt32(vector2.X), Convert.ToInt32(vector2.Y)];
            }
            set 
            {
                this[Convert.ToInt32(vector2.X), Convert.ToInt32(vector2.Y)] = value;
            }
        }

    }
}
