namespace Concesionario
{
    public class Program
    {
        public static void Main(string[] args)
        {
            VallejoAraujo creatorA = new();
            Casabaca creatorB = new();
            Asiacar creatorC = new();

            Console.WriteLine("Crear lista de autos");
            List<IAuto> listaAutos = new List<IAuto>();
            listaAutos.Add(creatorA.crearAuto());
            listaAutos.Add(creatorA.crearAuto());
            listaAutos.Add(creatorB.crearAuto());
            listaAutos.Add(creatorB.crearAuto());
            listaAutos.Add(creatorB.crearAuto());
            listaAutos.Add(creatorC.crearAuto());
            listaAutos.Add(creatorC.crearAuto());

            foreach (IAuto auto in listaAutos)
            {
                auto.mostrarAuto();  
                
            }

            Console.WriteLine("\n***Crear lista Concesionaria***\n" );
            List<Concesionaria> listaCreator = new List<Concesionaria>();

            listaCreator.Add(new VallejoAraujo());
            listaCreator.Add(new VallejoAraujo());
            listaCreator.Add(new Casabaca());
            listaCreator.Add(new Casabaca());
            listaCreator.Add(new Casabaca());
            listaCreator.Add(new Asiacar());
            listaCreator.Add(new Asiacar());

            foreach (Concesionaria creator in listaCreator)
            {
                creator.someOperacion();
            }
        }
    }
}