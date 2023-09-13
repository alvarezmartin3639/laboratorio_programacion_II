namespace Bibloteca
{
    public class Euro
    {
        #region Atributos
        private double cantidad;
        static double cotzRespectoDolar;
        #endregion

        #region Constructores
        static Euro()
        {
            cotzRespectoDolar = 1.17;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {
            cotzRespectoDolar = cotizacion;
        }
        #endregion

        #region Metodos
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
        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.cantidad * Euro.cotzRespectoDolar);
        }

        public static explicit operator Peso(Euro e)
        {
            return new Peso(e.cantidad * Euro.cotzRespectoDolar);
        }

        public static implicit operator Euro(double d)
        {
            return new Euro(d / Euro.cotzRespectoDolar);
        }

        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }

        public static bool operator !=(Euro e, Peso p)
        {
            return !(e == p);
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }

        public static bool operator ==(Euro e, Dolar d)
        {
            return (((Dolar)e).GetCantidad() == d.GetCantidad());
        }

        public static bool operator ==(Euro e, Peso p)
        {
            return (((Dolar)e).GetCantidad() == ((Dolar)p).GetCantidad());
        }

        public static bool operator ==(Euro e1, Euro e2)
        {
            return (((Dolar)e1).GetCantidad() == ((Dolar)e2).GetCantidad());
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            return ((Dolar)e).GetCantidad() + d.GetCantidad();
        }
        public static Euro operator +(Euro e, Peso p)
        {
            return ((Dolar)e).GetCantidad() + ((Dolar)p).GetCantidad();
        }
        public static Euro operator -(Euro e, Dolar d)
        {
            return ((Dolar)e).GetCantidad() - d.GetCantidad();
        }
        public static Euro operator -(Euro e, Peso p)
        {
            return ((Dolar)e).GetCantidad() - ((Dolar)p).GetCantidad();
        }
        #endregion
    }
}