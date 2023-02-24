using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaComposicao.Classes
{
    public class Cachorro : Mamifero
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Au au");
        }
    }
}
