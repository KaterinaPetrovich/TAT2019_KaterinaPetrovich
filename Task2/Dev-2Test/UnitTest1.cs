using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task2;

namespace Dev_2Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestÑheck()
        {
            string checkingWord = "àåîáïõü";
            int[] expected = new int[7] { 1, 2, 3, 4, 5, 6, 7 };
            Word word = new Word();
            int[] actual = word.Ñheck(checkingWord);
            for (int i = 0; i < checkingWord.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod]
        public void TestAddPlus()
        {
            string checkingWord = "êîò";
            string expected = "êî+ò";
            Word word = new Word();
            string actual = word.AddPlus(checkingWord);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestFonemaBuild()
        {
            string checkingWord = "¸ëêà";
            string expected = "éîëêà";
            int[] matrix = new int[4] { 2, 0, 4,1};
            Word word = new Word();
            string actual = word.FonemaBuild(checkingWord, matrix,1);
            Assert.AreEqual(expected, actual);
        }
       

    }
}
