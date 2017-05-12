using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Historico
    {
        private IList<Estado> estados = new List<Estado>();

        public void Adiciona(Estado estado)
        {
            estados.Add(estado);
        }

        public Estado Pega(int indice)
        {
            return estados[indice];
        }
    }
}
