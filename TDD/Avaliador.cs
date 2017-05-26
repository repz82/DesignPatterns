using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class Avaliador
    {
        private double maior = double.MinValue;
        private double menor = double.MaxValue;
        private double media = 0;
        private List<Lance> maiores = new List<Lance>();
        public void Avalia(Leilao leilao)
        {
            double soma = 0;

            if (leilao.Lances.Count == 0)
                throw new Exception("Não é possível avaliar leilão sem lances");

            foreach (var lance in leilao.Lances)
            {
                if (lance.Valor > maior)
                    maior = lance.Valor;

                if (lance.Valor < menor)
                    menor = lance.Valor;

                soma += lance.Valor;
            }

            media = soma / leilao.Lances.Count;

            pegaOsMaiores(leilao);
        }

        private void pegaOsMaiores(Leilao leilao)
        {
            maiores = leilao.Lances.OrderByDescending(x => x.Valor).Take(3).ToList();
        }

        public List<Lance> TresMaiores
        {
            get { return maiores; }
        }

        public double MaiorLance
        {
            get { return maior; }
        }

        public double MenorLance
        {
            get { return menor; }
        }

        public double Media
        {
            get { return media;  }
        }
    }
}

