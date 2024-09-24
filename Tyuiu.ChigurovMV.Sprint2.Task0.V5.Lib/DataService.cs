﻿using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ChigurovMV.Sprint2.Task0.V5.Lib
{
    public class DataService : ISprint2Task0V5
    {
        public bool[] GetCompareOperations(int x, int y)
        {
    
            bool[] res = new bool[6];

            res[0] = x == y;
            res[1] = x != y;
            res[2] = x < y;
            res[3] = y > x;
            res[4] = y <= x;
            res[5] = y >= x;

            return res;
        }
    }
}
