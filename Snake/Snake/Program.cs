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

            Point p1 = new Point(3, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            HLine lineUp = new HLine(1, 78, 1, '+');
            lineUp.Draw();

            HLine lineDown = new HLine(1, 78, 24, '+');
            lineDown.Draw();

            VLine lineLeft = new VLine(1, 23, 1, '+');
            lineLeft.Draw();

            VLine lineRight = new VLine(1, 23, 78, '+');
            lineRight.Draw();

            Console.ReadLine();
        }
    }
}
