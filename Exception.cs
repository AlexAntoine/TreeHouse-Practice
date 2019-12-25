namespace TreeHouse_Practice {

    class TreeHouseException : System.Exception
    {
        public TreeHouseException()
        {

        }
        
        public TreeHouseException(String message) : base(message)
        {
            
        }

    }

    class OutofBoundsException : TreeHouseException
    {
        public OutofBoundsException()
        {

        }

        public  OutofBoundsException(String message) : base (message)
        {

        }
    }
}