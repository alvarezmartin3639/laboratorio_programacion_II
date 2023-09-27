namespace Bibloteca
{
    public class Camion : VehiculoTerrestre
    {
        private short cantidadMarchas;
        private int cantidadPasajeros;
        //En kg
        private int pesoDeCarga;


        public Camion() : this(2, Colores.EColores.Blanco, 0, 2, 1, 20)
        {

        }

        public Camion(short cantidadRuedas, Colores.EColores color, short cantidadPuertas, short cantidadMarchas, int cantidadPasajeros, int pesoDeCarga) : base(cantidadRuedas, color, cantidadPuertas)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.cantidadPasajeros = cantidadPasajeros;
            this.pesoDeCarga = pesoDeCarga;
        }

        public bool VerificarValorDePropiedades(short cantidadRuedas, Colores.EColores color, short cantidadPuertas, short cantidadMarchas, int cantidadPasajeros, int pesoDeCarga)
        {
            bool verificado = false;

            if (base.VerificarValorDePropiedades(cantidadRuedas, color, cantidadPuertas) && this.cantidadMarchas == cantidadMarchas && this.cantidadPasajeros
                == cantidadPasajeros && this.PesoDeCarga == pesoDeCarga)
            {
                verificado = true;
            }

            return verificado;
        }

        public short CantidadMarchas { get => cantidadMarchas; set => cantidadMarchas = value; }
        public int CantidadPasajeros { get => cantidadPasajeros; set => cantidadPasajeros = value; }
        public int PesoDeCarga { get => pesoDeCarga; set => pesoDeCarga = value; }


    }
}
