using AulaTdd.Classes;
using System.Collections.Generic;
using Xunit;

namespace AulaTddTest
{
    public class CalculadoraTestes
    {
        [Fact]
        public void TestarSomarComNumerosInteiros()
        {
            // receber o resultado
            int resultado  = Calculadora.Somar(5, 5);

            // resultado a ser comparado
            int esperado = 10;

            string nome = "";

            // executa a comparação
            //Assert.Equal(esperado, resultado);
            //Assert.Contains(10, new List<int>() { 10, 20, 15, 30 });
            Assert.Empty(nome);
        }

        [Fact]
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
    }
}