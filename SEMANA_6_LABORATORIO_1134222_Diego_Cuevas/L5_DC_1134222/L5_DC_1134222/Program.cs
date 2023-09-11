using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5_DC_1134222
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 2");
            Console.WriteLine("Ingrese numero de dia");
            double numero = double.Parse(Console.ReadLine());

            if (numero >= 1 && numero <= 7)
            {
                if (numero == 1)
                {
                    Console.WriteLine("DIA: Lunes");
                }
                else if (numero == 2)
                {
                    Console.WriteLine("DIA: Martes");
                }
                else if (numero == 3)
                {
                    Console.WriteLine("DIA: Miercoles");
                }
                else if (numero == 4)
                {
                    Console.WriteLine("DIA: Jueves");
                }
                else if (numero == 5)
                {
                    Console.WriteLine("DIA: Viernes");
                }
                else if (numero == 6)
                {
                    Console.WriteLine("DIA: Sabado");
                }
                else if (numero == 7)
                {
                    Console.WriteLine("DIA: Domingo");
                }
                else if (numero <= 0)
                {
                    Console.WriteLine("Error: El numero a ingresar debe estar contenido entre 1 y 7");
                } 
            }
            Console.ReadKey();
        }
       
    }
}
