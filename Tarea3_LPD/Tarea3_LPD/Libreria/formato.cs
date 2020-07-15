using System;
using System.Collections.Generic;
using System.Text;


namespace Tarea3_LPD.Libreria
{
    public class formato
    {
        public string monto(int x)
        {
            string res;
            res = "$" + x.ToString("###,###,###,###");
            return res;
        }
        public bool valNeg(int mt)
        {
            bool res;
            if(mt <0) // regla de minimo o máximo?=
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
