using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public class AnoBissexto
    {
        public bool EhBissexto(int ano)
        {
            var bissexto = false;
            if ((ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0))
                bissexto = true;

            return bissexto;
        }
    }
}
