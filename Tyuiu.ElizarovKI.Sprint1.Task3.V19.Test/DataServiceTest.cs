using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ElizarovKI.Sprint1.Task3.V19.Lib;

namespace Tyuiu.ElizarovKI.Sprint1.Task3.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        public void method(bool expectedResult, int startX, int endX, int startY, int endY)
        {
            DataService ds = new DataService();

            bool result = ds.ElephCanMove(startX, endX, startY, endY);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void ValidExpression()
        {
            this.method(true, 1, 8, 1, 8);
        }

        [TestMethod]
        public void InvalidExpression()
        {
            this.method(false, 1, 8, 3, 8);
        }
    }
}
