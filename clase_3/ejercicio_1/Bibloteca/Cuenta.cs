namespace Bibloteca
{
    public class Cuenta
    {
        #region Atributos
        private string titular;
        private float cantidad;
        #endregion

        #region Constructores
        public Cuenta(string titular, float cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }
        #endregion
        
        #region Métodos
        public string GetTitular()
        {
            return this.titular;
        }

        public float GetCantidad()
        {
            return this.cantidad;
        }

        public string CuentaToString()
        {
            return $"Razón social: {this.GetTitular()} \nMonto actual: {this.GetCantidad()}";
        }

        public bool IngresarDinero(float montoParaIngresar)
        {
            bool seGeneroElIngreso = false;

            if (montoParaIngresar > 0)
            {
                seGeneroElIngreso = true;
                this.cantidad += montoParaIngresar;
            }

            return seGeneroElIngreso;
        }

        public bool RetirarDinero(float montoParaRetirar)
        {
            bool seGeneroElRetiro = false;

            if (montoParaRetirar > 0 && montoParaRetirar <= this.cantidad)
            {
                seGeneroElRetiro = true;
                this.cantidad -= montoParaRetirar;
            }

            return seGeneroElRetiro;
        }
        #endregion

    }
}