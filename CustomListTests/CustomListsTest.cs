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
            CustomList<string> customList = new CustomList<string>() { };

            //Act
            customList.Add("packers");
            customList.Add("vikings");
            customList.Add("bears");
            customList.Add("cowboys");
            customList.Remove("bears");
            //Assert
            Assert.AreEqual(customList.Count, 3);
        }

        [TestMethod]
        public void Remove_OneInt_VerifyIntExistsInArray()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>() { 25, 50, 75, 100 };
            //Act
            bool Example = customList.Remove(50);
            //Assert
            Assert.IsTrue(Example);
        }

        [TestMethod]
        public void Remove_OneInt_VerifyIntDoesNotExistInArray()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>() { 25, 50, 75, 100 };
            //Act
            bool Example = customList.Remove(60);
            //Assert
            Assert.IsFalse(Example);
        }



        [TestMethod]
        public void Iterate_ListOfInts_VerifyAllIntsInIteration()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();

            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            int result = 0;

            //Act
            foreach (int num in customList)
            {
                result += num;
            }

            //Assert
            Assert.AreEqual(result, 10);
        }

        [TestMethod]
        public void Iterate_ListOfStrings_VerifyAllStringsInIteration()
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>();

            customList.Add("Roscoe");
            customList.Add("is");
            customList.Add("pretty");
            customList.Add("neat");
            string result = "";

            //Act
            foreach (string word in customList)
            {
                result += word;
            }

            //Assert
            Assert.AreEqual(result, "Roscoeisprettyneat");
        }

        [TestMethod]
        public void OverrideToString_IntToString_VerifyIntToString()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            string answer;
            customList.Add(3);
            //Act
            answer = customList.ToString();
            //Assert
            Assert.AreEqual(answer, "3");
        }

        [TestMethod]
        public void ZipLists_ZipTwoStrings_VerifyCountAfterZip()
        {
            //Arrange
            CustomList<string> listOne = new CustomList<string>();
            CustomList<string> listTwo = new CustomList<string>();
            listOne.Add("A");
            listOne.Add("B");
            listOne.Add("C");
            listTwo.Add("1");
            listTwo.Add("2");
            listTwo.Add("3");

            //Act  
            CustomList<string> customZipList = CustomList<string>.Zip(listOne, listTwo);

            //Assert
            Assert.AreEqual(customZipList.Array.Length, 6);
        }

        [TestMethod]
        public void ZipLists_ZipTwoStrings_EnsureAccurateOrderOfList()
        {
            //Arrange
            CustomList<string> listOne = new CustomList<string>();
            CustomList<string> listTwo = new CustomList<string>();
            listOne.Add("A");
            listOne.Add("B");
            listOne.Add("C");
            listTwo.Add("1");
            listTwo.Add("2");
            listTwo.Add("3");
            //Act
            CustomList<string> customZipList = CustomList<string>.Zip(listOne, listTwo);
            //Assert
            Assert.AreEqual(customZipList.Array[2], "B" );
        }

        [TestMethod]
        public void ZipLists_ZipTwoIntLists_EnsureAccurateOrderOfList()
        {
            //Arrange
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            listOne.Add(1);
            listOne.Add(3);
            listOne.Add(5);
            listTwo.Add(2);
            listTwo.Add(4);
            listTwo.Add(6);
            //Act
            CustomList<int> customZipList = CustomList<int>.Zip(listOne, listTwo);
            //Assert
            Assert.AreEqual(customZipList.Array[3], 4);
        }

        [TestMethod]
        public void OverLoadPlus_TwoStringLists_VerifyLengthOfNewList()
        {
            //Arrange
            CustomList<string> strListOne = new CustomList<string>();
            CustomList<string> strListTwo = new CustomList<string>();
            strListOne.Add("lions");
            strListOne.Add("tigers");
            strListOne.Add("bears");
            strListTwo.Add("oh");
            strListTwo.Add("my");

            //Act
            CustomList<string> strResult = CustomList<string>.OverloadAdditionOperator(strListOne, strListTwo);

            //Assert
            Assert.AreEqual(strResult.Array.Length, 5);
        }

        [TestMethod]
        public void OverLoadPlus_TwoStringLists_VerifyIndexPositionOfNewList()
        {
            //Arrange
            CustomList<string> strListOne = new CustomList<string>();
            CustomList<string> strListTwo = new CustomList<string>();
            strListOne.Add("lions");
            strListOne.Add("tigers");
            strListOne.Add("bears");
            strListTwo.Add("oh");
            strListTwo.Add("my");

            //Act
            CustomList<string> strResult = CustomList<string>.OverloadAdditionOperator(strListOne, strListTwo);

            //Assert
            Assert.AreEqual(strResult.Array[3], "oh");
        }

        [TestMethod]
        public void OverLoadPlus_TwoIntLists_VerifyIndexPositionOfNewList()
        {
            //Arrange
            CustomList<int> intListOne = new CustomList<int>();
            CustomList<int> intListTwo = new CustomList<int>();
            intListOne.Add(10);
            intListOne.Add(20);
            intListOne.Add(30);
            intListTwo.Add(40);
            intListTwo.Add(50);

            //Act
            CustomList<int> intResult = CustomList<int>.OverloadAdditionOperator(intListOne, intListTwo);

            //Assert
            Assert.AreEqual(intResult.Array[4], 50);
        }




    }
}
