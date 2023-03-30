
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Montoya
{
    internal class Program
    {
        /// <FECHA> 25/02/2023
        /// </NOMBRE> MARIA CAMILA MONTOYA ZAPATA
        /// <DESCRIPCIÓN>Desarrollar un programa que cargue los lados de un triángulo e implemente los siguientes métodos:
        /// inicializar los atributos, imprimir el valor del lado mayor y otro método que muestre si es equilátero o no.
        static void Main(string[] args)
        {
            //Datos de salida
            Console.WriteLine("Hola, esta aplicación te mostrará el lado mayor de un tríangulo");
            Console.WriteLine("Ingresa el lado 1 del triangulo");
            //Declaración de variable
            int Lado1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Ingresa el lado 2 del triangulo");
            int Lado2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Ingresa el lado 3 del triangulo");
            int Lado3 = Convert.ToInt32(Console.ReadLine());

            //Métodos invocados
            InicializarAtributos(Lado1, Lado2, Lado3);

            ValorMayor(Lado1, Lado2, Lado3);

            TipoTriangulo(Lado1, Lado2, Lado3);
        }
        //Metodos
        public static void InicializarAtributos(int Lado1, int Lado2, int Lado3)
        {
            Console.WriteLine("Señor/a usuario, los lados registrados son:");
            Console.WriteLine("LADO 1: " + Lado1);
            Console.WriteLine("LADO 2: " + Lado2);
            Console.WriteLine("LADO 3: " + Lado3);


        }

        public static void ValorMayor(int Lado1, int Lado2, int Lado3)
        {
            //Estructura desiciva

            if (Lado1 == Lado2 & Lado1 == Lado3)
            {
                Console.WriteLine("No hay un lado mayor, debido a que todos los lados son iguales.");
            }
            else if (Lado1 > Lado2 & Lado1 > Lado3)
            {
                Console.WriteLine("El lado 1 es mayor con una medida de: " + Lado1);
            }
            else if (Lado2 > Lado1 & Lado2 > Lado3)
            {
                Console.WriteLine("El lado 2 es mayor con una medida de: " + Lado2);
            }
            else
            {
                Console.WriteLine("El lado 3 es mayor con una medida de: " + Lado3);
            }

           
        }

        public static void TipoTriangulo(int Lado1, int Lado2, int Lado3)
        {

            if (Lado1 == Lado2 & Lado2 == Lado3)
            {
                Console.WriteLine("Este triángulo es equílatero.");
            }
            else
            {
                Console.WriteLine("Este triángulo no es equílatero, debido a que todos sus lados no son iguales.");
            }

            Console.ReadKey();
        }

    }
}
