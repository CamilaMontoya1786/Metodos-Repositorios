using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    internal class Program
    { /// <FECHA> 25/02/2023
      /// </NOMBRE> MARIA CAMILA MONTOYA ZAPATA
      /// <DESCRIPCIÓN>  Desarrollar una clase que represente un Cuadrado y tenga los siguientes métodos: 
      /// cargar el valor de su lado, imprimir su perímetro y su superficie.
        static void Main(string[] args)
        {
            //Datos de saldia
            Console.WriteLine("Hola, esta aplicación te mostrará el perímetro y superficie de un cuadrado.");
            Console.WriteLine("Ingresa el lado del cuadrado");
            
            //Declaración de variable
            int Lado = Convert.ToInt32(Console.ReadLine());

            //Métodos invocados
            CargarLado(Lado);
            ImprimirPerimetro(Lado);
            ImprimirSuperficie(Lado);
        }

        //Métodos
        public static void CargarLado(int Lado)
        {
            Console.WriteLine("Señor/a usuario, el lado del cuadrado registrado es: " + Lado);

        }

        
        public static void ImprimirPerimetro(int Lado)
        {
            //Operación-Proceso
            int P = 4 * Lado;

            Console.WriteLine("Señor/a usuario, el perímetro del cuadrado es: " + P);

        }

        public static void ImprimirSuperficie(int Lado)
        {
            int S = Lado*Lado;
            Console.WriteLine("Señor/a usuario, la superficie del cuadrado es: " + S);

            Console.ReadKey();
        }

    }
}
