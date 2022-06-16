using _04_Ref_Return;

ref string palabra = ref Clase.Metodo(2);

Console.WriteLine(palabra);

Console.WriteLine("--------");

palabra = "muchos";

Clase.Imprimir();