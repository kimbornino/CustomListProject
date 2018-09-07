using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace CustomListUnitTests

{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void Add_CheckIfCountIncreases()
        {
            //arrange
            CustomList<int> test = new CustomList<int>();
            test.count
                int expectedaResult;
            //act
            test.Add(2);//2 because it needs an int
                        //assert
            Assert.AreEqual(expectedResult, test.Count);
        }
        [TestMethod]
        public void Add_CheckValueIndex0()
        {
            //arrange
            CustomList<int> test = new CustomList<int>();
            int expectedResult = 2;

            //act
            test.Add(expectedResult);

            //Assert
            Assert.AreEqual(expectedReult, test[0]);
        }
        [TestMethod]
        public void Add_CheckValueIndex1()
        {
            //arrange
            CustomList<int> test = new CustomList<int>();
            int expectedResult1 = 2;
            int expectedResult2 = 16;

            //act
            test.Add(expectedResult1);
            test.Add(expectedResult2);

            //assert
            Assert.AreEqual(expectedResult2, test[1]);
        }
    }
}
