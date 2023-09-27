using System.Text;

namespace Bibloteca
{
    public class VehiculoDeCarrera
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltaRestantes;

        public VehiculoDeCarrera(short numero, string escuderia)
        {
            this.Numero = numero;
            this.Escuderia = escuderia;
        }

        public VehiculoDeCarrera(short numero, string escuderia, short cantidadCombustible, bool enCompetencia, short vueltasRestantes):this(numero, escuderia)
        {
            this.CantidadCombustible = cantidadCombustible;
            this.EnCompetencia = EnCompetencia;
            this.VueltaRestantes = vueltasRestantes;
        }

        public short CantidadCombustible { get => cantidadCombustible; set => cantidadCombustible = value; }
        public bool EnCompetencia { get => enCompetencia; set => enCompetencia = value; }
        public string Escuderia { get => escuderia; set => escuderia = value; }
        public short Numero { get => numero; set => numero = value; }
        public short VueltaRestantes { get => vueltaRestantes; set => vueltaRestantes = value; }

        public virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Numero -> {this.Numero}");
            sb.AppendLine($"Escuderia -> {this.Escuderia}");
            sb.AppendLine($"En competencia -> {this.EnCompetencia}");
            sb.AppendLine($"Vueltas restantes -> {this.VueltaRestantes}");
            sb.AppendLine($"Cantidad combustible -> {this.CantidadCombustible}");

            return sb.ToString();
        }

        public static bool operator ==(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
           return v1.numero == v2.numero && v1.escuderia == v2.escuderia;
        }
        public static bool operator !=(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            return !(v1 == v2);
        }
    }
}