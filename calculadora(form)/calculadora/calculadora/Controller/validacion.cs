using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora.Controller
{
    public class validacion
    {
        public bool vNumero(string t)
        {
            decimal num;
            return decimal.TryParse(t, out num);
        }

        public bool esCero(string t)
        {
            if (t == "0")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool cVacia(string t)
        {
            string v = t.Trim();
            if (v == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
