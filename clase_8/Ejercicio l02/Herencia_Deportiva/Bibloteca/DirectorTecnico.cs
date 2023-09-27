using System.Data.Common;
using System.Text;

namespace Bibloteca
{
    public class DirectorTecnico: Persona
    {
        private DateTime fechaNacimiento;
        private DirectorTecnico(string nombre) :base(nombre)
        {
        }

        public DirectorTecnico(string nombre, DateTime fechaNacimiento):base(nombre)
        {
            this.fechaNacimiento = fechaNacimiento;
        }

        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder(base.MostrarDatos());

            sb.AppendLine($"Fecha Nacimiento -> {this.fechaNacimiento}.");

            return sb.ToString();
        }

        public static bool operator ==(DirectorTecnico d1, DirectorTecnico d2)
        {
            return (d1.Nombre == d2.Nombre && d1.fechaNacimiento == d2.fechaNacimiento);
        }

        public static bool operator !=(DirectorTecnico d1, DirectorTecnico d2)
        {
            return !(d1 == d2);
        }
    }
}