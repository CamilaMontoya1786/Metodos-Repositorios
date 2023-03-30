using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5_Montoya
{
    internal class Program
    { /// <FECHA> 25/02/2023
      /// </NOMBRE> MARIA CAMILA MONTOYA ZAPATA
      /// <DESCRIPCIÓN> Confeccionar una clase que represente un empleado. Definir como atributos su nombre y su sueldo.
      /// Confeccionar los métodos para la carga, otro para imprimir sus datos y por último uno que imprima un mensaje 
      /// si debe pagar impuestos (si el sueldo supera a 3000)
        static void Main(string[] args)
        {
            //Dato de salida
            Console.WriteLine("Hola, esta aplicación te permitirá registrar tus datos y saber si debes pagar impuestos.");

            //Declaración de variables
            string Nombre;
            int Sueldo;

            //Carga de datos
            Console.WriteLine("Ingrese su nombre");
            Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su sueldo");
            Sueldo = Convert.ToInt32(Console.ReadLine());


        

            //Métodos invocados
            ImprimirDatos(Sueldo, Nombre);
            Impuestos(Sueldo);
        }
     

        //Métodos
        public static void ImprimirDatos(int Sueldo, string Nombre)
        {
            Console.WriteLine("Señor/a usuario, los datos registrados son: ");
            Console.WriteLine("NOMBRE: " + Nombre);
            Console.WriteLine("SUELDO: " + Sueldo);

        }
        public static void Impuestos(int Sueldo)
        {

            //Estructura decisiva 
            if (Sueldo>3000)
            {
                Console.WriteLine("Señor/a usuario, usted debe pagar impuestos debido a su salario.");
            }
            else
            {
                Console.WriteLine("Señor/a  usuario, usted no debe pagar impuestos.");

                
            }
            Console.ReadKey();
        }
    }
}
