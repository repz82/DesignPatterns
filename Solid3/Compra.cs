namespace Solid3
{
    public class Compra
    {
        public string Cidade { get; private set; }
        public double Valor { get; private set; }

        public Compra(string cidade, double valor)
        {
            Cidade = cidade;
            Valor = valor;
        }
    }
}