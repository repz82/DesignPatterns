using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filtros
{
    class Program
    {
        static void Main(string[] args)
        {
            var contas = new List<Conta>();
            contas.Add(new Conta("Conta 1", 40, new DateTime(2017, 5, 1)));
            contas.Add(new Conta("Conta 2", 40000, new DateTime(2017, 5, 1)));
            contas.Add(new Conta("Conta 3", 4000000, new DateTime(2017, 5, 1)));
            contas.Add(new Conta("Conta 4", 500000, new DateTime(2017, 5, 1)));
            contas.Add(new Conta("Conta 5", 35, new DateTime(2017, 5, 1)));
            contas.Add(new Conta("Conta 6", 88, new DateTime(2017, 5, 1)));
            contas.Add(new Conta("Conta 7", 1025, new DateTime(2013, 5, 1)));
            contas.Add(new Conta("Conta 8", 1220, new DateTime(2014, 5, 1)));
            contas.Add(new Conta("Conta 9", 9999, new DateTime(2015, 5, 1)));
            contas.Add(new Conta("Conta 10", 20012, new DateTime(2016, 5, 1)));
            contas.Add(new Conta("Conta 11", 21453, new DateTime(2017, 2, 1)));
            contas.Add(new Conta("Conta 12", 144664654, new DateTime(2017, 5, 1)));
            contas.Add(new Conta("Conta 13", 4321352, new DateTime(2017, 3, 1)));
            contas.Add(new Conta("Conta 14", 40545464, new DateTime(2017, 4, 1)));
            contas.Add(new Conta("Conta 15", 4010120, new DateTime(2016, 5, 1)));
            contas.Add(new Conta("Conta 16", 40545465, new DateTime(2017, 5, 10)));

            var filtro1 = new FiltroMenor100();
            var contas1 = filtro1.Filtra(contas);

            Console.WriteLine("Nome - Saldo - DataAbertura");
            foreach (var item in contas1)
            {
                Console.WriteLine($"{item.Nome} - {item.Saldo} - {item.DataAbertura}");
            }

            var filtro2 = new FiltroMaior500000();
            var contas2 = filtro2.Filtra(contas);

            Console.WriteLine("------------------------------");
            Console.WriteLine("Nome - Saldo - DataAbertura");
            foreach (var item in contas2)
            {
                Console.WriteLine($"{item.Nome} - {item.Saldo} - {item.DataAbertura}");
            }

            var filtro3 = new FiltroDataAberturaMesCorrente();
            var contas3 = filtro3.Filtra(contas);

            Console.WriteLine("------------------------------");
            Console.WriteLine("Nome - Saldo - DataAbertura");
            foreach (var item in contas3)
            {
                Console.WriteLine($"{item.Nome} - {item.Saldo} - {item.DataAbertura}");
            }

            var filtro4 = new FiltroDataAberturaMesCorrente(new FiltroMenor100());
            var contas4 = filtro4.Filtra(contas);

            Console.WriteLine("------------------------------");
            Console.WriteLine("Nome - Saldo - DataAbertura");
            foreach (var item in contas4)
            {
                Console.WriteLine($"{item.Nome} - {item.Saldo} - {item.DataAbertura}");
            }

            var filtro5 = new FiltroDataAberturaMesCorrente(new FiltroMaior500000());
            var contas5 = filtro5.Filtra(contas);

            Console.WriteLine("------------------------------");
            Console.WriteLine("Nome - Saldo - DataAbertura");
            foreach (var item in contas5)
            {
                Console.WriteLine($"{item.Nome} - {item.Saldo} - {item.DataAbertura}");
            }

            Console.ReadKey();
        }
    }
}
