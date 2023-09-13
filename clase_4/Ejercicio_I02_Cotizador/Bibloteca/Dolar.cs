namespace Bibloteca
{
    public class Dolar
    {
        /*
         * 
         * Yo tengo que asumir que el atributo cantidad es dolares, pero cuando hago la sobrecarga de == por ejemplo no tendria que multiplicar por cotización porque tengo asumido que es dolares..
         */
        #region Atributos
        private double cantidad;
        static double cotzRespectoDolar;
        #endregion

        #region Constructores
        static Dolar()
        {
            cotzRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }
        #endregion

        #region Propiedades
        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return cotzRespectoDolar;
        }

        #endregion

        #region Sobrecargas
        public static explicit operator Euro(Dolar d)
        {
            return new Euro(d.cantidad * Euro.GetCotizacion());
        }

        public static explicit operator Peso(Dolar d)
        {
            return new Peso(d.cantidad * Peso.GetCotizacion());
        }

        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }
        public static bool operator ==(Dolar d, Euro e)
        {
            return (d.cantidad == (e.GetCantidad() * Euro.GetCotizacion()));
        }

        public static bool operator ==(Dolar d, Peso p)
        {
            return (d.cantidad == p.GetCantidad());
        }

        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return (d1.cantidad == d2.cantidad);
        }

        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }

        public static bool operator !=(Dolar d, Peso p)
        {
            return !(d == p);
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            return new Dolar(d.GetCantidad() + ((Dolar)e).GetCantidad());
        }

        public static Dolar operator +(Dolar d, Peso p)
        {
            return new Dolar(d.GetCantidad() + ((Dolar)p).GetCantidad());
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            return new Dolar(d.GetCantidad() - ((Dolar)e).GetCantidad());
        }

        public static Dolar operator -(Dolar d, Peso p)
        {
            return new Dolar(d.GetCantidad() - ((Dolar)p).GetCantidad());
        }
        #endregion
    }
}