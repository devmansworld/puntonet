using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3603_Manriquez_Alexander.Libreria
{
   public class Formato_Validacion
    {
        public string fDinero(int d)
        {
            string sal;
            sal = "$" + d.ToString("###,###,###,###");
            return sal;
        }

        public bool tVacio(string t)
        {
            bool sal;
            if (t == "")
            {
                sal = false;
            }
            else
            {
                sal = true;
            }
            return sal;
        }

        public bool vNumero(string t)
        {
            bool sal;
            int num;
            sal = Int32.TryParse(t, out num);
            return sal;
        }

        public bool vNumNegativo(string t)
        {
            bool sal;
            int num;
            sal = Int32.TryParse(t, out num);
            if (num < 0)
            {
                sal = false;
            }
            return sal;
        }
    }
}



