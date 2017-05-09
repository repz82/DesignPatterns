using System;

namespace Solid3
{
    public class Frete : IServicoEntrega
    {
        public double Para(string cidade)
        {
            if ("SAO PAULO".Equals(cidade.ToUpper()))
            {
                return 15;
            }
            return 30;
        }
    }
}