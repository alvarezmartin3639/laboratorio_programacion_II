using System.Text;

namespace Bibloteca
{
    public class Estudiante
    {

        #region Atributos
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;
        #endregion

        #region Constructores
        static Estudiante()
        {
            random = new Random();
        }

        public Estudiante(string apellido, string legajo, string nombre)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
        }
        #endregion

        #region Metodos
        public void SetNotaPrimerParcial(int nota)
        {
            if (nota > 0 && nota < 11)
            {
                this.notaPrimerParcial = nota;
            }
        }

        public void SetNotaSegundoParcial(int nota)
        {
            if (nota > 0 && nota < 11)
            {
                this.notaSegundoParcial = nota;
            }
        }

        private float CalcularPromedio()
        {
            return (this.notaPrimerParcial + this.notaSegundoParcial) / 2;
        }

        public double CalcularNotaFinal()
        {
            double nota = -1;

            if (this.notaPrimerParcial > 3 && this.notaSegundoParcial > 3)
            {
                nota = Estudiante.random.Next(6, 10);
            }

            return nota;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            double notaFinal = this.CalcularNotaFinal();

            sb.AppendLine($"Nombre -> {this.nombre} \nApellido -> {this.apellido} \nLegajo -> {this.legajo}");
            sb.AppendLine($"Nota del primer parcial -> {this.notaPrimerParcial} \nNota del segundo parcial -> {this.notaSegundoParcial}");
            sb.AppendLine($"Promedio de parciales -> {this.CalcularPromedio()}");
            sb.AppendLine($"Nota Final -> {(notaFinal > -1 ? notaFinal.ToString() : "Alumno desaprobado")}");

            return sb.ToString();
        }
        #endregion

    }
}