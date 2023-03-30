using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnTemperaturas
{
    internal class Program
    {
        /// <FECHA> 21/02/2023
        /// </NOMBRE> MARIA CAMILA MONTOYA ZAPATA
        /// <DESCRIPCIÓN> Aplicación que permita realizar la conversión de las temperaturas celsius
        /// a farenheit y viceversa utilizando dos funciones
        private static void Main(string[] args)
        {
            //Datos de salida
            Console.WriteLine("Hola, esta aplicación te permitirá convertir la temperatura de Celsius a Farenheit y viceversa.");
            Console.WriteLine("Ingresa tu nombre");

            //Datos de entrada
            String Nombre = Console.ReadLine();

            Console.WriteLine("¿Qué tipo de temperatura va ingresar?");
            Console.WriteLine("1 - temperatura en Celsius");
            Console.WriteLine("2 - temperatura en Fahrenheit");
           
            int TipoDeTemperatura = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa la temperatura");
            double Temperatura = Convert.ToInt32(Console.ReadLine());

            //Estructura de decisión lógica para ejecutar instrucciones dependiendo del tipo de temperatura
            if (TipoDeTemperatura == 1)
            {

                Console.WriteLine(Nombre + " La temperatura en Farenheit es:" + GenerarFahrenheit(Temperatura));

                Console.ReadKey();
            }
            else if (TipoDeTemperatura == 2)
            {

                Console.WriteLine(Nombre + " La temperatura en Celsius es:" + GenerarCelsius(Temperatura));


                Console.ReadKey();
            }



            Console.ReadKey();

        }

        //Método para pasar la temperatura de Celsius a Fahrenheit
            private static double GenerarFahrenheit(double Temperatura)
            {
              //Operación
              double Fahrenheit = (double)((Temperatura * 9/5) + 32);
              return Fahrenheit;
            }


        //Método para pasar la temperatura de Fahrenheit a Celsius
         private static double GenerarCelsius(double Temperatura)
            {
            //Operación
            double Celsius = (double)((Temperatura - 32) * 5/9);
            return Celsius;
           }





    }
}
