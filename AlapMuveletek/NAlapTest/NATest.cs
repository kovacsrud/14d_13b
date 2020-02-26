using System;
using NUnit.Framework;
using AlapMuveletek;

namespace NAlapTest
{
    [TestFixture]
    public class NATest
    {
        [Test]
        [TestCase(10,10,20)]
        [TestCase(10,20,30)]
        [TestCase(30.5,30.48,61)]
        public void TestOsszead(double a,double b,double elvart)
        {
            
            var sut = new Alapmuvelet();

            Assert.IsNotNull(sut);
            Assert.AreEqual(elvart,sut.Osszead(a,b),0.03);
        }
    }
}