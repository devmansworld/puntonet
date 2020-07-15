using System;
using Tarea3_LPD.Libreria;

namespace Tarea3_LPD
{
    class Program
    {
        static void Main(string[] args)
        {

            venta v = new venta();
            formato f = new formato();

            Console.WriteLine("Sistema de Validación para Descuentos");
            Console.WriteLine("Ingresar datos solicitados");
            Console.WriteLine("Ingresar edad: ");
            string ed = Console.ReadLine();

            Console.WriteLine("Ingresar Nombre: ");
            string n = Console.ReadLine();

            Console.WriteLine("Favor ingresar Monto de la Compra: ");
            string mv = Console.ReadLine();

            int val;
            bool tpEdad = Int32.TryParse(ed, out val);
            bool tpMonto = Int32.TryParse(mv, out val);
            if (tpEdad == false || tpMonto == false || n == "")
            {
                Console.WriteLine("Uno o más datos se han ingresado de manera incorrecta");
                Console.ReadLine();
            }
            else
            {
                bool edadN = f.valNeg(Convert.ToInt32(ed));
                bool mntN = f.valNeg(Convert.ToInt32(mv));
                if(edadN ==true || mntN == true)
                {
                    Console.WriteLine("Uno o más datos son negativos");
                    Console.ReadLine();
                }
                else {
                    v.NombreCompleto = n;
                    v.Edad = Convert.ToInt32(ed);
                    v.MontoVenta = Convert.ToInt32(mv);
                    Console.WriteLine(v.obtenerDatos());
                    Console.ReadLine();
               }
            }




        }
    }
}
