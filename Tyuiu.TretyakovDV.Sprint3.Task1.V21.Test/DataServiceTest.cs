using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TretyakovDV.Sprint3.Task1.V21.Lib;
namespace Tyuiu.TretyakovDV.Sprint3.Task1.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidValue()
        {
            DataService ds = new DataService();
            int value = 1;
            int startValue = 1;
            int stopValue = 12;
            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 98.339;
            Assert.AreEqual(wait, res);
        }
    }
}   