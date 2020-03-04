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

        [Test]
        public void TestExceptionA()
        {
            
            var ex = Assert.Throws<HaromszogHiba>(()=> new DHaromszog("0;3;4", 1));
            Assert.AreEqual("Az a oldal nem lehet 0!", ex.Message);
        }

        [Test]
        public void TestExceptionB()
        {

            var ex = Assert.Throws<HaromszogHiba>(() => new DHaromszog("2;0;4", 1));
            Assert.AreEqual("A b oldal nem lehet 0!", ex.Message);
        }

        [Test]
        public void TestExceptionC()
        {

            var ex = Assert.Throws<HaromszogHiba>(() => new DHaromszog("2;3;0", 1));
            Assert.AreEqual("A c oldal nem lehet 0!", ex.Message);
        }

        [Test]
        public void TestExceptionEllDerekszogu()
        {

            var ex = Assert.Throws<HaromszogHiba>(() => new DHaromszog("3;4;4", 1));
            Assert.AreEqual("Ez nem derékszögű!", ex.Message);
        }

        [Test]
        public void TestExceptionEllNovekvoSorrend()
        {

            var ex = Assert.Throws<HaromszogHiba>(() => new DHaromszog("5;4;3", 1));
            Assert.AreEqual("Az oldalak sorrendje rossz!", ex.Message);
        }

        [Test]
        public void TestExceptionEllMegszerkesztheto()
        {

            var ex = Assert.Throws<HaromszogHiba>(() => new DHaromszog("3;4;8", 1));
            Assert.AreEqual("Ez nem szerkeszthető meg!", ex.Message);
        }
    }
}