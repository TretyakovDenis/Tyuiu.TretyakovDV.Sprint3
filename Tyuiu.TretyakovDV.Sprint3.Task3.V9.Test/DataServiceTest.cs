using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TretyakovDV.Sprint3.Task3.V9.Lib;
namespace Tyuiu.TretyakovDV.Sprint3.Task3.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceNumOnChar()
        {
            DataService ds = new DataService();
            string value = "56hy vfe4r4 vf45b";
            char item = 'w';
            string res = ds.ReplaceNumOnChar(value, item);
            string wait = "wwhy vfewrw vfwwb";
            Assert.AreEqual(wait, res);
        }
    }
}