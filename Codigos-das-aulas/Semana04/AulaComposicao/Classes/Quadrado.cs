using AulaComposicao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaComposicao.Classes
{
    public class Quadrado : IFiguraGeometrica
    {
        public double Lado { get; set; }
        public double Area()
        {
            return Lado * Lado;
        }

        public double Perimetro()
        {
            return Lado * 4;
        }
    }
}
