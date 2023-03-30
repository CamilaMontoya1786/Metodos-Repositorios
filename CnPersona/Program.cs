using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnPersonas
{
    internal class Program
    {
        /// <FECHA> 25/02/2023
        /// </NOMBRE> MARIA CAMILA MONTOYA ZAPATA
        /// <DESCRIPCIÓN> Elabore una aplicación que pida el nombre de una persona y evalué que sea
        /// mayor de edad, para continuar pidiendo los demás datos personales(apellido, edad,correo electrónico)
        static void Main(string[] args)
        {
            //Datos de salida
            Console.WriteLine("Hola, esta aplicación te hará un cuestionario si eres mayor de edad");
            Console.WriteLine("Ingresa tu nombre");

            //Declaración de variable
            String Nombre = Console.ReadLine();

            Console.WriteLine("¿Eres mayor de edad?");
            Console.WriteLine("1-Sí");
            Console.WriteLine("2-No");

            //Declaración de variable
            int MayorDeEdad = Convert.ToInt32(Console.ReadLine());

            //Estructura de decisión lógica para ejecutar instrucciones dependiendo de la edad del usuario
            if (MayorDeEdad == 1)
            {

                GenerarCuestionario(Nombre);

                Console.ReadKey();
            }
            else if (MayorDeEdad == 2)
            {


                GenerarNegacion(Nombre);

                Console.ReadKey();
            }



            Console.ReadKey();

        }

        //Metodo 

        public static void GenerarCuestionario(string Nombre)
        {
            //Dato de salida
            Console.WriteLine(Nombre + ", ingresa tu apellido");
            //Dato de entrada
            String Apellido = Console.ReadLine();

            Console.WriteLine(Nombre + ", ingresa tu edad");
            String Edad = Console.ReadLine();

            Console.WriteLine(Nombre + ", ingresa tu correo electrónico");
            String Correo = Console.ReadLine();

            Console.WriteLine("-------------REGISTRO EXITOSO-----------------");




        }

        //Metodo 

        public static void  GenerarNegacion(string Nombre)
        {
            Console.WriteLine("Lo siento, " + Nombre + " debes ser mayor de edad para llenar este formulario.");
        }




    }
}
