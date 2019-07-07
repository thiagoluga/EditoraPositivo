using prmToolkit.NotificationPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects
{
    public class Nome: Notifiable
    {
        public Nome(string primeiroNome)
        {
            PrimeiroNome = primeiroNome;
            //SegundoNome = segundoNome;

            new AddNotifications<Nome>(this)
                .IfNullOrInvalidLength(x => x.PrimeiroNome, 2, 100, "Nome deve conter de 2 a 100 caracteres");
                //.IfNullOrInvalidLength(x => x.SegundoNome, 2, 100, "Nome deve conter de 2 a 200 caracteres");
        }

        public string PrimeiroNome { get; set; }
    }
}
