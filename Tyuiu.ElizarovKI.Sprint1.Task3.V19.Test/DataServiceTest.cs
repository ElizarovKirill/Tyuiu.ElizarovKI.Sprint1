using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ElizarovKI.Sprint1.Task3.V19.Lib;

namespace Tyuiu.ElizarovKI.Sprint1.Task3.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            int startX = 1;
            int startY = 1;
            int endX = 8;
            int endY = 8;

            DataService ds = new DataService();

            bool result = ds.ElephCanMove(startX, endX, startY, endY);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void InvalidExpression()
        {
            int startX = 1;
            int startY = 1;
            int endX = 2;
            int endY = 3;

            DataService ds = new DataService();

            bool result = ds.ElephCanMove(startX, endX, startY, endY);
            Assert.AreEqual(false, result);
        }
    }
}
