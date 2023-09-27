using System.Text;

namespace Bibloteca
{
    public class Jugador: Persona
    {
        private int partidosJugados;
        private int totalGoles;

        public Jugador(int dni, string nombre) : base(dni, nombre)
        {

        }

        public Jugador(int dni, string nombre, int partidosJugados, int totalGoles):base(dni, nombre)
        {
            this.partidosJugados = partidosJugados;
            this.totalGoles = totalGoles;
        }

        public int PartidosJugados { get => partidosJugados; set => partidosJugados = value; }
        public int TotalGoles { get => totalGoles; set => totalGoles = value; }

        public int PromedioGoles { get => partidosJugados / totalGoles; }

        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder(base.MostrarDatos());

            sb.AppendLine($"Partidos jugados -> {this.PartidosJugados}.");
            sb.AppendLine($"Total goles -> {this.TotalGoles}.");
            sb.AppendLine($"Promedio goles -> {this.PromedioGoles}.");

            return sb.ToString();
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return (Persona)j1 == (Persona)j2;
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
    }
}