
//Estilo C# 6
//Necesitamos declarar antes de usar con out
int suma = 0;
int multi = 0;

Aritmetica(5, 3, out suma, out multi);
Console.WriteLine($"{suma}, {multi}");
Console.WriteLine("--------");

//Estilo C# 7
//La variable para usar en out se puede declarar en el momento de 
//pasarla como parametro
Aritmetica(5, 7, out int x1, out int x2);
Console.WriteLine($"{x1}, {x2}");
Console.WriteLine("--------");

//Discard
//Si no nos interesa recibir un valor en particular hacemos uso de
//discard al poner un _
Aritmetica(15, 27, out int x3, out _);
Console.WriteLine(x3);
Aritmetica(15, 17, out _, out int x4);
Console.WriteLine(x4);
Console.WriteLine("--------");

static void Aritmetica(int a, int b, out int rsuma, out int rmultiplicacion)
{
    rsuma = a + b;
    rmultiplicacion = a * b;
}