using ClasesNegocio;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Declaraciónes e inicializaciónes

            Dictionary<Contacto, DateTime>[] agendas =
            {
            new Dictionary<Contacto, DateTime>
            {
                { new Contacto("Juan", "Pérez"), DateTime.Parse("2023-09-13") },
                { new Contacto("María", "González"), DateTime.Parse("2023-09-14") },
                { new Contacto("Carlos", "López"), DateTime.Parse("2023-09-15") }
            },
            new Dictionary<Contacto, DateTime>
            {
                { new Contacto("Pedro", "Ramírez"), DateTime.Parse("2023-09-16") },
                { new Contacto("Ana", "Martínez"), DateTime.Parse("2023-09-17") },
                { new Contacto("Luis", "García"), DateTime.Parse("2023-09-18") }
            },
            new Dictionary<Contacto, DateTime>
            {
                { new Contacto("Diego", "Rodríguez"), DateTime.Parse("2023-09-22") },
                { new Contacto("Isabel", "López"), DateTime.Parse("2023-09-23") },
                { new Contacto("Miguel", "Gómez"), DateTime.Parse("2023-09-24") }
            }

            };

            List<App>[] aplicaciones =
             {
            new List<App>
            {
                new App("Tinder", 40f),
                new App("WhatsApp", 20f),
                new App("Instagram", 15f)
            },
            new List<App>
            {
                new App("Facebook", 30f),
                new App("Twitter", 10f),
                new App("Snapchat", 25f)
            },
            new List<App>
            {
                new App("Spotify", 50f),
                new App("YouTube", 45f),
                new App("Google Maps", 35f)
            }
            };

            Queue<Llamada>[] llamadasRealizadas =
            new Queue<Llamada>[]
            {
              new Queue<Llamada>(new[]
               {
                new Llamada(new DateTime(2023, 05, 10), 15515134, 20000),
                new Llamada(new DateTime(2023, 05, 11), 15515135, 25000),
                new Llamada(new DateTime(2023, 05, 12), 15515136, 30000)
                }), 

              new Queue<Llamada>(new[]
               {
                 new Llamada(new DateTime(2023, 05, 13), 15515137, 35000),
                 new Llamada(new DateTime(2023, 05, 14), 15515138, 40000),
                 new Llamada(new DateTime(2023, 05, 15), 15515139, 45000)
                 }),

              new Queue<Llamada>(new[]
               {
               new Llamada(new DateTime(2023, 05, 16), 15515140, 50000),
               new Llamada(new DateTime(2023, 05, 17), 15515141, 55000),
               new Llamada(new DateTime(2023, 05, 18), 15515142, 60000)
               })

            };

            Celular[] celulares =
            {
                new Celular("Roberto", 15515155, EMarca.Samsung, "J7", 4, 64, agendas[0], aplicaciones[0], llamadasRealizadas[0]),
                new Celular("E  steban", 15545456, EMarca.Apple, "G4", 3, 43, agendas[1], aplicaciones[1], llamadasRealizadas[1]),
                new Celular("Juliana", 15222221, EMarca.Motorola, "X9", 5, 120, agendas[2], aplicaciones[2], llamadasRealizadas[2])
            };

            Stack<Celular> pilaCelulares = new Stack<Celular>(celulares);
            Compania movistar = new("Movistar", DateTime.Now, pilaCelulares);

            #endregion

            Console.WriteLine(movistar.MostrarCompania());
        }
    }
}