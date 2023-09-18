using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4_DC_1134222
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ejercicio 1: operaciones aritméticas");

            Console.WriteLine("Ingrese un numero:");
            string numero1 = Console.ReadLine();
            int num1 = Convert.ToInt32(numero1);

            Console.WriteLine("Ingrese otro numero:");
            string numero2 = Console.ReadLine();
            int num2 = Convert.ToInt32(numero2);

            Console.WriteLine("Ingrese otro numero:");
            string numero3 = Console.ReadLine();
            int num3 = Convert.ToInt32(numero3);

            int suma = num1 + num2;
            Console.WriteLine("Suma: " + num1 + " + " + num2 + " = " + suma);

            int resta = num1 - num2;
            Console.WriteLine("Resta: " + num1 + " - " + num2 + " = " + resta);

            int multiplicacion = num1 * num2;
            Console.WriteLine("Multiplicacion: " + num1 + " * " + num2 + " = " + multiplicacion);

            int division = num1 / num2;
            Console.WriteLine("Division: " + num1 + " / " + num2 + " = " + division);

            int resi = num1 % num2;
            Console.WriteLine("Residuo: " + num1 + " % " + num2 + " = " + resi);

            Console.WriteLine("ejercicio 2: operaciones booleanas");

            if (num1 > num2)
                Console.WriteLine(num1 + " > " + num2);

            else if (num1 < num2)
                Console.WriteLine(num1 + " < " + num2);

            else if (num1 == num2)
                Console.WriteLine(num1 + " = " + num2);

            Console.WriteLine("ejercicio 3: jerarquia de operaciones");

            int abc= num1 * num2 + num3;
            Console.WriteLine("I) a * b + c =" + abc);

            int abc2 = num1 * (num2 + num3);
            Console.WriteLine("II) a * (b + c) =" + abc2);


            Console.ReadKey();
        }
    }
}
