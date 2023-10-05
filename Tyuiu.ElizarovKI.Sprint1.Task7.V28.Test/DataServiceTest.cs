using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ElizarovKI.Sprint1.Task7.V28.Lib;

namespace Tyuiu.ElizarovKI.Sprint1.Task7.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 2;
            double z = 4.787;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(z, res);
        }
    }
}
