using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class Leilao
    {
        public string Descricao { get; set; }
        public IList<Lance> Lances { get; set; }

        public Leilao(string descricao)
        {
            Descricao = descricao;
            Lances = new List<Lance>();
        }

        public void Propoe(Lance lance)
        {
            if (lance.Valor <= 0)
                throw new ArgumentException("Valor não pode ser menor ou igual a zero");

            if (Lances.Count == 0 || podeDarLance(lance.Usuario))
                Lances.Add(lance);
        }

        private bool podeDarLance(Usuario usuario)
        {
            return !ultimoLanceDado().Usuario.Equals(usuario) && QuantidadeLances(usuario) < 5;
        }

        private int QuantidadeLances(Usuario usuario)
        {
            var total = 0;
            foreach (var l in Lances)
            {
                if (l.Usuario.Equals(usuario))
                    total++;
            }

            return total;
        }

        private Lance ultimoLanceDado()
        {
            return Lances[Lances.Count - 1];
        }

        public void DobraLance(Usuario usuario)
        {
            var ultimoLance = ultimoLanceDado(usuario);
            if (ultimoLance != null && QuantidadeLances(usuario) < 5)
                Lances.Add(new Lance(usuario, ultimoLance.Valor * 2));
        }

        private Lance ultimoLanceDado(Usuario usuario)
        {
            var ultimoLance = Lances.Where(x => x.Usuario.Equals(usuario));

            if (ultimoLance.Count() > 0)
                return ultimoLance.First();
            else
                return null;
        }
    }
}
