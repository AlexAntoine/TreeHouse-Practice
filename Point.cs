using System;

namespace TreeHouse_Practice {

    class Point{

        public readonly int _x;
        public readonly int _y;

        public Point (int x, int y)
        {
          _x = x;
          _y = y;
        }

        public int distanceTo(int x, int y)
        {
            // calcuated distance between two point 

            return (int)Math.Sqrt(Math.Pow(_x-x, 2) + Math.Pow(_y - y, 2));
        }

        public int distanceTo(Point point)
        {
            //calculates the distance between two point objects
            
            return distanceTo(point._x, point._y);
        }
    }
}