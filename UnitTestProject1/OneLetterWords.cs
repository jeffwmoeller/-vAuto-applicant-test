using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumeronymCreator;

namespace UnitTestProject1
{
    [TestClass]
    public class OneLetterWords
    {
        [TestMethod]
        public void TestOneLetterWords()
        {
            String output = NumeronymHelper.NumeronymizeSentence("A I,a");
            Assert.AreEqual(output, "A0A I0I,a0a");
        }
    }
}
