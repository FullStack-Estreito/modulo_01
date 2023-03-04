using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios04ao06.Classes
{
    // Resposta exercício 06
    public static class ValidadorDeNumeros
    {
        /// <summary>
        /// Verifica se um número é primo
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public static bool EhNumeroPrimo(int numero)
        {
            // o contador vai marcar quantas vezes ele é divisível por um número menor que ele
            // Inicia-se em 1 porque todo número é divisível por 1
            int contador = 1;

            // Inicia-se em 1 porque se iniciarmos com 0 na divisão vai quebrar, pois o C# não divide um número por 0.
            for (int n = 1; n < numero; n++)
            {
                if (numero % n == 0)
                {
                    contador = contador + 1;
                    // contador++;
                }
            }

            if (contador == 2)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Retorna se um número é par ou ímpar
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public static string ParOuImpar(int numero)
        {
            if(numero % 2 == 0)
            {
                return "Par";
            }

            return "Impar";
        }

        /// <summary>
        /// Verifica se um número é divisível por outro
        /// </summary>
        /// <param name="dividendo"></param>
        /// <param name="divisor"></param>
        /// <returns></returns>
        public static bool EhDivisivelPor(int dividendo, int divisor)
        {
            if (dividendo % divisor == 0)
            {
                return true;
            }

            return false;
        }
    }
}
