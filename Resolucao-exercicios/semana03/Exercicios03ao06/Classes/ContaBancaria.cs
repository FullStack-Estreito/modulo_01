using Exercicios03ao06.Classes.Enum;

namespace Exercicios03ao06
{
    public class ContaBancaria
    {
        // Resposta Exercício 04
        private int _numero;
        private int _agencia;
        private string _nomeDoTitular;
        private decimal _saldo = 0;
        private TipoContaEnum _tipoConta;

        // Resposta Exercício 03
        public ContaBancaria(int numero, int agencia, string nomeDoTitular, TipoContaEnum tipoConta)
        {
            // atribui os valores do construtor
            _numero = numero;
            _agencia = agencia;
            _nomeDoTitular = nomeDoTitular;
            _tipoConta = tipoConta;
        }

        // Resposta Exercício 05
        public ContaBancaria(string nomeDoTitular, TipoContaEnum tipoConta)
        {
            // Instancia uma classe Random para gerar número aleatórios
            Random random = new Random();

            // gera um número aleatório entre 0000 e 9999
            _numero = random.Next(0000, 9999);
            _agencia = random.Next(0000, 9999);

            // atribui os valores do construtor
            _nomeDoTitular = nomeDoTitular;
            _tipoConta = tipoConta;
        }

        // Resposta Exercício 06
        public void Transferir(ContaBancaria conta, decimal valor)
        {
            // valida se o valor a ser transferido é maior do que 0
            if(valor <= 0)
            {
                Console.WriteLine("O valor precisa ser maior do que 0!");
                return;
            }

            // valida se há saldo suficiente para realizar a transferência
            if(valor > _saldo)
            {
                Console.WriteLine("Saldo insuficiente!");
                return;
            }

            _saldo = _saldo - valor;
            //_saldo -= valor;
            conta.Depositar(valor);

            Console.WriteLine($"Valor de R$ {valor} transferido com sucesso!");
        }


        /*
         * Os próximos métodos foram criados durante os exercícios da semana 02.
         * 
         * Uma observação: quando os atributos desta classe forem alterados para private,
         * por convensão os seus nomes devem começar com _ . Por isso lembre de alterar
         * os nomes dos atributos usados nos métodos abaixo. Caso contrário dará erro de
         * execução.
         * 
         */
        public void Depositar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor precisa ser maior do que 0");
                return;
            }
            else
            {
                _saldo = _saldo + valor;
            }
        }

        
        public void Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor precisa ser maior do que 0");
                return;

            }
            else if (valor > _saldo)
            {
                Console.WriteLine("O valor é maior do que o saldo atual!");
                return;
            }
            else
            {
                _saldo = _saldo - valor;
            }
        }

        
        public void ExibirSaldo()
        {
            Console.WriteLine($"O saldo atual da conta é de R$ {_saldo}");
        }
    }
}
