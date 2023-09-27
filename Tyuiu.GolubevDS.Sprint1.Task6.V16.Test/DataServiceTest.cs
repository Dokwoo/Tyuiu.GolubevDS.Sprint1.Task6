using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GolubevDS.Sprint1.Task6.V16.Lib;
namespace Tyuiu.GolubevDS.Sprint1.Task6.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestValidString()
        {
            string strTest = "привет, как дела?";
            DataService ds = new DataService();
            int expectedCount = strTest.Length;
            int actualCount = ds.CheckLettersCount(strTest);
            string wait = "13 букв, 4 символа";
            Assert.AreEqual(expectedCount, actualCount, wait);
        }
    }
}
