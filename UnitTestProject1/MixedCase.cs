using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumeronymCreator;

namespace UnitTestProject1
{
    [TestClass]
    public class MixedCase
    {
        [TestMethod]
        public void TestMixedCase()
        {
            String output = NumeronymHelper.NumeronymizeSentence("upperUPPER");
            Assert.AreEqual(output, "u6R");
        }
    }
}
