namespace TreeHouse_Practice {
    
    class MapLocation : Point
    {
        public MapLocation(int x, int y, Map Map) : base(x,y)
        {
            if(!Map.OnMap(this))
            {
                throw new System.Exception();
            }
        }
    }
}