using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentificaciónDeErrores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Porfavor seleccione una actividad del 1 al 6");
            int actividad = Convert.ToInt32(Console.ReadLine());
            switch (actividad)
            {
                case 1:
                    Actividad1();
                    break;
                case 2:
                    Actividad2();
                    break;
                case 3:
                    Actividad3();
                    break;
                case 4:
                    Actividad4();
                    break;
                case 5:
                    Actividad5();
                    break;
                case 6:
                    Actividad6();
                    break;
                default:
                    Console.WriteLine("Actividad no valida");
                    break;
            }
            Console.WriteLine("Presione cualquier tecla para salir...");
        }
        public static void Actividad1()
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;                            // Error logico: faltaba el incremento de i para evitar un bucle infinito.
            }
        }
        public static void Actividad2()
        {
            int edad = 20;
            if (edad >= 18 && edad <= 65)       // Error logico: se corrigió el operador lógico de || a && y tambien se incluyeron los límites 18 y 65.
            {
                Console.WriteLine("Edad válida para trabajar.");
            }
        }
        public static void Actividad3()
        {
            for(int i = 0; i < 10; i++)         // Error sintaxico: Falto poner el ; para separar la condicion y el incremento en el for.
            {
                Console.WriteLine(i);
            }
        }
        public static void Actividad4()
        {
            int numero = 10;
            bool esMayor;
            esMayor = (numero > 5);             // Error logico: Se estaba reasignando el valor de numero a 5, lo que se tenia que hacer era comparar numero y 5 para saber
                                                // si esMayor es verdadero o falso.
            Console.WriteLine("¿Es mayor que 5? " + esMayor);
        }
        public static void Actividad5()
        {
            int resultado = 0;                  // Error excepción: Se declara la variable pero nunca se inicializa, lo que causa que al intentar sumarle 10
                                                // sin tener un valor inicial causa el error.
            resultado = resultado + 10;
            Console.WriteLine(resultado);
        }
        public static void Actividad6()
        {
            int edad = 17;
            if (edad >= 18)                     // Error sintaxico: Al momento de abrir el if-else no se colocaban los bloques de codigo que imprimen en la consola
                                                // dentro de llaaves {}.
            {
                Console.WriteLine("Es mayor de edad");
                Console.WriteLine("Puede votar");
            }
            else
            {
                Console.WriteLine("Es menor de edad");
            }
        }
    }
}
