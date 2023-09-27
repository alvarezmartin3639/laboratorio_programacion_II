using Bibloteca;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VehiculoDeCarrera v1 = new(1, "Roblex");
            VehiculoDeCarrera v2 = new(2, "Instar");
            MotoCross m1 = new(1,"Roblex", 120);
            MotoCross m2 = new(2, "Instar", 133);
            AutoF1 a1 = new(1,"Roblex",300);
            AutoF1 a2 = new(2, "Instar", 302);
            Competencia c1 = new Competencia(2,2,TipoCompetencia.MotoCross);

            Console.WriteLine("\n\n\nProbando sobrecarga operador == en Vehiculo de carrera:");
            Console.WriteLine("- 1, Roblex == 2, instar: {0}", v1 == v2 ? "Si es igual" : "No es igual" );
            Console.WriteLine("- 1, Roblex == 1, Roblex: {0}", v1 == v1 ? "Si es igual" : "No es igual");

            Console.WriteLine("\n\n\nProbando sobrecarga operador == en MotoCross:");
            Console.WriteLine("- 1, Roblex, 120 == 2, Instar, 133: {0} ", m1 == m2 ? "Si es igual" : "No es igual");
            Console.WriteLine("- 1, Roblex, 120 == 1, Roblex, 120: {0}", m1 == m1 ? "Si es igual" : "No es igual");

            Console.WriteLine("\n\n\nProbando sobrecarga operador == en AutoF1:");
            Console.WriteLine("- 1, Roblex, 300 == 2, Instar, 302: {0}", a1 == a2 ? "Si es igual" : "No es igual");
            Console.WriteLine("- 1, Roblex, 300 == 1, Roblex, 300 : {0}", a1 == a1 ? "Si es igual" : "No es igual");

            Console.WriteLine("\n\n\nProbando sobrecarga operador + en Competencia");
            Console.WriteLine("- Agregando moto a competencia de moto: {0}", c1 + m1 ? "Se agregó la moto a la competencia" : "No se agregó la moto a la competencia");
            Console.WriteLine("- Agregando auto a competencia de moto: {0}", c1 + a1 ? "Se agregó la moto a la competencia" : "No se agregó la moto a la competencia");

            Console.WriteLine("\n\n\nProbando sobrecarga operador - en Competencia:");
            Console.WriteLine("- Quitando moto a competencia de moto: {0}", c1 - m1 ? "Se agregó la moto a la competencia" : "No se agregó la moto a la competencia");


            Console.WriteLine("\n\n\nProbando sobrecarga operador == en Competencia");
            Console.WriteLine("- Agregando moto a competencia de moto: {0}", c1 + m1 ? "Se agregó la moto a la competencia" : "No se agregó la moto a la competencia");
            Console.WriteLine("- Verificando que exista la moto en la lista : {0}", c1 == m1 ? "Existe la moto en la lista" : "No existe la moto en la lista");
            Console.WriteLine("- Quitando moto a competencia de moto: {0}", c1 - m1 ? "Se agregó la moto a la competencia" : "No se agregó la moto a la competencia");
            Console.WriteLine("- Verificando que exista la moto en la lista : {0}", c1 == m1 ? "Existe la moto en la lista" : "No existe la moto en la lista");

        }
    }
}