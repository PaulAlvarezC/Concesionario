using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario
{
    public class Casabaca : Concesionaria
    {
        public override IAuto crearAuto()
        {
            Console.WriteLine("Creando Producto en Casabaca");
            return new Toyota();

        }
    }
}
