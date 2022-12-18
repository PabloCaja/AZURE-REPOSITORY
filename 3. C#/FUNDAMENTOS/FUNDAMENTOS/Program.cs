namespace FUNDAMENTOS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PositivoNegativo();
        }
        //AQUI LOS METODOS CON EL CODIGO LOGICO
        static void PositivoNegativo()
        {
            Console.WriteLine("Programa positivo negativo cero");
            //PEDIMOS UNA VARIABLE Y LA RECUPERAMOS COMO STRING
            string dato = Console.ReadLine();
            //CONVERTIMOS EL DATO STRING EN INT
            int numero = int.Parse(dato);
            if (numero > 0)
            {
                Console.WriteLine("Positivo");
            }
            else if (numero == 0)
            {
                Console.WriteLine("Cero");
            }
            else
            {
                Console.WriteLine("Negativo");
            }
        }

    }
}