using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumeronymCreator;

namespace UnitTestProject1
{
    [TestClass]
    public class EmptySentence
    {
        [TestMethod]
        public void TestEmptySentence()
        {
            String output = NumeronymHelper.NumeronymizeSentence("");
            Assert.IsTrue( String.IsNullOrEmpty(output));
        }
    }
}
