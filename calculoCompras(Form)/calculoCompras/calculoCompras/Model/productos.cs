using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculoCompras.Model
{
    class productos
    {
        #region Atributos
        private string _nombre;
        private int _precio;
        #endregion
        #region Constructor
        public productos()
        {
            Nombre = string.Empty;
            Precio = 0;
        }
        public productos(string Nombre, int Precio)
        {
            this.Nombre = Nombre;
            this.Precio = Precio;
        }
        #endregion
        #region Propiedades
        public string Nombre { get => _nombre; set => _nombre = value; }
        public int Precio { get => _precio; set => _precio = value; }
        #endregion
        #region Métodos
        public string obtenerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Nombre del producto: ").Append(_nombre).Append(".").Append(Environment.NewLine);
            sb.Append("Precio             : ").Append(_precio).Append(Environment.NewLine);
            return sb.ToString();
        }
        #endregion

    }
}
