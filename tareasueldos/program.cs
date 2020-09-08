using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3603_Manriquez_Alexander.Libreria;

namespace _3603_Manriquez_Alexander
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CONSOLA DE SUELDOS");
            Console.WriteLine("Ingrese los datos solicitados, si omite algo deberá comenzar nuevamente");
            Console.WriteLine("Ingrese el Nombre completo del trabajador: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el RUT del trabajador: ");
            string rut = Console.ReadLine();
            Console.WriteLine("Ingrese el Tipo de salud: ");
            Console.WriteLine("FONASA(1)    Isapre Colmena(2)    Isapre Consalud(3)");
            string tipoPrevision = Console.ReadLine();
            Console.WriteLine("Ingrese el número de Cargas Famliares: ");
            string numCargas = Console.ReadLine();
            Console.WriteLine("Ingrese el anticipo: ");
            string anticipo = Console.ReadLine();
            Console.WriteLine("Ingrese el Sueldo Base: ");
            string sueldoBase = Console.ReadLine();


            Formato_Validacion validar = new Formato_Validacion();
            if (validar.tVacio(nombre) == false || validar.tVacio(rut) == false || validar.tVacio(tipoPrevision) == false || validar.tVacio(numCargas) == false || validar.tVacio(anticipo) == false || validar.tVacio(sueldoBase) == false)
            {
                Console.WriteLine("Estimado Usuario debe llenar todos los campos.");
                Console.Read();
            }
            else
            {
                if (validar.vNumero(tipoPrevision) == false || validar.vNumNegativo(tipoPrevision) == false || validar.vNumero(numCargas) == false || validar.vNumNegativo(numCargas) == false || validar.vNumero(anticipo) == false || validar.vNumNegativo(anticipo) == false || validar.vNumero(sueldoBase) == false || validar.vNumNegativo(sueldoBase) == false)
                {
                    Console.WriteLine("Estimado Usuario los campos tipo de salud, numero de cargas, anticipo y sueldo base tienen que ser numeros no negativos.");
                    Console.Read();
                }
                else
                {
                    SueldoTrabajador sdo = new SueldoTrabajador();
                    sdo.NomCompleto = nombre;
                    sdo.Rut = rut;
                    sdo.TPrevision = int.Parse(tipoPrevision);
                    sdo.NumeroCargas = int.Parse(numCargas);
                    sdo.Anticipo = int.Parse(anticipo);
                    sdo.SueldoBase = int.Parse(sueldoBase);

                    Console.WriteLine(sdo.obtenerDatos());
                    Console.Read();
                }
            }
            
        }
    }
}
