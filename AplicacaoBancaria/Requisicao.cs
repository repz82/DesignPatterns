﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoBancaria
{
    public enum Formato
    {
        XML,
        CSV,
        PORCENTO
    }

    public class Requisicao
    {
        public Formato Formato { get; private set; }

        public Requisicao(Formato formato)
        {
            Formato = formato;
        }
    }
}
