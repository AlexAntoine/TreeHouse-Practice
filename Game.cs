﻿using System;

namespace TreeHouse_Practice
{
    class Game
    {
        static void Main(string[] args)
        {
           Map map = new Map(8, 5);
        
           try
           {
               MapLocation maplocation = new MapLocation(20,20, map);
           }
           catch (Exception ex)
           {
               
               Console.WriteLine(ex.Message);
           }
        }
    }
}
