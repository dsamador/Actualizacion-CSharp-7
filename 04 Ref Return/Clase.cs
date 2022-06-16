using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Ref_Return
{
    public class Clase
    {
        static string[] palabras = { "Hola", "a", "todos", "mis", "amigos" };

        public static ref string Metodo(int indice)
        {
            ref string referencia = ref palabras[indice];
            return ref referencia;
        }

        public static void Imprimir()
        {
            foreach(string s in palabras)
                Console.WriteLine(s);
        }

    }
}
