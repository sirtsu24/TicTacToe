using System;

namespace tictac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.SetWindowSize(70, 25);
            Console.SetBufferSize(70, 25);


            GameBoard.Board();
            PlayGame.Play();
            Winning.CheckWin();



        }

    }
}