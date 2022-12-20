        static void ConjeturaCollatz()
        {
            Console.WriteLine("Introduzca número");
            string dato = Console.ReadLine();
            int numero = int.Parse(dato);
            while (numero != 1)
            {
                if (numero % 2 == 0)
                {
                    //PAR
                    numero = numero / 2;
                }
                else
                {
                    //IMPAR
                    numero = numero * 3 + 1;
                }
                Console.WriteLine(numero);
            }
        }