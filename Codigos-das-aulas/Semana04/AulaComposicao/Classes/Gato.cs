using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaComposicao.Classes
{
    public class Gato : Mamifero
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Miau!");
        }
    }
}
