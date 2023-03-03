using Exercicios01ao06.Classes;

namespace Exercicios01ao06
{
    public class ContaBancaria
    {
        // Resposta exercício 02
        public int Numero { get; protected set; }
        public int Agencia { get; protected set; }
        public decimal Saldo { get; protected set; }
        public Cliente Cliente { get; protected set; }

        public ContaBancaria(int numero, int agencia, Cliente cliente)
        {
            Numero = numero;
            Agencia = agencia;
            // Opcional, visto que o tipo decimal já inicia em 0
            Saldo = 0;
            Cliente = cliente;
        }

        public virtual void Transferir(ContaBancaria conta, decimal valor)
        {
            // valida se o valor a ser transferido é maior do que 0
            if (valor <= 0)
            {
                Console.WriteLine("O valor precisa ser maior do que 0!");
                return;
            }

            // valida se há saldo suficiente para realizar a transferência
            if (valor > Saldo)
            {
                Console.WriteLine("Saldo insuficiente!");
                return;
            }

            Saldo = Saldo - valor;
            conta.Depositar(valor);

            Console.WriteLine($"Valor de R$ {valor} transferido com sucesso!");
        }

        public virtual void Depositar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor precisa ser maior do que 0");
                return;
            }
            else
            {
                Saldo = Saldo + valor;
            }

            Console.WriteLine($"Valor de R$ {valor} depositado com sucesso!");
        }

        public virtual void Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor precisa ser maior do que 0");
                return;

            }
            else if (valor > Saldo)
            {
                Console.WriteLine("O valor é maior do que o saldo atual!");
                return;
            }
            else
            {
                Saldo = Saldo - valor;
            }

            Console.WriteLine($"Saque no valor de R$ {valor} realizado com sucesso!");
        }

        public virtual void ExibirSaldo()
        {
            Console.WriteLine($"O saldo atual da conta é de R$ {Saldo}");
        }
    }
}
