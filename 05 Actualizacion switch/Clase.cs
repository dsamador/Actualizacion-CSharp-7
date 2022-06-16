using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Actualizacion_switch
{
    public class Clase
    {        
        //uso de goto en switch
        
        public static void Metodo(int valor)
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
                case 4:
                    Console.WriteLine("cuatro");
                    break;
                default:
                    Console.WriteLine("En default");
                    break;
            }
        }
    }
}
