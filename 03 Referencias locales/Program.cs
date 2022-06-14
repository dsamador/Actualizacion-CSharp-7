

//Ref Locals

//Nos permite tener una variable local de referencia a un
//elemento de un arreglo

string[] palabras = { "Hola", "a", "todos", "mis", "amigos" };

ref string referencia = ref palabras[2];

Console.WriteLine($"Por indice palabras[2] : {palabras[2]}");
Console.WriteLine($"Por referencia : {referencia}");
Console.WriteLine("--------");
referencia += " completos";

Console.WriteLine($"Por indice palabras[2] : {palabras[2]}");
Console.WriteLine($"Por referencia : {referencia}");

Console.WriteLine("--------");

foreach(string palabra in palabras)
    Console.WriteLine(palabra);
Console.WriteLine("--------");

referencia = "";

foreach (string palabra in palabras)
    Console.WriteLine(palabra);