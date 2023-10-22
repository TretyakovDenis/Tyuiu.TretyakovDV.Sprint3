﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;


namespace Tyuiu.TretyakovDV.Sprint3.Task0.V16.Lib
{
    public class DataService : ISprint3Task0V16
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double multi = 1;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                multi = multi * (Math.Pow((value / i), 3));
            }
            return Math.Round(multi, 3);
        }
    }
}