using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Custom_List_Unit_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddTest()
        {
            //arrange
            List<int> intList = new List<int>();
            //act
            intList.Add(11);
            intList.Add(22);
            intList.Add(33);
            //assert
            Assert.AreEqual(2, intList.IndexOf(2));
        }
    }
}
