static void SumarNumerosColeccion()
        {
            List<int> numeros = new List<int>();
            Console.WriteLine("Introduzca un número");
            string dato = Console.ReadLine();
            int num = int.Parse(dato);
            while (num != 0)
            {
                numeros.Add(num);
                Console.WriteLine("Introduzca un número");
                dato = Console.ReadLine();
                num = int.Parse(dato);
            }
            int suma = 0;
            foreach (int n in numeros)
            {
                suma += n;
                Console.WriteLine(n);
            }
            Console.WriteLine("Elementos almacenados: " + numeros.Count);
            float media = suma / numeros.Count;
            Console.WriteLine("Media de los números: " + media);
        }
