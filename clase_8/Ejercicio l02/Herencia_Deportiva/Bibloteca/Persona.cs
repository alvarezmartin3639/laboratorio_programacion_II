using System.Text;

namespace Bibloteca
{
    public class Persona
    {
        private long dni;
        private string nombre;

        public Persona(string nombre):this(0,nombre)
        {
        }

        public Persona(long dni, string nombre)
        {
            this.Dni = dni;
            this.Nombre = nombre;
        }

        public long Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre -> {this.Nombre}.");
            sb.AppendLine($"Dni -> {this.Dni.ToString()}.");

            return sb.ToString();
        }

        public static bool operator ==( Persona p1, Persona p2 )
        {
            return p1.dni == p2.dni;
        }

        public static bool operator !=(Persona p1, Persona p2)
        {
            return !(p1 == p2);
        }
    }
}   