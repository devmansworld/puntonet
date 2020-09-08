using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursosAlumno.Controller
{
    class validacion
    {
        public bool vCampo(string t)
        {
            string v = t.Trim();
            if(v == "" || v == string.Empty)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool vINT(string t)
        {
            int num;
            bool sal = Int32.TryParse(t, out num);
            return sal;
        }
    }
}
