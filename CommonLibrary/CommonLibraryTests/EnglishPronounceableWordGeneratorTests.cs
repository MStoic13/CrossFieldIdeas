using CommonLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CommonLibraryTests
{
    [TestClass]
    public class EnglishPronounceableWordGeneratorTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            string output = EnglishPronounceableWordGenerator.GetWord();
            Assert.AreEqual(true, output.Length >= 2 && output.Length <= 12);
        }
    }
}
