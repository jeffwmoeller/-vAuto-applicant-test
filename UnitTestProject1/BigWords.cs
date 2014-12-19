using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumeronymCreator;


namespace UnitTestProject1
{
    [TestClass]
    public class BigWords
    {
        [TestMethod]
        public void TestBigWords()
        {
            String output = NumeronymHelper.NumeronymizeSentence("abcdefghijklmnopqrstuvwxyz - OneLongWordLikeThis");
            Assert.AreEqual(output, "a24z - O12s");
        }
    }
}
