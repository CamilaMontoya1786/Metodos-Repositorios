using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejecicio3_Montoya
{
    internal class Program
    {
        static void Main(string[] args)
        /// <FECHA> 25/02/2023
        /// </NOMBRE> MARIA CAMILA MONTOYA ZAPATA
        /// <DESCRIPCIÓN>Desarrollar una clase que represente un punto en el plano y tenga los siguientes métodos: 
        /// cargar los valores de x e y, imprimir en que cuadrante se encuentra dicho punto (concepto matemático,
        /// primer cuadrante si x e y son positivas, si x<0 e y>0 segundo cuadrante, etc.)
        {

            //Datos de salida
            Console.WriteLine("Hola, esta aplicación te mostrará en que cuadrante se encuentra un punto en el plano.");
            Console.WriteLine("Ingresa el valor de X");
            //Declaración de variable para el punto
            int X= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa el valor de Y");
            int Y= Convert.ToInt32(Console.ReadLine()); 

            //Métodos invocados
            CargarValores(X, Y);
            ImprimirCuadrante(X, Y);
        }
        //Metodos
        public static void CargarValores(int X, int Y)
        {
            Console.WriteLine("Señor/a usuario, el punto registrado en el plano es: ");
            Console.WriteLine("( " + X + " , " + Y + " )");

        }
        public static void ImprimirCuadrante (int X, int Y)
        {
            //Estructura desiciva

            if (X>0 & Y>0)
            {
                Console.WriteLine("El punto en el plano está ubicado en el primer cuadrante.");
            }
            else if (X<0 & Y>0)
            {
                Console.WriteLine("El punto en el plano está ubicado en el segundo cuadrante.");
            }
            else if (X<0 & Y<0)
            {
                Console.WriteLine("El punto en el plano está ubicado en el tercer cuadrante.");
            }
            else
            {
                Console.WriteLine("El punto en el plano está ubicado en el cuarto cuadrante.");
            }

            Console.ReadKey();
        }

    }
}
