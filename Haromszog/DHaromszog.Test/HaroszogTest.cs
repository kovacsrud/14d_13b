using System;
using NUnit.Framework;
using Haromszog;


namespace Haromszog.Test
{
    [TestFixture]
    public class HaroszogTest
    {
        [Test]
        public void TestKerulet()
        {
            //Arrange
            var haromszog = new DHaromszog("3;4;5",1);
            //Act

            //Assert
            Assert.AreEqual(12, haromszog.Kerulet);
        }

        [Test]
        public void TestType()
        {
            var haromszog= new DHaromszog("3;4;5", 1);

            Assert.IsNotNull(haromszog);
            Assert.IsInstanceOf(typeof(DHaromszog), haromszog);
            
        }
    }
}