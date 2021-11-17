using System;

namespace Pong
{
    class Program
    {
        static void Main(string[] args)
        {
            var title1 = "Welcom to Pong. Press anykey to start. :p";
            Console.CursorLeft = Console.WindowWidth / 2 - title1.Length / 2;
            Console.CursorTop = Console.WindowHeight / 5;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(title1);
            var title2 = "Chris, How can I make a score ++ according to screen refresh?";
            Console.CursorLeft = Console.WindowWidth / 2 - title2.Length / 2;
            Console.CursorTop = Console.WindowHeight / 2;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(title2);
            Console.ReadKey();

            Console.CursorVisible = false;
            Pong pong = new Pong(60, 20);
            pong.Run();
            Console.ReadKey();


        }
    }
}
