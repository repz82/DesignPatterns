using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new CalculadoraDeSalario();

            Console.WriteLine($"Desenvolvedor R$ 5.000: {calc.Calcula(new Funcionario(new Desenvolvedor(new DezOuVintePorcento()), 5000))}");
            Console.WriteLine($"DBA R$ 4.000: {calc.Calcula(new Funcionario(new DBA(new QuinzeOuVinteCincoPorcento()), 4000))}");
            Console.WriteLine($"Tester R$ 1.500: {calc.Calcula(new Funcionario(new Tester(new QuinzeOuVinteCincoPorcento()), 1500))}");

            Console.ReadKey();
        }
    }
}
