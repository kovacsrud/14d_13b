using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlapMuveletek;

namespace Alapmuveletek.Test
{
    [TestClass]
    public class AlapTest
    {
        [TestMethod]
        public void OsszeadTest()
        {
            //Arrange
            //előkészületek pl. példányosítás
            Alapmuvelet alap = new Alapmuvelet();
            //Act
            //valamilyen tevékenység elvégzése 
            //metódus hívás 

            //Assert
            //Tesztelés, adott típusú-e, jó eredményt ad-e stb.
            Assert.IsNotNull(alap.Osszead(5, 5));
            Assert.AreEqual(20, alap.Osszead(10, 10));

        }

        [TestMethod]
        public void Kivonteszt()
        {
            var alap = new Alapmuvelet();
            Assert.IsNotNull(alap.Kivon(6,6));
            Assert.AreEqual(5, alap.Kivon(10, 5));
            
        }

        [TestMethod]
        public void Szorzasteszt()
        {
            var alap = new Alapmuvelet();
            Assert.IsNotNull(alap.Szoroz(6, 6));
            Assert.AreEqual(50, alap.Szoroz(10, 5));

        }

        [TestMethod]
        public void Osztasteszt()
        {
            var alap = new Alapmuvelet();
            Assert.IsNotNull(alap.Oszt(6, 6));
            Assert.AreEqual(2, alap.Oszt(10, 5));
            

        }
    }
}
