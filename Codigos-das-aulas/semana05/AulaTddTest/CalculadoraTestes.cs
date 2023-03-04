using AulaTdd.Classes;
using System.Collections.Generic;
using Xunit;

namespace AulaTddTest
{
    public class CalculadoraTestes
    {
        [Fact]
        [Trait("Categoria", "Somar")]
        public void TestarSomarComNumerosInteiros()
        {
            // receber o resultado
            int resultado = Calculadora.Somar(5, 5);

            // resultado a ser comparado
            int esperado = 10;

            string nome = "";

            // executa a comparação
            //Assert.Equal(esperado, resultado);
            //Assert.Contains(10, new List<int>() { 10, 20, 15, 30 });
            Assert.Empty(nome);
        }

        [Fact(DisplayName = "Teste para somar decimais")]
        [Trait("Categoria", "Somar")]
        public void TestarSomarComNumerosDecimais()
        {
            // receber o resultado
            decimal resultado = Calculadora.Somar(5.3M, 5.78M);

            // resultado a ser comparado
            decimal esperado = 11.08M;

            //string nome = "";

            // executa a comparação
            Assert.Equal(esperado, resultado);
            //Assert.Contains(10, new List<int>() { 10, 20, 15, 30 });
            //Assert.Empty(nome);
        }

        //[Fact(Skip = "Teste não emplementado")]
        [Fact]
        [Trait("Categoria", "divisivelPor")]
        public void TesteDivisivelPor()
        {
            bool resultado = Calculadora.DivisivelPor(9, 3);

            Assert.True(resultado);
        }

        [Theory]
        [Trait("Categoria", "Somar")]
        // Recebe uma entrada de dados que serão recebidos pelo teste 
        // através de parâmetros
        [InlineData(5, 7, 12)]
        [InlineData(3, 2, 5)]
        [InlineData(-5, -3, -8)]
        public void testarSomaInteirosTheory(int numero1, int numero2, int resultadoEsperado)
        {
            // quero fazer
            int resultado = Calculadora.Somar(numero1, numero2);

            // espero receber
            int esperado = resultadoEsperado;

            // validação/teste
            Assert.Equal(esperado, resultado);
        }

        [Theory]
        [MemberData(nameof(ListaNumeros))]
        public void TestarSomaInteirosMemberData(ListaNumeros lista)
        {
            int resultado = Calculadora.Somar(lista.numero1, lista.numero2);

            Assert.Equal(lista.esperado, resultado);
        }

        public static List<object[]> ListaNumeros()
        {
            List<object[]> listageral = new List<object[]>();

            listageral.Add(new[] { new ListaNumeros() { numero1 = 5, numero2 = 5, esperado = 10 } });

            listageral.Add(new[] { new ListaNumeros() { numero1 = 3, numero2 = 8, esperado = 11 } });

            return listageral;

        }

    }
}