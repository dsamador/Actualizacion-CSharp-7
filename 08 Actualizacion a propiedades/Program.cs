using System;

namespace _08_Actualizacion_a_propiedades//Tuplas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Se infiere el tipo 
            var tupla = ("hola", 23);
            Console.WriteLine(tupla.Item1);
            Console.WriteLine(tupla.Item2);

            Console.WriteLine("--------");

            //Las tuplas son mutables, pero no en tipo sino en valor
            tupla.Item1 = "Otro nombre";
            tupla.Item2 = 43;
            Console.WriteLine(tupla.Item1);
            Console.WriteLine(tupla.Item2);
            Console.WriteLine("--------");

            //Los tipos de la tupla pueden ser definidos explicitamente
            (int, double) valores = (4, 6.7);
            Console.WriteLine(valores);
            Console.WriteLine("--------");

            //Los metodos pueden devolver tuplas
            (string, int) persona = Metodo();
            Console.WriteLine($"Fuera del metodo, {persona}");
            Console.WriteLine("--------");

            //Los elementos de la tupla pueden ser nombrados
            var otraTupla = (modelo: "XYZ0005", costo: 435);
            Console.WriteLine(otraTupla.modelo);
            Console.WriteLine(otraTupla.costo);

            static (string, int) Metodo()
            {
                string nombre = "David";
                int calificacion = 5;

                Console.WriteLine($"En el metodo, {nombre}, {calificacion}");
                return (nombre, calificacion);
            }
        }
    }
}
