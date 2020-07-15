using System;
using System.Collections.Generic;
using System.Text;
using Tarea3_LPD.Libreria;

namespace Tarea3_LPD.Libreria
{
    public class venta
    {
        #region Atributos
        private string _nombreCompleto;
        private int _edad;
        private int _montoVenta;
        #endregion

        #region Constructor
        public venta()
        {
            _nombreCompleto = string.Empty;
            _edad = 0;
            _montoVenta = 0;
        }
        public venta(string NombreCompleto, int Edad, int MontoVenta)
        {
            _nombreCompleto = NombreCompleto;
            _edad = Edad;
            _montoVenta = MontoVenta;
        }

        #endregion

        #region Propiedades
        public string NombreCompleto { get => _nombreCompleto; set => _nombreCompleto = value; }
        #endregion
        public int Edad { get => _edad; set => _edad = value; }
        public int MontoVenta { get => _montoVenta; set => _montoVenta = value; }
        #region Metodo
        formato f = new formato();
        public int descuento()
        {
            int desc;
            double v;
            if (_edad >= 70)
            {
                v = 0.4;
            }
            else if (_edad <= 18)
            {
                v = 0.2;
            }
            else
            {
                v = 0;
            }
            desc = Convert.ToInt32(Math.Round(_montoVenta * v));
            return desc;
        }
        public int montoPago()
        {
            int mp = _montoVenta - descuento();
            return mp;
        }

        public string rangoEdad()
        {
            string r;
            if (_edad >= 65)
            {
                r = "Adulto mayor";
            }
            else if (_edad < 18)
            {
                r = "Joven";
            }
            else
            {
                r = "Adulto";
            }
            return r;
        }
        public string obtenerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("-----------------------------------------------").Append(Environment.NewLine);
            sb.Append("Nombre            : ").Append(_nombreCompleto).Append(".").Append(Environment.NewLine);
            sb.Append("Edad              : ").Append(_edad).Append(".").Append(Environment.NewLine);
            sb.Append("Rango de edad     : ").Append(rangoEdad()).Append(".").Append(Environment.NewLine);
            sb.Append("Monto de la Venta : ").Append(f.monto(_montoVenta)).Append(".").Append(Environment.NewLine);
            sb.Append("Monto de descuento: ").Append(f.monto(descuento())).Append(".").Append(Environment.NewLine);
            sb.Append("Monto total       : ").Append(f.monto(montoPago())).Append(".").Append(Environment.NewLine);
            sb.Append("-----------------------------------------------").Append(Environment.NewLine);
            return sb.ToString();
        }

        #endregion

    }
}
