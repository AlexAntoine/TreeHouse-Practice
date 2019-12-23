namespace TreeHouse_Practice {

    class Map {

        public readonly int _width;
        public readonly int _height;

        public Map(int width, int height)
        {
            width = _width;
            heigth = _height;
        }

        public bool OnMap(Point point)
        {
           return point._x >=0 && point._x < _width && point._y >= 0 && point._y < _height;
        }
        
    }
}