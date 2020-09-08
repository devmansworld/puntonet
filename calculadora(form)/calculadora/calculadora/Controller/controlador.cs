using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using calculadora.Model;

namespace calculadora.Controller
{
    class controlador
    {

        public decimal suma(decimal n1, decimal n2)
        {
            return n1 + n2;
        }

        public decimal resta(decimal n1, decimal n2)
        {
            return n1 - n2;
        }

        public decimal multiplicacion(decimal n1, decimal n2)
        {
            return n1 * n2;
        }

        public decimal division(decimal n1, decimal n2)
        {
            return n1 / n2;
        }

        public string formato(int v, decimal r, decimal n1, decimal n2)
        {
            string s;
            string sal;
            switch (v)
            {
                case 1:
                    s = " + ";
                    break;
                case 2:
                    s = " - ";
                    break;
                case 3:
                    s = " x ";
                    break;
                case 4:
                    s = " / ";
                    break;
                default:
                    s = "";
                    break;
            }
            sal = n1 + s + n2 + " = " + r;
            return sal;
        }
    }
}
