using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task2;

namespace Dev_2Test
{
    [TestClass]
    public class UnitTest1
    {
<<<<<<< HEAD
        Word word;
        [TestInitialize]
        public void TestInitialize()
        {
            word = new Word();
        }

=======
>>>>>>> a5529a7ae263e2d32c6aaa421e7bb75135bdc880
        [TestMethod]
        public void TestСheck()
        {
            string checkingWord = "аеобпхь";
            int[] expected = new int[7] { 1, 2, 3, 4, 5, 6, 7 };
<<<<<<< HEAD
=======
            Word word = new Word();
>>>>>>> a5529a7ae263e2d32c6aaa421e7bb75135bdc880
            int[] actual = word.Сheck(checkingWord);
            for (int i = 0; i < checkingWord.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod]
        public void TestAddPlus()
        {
            string checkingWord = "кот";
            string expected = "ко+т";
<<<<<<< HEAD
=======
            Word word = new Word();
>>>>>>> a5529a7ae263e2d32c6aaa421e7bb75135bdc880
            string actual = word.AddPlus(checkingWord);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestFonemaBuild()
        {
            string checkingWord = "ёлка";
            string expected = "йолка";
<<<<<<< HEAD
            int[] matrix = new int[4] { 2, 0, 4, 1 };
            string actual = word.FonemaBuild(checkingWord, matrix,1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCheckWordForOneSyllable()
        {
            string checkingWord = "кот";
            bool expected = true;
            bool actual = word.CheckWordForOneSyllable(checkingWord);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSearchAndDeleteStress()
        {
            string checkingWord = "молоко+";
            string expected = "молоко";
            int stress = 1;
            string actual = word.SearchAndDeleteStress(checkingWord, out stress);
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(stress, 5);
        }

        }
=======
            int[] matrix = new int[4] { 2, 0, 4,1};
            Word word = new Word();
            string actual = word.FonemaBuild(checkingWord, matrix,1);
            Assert.AreEqual(expected, actual);
        }
       

    }
>>>>>>> a5529a7ae263e2d32c6aaa421e7bb75135bdc880
}
