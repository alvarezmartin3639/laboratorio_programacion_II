namespace Bibloteca
{
    public class Automovil : VehiculoTerrestre
    {
        private short cantidadMarchas;
        private int cantidadPasajeros;

        public Automovil()
        {
        }

        public Automovil(short cantidadRuedas, Colores.EColores color, short cantidadPuertas, short cantidadMarchas, int cantidadPasajeros) : base(cantidadRuedas, color, cantidadPuertas)
        {
            base.CantidadRuedas = cantidadRuedas;
            base.Color = color;
            base.CantidadPuertas = cantidadPuertas;
            this.CantidadMarchas = cantidadMarchas;
            this.cantidadPasajeros = cantidadPasajeros;
        }

        public bool VerificarValorDePropiedades(short cantidadRuedas, Colores.EColores color, short cantidadPuertas, short cantidadMarchas, int cantidadPasajeros)
        {
            bool verificado = false;

            if (base.VerificarValorDePropiedades(cantidadRuedas, color, cantidadPuertas) && this.cantidadMarchas == cantidadMarchas && this.cantidadPasajeros == cantidadPasajeros)
            {
                verificado = true;
            }

            return verificado;
        }

        public short CantidadMarchas { get => cantidadMarchas; set => cantidadMarchas = value; }
        public int CantidadPasajeros { get => cantidadPasajeros; set => cantidadPasajeros = value; }
    }
}
