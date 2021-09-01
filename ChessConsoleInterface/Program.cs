using System;
using ChessLibrary;
using System.Numerics;

namespace ChessConsoleInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            ChessLibrary.MatchComponents.DebugClass debug = new ChessLibrary.MatchComponents.DebugClass();
            object[] buf;


            Console.WriteLine("Pawn");
            buf = (object[])debug.UnitTest()[0];
            Console.WriteLine(buf[0]);
            Console.WriteLine();

            Console.WriteLine("Rook");
            buf = (object[])debug.UnitTest()[1];
            Console.WriteLine(buf[0]);
            Console.WriteLine(buf[1]);
            Console.WriteLine(buf[2]);
            Console.WriteLine();

            Console.WriteLine("Knight");
            buf = (object[])debug.UnitTest()[2];
            Console.WriteLine(buf[0]);
            Console.WriteLine(buf[1]);
            Console.WriteLine(buf[2]);
            Console.WriteLine(buf[3]);
            Console.WriteLine();

            Console.WriteLine("Bishop");
            buf = (object[])debug.UnitTest()[3];
            Console.WriteLine(buf[0]);
            Console.WriteLine(buf[1]);
            Console.WriteLine(buf[2]);
            Console.WriteLine();

            Console.WriteLine("Queen");
            buf = (object[])debug.UnitTest()[4];
            Console.WriteLine(buf[0]);
            Console.WriteLine(buf[1]);
            Console.WriteLine(buf[2]);
            Console.WriteLine(buf[3]);
            Console.WriteLine();

            Console.WriteLine("King");
            buf = (object[])debug.UnitTest()[5];
            Console.WriteLine(buf[0]);
            Console.WriteLine(buf[1]);
            Console.WriteLine(buf[2]);
            Console.WriteLine(buf[3]);
            Console.WriteLine();
        }
    }
}
