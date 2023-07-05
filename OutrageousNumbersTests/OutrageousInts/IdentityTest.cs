using Microsoft.VisualStudio.TestTools.UnitTesting;
using OutrageousNumbers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutrageousNumbersTests.OutrageousInts
{
    [TestClass()]
    public class IdentityTest
    {
        // Test the additive identity
        [TestMethod()]
        public void AdditiveIdentityTest()
        {
            Assert.AreEqual(
                OutrageousInt.Zero,
                OutrageousInt.AdditiveIdentity,
                "OutrageousInt AdditiveIdentity not correct");
        }

        // Test the multiplicative identity
        [TestMethod()]
        public void MultiplicativeIdentityTest()
        {
            Assert.AreEqual(
                OutrageousInt.One,
                OutrageousInt.MultiplicativeIdentity,
                "OutrageousInt MultiplicativeIdentity not correct");
        }
    }
}
