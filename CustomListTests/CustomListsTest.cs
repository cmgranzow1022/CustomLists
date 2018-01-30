using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomLists;

namespace CustomListTests
{

    [TestClass]
    public class CustomListTest
    {

        [TestMethod]
        public void Add_TwoNums_TwoNumsAddedToList(int value)
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();

            //Act
            customList.Add(10);
            customList.Add(20);

            //Assert
            Assert.AreSame(customList.Count, 2);
        }

        [TestMethod]
        public void Add_FourNums_FourNumsAddedToExistingList()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>() { };

            //Act
            customList.Add(10);
            customList.Add(20);
            customList.Add(30);
            customList.Add(40);

            //Assert
            Assert.AreEqual(customList.Count, 4);
        }

        [TestMethod]
        public void Add_TwoNumsToExistingList_VerifyCorrectIndexPosition()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>() { 10, 20 };

            //Act
            customList.Add(30);
            customList.Add(40);
            customList.Add(50);
            customList.Add(60);

            //Assert
            Assert.AreEqual(customList.Array[3], 40);
        }

        [TestMethod]
        public void Add_TwoNum_VerifyZeroIndexPosition()
        {
            CustomList<int> customList = new CustomList<int>();
            //Arrange
            int customListOne = 10;
            int customListTwo = 20;

            //Act
            customList.Add(customListOne);
            customList.Add(customListTwo);

            //Assert
            Assert.AreEqual(customList.Array[0], 10);
        }

        [TestMethod]
        public void Add_TwoStrings_VerifyCount()
        {
            CustomList<string> customList = new CustomList<string>();
            //Arrange
            string customListOne = "Hello";
            string customListTwo = "World";

            //Act
            customList.Add(customListOne);
            customList.Add(customListTwo);

            //Assert
            Assert.AreEqual(customList.Count, 2);
        }

        [TestMethod]
        public void Add_TwoStrings_VerifyIndexPosition()
        {
            CustomList<string> customList = new CustomList<string>();
            //Arrange
            string customListOne = "Hello";
            string customListTwo = "World";

            //Act
            customList.Add(customListOne);
            customList.Add(customListTwo);

            //Assert
            Assert.AreEqual(customList.Array[1], "World");
        }

        [TestMethod]
        public void Add_EightNums_EightNumsAddedToList()
        {

            //Arrange
            CustomList<int> customList = new CustomList<int>() { };

            //Act
            customList.Add(10);
            customList.Add(20);
            customList.Add(30);
            customList.Add(40);
            customList.Add(50);
            customList.Add(60);
            customList.Add(70);
            customList.Add(80);

            //Assert
            Assert.AreEqual(customList.Count, 8);
        }

        //test methods for Remove method

        [TestMethod]
        public void Remove_OneInt_VerifyCountAfterRemovingOneIntFromExistingList()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>() { 10, 20, 30, 40 };

            //Act
            customList.Remove(10);

            //Assert
            Assert.AreEqual(customList.Count, 3);
        }

        [TestMethod]
        public void Remove_LastInt_VerifyIndexPositionAfterRemovingLastInt()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>() { 10, 20, 30, 40 };
            //Act
            customList.Remove(30);
            //Assert
            Assert.AreEqual(customList.Array[2], 40);
        }

        [TestMethod]
        public void Remove_TwoStrings_VerifyIndexPositionAfterRemovingFirstTwoStrings()
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>() { };

            //Act
            customList.Add("lions");
            customList.Add("tigers");
            customList.Add("bears");
            customList.Add("oh");
            customList.Add("my");
            customList.Remove("lions");
            customList.Remove("tigers");
            //Assert
            Assert.AreEqual(customList.Array[2], "my");
        }


        [TestMethod]
        public void Remove_OneString_VerifyCountAfterRemovingString()
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>() { "packers", "vikings", "bears", "cowboys" };

            //Act
            customList.Remove("bears");
            //Assert
            Assert.AreEqual(customList.Count, 3);
        }

        //public void Remove_OneInt_VerifyIntExistsInArray()
        //{
        //    //Arrange
        //    CustomList<int> customList = new CustomList<int>() { 25, 50, 75, 100 };
        //    //Act
        //    bool Example = customList.Remove(50);
        //    //Assert
        //    Assert.IsTrue( );

        //}

    }
}
