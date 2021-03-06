﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridges
{
    public class MensagemAdministrativa : IMensagem
    {
        private string nome;
        public IEnviador Enviador { get; set; }

        public MensagemAdministrativa(string nome)
        {
            this.nome = nome;
        }

        public void Envia()
        {
            Enviador.Envia(this);
        }

        public string Formata()
        {
            return $"Enviando a mensagem para o administrador {nome}";
        }
    }
}
