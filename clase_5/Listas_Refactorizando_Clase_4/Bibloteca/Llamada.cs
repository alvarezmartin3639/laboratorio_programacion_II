using System.Text;

namespace ClasesNegocio
{
    public class Llamada
    {
        private DateTime fecha;
        private int numeroDestino;
        private int duracion;


        public Llamada(DateTime fecha, int numeroDestino, int duracion)
        {
            this.fecha = fecha;
            this.numeroDestino = numeroDestino;
            this.duracion = duracion;
        }

        public Llamada()
        {
            this.fecha = new DateTime();
        }

        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int NumeroDestino { get => numeroDestino; set => numeroDestino = value; }
        public int Duracion { get => duracion; set => duracion = value; }

        public override string ToString()
        {
            StringBuilder strb = new StringBuilder();

            strb.AppendLine($"Fecha -> {this.Fecha.ToString()}");
            strb.AppendLine($" Numero de destino -> {this.NumeroDestino}");
            strb.AppendLine($" Duración -> {this.Duracion}");

            return strb.ToString();
        }
    }
}
