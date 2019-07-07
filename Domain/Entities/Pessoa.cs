using Domain.Entities.Base;
using Domain.ValueObjects;
using prmToolkit.NotificationPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Pessoa: EntityBase
    {
        public Pessoa()
        {
        }

        //public Pessoa(Nome nome, Email email)
        public Pessoa(Nome nome)
        {
            Nome = nome;
            //Email = email;

            AddNotifications(nome);
        }

        public Nome Nome { get; set; }

        //public Email Email { get; set; }

        //public string CPF { get; set; }

        //public string Telefone { get; set; }

        //public string Endereco { get; set; }

        //public override string ToString()
        //{
        //    var fullName = String.Format("{0} {1}", this.Nome.PrimeiroNome, this,Nome.SegundoNome);
        //    return fullName;
        //}
    }
}
