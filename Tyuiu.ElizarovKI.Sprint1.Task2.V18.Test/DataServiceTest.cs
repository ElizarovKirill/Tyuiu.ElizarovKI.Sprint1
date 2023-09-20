using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ElizarovKI.Sprint1.Task2.V18.Lib;

namespace Tyuiu.ElizarovKI.Sprint1.Task2.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2;
            int y = 3;
            int z = 2;
            var res = ds.CalculateSideSquareParallelepiped(x, z, y);
            Assert.AreEqual(12, res);
        }
    }
}
