namespace FUNDAMENTOS
{
    internal class NumerosTres
    {
        static void Main(string[] args)
        {
            NumeroMayorMenor();
        }
        static void NumeroMayorMenor()
        {
            //DECLARAMOS TRES VARIABLES
            int mayor = 0, menor = 0, intermedio = 0;
            Console.WriteLine("Introduzca número 1:");
            string dato = Console.ReadLine();
            int numero1 = int.Parse(dato);
            Console.WriteLine("Introduzca número 2:");
            dato = Console.ReadLine();
            int numero2 = int.Parse(dato);
            Console.WriteLine("Introduzca número 3:");
            dato = Console.ReadLine();
            int numero3 = int.Parse(dato);
            if (numero1 >= numero2 && numero1 >= numero3)
            {
                mayor = numero1;
            }
            else if (numero2 >= numero1 && numero2 >= numero3)
            {
                mayor = numero2;
            }
            else
            {
                mayor = numero3;
            }
            if (numero1 <= numero2 && numero1 <= numero3)
            {
                menor = numero1;
            }
            else if (numero2 <= numero1 && numero2 <= numero3)
            {
                menor = numero2;
            }
            else
            {
                menor = numero3;
            }
            int suma = numero1 + numero2 + numero3;
            intermedio = suma - mayor - menor;
            Console.WriteLine("Mayor: " + mayor);
            Console.WriteLine("Menor: " + menor);
            Console.WriteLine("Intermedio: " + intermedio);
        }
    }
}
