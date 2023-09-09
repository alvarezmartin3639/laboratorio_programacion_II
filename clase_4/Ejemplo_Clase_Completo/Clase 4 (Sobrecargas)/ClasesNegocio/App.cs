namespace ClasesNegocio
{
    public class App
    {
        #region Atributos
        private string nombre;
        private double size;
        #endregion

        #region Constructores
        public App(string nombre, double size)
        {
            this.nombre = nombre;
            this.size = size;
        }
        #endregion

        #region Propiedades
        public string Nombre { get => nombre; set => nombre = value; }
        public double Size { get => size; set => size = value; }
        #endregion

        #region Metodos
        public static List<App> InstalarPilaDeAplicaciones(Celular celular, List<App> pilaDeAplicaciones)
        {
            List<App> aplicacionesConErroresDeInstalacion = new List<App>();

            if (pilaDeAplicaciones == null)
            {
                throw new ArgumentException("Parametro pilaDeAplicaciones es null");
            }

            foreach (App aplicacion in pilaDeAplicaciones)
            {
                if (celular + aplicacion == false)
                {
                    aplicacionesConErroresDeInstalacion.Add(aplicacion);
                }
            }

            return aplicacionesConErroresDeInstalacion;
        }
        #endregion

        #region Sobrecargas
        // Sobrecarga del operador explícito para convertir App a string
        public static explicit operator string(App app)
        {
            return $"{app.Nombre} ({app.Size} GB)";
        }

        // Sobrecarga del operador explícito para convertir App a double
        public static implicit operator double(App app)
        {
            return app.Size;
        }
        #endregion

    }
}
