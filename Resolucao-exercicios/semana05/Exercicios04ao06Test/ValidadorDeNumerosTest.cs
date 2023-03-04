using Exercicios04ao06.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Exercicios04ao06Test
{
    public class ValidadorDeNumerosTest
    {
        [Fact]
        public void TesteEhNumeroPrimo()
        {
            bool resultado = ValidadorDeNumeros.EhNumeroPrimo(17);

            Assert.True(resultado);
        }

        [Fact]
        public void TesteParOuImpar()
        {
            string resultado = ValidadorDeNumeros.ParOuImpar(17);

            string esperado = "Impar";

            Assert.Equal(esperado, resultado);
        }

        [Fact]
        public void TesteEhDivisivelPor()
        {
            bool resultado = ValidadorDeNumeros.EhDivisivelPor(15, 5);

            Assert.True(resultado);
        }
    }
}
