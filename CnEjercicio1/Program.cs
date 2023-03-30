using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Montoya
{
    internal class Program
    {
        /// <FECHA> 25/02/2023
        /// </NOMBRE> MARIA CAMILA MONTOYA ZAPATA
        /// <DESCRIPCIÓN> Crear una clase que permita cargar el nombre y la edad de una persona. 
        /// Mostrar los datos cargados.  Imprimir un mensaje si es mayor de edad (edad >=18).
        static void Main(string[] args)
        {
            //Datos de salida
            Console.WriteLine("Hola, esta aplicación te dirá si eres mayor de edad");
            Console.WriteLine("Ingresa tu nombre");

            //Declaración de variable
            String Nombre = Console.ReadLine();

            Console.WriteLine("Ingresa tu edad");
       
            //Declaración de variable
            int Edad = Convert.ToInt32(Console.ReadLine());

            //Métodos invocados
           MostrarDatos(Nombre, Edad);
            GenerarMensaje(Edad);

            Console.ReadKey();
           

            


        }

        //Metodo para mostrar datos registrados
        public static void MostrarDatos(string Nombre , int Edad)
        {
            Console.WriteLine("Señor/a usuario, los datos registrados son:");
            Console.WriteLine("NOMBRE: " + Nombre);
            Console.WriteLine("EDAD: " + Edad);

        }

        //Metodo para mostrar si el usuario es mayor de edad
        public static void GenerarMensaje(int Edad)
        {
            //Estructura de decisión lógica para ejecutar instrucciones dependiendo de la edad del usuario
            if (Edad >= 18)
            {
                Console.WriteLine("Señor/a, usted es mayor de edad");
                Console.WriteLine("----------------REGISTRO EXITOSO---------------------");
            }
            else
            {
                Console.WriteLine("Señor/a, usted no es mayor de edad");
                Console.WriteLine("----------------REGISTRO EXITOSO---------------------");
            }
            }
        }
    }

