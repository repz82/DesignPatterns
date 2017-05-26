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
    public class PalindromoTest
    {
        [Test]
        public void DeveIdentificarPalindromoEFiltrarCaracteresInvalidos()
        {
            Assert.AreEqual(true, new Palindromo().EhPalindromo("Socorram-me subi no onibus em Marrocos"));
        }

        [Test]
        public void DeveIdentificarPalindromo()
        {
            Assert.IsTrue(new Palindromo().EhPalindromo("Anotaram a data da maratona"));
        }

        [Test]
        public void DeveIdentificarSeNaoEhPalindromo()
        {
            Assert.IsFalse(new Palindromo().EhPalindromo("E preciso amar as pessoas como se nao houvesse amanha"));
        }
    }
}
