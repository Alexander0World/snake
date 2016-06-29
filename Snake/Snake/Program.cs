using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            HLine lineUp = new HLine(1, 78, 1, '+');
            HLine lineDown = new HLine(1, 78, 24, '+');
            VLine lineLeft = new VLine(1, 23, 1, '+');
            VLine lineRight = new VLine(1, 23, 78, '+');

            lineUp.Draw();
            lineDown.Draw();
            lineLeft.Draw();
            lineRight.Draw();

            Point p = new Point(10, 10, '*');
            Snake snake = new Snake(p, 5, Direction.RIGHT);
            snake.Draw();
            snake.Move();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();

                    snake.Control(key.Key);
                }
                System.Threading.Thread.Sleep(100);
                snake.Move();
            }
        }
    }
}
