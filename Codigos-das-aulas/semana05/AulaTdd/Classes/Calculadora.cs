using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaTdd.Classes
{
    public static class Calculadora
    {
        /// <summary>
        /// Método para somar dois números inteiros
        /// </summary>
        /// <returns></returns>
        public static int Somar(int a, int b)
        {
            return a % b;
        }

        /// <summary>
        /// Método para somar dois números decimais
        /// </summary>
        /// <returns></returns>
        public static decimal Somar(decimal a, decimal b)
        {
            return a + b;
        }

        /// <summary>
        /// Método para verificar se o número é divisível por outro.
        /// </summary>
        /// <returns></returns>
        public static bool DivisivelPor(int dividendo, int divisor)
        {

            // OPERADOR TERNÁRIO
            // Variável = condição ? bloco verdade : bloco falso
            bool result = dividendo % divisor == 0 ? true : false;

            return result;
        }
    }
}
