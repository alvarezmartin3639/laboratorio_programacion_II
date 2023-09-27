namespace Bibloteca
{
    public class Moto : VehiculoTerrestre
    {
        private short cilindrada;

        public Moto() : this(2, Colores.EColores.Blanco, 0, 60)
        {
        }

        public Moto(short cantidadRuedas, Colores.EColores color, short cantidadPuertas, short cilindrada) : base(cantidadRuedas, color, cantidadPuertas)
        {
            base.CantidadRuedas = cantidadRuedas;
            base.Color = color;
            base.CantidadPuertas = cantidadPuertas;
            this.Cilindrada = cilindrada;
        }

        public bool VerificarValorDePropiedades(short cantidadRuedas, Colores.EColores color, short cantidadPuertas, short cilindradas)
        {
            bool verificado = false;

            if (base.VerificarValorDePropiedades(cantidadRuedas, color, cantidadPuertas) && this.Cilindrada == cilindradas)
            {
                verificado = true;
            }

            return verificado;
        }

        public short Cilindrada { get => cilindrada; set => cilindrada = value; }
    }
}
