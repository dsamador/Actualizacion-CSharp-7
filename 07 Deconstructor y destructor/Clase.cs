namespace _07_Deconstructor_y_destructor
{
    public  class Clase
    {
        private string nombre;
        private int edad;

        public Clase(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public override string ToString()
        {
            return $"{nombre} tiene {edad} de edad";
        }

        //Debe llevar siempre la palabra Deconstruct
        public void Deconstruct(out string oNombre, out int oEdad)
        {
            //Mandamos al exterior lo que nos interesa antes
            //de que el objeto sea destruido.
            oNombre = nombre;
            oEdad = edad;
        }
        //Creamos el destructor que usa =>
        ~Clase() => Console.WriteLine("Adios");
    }
}
