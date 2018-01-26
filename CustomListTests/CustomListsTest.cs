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
            CustomList<int> customList = new CustomList<int>();
            //Arrange
            int customListOne = 10;
            int customListTwo = 20;

            //Act
            customList.Add(customListOne);
            customList.Add(customListTwo);

            //Assert
            Assert.AreSame(customList.Count, 2); 
        }


        [TestMethod]
        public void Add_TwoNums_TwoNumsAddedToExistingList(int value)
        {
            CustomList<int> customList = new CustomList<int>() {};
            //Arrange

            int customListOne = 10;
            int customListTwo = 20;
            int customListThree = 30;
            int customListFour = 40;

            //Act
            customList.Add(customListOne);
            customList.Add(customListTwo);

            //Assert
            Assert.AreSame(customList.Count, 4);
        }

        [TestMethod]
        public void Add_TwoNums_VerifyCorrectIndex(int value)
        {
            CustomList<int> customList = new CustomList<int>() { };
            //Arrange
            int customListOne = 10;
            int customListTwo = 20;
            int customListThree = 30;
            int customListFour = 40;

            //Act
            customList.Add(customListOne);
            customList.Add(customListTwo);
            customList.Add(customListThree);
            customList.Add(customListFour);

            //Assert
            Assert.AreSame(customList[3], 40);
        }

        [TestMethod]
        public void Add_TwoNum_VerifyIndexPosition(int value)
        {
            CustomList<int> customList = new CustomList<int>();
            //Arrange
            int customListOne = 10;
            int customListTwo = 20;

            //Act
            customList.Add(customListOne);
            customList.Add(customListTwo);

            //Assert
            Assert.AreSame(customList[1], 10);
        }

        [TestMethod]
        public void Add_TwoStrings_VerifyCount(string value)
        {
            CustomList<string> customList = new CustomList<string>();
            //Arrange
            string customListOne = "Hello";
            string customListTwo = "World";

            //Act
            customList.Add(customListOne);
            customList.Add(customListTwo);

            //Assert
            Assert.Equals(customList.Count, 2);
        }

        [TestMethod]
        public void Add_TwoStrings_VerifyIndexPosition(string value)
        {
            CustomList<string> customList = new CustomList<string>();
            //Arrange
            string customListOne = "Hello";
            string customListTwo = "World";

            //Act
            customList.Add(customListOne);
            customList.Add(customListTwo);

            //Assert
            Assert.Equals(customList[1], "World");
        }




        //[TestMethod]
        //public void RemoveFromList(int value)
        //{
        //    CustomList<int> customList = new CustomList<int>() { 10, 20, 30, 40 };
        //    //Arrange
        //    int testOne = 1;

        //    //Act
        //    customList.RemoveFromList();

        //    //Assert
        //    Assert.AreSame(customList.count, 2);
        //}

    }
}
