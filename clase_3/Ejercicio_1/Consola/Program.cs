namespace Consola
{
    using Bibloteca;

    internal class Program
    {
        static void Main(string[] args)
        {

            Cuenta primerCuenta = new Cuenta("Pedro", 159000);
            Random random = new Random();
            float montoRandom;

            for (int i = 0; i < 5; i++)
            {
                montoRandom = (float)random.NextDouble() * 100000;

                Console.WriteLine(primerCuenta.IngresarDinero(montoRandom)
                 ? $"Pedro ingresó ${montoRandom} correctamente!"
                 : $"Pedro no pudo hacer su ingreso de ${montoRandom}.");

                Console.WriteLine($"\nInformación de pedro actualizada:\n{primerCuenta.CuentaToString()}");
                Console.WriteLine("======================================================================");

                Console.WriteLine(primerCuenta.RetirarDinero(montoRandom)
                 ? $"Pedro retiró ${montoRandom} correctamente!."
                 : $"Pedro no pudo hacer su retirar los ${montoRandom}.");

                Console.WriteLine($"\nInformación de pedro actualizada:\n{primerCuenta.CuentaToString()}");
                Console.WriteLine("======================================================================");
            }

        }
    }
}