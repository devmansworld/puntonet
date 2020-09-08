using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculoCompras.Controller
{
    class Validacion
    {
        public bool cVacio(string t)
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

        public bool vInt(string t)
        {
            int num;
            bool sal= Int32.TryParse(t, out num);
            return sal;
        }
    }
}
