using Bibloteca;
using System.Runtime.CompilerServices;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new(36393344,"Martín");
            Persona p2 = new(34444444, "Jorge");
            Jugador j1 = new(36393344, "Martín");
            Jugador j2 = new(34444444, "Jorge");
            DirectorTecnico dt1 = new("Hernesto",new DateTime(1991,5,4));
            DirectorTecnico dt2 = new("Fausto", new DateTime(1961, 1, 7));

            Equipo e1 = new(0,"Boca");

            Console.WriteLine("\nTest sobrecarga operadores:");

            Console.WriteLine("\n\nComparando p1 con p2");
            Console.WriteLine("Persona: Martín 36393344 == 34444444, Jorge: {0} ",p1 == p2 ? "Es igual" : "No es igual");

            Console.WriteLine("\n\nComparando p1 con p1");
            Console.WriteLine("Persona: Martín 36393344 == Martín 36393344: {0} ", p1 == p1 ? "Es igual" : "No es igual");

            Console.WriteLine("\n\nComparando j1 con j2");
            Console.WriteLine("Jugador: Martín 36393344 == 34444444, Jorge: {0} ", j1 == j2 ? "Es igual" : "No es igual");

            Console.WriteLine("\n\nComparando j1 con j1");
            Console.WriteLine("Jugador: Martín 36393344 == Martín 36393344: {0} ", j1 == j1 ? "Es igual" : "No es igual");

            Console.WriteLine("\n\nComparando DT1 con DT2");
            Console.WriteLine("DT: Hernesto 1991/5/4 ==  Fausto 1961/1/7: {0} ", dt1 == dt2 ? "Es igual" : "No es igual");

            Console.WriteLine("\n\nComparando DT1 con DT1");
            Console.WriteLine("DT: Hernesto 1991/5/4 ==  Hernesto 1991/5/4:  {0} ", dt1 == dt1 ? "Es igual" : "No es igual");

            Console.WriteLine("\n\nProbando la lista de Equipo:");
            Console.WriteLine("\nAgregando j1 al equipo e2: {0}, numero total de la lista de jugadores {1} ", e1 + j1 ? "Se agregó con exito" : "No se agregó", e1.CantidadDeJugadores);
            
            
         

        }
    }
}