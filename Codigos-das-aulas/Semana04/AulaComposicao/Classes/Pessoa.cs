using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaComposicao.Classes
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }

        // CamelCase
        public Endereco EnderecoCompleto { get; set; }

        //public Pessoa(string nome, DateTime nascimento, Endereco endereco)
        //{
        //    Nome = nome;
        //    Nascimento = nascimento;
        //    EnderecoCompleto = endereco;
        //}
    }
}
