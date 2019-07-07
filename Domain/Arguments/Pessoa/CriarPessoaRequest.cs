using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Arguments.Pessoa
{
    public class CriarPessoaRequest
    {
        public string PrimeiroNome { get; set; }

        public string SegundoNome { get; set; }

        public string Email { get; set; }

        public string CPF { get; set; }

        public string Telefone { get; set; }

        public string Endereco { get; set; }
    }
}
