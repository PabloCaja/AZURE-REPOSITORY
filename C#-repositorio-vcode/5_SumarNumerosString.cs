namespace FUNDAMENTOS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SumarNumerosString();
        }
        static void SumarNumerosString()
        {
            Console.WriteLine("introduzca un texto con solo numeros");
            String texto = Console.ReadLine();
            int suma = 0;
            //RECORREMOS TODOS LOS CARACTERES DEL TEXTO
            for (int i = 0; i < texto.Length; i++)
            {
                char caracter = texto[i];
                int numero = int.Parse(caracter.ToString());    
                suma += numero;
            }
            Console.WriteLine("La suma de " + texto + " es " + suma);   
            

        }
    }
}