using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3603_Manriquez_Alexander.Libreria
{
   public class SueldoTrabajador
    {
        #region Atributo
        private string _nomCompleto;
        private string _rut;
        private int _tPrevision;
        private int _numeroCargas;
        private int _anticipo;
        private int _sueldoBase;
        private int tipoAFP;
        #endregion

        #region Constructor
        public SueldoTrabajador(string _nomCompleto, string _rut, int _tPrevision, int _numeroCargas, int _anticipo, int _sueldoBase, int _tipoAFP)
        {
            this.NomCompleto = _nomCompleto;
            this.Rut = _rut;
            this.TPrevision = _tPrevision;
            this.NumeroCargas = _numeroCargas;
            this.Anticipo = _anticipo;
            this.SueldoBase = _sueldoBase;
            this.TipoAFP = _tipoAFP;
        }

        public SueldoTrabajador()
        {
            this.NomCompleto = string.Empty;
            this.Rut = string.Empty; 
            this.TPrevision = 0;
            this.NumeroCargas = 0;
            this.Anticipo = 0;
            this.SueldoBase = 0;
            this.TipoAFP = 0;
        }

        #endregion


        #region Propiedades

        public string NomCompleto
        {
            get
            {
                return _nomCompleto;
            }

            set
            {
                _nomCompleto = value;
            }
        }

        public string Rut
        {
            get
            {
                return _rut;
            }

            set
            {
                _rut = value;
            }
        }

        public int TPrevision
        {
            get
            {
                return _tPrevision;
            }

            set
            {
                _tPrevision = value;
            }
        }

        public int NumeroCargas
        {
            get
            {
                return _numeroCargas;
            }

            set
            {
                _numeroCargas = value;
            }
        }

        public int Anticipo
        {
            get
            {
                return _anticipo;
            }

            set
            {
                _anticipo = value;
            }
        }

        public int SueldoBase
        {
            get
            {
                return _sueldoBase;
            }

            set
            {
                _sueldoBase = value;
            }
        }

        public int TipoAFP
        {
            get
            {
                return tipoAFP;
            }

            set
            {
                tipoAFP = value;
            }
        }
        #endregion

        #region Metodos

        public string TipoPrevicion()
        {
            string sal;
            if (_tPrevision == 1)
            {
                sal = "FONASA (7%). ";
            }
            else if (_tPrevision == 2)
            {
                sal = "Isapre Colmena (9%). ";
            }
            else if (_tPrevision == 2)
            {
                sal = "Isapre Consalud (11%). ";
            }
            else
            {
                sal = "nulo";
            }
            return sal;
        }

        public int DineroSalud()
        {
            int sal;
            if (_tPrevision == 1)
            {
                sal = _sueldoBase * 7 / 100;
            }
            else if (_tPrevision == 2)
            {
                sal = _sueldoBase * 9 / 100;
            }
            else if (_tPrevision == 2)
            {
                sal = _sueldoBase * 11 / 100;
            }
            else
            {
                sal = 0;
            }
            return sal;
        }

        public int sdoImponible()
        {
            int sal;
            sal = _sueldoBase + 57000;
            return sal;
        }

        public int sdoCargaFAmiliar()
        {
            int sal;
            sal = 12620 * _numeroCargas;
            return sal;
        }

        public int sdoTotalNoImponible()
        {
            int sal;
            sal = 40000 + 50000 + sdoCargaFAmiliar();
            return sal;
        }

        public int sdoAFP()
        {
            int sal;
            sal = _sueldoBase * 10/100;
            return sal;
        }

        public int sdoSeguroCesantia()
        {
            int sal;
            sal = _sueldoBase * 1 / 100;
            return sal;
        }

        public int TotalDescuentos()
        {
            int sal;
            sal = DineroSalud() + sdoAFP() + _anticipo + sdoSeguroCesantia();
            return sal;
        }


        public int SueldoApagar()
        {
            int sal;
            sal = sdoTotalNoImponible() + sdoImponible() - TotalDescuentos() ;
            return sal;
        }
        public string obtenerDatos()
        {
            Formato_Validacion formato = new Formato_Validacion();
            StringBuilder sb = new StringBuilder();
            sb.Append("==================================================").Append(Environment.NewLine);
            sb.Append("Nombre                     : ").Append(_nomCompleto).Append(".").Append(Environment.NewLine);
            sb.Append("RUT                        : ").Append(_rut).Append(Environment.NewLine);
            sb.Append("Previsión                  : ").Append(TipoPrevicion()).Append(".").Append(Environment.NewLine);
            sb.Append("Carga Familiar             : ").Append(_numeroCargas).Append(" Cargas.").Append(Environment.NewLine);
            sb.Append("Anticipo                   : ").Append(formato.fDinero(_anticipo)).Append(".").Append(Environment.NewLine);
            sb.Append("--------------------------------------------------").Append(Environment.NewLine);
            sb.Append("Sueldo Base                : ").Append(formato.fDinero(_sueldoBase)).Append(".").Append(Environment.NewLine);
            sb.Append("Gratificación              : ").Append("$ 57.000").Append(".").Append(Environment.NewLine);
            sb.Append("TOTAL IMPONIBLE            : ").Append(formato.fDinero(sdoImponible())).Append(".").Append(Environment.NewLine);
            sb.Append("").Append(Environment.NewLine);
            sb.Append("Carga Familiar             : ").Append(formato.fDinero(sdoCargaFAmiliar())).Append(".").Append(Environment.NewLine);
            sb.Append("Movilización               : ").Append("$ 40.000").Append(".").Append(Environment.NewLine);
            sb.Append("Colación                   : ").Append("$50.000").Append(".").Append(Environment.NewLine);
            sb.Append("TOTAL NO IMPONIBLE         : ").Append(formato.fDinero(sdoTotalNoImponible())).Append(".").Append(Environment.NewLine);
            sb.Append("").Append(Environment.NewLine);
            sb.Append("Salud                      : ").Append(formato.fDinero(DineroSalud())).Append(Environment.NewLine);
            sb.Append("AFP                        : ").Append(formato.fDinero(sdoAFP())).Append(Environment.NewLine);
            sb.Append("Anticipo                   : ").Append(formato.fDinero(_anticipo)).Append(".").Append(Environment.NewLine);
            sb.Append("Seguro Cesantia            : ").Append(formato.fDinero(sdoSeguroCesantia())).Append(".").Append(Environment.NewLine);
            sb.Append("TOTAL DESCUENTOS           : ").Append(formato.fDinero(TotalDescuentos())).Append(".").Append(Environment.NewLine);
            sb.Append("--------------------------------------------------").Append(Environment.NewLine);
            sb.Append("Total Imponible            : ").Append(formato.fDinero(sdoImponible())).Append(".").Append(Environment.NewLine);
            sb.Append("Total No Imponible         : ").Append(formato.fDinero(sdoTotalNoImponible())).Append(".").Append(Environment.NewLine);
            sb.Append("Descuentos                 : ").Append(formato.fDinero(TotalDescuentos())).Append(".").Append(Environment.NewLine);
            sb.Append("SUELDO A PAGAR             : ").Append(formato.fDinero(SueldoApagar())).Append(".").Append(Environment.NewLine);
            sb.Append("==================================================").Append(Environment.NewLine);
            return sb.ToString();
        }
        #endregion
    }
}
