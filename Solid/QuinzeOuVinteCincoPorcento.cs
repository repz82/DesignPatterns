using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    public class QuinzeOuVinteCincoPorcento : IRegraCalculo
    {
        public double Calcula(Funcionario funcionario)
        {
            return funcionario.SalarioBase > 2000 ? funcionario.SalarioBase * 0.75 : funcionario.SalarioBase * 0.85;
        }
    }
}
