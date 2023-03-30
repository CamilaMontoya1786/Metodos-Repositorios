using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7_Montoya
{ /// <FECHA> 25/02/2023
  /// </NOMBRE> MARIA CAMILA MONTOYA ZAPATA
  /// <DESCRIPCIÓN>Confeccionar una clase que permita ingresar tres valores por teclado. 
  /// Luego mostrar el mayor y el menor.

    internal class Program
    {
        static void Main(string[] args)
        {
            //Datos de salida
            Console.WriteLine("Hola, esta aplicación te mostrará el número mayor y menor que ingreses.");
            Console.WriteLine("Ingresa el número 1");
            //Declaración de variable
            int Numero1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Ingresa el número 2");
            int Numero2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Ingresa el número 3");
            int Numero3 = Convert.ToInt32(Console.ReadLine());

            //Métodos invocados

            CargarDatos(Numero1, Numero2, Numero3);
            NumeroMayor(Numero1, Numero2, Numero3);
            NumeroMenor(Numero1, Numero2, Numero3);

        }

        //Métodos
        public static void CargarDatos(int Numero1, int Numero2, int Numero3)
        {
            Console.WriteLine("Señor/a usuario, los numeros registrados son:");
            Console.WriteLine("NÚMERO 1: " + Numero1);
            Console.WriteLine("NÚMERO 2: " + Numero2);
            Console.WriteLine("NÚMERO 3: " + Numero3);
            
        }

        public static void NumeroMayor(int Numero1, int Numero2, int Numero3)
        {
            //Estructura decisiva 
            if (Numero1 > Numero2 & Numero1 > Numero3)
            {
                Console.WriteLine("El número 1: " + Numero1 + " ,es el mayor");
            }
            else if (Numero2 > Numero1 & Numero2 > Numero3)
            {
                Console.WriteLine("El número 2: " + Numero2 + " ,es el mayor");
            }
            else
            {
                Console.WriteLine("El número 3: " + Numero3 + " es el mayor");
            }

            
        }

        public static void NumeroMenor(int Numero1, int Numero2, int Numero3)
        {
            //Estructura decisiva 
            if (Numero1 < Numero2 & Numero1 < Numero3)
            {
                Console.WriteLine("El número 1: " + Numero1 + " es el menor");
            }
            else if (Numero2 < Numero1 & Numero2 < Numero3)
            {
                Console.WriteLine("El número 2: " + Numero2 + " es el menor");
            }
            else
            {
                Console.WriteLine("El número 3: " + Numero3 + " es el menor");
            }

            Console.ReadKey();
            
        }
    }
}
