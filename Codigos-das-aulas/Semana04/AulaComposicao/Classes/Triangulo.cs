using AulaComposicao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaComposicao.Classes
{
    public class Triangulo : IFiguraGeometrica
    {
        public double ladoA { get; set; }
        public double ladoB { get; set; }
        public double ladoC { get; set; }
        public double Base { get; set; }
        public double Altura { get; set; }

        public double Area()
        {
            return (Base * Altura) / 2;
        }

        public double Perimetro()
        {
            return ladoA + ladoB + ladoC;
        }
    }
}
