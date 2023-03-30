using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6_Montoya
{
    /// <FECHA> 25/02/2023
    /// </NOMBRE> MARIA CAMILA MONTOYA ZAPATA
    /// <DESCRIPCIÓN>Confeccionar una clase que permita ingresar valores enteros por teclado y nos muestre la tabla
    /// de multiplicar de dicho valor. Finalizar el programa al ingresar el -1.
    internal class Program
    {
        static void Main(string[] args)

        {
            //Datos de salida
            Console.WriteLine("Hola, esta aplicación te mostrará la tabla de mutiplicación de un número entero");
            Console.WriteLine("Ingresa un número ENTERO para generar la tabla");
            int numero= Convert.ToInt32(Console.ReadLine());
            //Métodos invocados
            GenerarTabla(numero);
            FinalizarPrograma(numero);

        }

        //Métodos
        public static void GenerarTabla(int numero)
        {
            //vector para la tabla
            Console.WriteLine("La tabla del " + numero + " es:");
            for (int i = 0; i <= 10; i++)
            {
                //Dato de salida con operación
                Console.WriteLine(numero+ "*" + i +"="+ numero*i) ;
            }

           
        }

        public static void FinalizarPrograma(int numero)
        {
            Console.WriteLine("Si desea cerrar el programa ingrese -1 y si desea realizar otra tabla ingrese 1");

            int numero2= Convert.ToInt32(Console.ReadLine()); 

            if (numero2==-1)
            {
                //Cerrar programa
                return;
            }
            else
            {
                //Ejecuta de nuevo el programa
                Console.WriteLine("Ingresa el número para generar la tabla");
                numero = Convert.ToInt32(Console.ReadLine());

                GenerarTabla(numero);
                FinalizarPrograma(numero);
            }

            Console.ReadKey();
        }


    }
}
