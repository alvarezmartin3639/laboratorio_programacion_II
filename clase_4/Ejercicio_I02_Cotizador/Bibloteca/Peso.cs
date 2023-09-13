namespace Bibloteca
{
    public class Peso
    {
        #region Atributos
        private double cantidad;
        static double cotzRespecotDolar;
        #endregion

        #region Constructores
        static Peso()
        {
            cotzRespecotDolar = 0.009747;
        }

        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Peso(double cantidad, double cotizacion) : this(cantidad)
        {
            cotzRespecotDolar = cotizacion;
        }

        #endregion

        #region Metodos
        public static double GetCotizacion()
        {
            return cotzRespecotDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }
        #endregion

        #region Sobrecargas
        public static explicit operator Dolar(Peso p)
        {
            return new Dolar( p.cantidad * Peso.cotzRespecotDolar );
        }

        public static explicit operator Euro(Peso p)
        {
            return new Euro(p.cantidad * Peso.cotzRespecotDolar);
        }

        public static implicit operator Peso(double d)
        {
           return new Peso(d);
        }


        public static bool operator ==(Peso p, Dolar d)
        {
            return ((p.GetCantidad() * Peso.cotzRespecotDolar) == d.GetCantidad());
        }
        public static bool operator ==(Peso p, Euro e)
        {
            return (p.cantidad == e.GetCantidad());
        }

        public static bool operator ==(Peso p1, Peso p2)
        {
            return (p1.cantidad == p2.GetCantidad());
        }

        public static bool operator !=(Peso p, Dolar d)
        {

        }

        public static bool operator !=(Peso p, Euro e)
        {

        }

        public static bool operator !=(Peso p1, Peso p2)
        {

        }

        public static Peso operator +(Peso p, Dolar d)
        {

        }

        public static Peso operator +(Peso p, Euro e)
        {

        }

        public static Peso operator -(Peso p, Dolar d)
        {

        }

        public static Peso operator -(Peso p, Euro e)
        {

        }
        #endregion
    }
}