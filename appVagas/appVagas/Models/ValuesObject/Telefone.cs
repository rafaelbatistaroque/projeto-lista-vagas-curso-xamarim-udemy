using System;
using System.Collections.Generic;
using System.Text;

namespace appVagas.Modelos.ValuesObject
{
    public class Telefone
    {
        public Telefone(int ddd, string numero)
        {
            DDD = ddd;
            Numero = numero;
        }

        public int DDD { get; set; }
        public string Numero { get; set; }

        public override string ToString()
        {
            return $"({DDD}) {Numero}"; ;
        }
    }
}
