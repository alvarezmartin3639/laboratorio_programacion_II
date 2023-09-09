using Bibloteca;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sumador sumador1 = new Sumador();
            Sumador sumador2 = new Sumador();

            Console.WriteLine("Suma de numeros(sumador1): {0}", sumador1.Sumar(2,2));
            Console.WriteLine("Suma de cadenas(sumador2): {0}", sumador2.Sumar("2", "2"));
            Console.WriteLine("Cantidad de sumas utilizando el sumador1: {0}", (int)sumador1);
            Console.WriteLine("Cantidad de sumas utilizando el sumador2: {0}", (int)sumador2);
            Console.WriteLine("sumador1 + sumador2 = {0}", sumador1 + sumador2);
            Console.WriteLine("Ambos sumadores hicieron la misma cantida de sumas?: {0}", (sumador1 | sumador2) ?"SI" :"NO");

        }
    }
}