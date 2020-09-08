using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursosAlumno.Model;

namespace CursosAlumno.Model
{
    class alumno
    {
        #region Atributos
        private int _idA;
        private string _nombreA;
        private string _appatA;
        private string _apmatA;
        private string _rutA;
        private curso _cursoA;
        #endregion
        #region Constructores
        public alumno()
        {
            IdA = 0;
            NombreA = string.Empty;
            AppatA = string.Empty;
            ApmatA = string.Empty;
            RutA = string.Empty;
            CursoA = new curso();
        }

        public alumno(int IdA, string NombreA, string AppatA, string ApmatA, string RutA, curso CursoA)
        {
            this.IdA = IdA;
            this.NombreA = NombreA;
            this.AppatA = AppatA;
            this.ApmatA = ApmatA;
            this.RutA = RutA;
            this.CursoA = CursoA;
        }
        #endregion
        #region Propiedades
        public int IdA { get => _idA; set => _idA = value; }
        public string NombreA { get => _nombreA; set => _nombreA = value; }
        public string AppatA { get => _appatA; set => _appatA = value; }
        public string ApmatA { get => _apmatA; set => _apmatA = value; }
        public string RutA { get => _rutA; set => _rutA = value; }
        internal curso CursoA { get => _cursoA; set => _cursoA = value; }
        #endregion
        #region Metodos
        public string obtenerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("ID      : ").Append(_idA).Append(Environment.NewLine);
            sb.Append("Nombre  : ").Append(_nombreA).Append(" ").Append(_appatA).Append(" ").Append(ApmatA).Append(Environment.NewLine);
            sb.Append("RUT     : ").Append(_rutA).Append(Environment.NewLine);
            sb.Append("Curso   : ").Append(_cursoA.NombreC).Append(Environment.NewLine);
            return sb.ToString();
        }
        #endregion
    }
}
