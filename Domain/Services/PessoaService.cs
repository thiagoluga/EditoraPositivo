using Domain.Arguments.Pessoa;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Domain.ValueObjects;
using prmToolkit.NotificationPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Services
{
    public class PessoaService : Notifiable, IPessoaService
    {
        private readonly IPessoaRepository _pessoaRepository;

        public PessoaService(IPessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        public CriarPessoaResponse CriarPessoa(CriarPessoaRequest criarPessoaRequest)
        {
            var nome = new Nome(criarPessoaRequest.PrimeiroNome);

            //var email = new Email(criarPessoaRequest.Email);

            //var pessoa = new Pessoa(nome);

            AddNotifications(nome);

            //if(_pessoaRepository.Existe(x => x.Email.EnderecoEmail == criarPessoaRequest.Email))
            //{
            //    AddNotification(criarPessoaRequest.Email, "Email já cadastrado");
            //}

            if (this.IsInvalid())
            {

                return null;
            }

            var pess = new Pessoa()
            {
                Nome = new Nome(criarPessoaRequest.PrimeiroNome)
            };

            var a = _pessoaRepository.Adicionar(pess);

            return (CriarPessoaResponse)pess;
        }

        public void AtualizarPessoa()
        {
            throw new NotImplementedException();
        }

        public void DeletarPessoa()
        {
            throw new NotImplementedException();
        }

        public void ListarPessoa()
        {
            throw new NotImplementedException();
        }
    }
}
