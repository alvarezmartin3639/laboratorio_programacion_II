using System.Text;

namespace ClasesNegocio
{
    public class Celular
    {

        #region Atributos
        private string titular;
        private int numero;
        private EMarca marca;
        private string modelo;
        private int ram;
        private double almacenamiento;
        private double almacenamientoActual;
        private bool encendido;
        private Queue<Llamada> llamadasRealizadas;
        private Dictionary<Contacto, DateTime> agenda;
        //private List<Contacto> agenda;//Lista Contacto
        private List<App> apps;//Lista Ap
        #endregion

        #region Constructores
        public Celular()
        {
            this.llamadasRealizadas = new Queue<Llamada>();
            this.Apps = new List<App>();
            this.Agenda = new Dictionary<Contacto, DateTime>();
        }

        public Celular(string titular, int numero, EMarca marca, string modelo, int ram, double almacenamiento)
            : this()
        {
            this.Titular = titular;
            this.Numero = numero;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Ram = ram;
            this.Almacenamiento = almacenamiento;
        }

        public Celular(string titular, int numero, EMarca marca, string modelo, int ram, double almacenamiento, Dictionary<Contacto, DateTime> agenda, List<App> apps, Queue<Llamada> llamadasRealizadas)
            : this(titular, numero, marca, modelo, ram, almacenamiento)
        {
            this.Agenda = agenda;
            this.Apps = apps;
            this.llamadasRealizadas = llamadasRealizadas;
        }
        #endregion

        #region Propiedades
        public string Modelo
        {
            get
            {
                return this.modelo;
            }
            set
            {
                this.modelo = value;
            }
        }

        public EMarca Marca { get => marca; set => marca = value; }

        public int Ram { get => ram; set => ram = value; }
        public double Almacenamiento
        {
            get => almacenamiento;
            set => almacenamiento = value;
        }
        public double AlmacenamientoActual { get => almacenamientoActual; set => almacenamientoActual = value; }
        public bool Encendido { get => encendido; set => encendido = value; }
        public Dictionary<Contacto, DateTime> Agenda { get => agenda; set => agenda = value; }
        public List<App> Apps { get => apps; set => apps = value; }
        public string Titular { get => titular; set => titular = value; }
        public int Numero { get => numero; set => numero = value; }
        public Queue<Llamada> LlamadasRealizadas { get => llamadasRealizadas; }
        #endregion

        #region Metodos
        public string AlternarEncendido()
        {
            this.Encendido = !this.Encendido;
            return this.Encendido ? "Encendiendo..." : "Apagando...";
        }

        public void Llamar(string numero)
        {
            if (this.encendido)
            {
                if (BuscarEnAgenda(numero))
                {
                    Console.WriteLine($"Llamando al numero: {numero}");
                }
                else
                {
                    Console.WriteLine("Numero no encontrado...");
                }
            }
            else
            {
                Console.WriteLine("El celular esta apagado");
            }
        }

        public void Llamar(Contacto unContacto)
        {
            if (this.encendido)
            {
                if (BuscarEnAgenda(unContacto.Numero))
                {
                    Console.WriteLine($"Llamando a: {unContacto.Nombre}");
                }
                else
                {
                    Console.WriteLine("Contacto no encontrado...");
                }
            }
            else
            {
                Console.WriteLine("El celular esta apagado");
            }
        }


        private bool BuscarEnAgenda(string numeroIngresado)
        {
            bool estaEnAgenda;
            estaEnAgenda = false;

            foreach (KeyValuePair<Contacto, DateTime> contacto in this.agenda)
            {
                if (contacto.Key.Numero == numeroIngresado)
                {
                    estaEnAgenda = true;
                    break;
                }
            }

            return estaEnAgenda;
        }

        private bool InstalarApp(App aplicacion)
        {
            bool exito;
            exito = false;

            if (this.encendido && this != aplicacion && VerificarEspacio(aplicacion.Size))
            {
                exito = true;
                this.apps.Add(aplicacion);
                this.almacenamientoActual += aplicacion.Size;
            }

            return exito;
        }

        private bool VerificarEspacio(double nuevoSize)
        {
            return (this.almacenamientoActual + nuevoSize) < this.almacenamiento;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($" Titular -> {this.Titular}");
            sb.AppendLine($" Número -> {this.Numero}");
            sb.AppendLine($" Marca -> {this.marca}");
            sb.AppendLine($" Modelo -> {this.modelo}");
            sb.AppendLine($" RAM -> {this.ram}");
            sb.AppendLine($" Almacenamiento -> {this.almacenamiento}");
            sb.AppendLine("\n\n Aplicaciones instaladas:\n");

            if (this.apps.Count > 0)
            {
                foreach (App aplicacion in this.Apps)
                {
                    sb.AppendLine($" -{aplicacion.Nombre}");
                }
            }
            else
            {
                sb.AppendLine("No hay apps instaladas");
            }

            if (this.LlamadasRealizadas.Count > 0)
            {
                sb.AppendLine($"\n\n Llamadas realizadas:\n");

                foreach (Llamada llamada in this.LlamadasRealizadas)
                {
                    sb.AppendLine($" {llamada.ToString()}");
                }

            }

            return sb.ToString();
        }

        #endregion

        #region Sobrecarga de operadores
        public static bool operator ==(Celular miCelu, App miApp)
        {
            bool exito;
            exito = false;
            foreach (string aplicacion in miCelu.Apps)
            {
                if (aplicacion == miApp.Nombre)
                {
                    exito = true;
                    break;
                }
            }

            return exito;
        }
        public static bool operator !=(Celular miCelu, App miApp)
        {
            return !(miCelu == miApp);
        }

        public static bool operator +(Celular miCelu, App miApp)
        {
            return miCelu.InstalarApp(miApp);
        }
        #endregion

    }
}