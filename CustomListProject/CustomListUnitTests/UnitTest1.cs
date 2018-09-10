using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;
using System.Collections;
using System.Collections.Generic;

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
            int expectedResult = 1;
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
            Assert.AreEqual(expectedResult, test[0]);
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
        [TestMethod]
        public void Add_CheckValueIndex3()
        {
            //arrange
            CustomList<int> test = new CustomList<int>();
            int expectedResult1 = 2;
            int expectedResult2 = 16;
            int expectedResult3 = 3;

            //act
            test.Add(expectedResult1);
            test.Add(expectedResult2);
            test.Add(expectedResult3);

            //assert
            Assert.AreEqual(expectedResult3, test[2]);
        }
        [TestMethod]
        public void Add_CheckValueIndex4()
        {
            //arrange
            CustomList<int> test = new CustomList<int>();
            int expectedResult1 = 2;
            int expectedResult2 = 16;
            int expectedResult3 = 3;
            int expectedResult4 = 7;

            //act
            test.Add(expectedResult1);
            test.Add(expectedResult2);
            test.Add(expectedResult3);
            test.Add(expectedResult4);

            //assert
            Assert.AreEqual(expectedResult4, test[3]);
        }
        //this is the point at which the array size needs to increase

        [TestMethod]
        public void Add_CheckValueIndex5()
        {
            //arrange
            CustomList<int> test = new CustomList<int>();
            int expectedResult1 = 2;
            int expectedResult2 = 16;
            int expectedResult3 = 3;
            int expectedResult4 = 7;
            int expectedResult5 = 6;

            //act
            test.Add(expectedResult1);
            test.Add(expectedResult2);
            test.Add(expectedResult3);
            test.Add(expectedResult4);
            test.Add(expectedResult5);

            //assert
            Assert.AreEqual(expectedResult5, test[4]);
        }
        [TestMethod]
        public void Add_CheckLargerIndex()
        {
            //arrange
            CustomList<int> test = new CustomList<int>();
            //act
            for (int i= 0; i<100;i++)
            {
                test.Add(i);
            }

            //assert
            Assert.AreEqual(99, test[99]);
        }


        [TestMethod]
        public void Remove_CheckIndexZero()
        {
            //arrange
            CustomList<int> test = new CustomList<int>();
            test.Add(1);
            test.Add(2);
            test.Add(3);
            test.Add(4);
            int expectedResult = 2;

            //act
            test.Remove(1);
            //assert
            Assert.AreEqual(expectedResult, test[0]);
        }
        [TestMethod]

        public void Remove_CheckListCount()
        {
            //arrange 
            CustomList<int> test = new CustomList<int>();
            test.Add(1);
            test.Add(2);
            test.Add(3);
            test.Add(4);

            int expectedResult = 3;

            //act
            test.Remove(1);
            //assert
            Assert.AreEqual(expectedResult, test.Count);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Remove_nonexistentint()
        {
            //arrange
            CustomList<int> test = new CustomList<int>();
            test.Add(1);
            test.Add(2);
            test.Add(3);
            test.Add(4);
            //act
            test.Remove(7);
        }

        [TestMethod]
        public void Remove_RemoveAllRepeats()
        {
            //arrange
            //the remove funtion in this list method will remove all repeat instances of an item
            CustomList<int> test = new CustomListProject.CustomList<int>();
            test.Add(1);
            test.Add(2);
            test.Add(2);
            test.Add(3);
            test.Add(4);

            int expectedResult = 3;

            //act
            test.Remove(2);

            //assert 
            Assert.AreEqual(expectedResult, test.Count);
        }
        //[TestMethod]
        //public void Zip_testNewListCount()
        //{
        //    //arrange
        //    CustomList<int> even = new CustomList<int>();
        //    even.Add(2);
        //    even.Add(4);
        //    even.Add(6);

        //    CustomList<int> odd = new CustomList<int>();
        //    odd.Add(1);
        //    odd.Add(3);
        //    odd.Add(5);

        //    int expectedResult = 6;
        //    //act
        //    Assert.AreEqual(expectedResult, actual)
        //} 
    }
}

