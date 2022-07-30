using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad2_Calculadora
{
    class calculadora
    {
        public static double Operacion(double num1, double num2, string op)
        {
            double resultado = double.NaN;


            switch (op)
            {
                case "s":
                    resultado = num1 + num2;
                    break;
                case "r":
                    resultado = num1 - num2;
                    break;
                case "m":
                    resultado = num1 * num2;
                    break;
                case "d":

                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                    }
                    break;

                default:
                    break;
            }
            return resultado;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {


            bool endApp = false;

            Console.WriteLine("Calculadora de consola en C#\r");
            Console.WriteLine("------------------------\n");

            while (!endApp)
            {

                string primero = "";
                string segundo = "";
                double resultado = 0;



                Console.Write("Escriba un numero, y luego precione ENTER: ");
                primero = Console.ReadLine();

                double numero1 = 0;
                while (!double.TryParse(primero, out numero1))
                {
                    Console.Write("El numero no es valido. Por favor ingresar un valor entero: ");
                    primero = Console.ReadLine();
                }


                Console.Write("Escriba otro numero, y luego preciona ENTER: ");
                segundo = Console.ReadLine();

                double numero2 = 0;
                while (!double.TryParse(segundo, out numero2))
                {
                    Console.Write("Esta entrada no es valida ingrese un numero entero: ");
                    segundo = Console.ReadLine();
                }


                Console.WriteLine("Elija un operador, de la siguiente lista:");
                Console.WriteLine("\ts - suma");
                Console.WriteLine("\tr - restar");
                Console.WriteLine("\tm - multiplicar");
                Console.WriteLine("\td - divicion");
                Console.Write("escriba, su obcion? ");

                string op = Console.ReadLine();

                try
                {
                    resultado = calculadora.Operacion(numero1, numero2, op);
                    if (double.IsNaN(resultado))
                    {
                        Console.WriteLine("Esta operacion resulto en un error matematico.\n");
                    }
                    else Console.WriteLine("El resultado es: {0:0.##}\n", resultado);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oh no! Se produjo un error al intentar realizar los calculos.\n - Detalle: " + e.Message);
                }

                Console.WriteLine("------------------------\n");


                Console.Write("precione n y enter para cerrar la aplicacion o precione cualquier otra tecla para continuar: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n");
            }
            return;
        }
    }
}



