using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.Tests
{
    [TestFixture]
    public class AnoBissextoTest
    {
        [Test]
        public void DeveSerAnoBissexto()
        {
            var ano = new AnoBissexto();
            Assert.AreEqual(true, ano.EhBissexto(2000));
        }

        [Test]
        public void NaoDeveSerAnoBissexto()
        {
            var ano = new AnoBissexto();
            Assert.AreEqual(false, ano.EhBissexto(2001));
        }

    }
}
