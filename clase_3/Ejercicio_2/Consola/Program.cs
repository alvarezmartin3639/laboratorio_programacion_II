namespace Consola
{
    using Bibloteca;
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante[] listaEstudiantes =
                {
                 new Estudiante("Perez", "1", "Juan"),
                 new Estudiante("Flores", "2", "Roberto"),
                 new Estudiante("Banquito", "3", "Esteban"),
            };

            for (int i = 0; i < 3; i++)
            {
                listaEstudiantes[i].SetNotaPrimerParcial(i + 6);
                listaEstudiantes[i].SetNotaSegundoParcial((i < 2) ? i + 7 : 2);
                Console.WriteLine(listaEstudiantes[i].Mostrar());
            }

        }
    }
}