using System.Text;

namespace ClasesNegocio
{
    public class Compania
    {
        #region Atributos
        private string razonSocial;
        private DateTime fechaDeApertura;
        private Stack<Celular> pilaDeCelulares;
        #endregion

        #region Constructores
        public Compania(string razonSocial, DateTime fechaDeApertura, Stack<Celular> pilaDeCelulares)
        {
            this.razonSocial = razonSocial;
            this.fechaDeApertura = fechaDeApertura;
            this.pilaDeCelulares = pilaDeCelulares;
        }

        public Compania() : this("Desconocida", new DateTime(), new Stack<Celular>())
        {
        }
        #endregion

        #region Propiedades
        public string RazonSocial { get => razonSocial; set => razonSocial = value; }
        public DateTime FechaDeApertura { get => fechaDeApertura; set => fechaDeApertura = value; }
        public Stack<Celular> PilaDeCelulares { get => pilaDeCelulares; set => pilaDeCelulares = value; }
        #endregion

        #region Metodos
        public string MostrarCompania()
        {
            StringBuilder strAux = new StringBuilder();

            strAux.AppendLine($"**************************************************************************************");
            strAux.AppendLine($"Razón social -> {this.RazonSocial}");
            strAux.AppendLine($"Fecha apertura -> {this.FechaDeApertura}");
            strAux.AppendLine($"**************************************************************************************");

            strAux.AppendLine($"--------------------------------------------------------------------------------------");
            strAux.AppendLine($"Celulares vinculados a {this.RazonSocial}:");
            strAux.AppendLine($"--------------------------------------------------------------------------------------");

            foreach (Celular celular in this.pilaDeCelulares)
            {
                strAux.AppendLine();
                strAux.AppendLine(celular.ToString());
                strAux.AppendLine("--------------------------------------------------------------------------------------");
            }

            return strAux.ToString();
        }


        #endregion


    }
}
