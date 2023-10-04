using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ElizarovKI.Sprint1.Task6.V15.Lib;

namespace Tyuiu.ElizarovKI.Sprint1.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "1123fsdrhv";
            DataService ds = new DataService();
            bool res = ds.CheckLettersCount(strTest);
            Assert.AreEqual(true, res);
        }
    }
}
