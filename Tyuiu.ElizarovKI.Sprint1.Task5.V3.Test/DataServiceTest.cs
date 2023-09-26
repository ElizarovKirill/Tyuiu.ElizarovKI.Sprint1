using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ElizarovKI.Sprint1.Task5.V3.Lib;

namespace Tyuiu.ElizarovKI.Sprint1.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            int k = 123456;
            int wait = 4;
            int res = ds.Calculate(k);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void InvalidExpression()
        {
            DataService ds = new DataService();

            int k = 123456;
            int wait = 6;
            int res = ds.Calculate(k);
            Assert.AreEqual(false, wait == res);
        }
    }
}
