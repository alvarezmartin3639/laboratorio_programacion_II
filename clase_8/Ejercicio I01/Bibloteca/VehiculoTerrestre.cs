using static Bibloteca.Colores;

namespace Bibloteca
{
    public class VehiculoTerrestre
    {
        private short cantidadRuedas;
        private EColores color;
        private short cantidadPuertas;

        public VehiculoTerrestre() : this(1, EColores.Blanco, 0)
        {

        }


        public VehiculoTerrestre(short cantidadRuedas, EColores color, short cantidadPuertas)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.color = color;
            this.cantidadPuertas = cantidadPuertas;

        }

        public short CantidadRuedas { get => cantidadRuedas; set => cantidadRuedas = value; }
        public EColores Color { get => color; set => color = value; }
        public short CantidadPuertas { get => cantidadPuertas; set => cantidadPuertas = value; }

        public virtual bool VerificarValorDePropiedades(short cantidadRuedas, EColores color, short cantidadPuertas)
        {
            bool verificado = false;

            if (this.CantidadRuedas == cantidadRuedas && this.Color == color && this.cantidadPuertas == cantidadPuertas)
            {
                verificado = true;
            }

            return verificado;
        }
    }
}
