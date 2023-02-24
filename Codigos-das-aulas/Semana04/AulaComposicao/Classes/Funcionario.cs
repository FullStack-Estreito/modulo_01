using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaComposicao.Classes
{
    public class Funcionario : Pessoa
    {
        public string Cargo { get; set; }
        public decimal Salario { get; set; }
        public Funcionario(string cargo, decimal salario, string nome, DateTime nascimento, Endereco endereco) : base(nome, nascimento, endereco)
        {
            Cargo = cargo;
            Salario = salario;
        }

        public override void FazerAniversario()
        {
            Salario = Salario + (Salario * 10 / 100);
            //Salario = Salario + (Salario * 0.10M);
            //Salario *= 1.10M;
            //Nascimento = Nascimento.AddYears(1);
            base.FazerAniversario();

        }

        public override void Descrever()
        {
            Console.WriteLine($"O funcionário {Nome} nasceu em {Nascimento} e trabalha como {Cargo}");
        }
    }
}
