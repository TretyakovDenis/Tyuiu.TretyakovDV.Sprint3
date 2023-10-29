using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TretyakovDV.Sprint3.Task6.V17.Lib;
namespace Tyuiu.TretyakovDV.Sprint3.Task6.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            
            int startValue = 10;
            int stopValue = 20;
            
            double res = ds.GetSumTheDivisors(startValue, stopValue);
            double wait = 43;
            Assert.AreEqual(wait, res);
        }
    }
}