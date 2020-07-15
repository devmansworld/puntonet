using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora.Model
{
    public class numeros
    {
        #region Atributos
        private decimal _n1;
        private decimal _n2;
        #endregion
        #region Constructor
        public numeros()
        {
            N1 = 0;
            N2 = 0;
        }

        public numeros(decimal N1, decimal N2)
        {
            this.N1 = N1;
            this.N2 = N2;
        }

        #endregion
        #region Propiedades
        public decimal N1 { get => _n1; set => _n1 = value; }
        public decimal N2 { get => _n2; set => _n2 = value; }
        #endregion
        #region Metodos

        public string obtenerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Primer número  : ").Append(_n1).Append(Environment.NewLine);
            sb.Append("Segundo número : ").Append(_n2).Append(Environment.NewLine);
            return sb.ToString();
        }
        #endregion
    }
}
