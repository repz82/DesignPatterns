using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TDD;

namespace TDD.Tests
{
    [TestFixture]
    public class AvaliadorTest
    {
        private Avaliador leiloeiro;
        private Usuario usuario1;
        private Usuario usuario2;
        private Usuario usuario3;

        [SetUp]
        public void CriaAvaliador()
        {
            leiloeiro = new Avaliador();
            usuario1 = new Usuario("Usuario 1");
            usuario2 = new Usuario("Usuario 2");
            usuario3 = new Usuario("Usuario 3");
        }

        [Test]
        public void DeveEntenderLancesEmOrdemCrescente()
        {
            var leilao = new LeilaoBuilder().Para("A200")
                .Lance(usuario1, 100000)
                .Lance(usuario2, 150000)
                .Lance(usuario3, 120000)
                .Constroi();

            leiloeiro.Avalia(leilao);

            Assert.AreEqual(150000, leiloeiro.MaiorLance, 0.00001);
            Assert.AreEqual(100000, leiloeiro.MenorLance, 0.00001);
        }

        [Test]
        public void DeveEntenderLeilaoComUmLance()
        {
            var leilao = new LeilaoBuilder().Para("A200")
                .Lance(usuario1, 100000)
                .Constroi();

            leiloeiro.Avalia(leilao);

            Assert.AreEqual(100000, leiloeiro.MaiorLance, 0.00001);
            Assert.AreEqual(100000, leiloeiro.MenorLance, 0.00001);
        }

        [Test]
        public void DeveEntenderLancesEmOrdemDecrescente()
        {
            var leilao = new LeilaoBuilder().Para("A200")
                .Lance(usuario1, 190000)
                .Lance(usuario2, 150000)
                .Lance(usuario3, 120000)
                .Constroi();

            leiloeiro.Avalia(leilao);

            Assert.AreEqual(190000, leiloeiro.MaiorLance, 0.00001);
            Assert.AreEqual(120000, leiloeiro.MenorLance, 0.00001);
        }

        [Test]
        public void DeveEncontrarOsTresMaiores()
        {
            var leilao = new LeilaoBuilder().Para("A200")
                .Lance(usuario1, 100000)
                .Lance(usuario2, 150000)
                .Lance(usuario3, 120000)
                .Lance(usuario1, 400000)
                .Lance(usuario2, 180000)
                .Lance(usuario3, 110000)
                .Lance(usuario1, 100000)
                .Lance(usuario2, 140000)
                .Lance(usuario3, 390000)
                .Constroi();

            leiloeiro.Avalia(leilao);
            var maiores = leiloeiro.TresMaiores;
            Assert.AreEqual(3, maiores.Count);
            Assert.AreEqual(400000, maiores[0].Valor);
            Assert.AreEqual(390000, maiores[1].Valor);
            Assert.AreEqual(180000, maiores[2].Valor);
        }

        [Test]
        public void DeveEncontrarOsUnicosDoisLances()
        {
            var leilao = new LeilaoBuilder().Para("A200")
                .Lance(usuario1, 100000)
                .Lance(usuario2, 150000)
                .Constroi();

            leiloeiro.Avalia(leilao);
            var maiores = leiloeiro.TresMaiores;
            Assert.AreEqual(2, maiores.Count);
            Assert.AreEqual(150000, maiores[0].Valor);
            Assert.AreEqual(100000, maiores[1].Valor);
        }

        [Test]
        public void NaoDeveAvaliarLeiloesSemNenhumLanceDado()
        {
            var leilao = new LeilaoBuilder().Para("A200")
                .Constroi();

            Assert.That(() => leiloeiro.Avalia(leilao), Throws.TypeOf<Exception>());
        }

        [Test]
        public void DeveVerificarMedia()
        {
            var leilao = new LeilaoBuilder().Para("A200")
                .Lance(usuario1, 100000)
                .Lance(usuario2, 150000)
                .Lance(usuario3, 120000)
                .Constroi();

            leiloeiro.Avalia(leilao);
            var mediaEsperada = 123333.33333;
            Assert.AreEqual(mediaEsperada, leiloeiro.Media, 0.00001);
        }

        [TearDown]
        public void Finaliza()
        {
            Console.WriteLine("fim");
        }
    }
}
