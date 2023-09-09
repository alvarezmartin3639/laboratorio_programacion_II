using ClasesNegocio;
using static System.Net.Mime.MediaTypeNames;

namespace Clase_4__Sobrecargas_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Contacto> agenda = new List<Contacto>();
            List<App> listaApps = new List<App>();
            Celular celular1 = new Celular(EMarca.Samsung, "J7", 4, 64, agenda);
            Contacto miContacto = new Contacto("Juan", "5555");  

            agenda.Add(new Contacto("Roberto", "1111"));
            agenda.Add(new Contacto("Juan", "2222"));
            agenda.Add(new Contacto("Esteban", "3333"));

            listaApps.Add(new App("Tinder", 40f));
            listaApps.Add(new App("WhatsApp", 20f));
            listaApps.Add(new App("Instagram", 15f));

            Console.WriteLine("****************************************\n");
            Console.WriteLine(celular1.AlternarEncendido());         
            celular1.Llamar(miContacto);
            Console.WriteLine("****************************************");

            Console.WriteLine("\n****************************************");
            //Si existen errores los muestra al usuario
            if (App.InstalarPilaDeAplicaciones(celular1, listaApps).Count > 0)
            {
                foreach (App aplicacion in listaApps)
                {
                    Console.WriteLine("Error al instalar {0}", aplicacion.Nombre);
                }
            }
            else
            {
                Console.WriteLine("Se instalaron todas las Apps con exito!.");
            }
            Console.WriteLine("****************************************\n");

            Console.WriteLine("\n****************************************");
            Console.WriteLine("Muestra del celular: ");
            Console.WriteLine(celular1.ToString());

            Console.WriteLine("\n*********************EXPLICIT e IMPLICIT*********************************");
            //PRUEBA DE OPERADORES EXPLICITOS E IMPLICITOS DE LA CLASE APP
            App unaApp = new App("Pokemon Go", 45f);
            string appString;

            appString = (string)unaApp;

            Console.WriteLine(appString);

            double capacidad;

            capacidad = unaApp;

            Console.WriteLine($"La capacidad del celular es: {capacidad}");















        }


    }
}