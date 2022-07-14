using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario
{
    public abstract class  Concesionaria
    {
        public abstract IAuto crearAuto();

        public  void someOperacion()
        {
            Console.WriteLine("Operación en Concesionaria");
            IAuto auto = crearAuto();
            auto.mostrarAuto();
        }
        

    }
}
