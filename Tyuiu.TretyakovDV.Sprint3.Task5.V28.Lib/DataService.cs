﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;


namespace Tyuiu.TretyakovDV.Sprint3.Task5.V28.Lib
{
    public class DataService : ISprint3Task5V28
    {
        
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double res = 0;
            int i, j;
            for (i = startValue1; i <= stopValue1; i++)
            {
                for (j = startValue2; j<= stopValue2; j++)
                {
                    res = res + (Math.Pow(j, x) / Math.Sin(j));
                }
            }
            return Math.Round(res, 3);
        }
    }
}
