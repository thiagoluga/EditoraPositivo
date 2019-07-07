using Domain.Arguments.Pessoa;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces.Services
{
    public interface IPessoaService
    {
        CriarPessoaResponse CriarPessoa(CriarPessoaRequest criarPessoaRequest);

        void ListarPessoa();

        void AtualizarPessoa();

        void DeletarPessoa();
    }
}
