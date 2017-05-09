namespace Solid4
{
    public class Pagamento
    {
        public double Valor { get; private set; }
        public MeioDePagamento Boleto { get; private set; }

        public Pagamento(double valor, MeioDePagamento boleto)
        {
            Valor = valor;
            Boleto = boleto;
        }
    }
}