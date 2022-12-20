namespace FUNDAMENTOS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ValidarIsbn();
        }
        static void ValidarIsbn()
        {
            Console.WriteLine("validar ISBN");
            Console.WriteLine("Introduce un ISB correcto");
            String isbn = Console.ReadLine();

            if (isbn.Length != 10) 
            {
                Console.WriteLine("El numero debe contener 10 al menos bro");
            }
            else
            {
                int suma = 0;
                for (int i = 0; i < isbn.Length; i++)
                {
                    char caracter = isbn[i];
                    int numero = int.Parse(caracter.ToString());
                    int operacion = numero * (i + 1);
                    suma += operacion;
                }
                if (suma % 11 == 0) 
                {
                    Console.WriteLine("ISBN correcto!");
                }
                else
                {
                    Console.WriteLine("Incorrecto");
                }    

            }
            

        }
    }
}