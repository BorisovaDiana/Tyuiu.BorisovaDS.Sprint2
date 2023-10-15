using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BorisovaDS.Sprint2.Task4.V15.Lib;

namespace Tyuiu.BorisovaDS.Sprint2.Task4.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 1;
            double res = ds.Calculate(x, y);
            double wait = 625;
            Assert.AreEqual(wait, res);

        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 484;
            double res = ds.Calculate(x, y);
            double wait = 1.731;
            Assert.AreEqual(wait, res);

        }
    }
}
