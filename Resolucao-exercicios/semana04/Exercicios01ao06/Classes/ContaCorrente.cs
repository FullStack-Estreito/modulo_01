using Exercicios01ao06.Classes.enums;

namespace Exercicios01ao06.Classes
{
    public class ContaCorrente : ContaBancaria
    {
        // Resposta exercício 03
        public ContaCorrente(int numero, int agencia, Cliente cliente) : base(numero, agencia, cliente)
        {
            // Aqui lançei uma exceção para validar o Tipo da pessoa física.
            // Vamos aprender mais sobre isso na próxima semana.
            if (cliente.TipoPessoa != TipoPessoaEnum.FISICA)
            {
                throw new ArgumentException("Cliente precisa ser do tipo física!");
            }
        }

        // Resposta exercício 06
        public override void Sacar(decimal valor)
        {
            // Taxa de R$ 0,50 por saque
            valor += 0.50M;
            base.Sacar(valor);
        }

        // Resposta exercício 06
        public override void Transferir(ContaBancaria conta, decimal valor)
        {
            // Taxa de R$ 0,25 por transferência
            valor += 0.25M;
            base.Transferir(conta, valor);
        }
    }
}
