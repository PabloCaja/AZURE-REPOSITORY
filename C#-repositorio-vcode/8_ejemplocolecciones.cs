        static void EjemploColecciones()
        {
            //CREAMOS UNA COLECCION DE int
            List<int> numeros = new List<int>();
            //MEDIANTE EL METODO Add PODEMOS AÑADIR ELEMENTOS
            numeros.Add(99);
            numeros.Add(445);
            //AL SER TIPADA LA COLECCION, EL COMPILADOR DETECTA 
            //ERRORES SI NO AÑADIMOS NUMEROS
            Console.WriteLine("Elementos de la colección " + numeros.Count);
            //PODEMOS RECORRER TODOS LOS ELEMENTOS DE LA COLECCION
            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }

            //CREAMOS UN ARRAY DE NOMBRES
            List<string> nombres = new List<string>();
            nombres.Add("Ana");
            nombres.Add("Adrian");
            nombres.Add("Lucia");
            nombres.Add("Ana");
            Console.WriteLine("Dame un nombre");
            string nombre = Console.ReadLine();
            nombres.Add(nombre);
            //QUE SUCEDE SI ELIMINAMOS UN ELEMENTO 
            //COMO OBJETO?
            //ELIMINA POR LA PRIMERA COINCIDENCIA
            //nombres.Remove("Ana");
            //nombres.RemoveAt(3);
            foreach (string name in nombres)
            {
                Console.WriteLine(name);
            }
        }