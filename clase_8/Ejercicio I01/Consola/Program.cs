using Bibloteca;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VehiculoTerrestre vehiculoTerrestre = new VehiculoTerrestre(2, Colores.EColores.Azul, 2);
            Automovil autoMovil = new Automovil(2, Colores.EColores.Blanco, 2, 2, 1);
            Camion camion = new Camion(6, Colores.EColores.Rojo, 3, 3, 2, 1000);
            Moto moto = new Moto(2, Colores.EColores.Negro, 2, 33);

            Console.WriteLine(vehiculoTerrestre.VerificarValorDePropiedades(2, Colores.EColores.Azul, 2)
                ? "\n\nVehiculo terrestre creado con exito!."
                : "\n\nVehiculo terrestre no se creó con exito");

            Console.WriteLine(autoMovil.VerificarValorDePropiedades(2, Colores.EColores.Blanco, 2, 2, 1)
                ? "\n\nAutomovil creado con exito!."
                : "\n\nAutomovil no se creó con exito");

            Console.WriteLine(camion.VerificarValorDePropiedades(6, Colores.EColores.Rojo, 3, 3, 2, 1000)
                ? "\n\nCamion creado con exito!."
                : "\n\nCamion  no se creó con exito");

            Console.WriteLine(moto.VerificarValorDePropiedades(2, Colores.EColores.Negro, 2, 33)
                ? "\n\nMoto creada con exito!."
                : "\n\nMoto no se creó con exito");
        }
    }
}