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
            for (int i = 0; i < 100; i++)
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
        public void Remove_CheckIndexOne()
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
            Assert.AreEqual(expectedResult, test[1]);
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
        [TestMethod]

        public void ToString_CheckNewResult()
        {
            //arrange

            CustomList<int> test = new CustomList<int>();
            test.Add(1);
            test.Add(2);
            test.Add(2);
            test.Add(3);
            test.Add(4);
            string expectedResult = "1 , 2 , 2 , 3 , 4 , ";

            // act
            string actual = test.ToString();
            //assert
            Assert.AreEqual(expectedResult, actual);
        } 

        [TestMethod]

        public void ToString_CheckLargerCount()
        {
            //arrange
            CustomList<int> test = new CustomList<int>();
            test.Add(1);
            test.Add(2);
            test.Add(3);
            test.Add(4);
            test.Add(5);
            test.Add(6);
            test.Add(7);
            test.Add(8);
            test.Add(9);
            test.Add(10);
            test.Add(11);
            string expectedResult = "1 , 2 , 3 , 4 , 5 , 6 , 7 , 8 , 9 , 10 , 11 , ";

            //act
            //test.ToString();

            // assert
            Assert.AreEqual(expectedResult, test.ToString());
        }

        [TestMethod]
        public void ToString_CheckIindividualString()
        {
            //arrange
            CustomList<int> test = new CustomList<int>();
            test.Add(1);
            test.Add(2);
            test.Add(2);
            test.Add(3);
            test.Add(4);
            string expectedResult = "1";

            //act
           for (int i = 0; i < 1; i++)
            {

            }

            // act
            test.ToString();
         
            //assert
            Assert.AreEqual(expectedResult, test.ToString());
        } 

        [TestMethod]
        public void ToString_CheckIndexFive()
        {
            //arrange
            CustomList<int> test = new CustomList<int>();
            test.Add(1);
            test.Add(2);
            test.Add(2);
            test.Add(3);
            test.Add(4);
            string expectedResult = "4";

            // act
            test.ToString();
            //assert
            Assert.AreEqual(expectedResult, test[4]);
        }

      /*  //do not know how to check this */
        [TestMethod]
        public void Itterable_PrintList()
        {
            //arrange
            CustomList<int> test = new CustomList<int>();
            test.Add(1);
            test.Add(2);
            test.Add(2);
            test.Add(3);
            test.Add(4);


            //act 

            for (int i = 0; i < test.Count; i++)
            {
                Console.WriteLine(i);
            }
            //Assert.AreEqual(?,Console.WriteLine(4));
        }
        
        [TestMethod]
        public void Zip_testNewListCount()
        {
            //arrange
            CustomList<int> even = new CustomList<int>();
            even.Add(2);
            even.Add(4);
            even.Add(6);

            CustomList<int> odd = new CustomList<int>();
            odd.Add(1);
            odd.Add(3);
            odd.Add(5);

            CustomList<int> zippedList = new CustomList<int>();

            int expectedResult = 6;
            //act

            CustomList<int> result = CustomList<int>.Zip(odd, even);

            //Assert
            Assert.AreEqual(expectedResult, result.Count);
        }
        //write test method for uneven lists[TestMethod]
        [TestMethod]
        public void Zip_TestNewListAtIndexZero()
        {
            //arrange
            CustomList<int> even = new CustomList<int>();
           
            even.Add(2);
            even.Add(4);
            even.Add(6);

            CustomList<int> odd = new CustomList<int>();
            odd.Add(1);
            odd.Add(3);
            odd.Add(5);


            int expectedResult = 1;
            //act
            CustomList<int> result = CustomList<int>.Zip(odd, even);

            //assert
            Assert.AreEqual(expectedResult, result[0]);
        } 
        [TestMethod]
        public void Zip_TestNewListAtIndexOne()
        { 
            //arrange
            CustomList<int> even = new CustomList<int>();
            even.Add(2);
            even.Add(4);
            even.Add(6);

            CustomList<int> odd = new CustomList<int>();
            odd.Add(1);
            odd.Add(3);
            odd.Add(5);

            int expectedResult = 2;
            
            //act
            CustomList<int> result = CustomList<int>.Zip(odd, even);

            //assert
            Assert.AreEqual(expectedResult, result[1]);
        } 
        [TestMethod]
        public void Zip_TestNewListAtIndexTwo()
        {
            //arrange
            CustomList<int> even = new CustomList<int>();
            even.Add(2);
            even.Add(4);
            even.Add(6);

            CustomList<int> odd = new CustomList<int>();
            odd.Add(1);
            odd.Add(3);
            odd.Add(5);

            CustomList<int> zippedList = new CustomList<int>();

            int expectedResult = 3;
            //act
            CustomList<int> result = CustomList<int>.Zip(odd, even);

            //assert
            Assert.AreEqual(expectedResult, result[2]);
        } 
        [TestMethod]
        public void Plus_CheckCount()
        {
            //arrange
            CustomList<int> result = new CustomList<int>();

            CustomList<int> first = new CustomList<int>();
            first.Add(1);
            first.Add(2);
            first.Add(3);

            CustomList<int> second = new CustomList<int>();
            second.Add(4);
            second.Add(5);
            second.Add(6);

            int expectedResult = 6;

            //act
            //how do I call the operator override for my test?
           
              result = first + second;

            //assert
            Assert.AreEqual(expectedResult, result.Count);
        }
        [TestMethod]
        public void Plus_CheckIndexZero()
        {
            //arrange
            CustomList<int> first = new CustomList<int>();
            first.Add(1);
            first.Add(2);
            first.Add(3);

            CustomList<int> second = new CustomList<int>();
            second.Add(4);
            second.Add(5);
            second.Add(6);

            CustomList<int> result = new CustomList<int>();
            int expectedResult = 1;

            ////act
            result = first + second;
            //assert
            Assert.AreEqual(expectedResult, result[0]);
        }
        [TestMethod]
        public void Plus_CheckIndexThree()
        {
            //arrange
            CustomList<int> first = new CustomList<int>();
            first.Add(1);
            first.Add(2);
            first.Add(3);

            CustomList<int> second = new CustomList<int>();
            second.Add(4);
            second.Add(5);
            second.Add(6);

            CustomList<int> result = new CustomList<int>();
            int expectedResult = 4;

            //act
            result = first + second;
            //assert
            Assert.AreEqual(expectedResult, result[3]);
        }
        [TestMethod]

        public void Minus_CheckIndexZero()
        {
            CustomList<int> first = new CustomList<int>();
            first.Add(1);
            first.Add(2);
            first.Add(3);

            CustomList<int> second = new CustomList<int>();
            second.Add(4);
            second.Add(1);
            second.Add(6);

            CustomList<int> result = new CustomList<int>();
            int expectedResult = 2;

            //act
            result = first - second;

            //assert
            Assert.AreEqual(expectedResult, result[0]);
        } 
        [TestMethod]
        public void Minus_CheckIndexOne()
        {
            CustomList<int> first = new CustomList<int>();
            first.Add(1);
            first.Add(2);
            first.Add(3);

            CustomList<int> second = new CustomList<int>();
            second.Add(4);
            second.Add(1);
            second.Add(6);

            CustomList<int> result = new CustomList<int>();
            int expectedResult = 3;

            //act
            result = first - second;

            //assert
            Assert.AreEqual(expectedResult, result[1]);
        } 
    }
}

