using System.Text;

namespace ClasesNegocio
{
    public class Contacto
    {
        private string nombre;
        private string numero;

        public Contacto(string nombre, string numero)
        {
            this.Nombre = nombre;
            this.Numero = numero;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Numero { get => numero; set => numero = value; }


        public override string ToString()
        {
            StringBuilder strBuilder = new();

            strBuilder.AppendLine($"Nombre -> \n{this.Nombre}");
            strBuilder.AppendLine($"Tamaño -> \n{this.Numero}");


            return strBuilder.ToString();
        }

    }
}
