using System;
using System.Numerics;

namespace ChessLibrary.MatchComponents
{
    public class DebugClass
    {
        public object[] UnitTest()
        {
            Bishop rook = new Bishop(0, 0, 0);
            return new object[]
            {
                //Pawn
                new object[] {false},     
                //Rook
                new object[] {new Rook(0,0,0).checkMoveAvailable(1,0), new Rook(0,0,0).checkMoveAvailable(1,1), new King(0, 0, 0).checkMoveAvailable(0, 0)},
                //Knight
                new object[] {new Knight(0,0,0).checkMoveAvailable(1,2), new Knight(0,0,0).checkMoveAvailable(-1, 2), new Knight(0,0,0).checkMoveAvailable(-2, -1), new Knight(0,0,0).checkMoveAvailable(1,3)},
                //Bishop
                new object[] {new Bishop(0,0,0).checkMoveAvailable(1,1), new Bishop(0,0,0).checkMoveAvailable(1,0), new King(0, 0, 0).checkMoveAvailable(0, 0)},
                //Queen
                new object[] {new Queen(5,5,0).checkMoveAvailable(6,6), new Queen(0,0,0).checkMoveAvailable(1,0), new Queen(0,0,0).checkMoveAvailable(1,2), new King(0, 0, 0).checkMoveAvailable(0, 0)},
                //King
                new object[] {new King(0, 0, 0).checkMoveAvailable(0, 1), new King(0, 0, 0).checkMoveAvailable(1, 1), new King(0, 0, 0).checkMoveAvailable(0, 0), new King(0,0,0).checkMoveAvailable(1,2) }             
            };
        }

    }


    abstract class ChessPiece
    {
           

        protected Vector2 Pos;
        internal byte teamID { get; private set; }
        public abstract bool checkMoveAvailable(int x, int y);

        protected ChessPiece(int posX, int posY, byte teamID)
        {
            this.teamID = teamID;
            Pos = new Vector2(posX, posY);
        }

        protected static Vector2 magicConst { get { return Vector2.One; } }
    }

    class Pawn : ChessPiece
    {
        public Pawn(int posX, int posY, byte teamID) : base(posX, posY, teamID)
        {
            
        }

        public override bool checkMoveAvailable(int x, int y)
        {
            throw new NotImplementedException();
        }
    }

    class Rook : ChessPiece
    {
        public Rook(int posX, int posY, byte teamID) : base(posX, posY, teamID)
        {

        }

        public override bool checkMoveAvailable(int x, int y)
        {
            Vector2 endPoint = Vector2.Normalize(new Vector2(x, y) - Pos);
            float result = MathF.Abs((Vector2.Dot(magicConst, endPoint)));
            if (MathF.Round(result, 2) == 1.0f) { return true; }
            return false;

        }
    }

    class Knight : ChessPiece
    {
        public Knight(int posX, int posY, byte teamID) : base(posX, posY, teamID)
        {

        }

        public override bool checkMoveAvailable(int x, int y)
        {
            Vector2 endPoint = new Vector2(x, y) - Pos;
            return endPoint.Length() == new Vector2(1, 2).Length();
        }
    }


    class Bishop : ChessPiece
    {
        public Bishop(int posX, int posY, byte teamID) : base(posX, posY, teamID)
        {

        }

        public override bool checkMoveAvailable(int x, int y)
        {
            Vector2 endPoint = Vector2.Normalize(new Vector2(x, y) - Pos);
            endPoint = Vector2.Transform(endPoint, Matrix3x2.CreateRotation(MathF.PI / 4));
            float result = MathF.Abs((Vector2.Dot(magicConst, endPoint)));
            if (MathF.Round(result, 2) == 1.0f) { return true; }
            return false;
        }
    }

    class Queen : ChessPiece
    {
        public Queen(int posX, int posY, byte teamID) : base(posX, posY, teamID)
        {

        }

        public override bool checkMoveAvailable(int x, int y)
        {
            Vector2 endPoint = Vector2.Normalize(new Vector2(x, y) - Pos);
            if (endPoint.X * endPoint.Y != 0) endPoint = Vector2.Transform(endPoint, Matrix3x2.CreateRotation(MathF.PI / 4));
            float result = MathF.Abs((Vector2.Dot(magicConst, endPoint)));
            if (MathF.Round(result, 2) == 1.0f) { return true; }
            return false;
        }
    }
    class King : ChessPiece
    {
        public King(int posX, int posY, byte teamID) : base(posX, posY, teamID)
        {
            
        }

        public override bool checkMoveAvailable(int x, int y)
        {
            Vector2 endPoint = new Vector2(x, y) - Pos;
            return 0.5f < endPoint.Length() && endPoint.Length() < 1.5f;
        }
    }

    
}
