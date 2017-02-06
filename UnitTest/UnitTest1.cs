using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace Unit_Test_1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Zip()
        {
            //arrange
            List<int> listL = new List<int>();
            listL.Add(1);
            listL.Add(2);
            List<int> listK = new List<int>();
            listK.Add(3);
            listK.Add(4);
            List<int> join = new List<int>();
            //act
            join = join.Zip(listL, listK);
            //assert
            Assert.AreEqual(4, join.Count);
        }
        [TestMethod]
        public void AddDifferentValues()
        {
            //arrange
            List<int> listOne = new List<int>();
            //act
            listOne.Add(30);
            listOne.Add(35);
            //assert
            Assert.AreNotSame(0, 1);
        }
        [TestMethod]
        public void RemoveInt()
        {
            //arrange
            List<int> listX = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int expected = 9;
            //act
            listX.Remove(4);
            int actual = listX.count;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IncreaseCapacity()
        {
            //arrange (capacity is set to 10)
            List<int> listY = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int expected = 14;
            //act
            listY.Add(11);
            listY.Add(12);
            listY.Add(13);
            listY.Add(14);

            int actual = listY.count;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CountItems()
        {
            //arrange
            List<int> listTwo = new List<int>() { 10, 20, 30, 40 };
            int expected = 4;
            //act
            int actual = listTwo.count;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddString()
        {
            //arrange
            List<string> listOne = new List<string>() {"cat", "dog", "bird"};
            int expected = 4;
            //act
            listOne.Add("snake");
            int actual = listOne.count;     
            //assert
            Assert.AreEqual(expected, actual);
        }
            [TestMethod]
            public void ToString()
        {
            //arrange
            List<string> listSeven = new List<string>();
            string expected = "HELLO";
            //act
            listSeven.Add("H");
            listSeven.Add("E");
            listSeven.Add("L");
            listSeven.Add("L");
            listSeven.Add("O");
            //assert
            Assert.AreEqual(expected, listSeven.ToString());
        }
        [TestMethod]
        public void RemoveString()
        {
            //arrange
            List<string> listZ = new List<string>() { "cat", "dog", "bird", "snake" };
            int expected = 3;
            //act
            listZ.Remove("cat");
            int actual = listZ.count;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddDecimal()
        {
            //arrange
            List<decimal> listDec = new List<decimal>();      
            //act
            listDec.Add(1.75m);
            listDec.Add(2.75m);
            listDec.Add(1.50m);
            listDec.Add(5.75m);
            listDec.Add(6.05m);
            listDec.Add(9.95m);
            listDec.Add(0.75m);
            //assert
            Assert.AreEqual(listDec.Count, 7);
        }
        [TestMethod]
        public void AddDifferentObjects()
        {
            //arrange
            List<object> listObject = new List<object>();
            //act
            listObject.Add(1.75m);
            listObject.Add("Hello");
            listObject.Add(51);
            listObject.Add(0.376482);
            listObject.Add("World");
            listObject.Add(9);
            //assert
            Assert.AreEqual(listObject.Count, 6);
        }
    }
}
