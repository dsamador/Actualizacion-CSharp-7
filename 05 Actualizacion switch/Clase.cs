using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Actualizacion_switch
{
    public class Clase
    {             
        public static void MetodoGoTo(int valor)
        {
            switch (valor)
            {
                case 1:
                    Console.WriteLine("uno");
                    break;
                case 2:
                    Console.WriteLine("dos");
                    goto default;
                case 3:
                    Console.WriteLine("tres");
                    goto case 1;                
                default:
                    Console.WriteLine("En default");
                    break;
            }
        }

        public static void MetodoPatron(object valor)
        {
            switch (valor)
            {
                case int i:
                    Console.WriteLine($"El entero vale {valor}");
                    break;
                case string s:
                    Console.WriteLine("La cadena es" + s);
                    break;
                case double d:
                    Console.WriteLine($"El doble vale {d}");
                    break;
                case null:
                    Console.WriteLine("Es un null");
                    break;
            }
        }

        public static void MetodoWhen(object valor)
        {
            switch (valor)
            {
                case int i when i < 10:
                    Console.WriteLine("El valor es menor a 10");
                    break;
                case int i:
                    Console.WriteLine("El valor es mayor o igual a 10");
                    break;
            }
        }
    }
}
