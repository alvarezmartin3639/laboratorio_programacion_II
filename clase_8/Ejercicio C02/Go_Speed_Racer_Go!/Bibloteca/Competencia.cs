using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteca
{
    public enum TipoCompetencia{
        F1,
        MotoCross
    }

    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<VehiculoDeCarrera> competidores;
        private TipoCompetencia tipo;

        private Competencia()
        {
            this.competidores = new List<VehiculoDeCarrera>();
        }

        public Competencia(short cantidadCompetidores, short cantidadVueltas, TipoCompetencia tipo):this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
            this.tipo = tipo;
        }

        public short CantidadCompetidores { get => cantidadCompetidores; set => cantidadCompetidores = value; }
        public short CantidadVueltas { get => cantidadVueltas; set => cantidadVueltas = value; }
        public List<VehiculoDeCarrera> Competidores { get => competidores; set => competidores = value; }
        public TipoCompetencia Tipo { get => tipo; set => tipo = value; }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Tipo competencia -> {this.Tipo}.");
            sb.AppendLine($"Cantidad competidores -> {this.CantidadCompetidores}.");
            Console.WriteLine("{0}");
            this.Competidores.ForEach(competidores => sb.AppendLine(competidores.MostrarDatos()));
            sb.AppendLine($"Cantidad vueltas -> {this.CantidadVueltas}.");
            sb.AppendLine($"Tipo competencia -> {this.Tipo}.");

            return sb.ToString();
        }

        public bool VehiculoEsAptoParaCompetencia(VehiculoDeCarrera a)
        {
            return (this.Tipo == TipoCompetencia.MotoCross && a.GetType() == typeof(MotoCross)
                || this.Tipo == TipoCompetencia.F1 && a.GetType() == typeof(AutoF1));
        }

        public static bool operator ==(Competencia c,VehiculoDeCarrera a)
        {
            return c.competidores.Contains(a);
        }

        public static bool operator !=(Competencia c, VehiculoDeCarrera a)
        {
            return !(c == a);
        }

        public static bool operator +(Competencia c, VehiculoDeCarrera a)
        {
            bool retorno = false;

            if (c.VehiculoEsAptoParaCompetencia(a))
            {
                retorno = true;
                c.competidores.Add(a);
            }

            return retorno;
        }

        public static bool operator -(Competencia c, VehiculoDeCarrera a)
        {
            bool retorno = false;

            if (c.VehiculoEsAptoParaCompetencia(a))
            {
                retorno = true;
                c.competidores.Remove(a);
            }

            return retorno;
        }
    }
}
