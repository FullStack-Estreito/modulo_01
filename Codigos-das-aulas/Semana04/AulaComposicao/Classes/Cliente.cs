using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaComposicao.Classes
{
    public class Cliente : Pessoa
    {
        public Cliente(string nome, DateTime nascimento, Endereco endereco) : base(nome, nascimento, endereco)
        {
        }

        public override void Descrever()
        {
            Console.WriteLine($"O cliente {Nome} nasceu em {Nascimento}");
        }
    }
}
