using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteca
{
    public class MotoCross: VehiculoDeCarrera
    {
        private short cilindrada;
        
        public MotoCross(short numero, string escuderia):base(numero, escuderia)
        {

        }
        public MotoCross(short numero, string escuderia, short cilindrada):base(numero, escuderia)
        {
            this.Cilindrada = cilindrada;
        }

        public short Cilindrada { get => cilindrada; set => cilindrada = value; }

        public static bool operator ==(MotoCross a1, MotoCross a2)
        {
            return (VehiculoDeCarrera)a1 == (VehiculoDeCarrera)a2 ? a1.cilindrada == a2.cilindrada : false;
        }

        public static bool operator !=(MotoCross a1, MotoCross a2)
        {
            return !(a1 == a2);
        }
    }
}
