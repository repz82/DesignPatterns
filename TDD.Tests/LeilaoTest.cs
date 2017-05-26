using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.Tests
{
    [TestFixture]
    public class LeilaoTest
    {
        private Usuario usuario1;
        private Usuario usuario2;
        private Usuario usuario3;

        [SetUp]
        public void CriaAvaliador()
        {
            usuario1 = new Usuario("Usuario 1");
            usuario2 = new Usuario("Usuario 2");
            usuario3 = new Usuario("Usuario 3");
        }

        [Test]
        public void DeveReceberUmLance()
        {
            var leilao = new LeilaoBuilder().Para("A200")
                .Constroi();
            Assert.AreEqual(0, leilao.Lances.Count);

            leilao = new LeilaoBuilder().Para("A200")
                .Lance(usuario1, 50000)
                .Constroi();

            Assert.AreEqual(1, leilao.Lances.Count);
            Assert.AreEqual(50000, leilao.Lances[0].Valor);
        }

        [Test]
        public void DeveReceberVariosLances()
        {
            var leilao = new LeilaoBuilder().Para("A200")
                .Lance(usuario1, 50000)
                .Lance(usuario2, 150000)
                .Constroi();

            Assert.AreEqual(2, leilao.Lances.Count);
            Assert.AreEqual(50000, leilao.Lances[0].Valor);
            Assert.AreEqual(150000, leilao.Lances[1].Valor);
        }

        [Test]
        public void NaoDeveAceitarDoisLancesSeguidosDoMesmoUsuario()
        {
            var leilao = new LeilaoBuilder().Para("A200")
                .Lance(usuario1, 50000)
                .Lance(usuario1, 150000)
                .Constroi();

            Assert.AreEqual(1, leilao.Lances.Count);
            Assert.AreEqual(50000, leilao.Lances[0].Valor);
        }

        [Test]
        public void NaoDeveAceitarMaisDoQueCincoLancesDoMesmoUsuario()
        {
            var leilao = new LeilaoBuilder().Para("A200")
                .Lance(usuario1, 50000)
                .Lance(usuario2, 60000)
                .Lance(usuario1, 150000)
                .Lance(usuario2, 160000)
                .Lance(usuario1, 200000)
                .Lance(usuario2, 210000)
                .Lance(usuario1, 300000)
                .Lance(usuario2, 310000)
                .Lance(usuario1, 400000)
                .Lance(usuario2, 410000)
                .Lance(usuario1, 500000)
                .Constroi();

            Assert.AreEqual(10, leilao.Lances.Count);

            var ultimo = leilao.Lances.Count - 1;
            var ultimoLance = leilao.Lances[ultimo];

            Assert.AreEqual(410000, ultimoLance.Valor);
        }

        [Test]
        public void DeveDobrarOLanceDoUsuario()
        {
            var leilao = new LeilaoBuilder().Para("A200")
                .Lance(usuario1, 50000)
                .Constroi();

            leilao.DobraLance(usuario1);

            Assert.AreEqual(2, leilao.Lances.Count);
            Assert.AreEqual(50000, leilao.Lances[0].Valor);
            Assert.AreEqual(100000, leilao.Lances[1].Valor);
        }

        [Test]
        public void NaoDeveDobrarOLanceDoUsuario()
        {
            var leilao = new LeilaoBuilder().Para("A200")
                .Lance(usuario1, 50000)
                .Lance(usuario2, 55000)
                .Lance(usuario1, 60000)
                .Lance(usuario2, 65000)
                .Lance(usuario1, 70000)
                .Lance(usuario2, 75000)
                .Lance(usuario1, 80000)
                .Lance(usuario2, 85000)
                .Lance(usuario1, 90000)
                .Constroi();
            leilao.DobraLance(usuario1);

            Assert.AreEqual(9, leilao.Lances.Count);
            Assert.AreEqual(50000, leilao.Lances[0].Valor);
            Assert.AreEqual(60000, leilao.Lances[2].Valor);
            Assert.AreEqual(70000, leilao.Lances[4].Valor);
            Assert.AreEqual(80000, leilao.Lances[6].Valor);
            Assert.AreEqual(90000, leilao.Lances[8].Valor);
        }

        [Test]
        public void NaoDeveDobrarLeilaoSemLance()
        {
            var leilao = new LeilaoBuilder().Para("A200")
                .Constroi();
            leilao.DobraLance(usuario1);

            Assert.AreEqual(0, leilao.Lances.Count);
        }

        [TestFixtureSetUp]
        public void TestandoBeforeClass()
        {
            Console.WriteLine("test fixture setup");
        }

        [TestFixtureTearDown]
        public void TestandoAfterClass()
        {
            Console.WriteLine("test fixture tear down");
        }

        [Test]
        public void DeveLancarExcecaoParaLanceIgualAZero()
        {
            Assert.That(() => new LeilaoBuilder().Para("A200")
                .Lance(usuario1, 0)
                , Throws.TypeOf<ArgumentException>()); 
        }

        [Test]
        public void DeveLancarExcecaoParaLanceMenorQueZero()
        {
            Assert.That(() => new LeilaoBuilder().Para("A200")
                .Lance(usuario1, -10)
                , Throws.TypeOf<ArgumentException>());
        }
    }
}
