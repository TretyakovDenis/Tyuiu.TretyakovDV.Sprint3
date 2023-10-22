using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;


namespace Tyuiu.TretyakovDV.Sprint3.Task1.V21.Lib
{
    public class DataService : ISprint3Task1V21
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double multi = 1;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                multi = multi * (Math.Pow(((0.5+(i/5))/(Math.Cos(value)+0.5)), 3));
            }
            return Math.Round(multi, 3);
        }
    }
}