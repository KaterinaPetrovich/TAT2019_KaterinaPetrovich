using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task2;

namespace Dev_2Test
{
    [TestClass]
    public class UnitTest1
    {
        Word word;
        [TestInitialize]
        public void TestInitialize()
        {
            word = new Word();
        }

        [TestMethod]
        public void Test�heck()
        {
            string checkingWord = "�������";
            int[] expected = new int[7] { 1, 2, 3, 4, 5, 6, 7 };
            int[] actual = word.�heck(checkingWord);
            for (int i = 0; i < checkingWord.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod]
        public void TestAddPlus()
        {
            string checkingWord = "���";
            string expected = "��+�";
            string actual = word.AddPlus(checkingWord);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestFonemaBuild()
        {
            string checkingWord = "����";
            string expected = "�����";
            int[] matrix = new int[4] { 2, 0, 4, 1 };
            string actual = word.FonemaBuild(checkingWord, matrix,1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCheckWordForOneSyllable()
        {
            string checkingWord = "���";
            bool expected = true;
            bool actual = word.CheckWordForOneSyllable(checkingWord);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSearchAndDeleteStress()
        {
            string checkingWord = "������+";
            string expected = "������";
            int stress = 1;
            string actual = word.SearchAndDeleteStress(checkingWord, out stress);
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(stress, 5);
        }

        }
}
