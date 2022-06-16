
static double sumar(double x, double y) => x * y;

static void numeros()
{
    Console.WriteLine(DobleLength("Hola"));
    Console.WriteLine(DobleLength("a todos"));
    Console.WriteLine(DobleLength("mis amigos"));

    int DobleLength(string s) => s.Length * 2;
}

numeros();