using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaComposicao.Classes
{
    public class Aluno : Pessoa
    {
        public string Curso { get; set; }
        public int Semestre { get; set; }

        public Aluno(string nome, DateTime nascimento, Endereco endereco, string curso, int semestre) : base(nome, nascimento, endereco)
        {
            Curso = curso;
            Semestre = semestre;
        }

        public override void Descrever()
        {
            Console.WriteLine($"O aluno {Nome} cursa o {Semestre}º do curso {Curso}");
        }
    }
}
