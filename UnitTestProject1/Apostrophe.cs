using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumeronymCreator;

namespace UnitTestProject1
{
    [TestClass]
    public class Apostrophe
    {
        [TestMethod]
        public void TestApostrophe()
        {
            String output = NumeronymHelper.NumeronymizeSentence("That's something, isn't it?");
            Assert.AreEqual(output, "T2t's0s s7g, i1n't0t i0t?");
        }
    }
}
