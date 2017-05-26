using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TDD;

namespace TDD
{
    [TestFixture]
    public class MatematicaMalucaTest
    {
        [Test]
        public void DeveQuadruplicarNumeroMaiorQueTrinta()
        {
            Assert.AreEqual(160, new MatematicaMaluca().ContaMaluca(40));
        }

        [Test]
        public void DeveTriplicarNumeroMaiorQueDezEMenorOuIgualATrinta()
        {
            Assert.AreEqual(90, new MatematicaMaluca().ContaMaluca(30));
            Assert.AreEqual(60, new MatematicaMaluca().ContaMaluca(20));
        }

        [Test]
        public void DeveDuplicarNumeroIgualOuMenorADez()
        {
            Assert.AreEqual(20, new MatematicaMaluca().ContaMaluca(10));
            Assert.AreEqual(10, new MatematicaMaluca().ContaMaluca(5));
        }
    }
}
