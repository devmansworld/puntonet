using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursosAlumno.Model
{
    class curso
    {
        #region Atributos
        private int _idC;
        private string _nombreC;
        #endregion
        #region Constructores
        public curso()
        {
            IdC = 0;
            NombreC = string.Empty;
        }

        public curso(int IdC, string NombreC)
        {
            this.IdC = IdC;
            this.NombreC = NombreC;
        }
        #endregion
        #region Propiedades
        public int IdC { get => _idC; set => _idC = value; }
        public string NombreC { get => _nombreC; set => _nombreC = value; }
        #endregion
        #region Metodos
        public string obtenerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("ID    : ").Append(_idC).Append(Environment.NewLine);
            sb.Append("Nombre: ").Append(_nombreC).Append(Environment.NewLine);
            return sb.ToString();
        }
        #endregion
    }
}
