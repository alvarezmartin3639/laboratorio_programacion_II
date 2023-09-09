namespace Bibloteca
{
    public class Sumador
    {
        private int cantidadSumas;

        public Sumador():this(0)
        {
        }

        public Sumador(int cantidadSumas)
        {
            this.CantidadSumas = cantidadSumas;
        }

        public int CantidadSumas { get => cantidadSumas; set => cantidadSumas = value; }

        public long Sumar(long a, long b)
        {
            this.cantidadSumas++;
            return a + b;
        }

        public string Sumar(string a, string b)
        {
            this.cantidadSumas++;
            return a + b;
        }

        public static explicit operator int(Sumador sumador) {
                return sumador.CantidadSumas;
        }    

        public static long operator +(Sumador s1, Sumador s2)
        {
            return s1.CantidadSumas + s2.CantidadSumas; 
        }

        public static bool operator |(Sumador s1, Sumador s2)
        {
            return (s1.CantidadSumas == s2.CantidadSumas) ;
        }
    }
}