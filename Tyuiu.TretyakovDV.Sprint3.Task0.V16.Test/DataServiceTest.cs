using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TretyakovDV.Sprint3.Task0.V16.Lib;
namespace Tyuiu.TretyakovDV.Sprint3.Task0.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidValue()
        {
            DataService ds = new DataService();
            int value = 6;
            int startValue = 2;
            int stopValue = 6;
            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 216;
            Assert.AreEqual(wait, res);
        }
    }
}