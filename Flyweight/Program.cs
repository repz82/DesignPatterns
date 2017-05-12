using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            var notas = new NotasMusicais();
            var musica = new List<INota>() { notas.Pega("do"),
                                notas.Pega("re"),
                                notas.Pega("mi"),
                                notas.Pega("fa"),
                                notas.Pega("fa"),
                                notas.Pega("fa"),

                                notas.Pega("do"),
                                notas.Pega("re"),
                                notas.Pega("do"),
                                notas.Pega("re"),
                                notas.Pega("re"),
                                notas.Pega("re"),

                                notas.Pega("do"),
                                notas.Pega("sol"),
                                notas.Pega("fa"),
                                notas.Pega("mi"),
                                notas.Pega("mi"),
                                notas.Pega("mi"),

                                notas.Pega("do"),
                                notas.Pega("re"),
                                notas.Pega("mi"),
                                notas.Pega("fa"),
                                notas.Pega("fa"),
                                notas.Pega("fa")
                                };
            var piano = new Piano();
            piano.Toca(musica);

        }
    }
}
