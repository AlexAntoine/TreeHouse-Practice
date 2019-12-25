using System;

namespace TreeHouse_Practice
{
    class Game
    {
        static void Main(string[] args)
        {
           Map map = new Map(8, 5);

           Point x = new MapLocation(4,2);

           Point p = x;

           map.OnMap(new MapLocation(0,0));
          
           Console.WriteLine(x.distanceTo(5,5));

           Console.WriteLine(x is MapLocation);

           Console.WriteLine(x is Point);

           Point point = new Point(0,0);

           Console.WriteLine( point is MapLocation);
        }
    }
}
