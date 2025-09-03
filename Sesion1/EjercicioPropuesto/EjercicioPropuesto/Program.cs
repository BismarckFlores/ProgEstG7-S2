using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPropuesto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalVentas = 0;
            int productosRegistrados = 0;
            bool alertaVentaMayorista = false;

            Console.WriteLine("--- Control Diario de Ventas ---");
            Console.WriteLine("Ingrese la cantidad de productos y su precio unitario. Para terminar, ingrese '0' en la cantidad.");

            while (true)
            {
                Console.WriteLine("------------------------------");
                Console.Write("Cantidad de productos (0 para salir): ");
                int inputCantidad = Convert.ToInt32(Console.ReadLine());

                if (inputCantidad == 0)
                {
                    break;
                }

                if (inputCantidad > 0)
                {
                    Console.Write("Precio unitario: C$");
                    float precioUnitario = Convert.ToSingle(Console.ReadLine());
                    if (precioUnitario >= 0)
                    {
                        double subtotal = inputCantidad * precioUnitario;
                        totalVentas += subtotal;
                        productosRegistrados += inputCantidad;

                        if (subtotal > 10000)
                        {
                            alertaVentaMayorista = true;
                        }

                        Console.WriteLine($"Venta registrada. Subtotal: C${subtotal:N2}");
                    }
                    else
                    {
                        Console.WriteLine("Error: El precio unitario ingresado no es válido. Intente de nuevo.");
                    }
                }
                else
                {
                    Console.WriteLine("Error: La cantidad ingresada no es válida. Intente de nuevo.");
                }
            }

            Console.WriteLine("\n--- Resumen del Día ---");
            Console.WriteLine($"Total de ventas: C${totalVentas:N2}");
            Console.WriteLine($"Número de productos registrados: {productosRegistrados}");

            if (alertaVentaMayorista)
            {
                Console.WriteLine("¡ALERTA! Se registró al menos una venta individual que superó los C$10,000.");
            }

            Console.WriteLine("\n¡Gracias por usar el sistema!");
        }
    }
}
