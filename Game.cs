using System;

namespace TreeHouse_Practice
{
    class Game
    {
        static void Main(string[] args)
        {
           Map map = new Map(8, 5);

           Point point = new Point(4,2);
          
           Console.WriteLine(point.distanceTo(5,5));
        }
    }
}
