
namespace GUI
{
    using ClasesNegocio;

    public class MensajesConsola
    {
        public void MostrarNombresDeApps(List<App> listaDeApps)
        {
            foreach (App aplicacion in listaDeApps)
            {
                Console.WriteLine(aplicacion.Nombre);
            }
        }

    }
}