using AulaComposicao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaComposicao.Classes
{
    public class Circulo : IFiguraGeometrica
    {
        public double Raio { get; set; }
        public double Area()
        {
            return 3.14 * (Raio * Raio);
        }

        public double Perimetro()
        {
            return 2 * 3.14 * Raio;
        }
    }
}
