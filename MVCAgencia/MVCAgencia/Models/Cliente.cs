using System;

namespace MVCAgencia.Models
{
    public class Cliente
    {
        public int CodCliente { get; set; }
        public string NomeCompleto { get; set; }
        public string CPF { get; set; }
        public string  RG { get; set; }
        public DateTime Nascimento { get; set; }
        }
}
