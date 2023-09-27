namespace Bibloteca
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            this.Jugadores = new List<Jugador>();
        }

        public Equipo(short cantidad, string nombre) : this()
        {
            this.cantidadDeJugadores = cantidad;
            this.Nombre = nombre;
        }   

        public short CantidadDeJugadores { get => (short)this.Jugadores.Count(); }
        public List<Jugador> Jugadores { get => jugadores; set => jugadores = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public static bool operator +(Equipo e, Jugador j)
        {
            bool retorno = false;

            if (e.Jugadores != null)
            {
                e.Jugadores.Add(j);
                retorno = false;
            }

            return retorno;
        }
    }
}