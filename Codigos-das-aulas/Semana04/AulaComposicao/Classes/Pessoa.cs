using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaComposicao.Classes
{
    public abstract class Pessoa
    {
        // Auto propertie -> Propriedade automática
        public string Nome { get; set; }

        // Field -> Campo ou atributo

        private string _nome;

        // Propertie -> Propriedade
        public string _Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }
        public DateTime Nascimento { get; set; }

        // CamelCase
        public Endereco EnderecoCompleto { get; set; }

        public Pessoa(string nome, DateTime nascimento, Endereco endereco)
        {
            Nome = nome;
            Nascimento = nascimento;
            EnderecoCompleto = endereco;
        }

        public virtual void FazerAniversario()
        {
            Nascimento = Nascimento.AddYears(1);
            /*
             * mais regras
             */
        }

        public abstract void Descrever();
    }
}
