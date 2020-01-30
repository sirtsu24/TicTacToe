using System;
using System.Collections.Generic;
using System.Text;

namespace tictac
{
    class GameBoard
    {// Greate gameboard

        public static char[] arr = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public static void Board()

        {
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("      |       |     ");
            Console.WriteLine("    {0} |   {1}   | {2} ", arr[1], arr[2], arr[3]);
            Console.WriteLine(" _____|_______|_____ ");
            Console.WriteLine("      |       |     ");
            Console.WriteLine("    {0} |   {1}   | {2} ", arr[4], arr[5], arr[6]);
            Console.WriteLine(" _____|_______|_____ ");
            Console.WriteLine("      |       |     ");
            Console.WriteLine("    {0} |   {1}   | {2} ", arr[7], arr[8], arr[9]);
            Console.WriteLine("      |       |     ");

        }
    }
}