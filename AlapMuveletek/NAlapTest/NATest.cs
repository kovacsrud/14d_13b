using System;
using NUnit.Framework;
using AlapMuveletek;

namespace NAlapTest
{
    [TestFixture]
    public class NATest
    {
        [Test]
        public void TestOsszead()
        {
            
            var sut = new Alapmuvelet();

            Assert.IsNotNull(sut);
            Assert.AreEqual(10,sut.Osszead(5,5));
        }
    }
}