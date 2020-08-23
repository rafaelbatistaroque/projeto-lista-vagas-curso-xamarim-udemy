using System;
using System.Collections.Generic;
using System.Text;

namespace appVagas.Modelos.ValuesObject
{
    public class Email
    {
        public Email(string enderecoEmail)
        {
            EnderecoEmail = enderecoEmail;
        }

        public string EnderecoEmail { get; set; }

        public override string ToString()
        {
            return EnderecoEmail;
        }
    }
}
