using FUNDAMENTOS.Helpers;
using FUNDAMENTOS.Models;
using System;
using System.Collections.Generic;

namespace FUNDAMENTOS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Metodo MAIN");
            //METODO PRINCIPAL DE EJECUCION
            //REALIZAMOS LA LLAMADA A LOS METODOS 
            //QUE DESEEMOS.
            //PositivoNegativo();
            //NumeroMayorMenor();
            //DiaNacimientoSemana();
            //EjemploBucles();
            //ConjeturaCollatz();
            //NumerosPares();
            //SumarNumeros();
            //SumarNumerosString();
            //ValidarISBN();
            //EjemploColecciones();
            //SumarNumerosColeccion();
            AdministrarTemperaturas();
            AdministrarTemperaturasHelper();
        }

        static void AdministrarTemperaturasHelper()
        {
            HelperMeses helper = new HelperMeses();
            foreach (TemperaturaMes mes in helper.Meses)
            {
                Console.WriteLine(mes.NombreMes + ", Maxima: "
                    + mes.Maxima + ", Minima " + mes.Minima + ", Media mensual: "
                    + mes.GetMediaMes());
            }
            Console.WriteLine("Media anual: " + helper.GetMediaAnual());
            Console.WriteLine("Maxima anual: " + helper.GetMaximaAnual());
            Console.WriteLine("Minima anual " + helper.GetMinimaAnual());
        }

        static void AdministrarTemperaturas()
        {
            //QUEREMOS GENERAR 12 TEMPERATURAS
            //ASIGNAMOS VALORES ALEATORIOS AL MAXIMO Y MINIMO
            //PARA GENERAR VALORES ALEATORIOS DENTRO DE NET SE 
            //UTILIZA LA CLASE RANDOM
            //DICHA CLASE TIENE UN METODO Next() QUE NOS 
            //DEVUELVE UN NUMERO ALEATORIO ENTRE UN MINIMO Y UN MAXIMO
            Random random = new Random();
            //ALMACENAREMOS LOS 12 MESES EN UNA COLECCION
            List<TemperaturaMes> meses = new List<TemperaturaMes>();
            //REALIZAMOS UN BUCLE DE 1 A 12 PARA IR CREANDO MES A MES
            //Y AÑADIENDOLO A LA COLECCION
            for (int i = 1; i <= 12; i++)
            {
                //DENTRO DEL BUCLE IREMOS CREANDO UN MES EN CADA VUELTA
                TemperaturaMes mes = new TemperaturaMes();
                mes.NombreMes = "Mes " + i;
                mes.Maxima = random.Next(20, 60);
                mes.Minima = random.Next(-5, 17);
                //AÑADIMOS CADA MES A LA COLECCION
                meses.Add(mes);
            }
            //EN ESTE PUNTO YA TENEMOS DOCE MESES.  PODEMOS HACER CUALQUIER
            //CODIGO, MOSTRARLOS, VER SU MEDIA O LO QUE SE NOS OCURRA...
            //SIMPLEMENTE VAMOS A RECORRER LOS MESES GUARDADADOS Y MOSTRAMOS SUS DATOS
            foreach (TemperaturaMes mes in meses)
            {
                Console.WriteLine(mes.NombreMes + ", Máxima: "
                    + mes.Maxima + ", Mínima: " + mes.Minima
                    + ", Media mensual: " + mes.GetMediaMes());
            }
            Console.WriteLine("Fin de programa");
        }

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

        static void ValidarISBN()
        {
            Console.WriteLine("Introduzca número ISBN");
            string isbn = Console.ReadLine();
            if (isbn.Length != 10)
            {
                Console.WriteLine("El número ISBN debe tener 10 caracteres");
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
                    Console.WriteLine("Número ISBN correcto!!!");
                }
                else
                {
                    Console.WriteLine("Número ISBN incorrecto");
                }
            }
        }


        static void SumarNumerosString()
        {
            Console.WriteLine("Introduzca un texto con solo números");
            string texto = Console.ReadLine();
            int suma = 0;
            //RECORREMOS TODOS LOS CARACTERES DEL TEXTO
            for (int i = 0; i < texto.Length; i++)
            {
                //RECUPERAMOS CADA CARACTER POR SU POSICION
                char caracter = texto[i];
                //CONVERTIRMOS CADA CARACTER '1' A UN NUMERO int
                //PARA HACERLO, DEBEMOS RECUPERAR EL LITERAL DEL NUMERO "1"
                int numero = int.Parse(caracter.ToString());
                suma += numero;
            }
            Console.WriteLine("La suma de " + texto + " es " + suma);
        }


        //•	Exista @
        //•	Exista un punto
        //•	Exista un punto después de una @
        //•	Que no comience por @ ni punto
        //•	Solamente una @
        //•	Dominio debe ser de 2-4 caracteres

        static void ValidarEmail()
        {
            Console.WriteLine("Introduzca un mail válido");
            string email = Console.ReadLine();
            if (email.Contains("@") == false)
            {
                Console.WriteLine("No existe @");
            }
            else if (email.IndexOf(".") == -1)
            {
                Console.WriteLine("No existe .");
            }
            else if (email.StartsWith("@") || email.EndsWith("@")
                || email.StartsWith(".") || email.EndsWith("."))
            {
                Console.WriteLine("Punto o @ al inicio o al final del mail");
            }
            else if (email.LastIndexOf(".") < email.IndexOf("@"))
            {
                Console.WriteLine("Debe existir un punto después de la @");
            }
            else if (email.IndexOf("@") != email.LastIndexOf("@"))
            {
                Console.WriteLine("Existe más de una @");
            }
            else
            {
                int ultimoPunto = email.LastIndexOf(".");
                //paco@gmail.com
                string dominio = email.Substring(ultimoPunto + 1);
                if (dominio.Length >= 2 && dominio.Length <= 4)
                {
                    Console.WriteLine("Email correcto!!!");
                }
                else
                {
                    Console.WriteLine("El dominio debe ser de 2 a 4 caracteres");
                }
            }
        }

        static void EjemploClases()
        {
            DateTime fecha = DateTime.Now;
            Console.WriteLine(fecha.ToLongDateString());
            Console.WriteLine(fecha.ToShortDateString());
            //RECORREMOS TODOS LOS ELEMENTOS DEL CODIGO ASCII
            for (int i = 0; i <= 255; i++)
            {
                //CONVERTIMOS CADA int A CARACTER char
                char letra = (char)i; //A
                if (char.IsNumber(letra))
                {
                    Console.WriteLine(letra);
                }
            }
        }

        static void SumarNumeros()
        {
            Console.WriteLine("Introduzca un número");
            string dato = Console.ReadLine();
            //CONVERTIMOS EL NUMERO A int
            int numero = int.Parse(dato);
            //DECLARAMOS UNA VARIABLE suma PARA IR 
            //ALMACENANDO Y SUMANDO EL RESTO DE NUMEROS
            int suma = numero;
            while (numero != 0)
            {
                Console.WriteLine("Suma: " + suma);
                Console.WriteLine("Introduzca otro número");
                dato = Console.ReadLine();
                numero = int.Parse(dato);
                suma += numero;
            }
            Console.WriteLine("Fin de programa");
        }

        static void NumerosPares()
        {
            Console.WriteLine("Introduzca un idsfnicio: ");
            string dato = Console.ReadLine();
            int inicio = int.Parse(dato);
            Console.WriteLine("Introduzca un número final");
            dato = Console.ReadLine();
            int fin = int.Parse(dato);
            for (int i = inicio; i <= fin; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

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

        static void EjemploBucles()
        {
            int contador = 1;
            while (contador <= 10)
            {
                Console.WriteLine(contador);
                contador += 1;
            }

            //EJEMPLO BUCLE INVERSO
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }

        static void DiaNacimientoSemana()
        {
            Console.WriteLine("Introduzca el día");
            string dato = Console.ReadLine();
            int dia = int.Parse(dato);
            Console.WriteLine("Introduzca mes");
            dato = Console.ReadLine();
            int mes = int.Parse(dato);
            Console.WriteLine("Introduzca el año");
            dato = Console.ReadLine();
            int anyo = int.Parse(dato);
            if (mes == 1)
            {
                mes = 13;
                anyo -= 1;
            }
            else if (mes == 2)
            {
                mes = 14;
                anyo -= 1;
            }
            int op1 = ((mes + 1) * 3) / 5;
            int op2 = anyo / 4;
            int op3 = anyo / 100;
            int op4 = anyo / 400;
            int op5 = dia + (mes * 2) + anyo + op1 + op2 - op3 + op4 + 2;
            int op6 = op5 / 7;
            int resultado = op5 - (op6 * 7);
            if (resultado == 0)
            {
                Console.WriteLine("SABADO");
            }
            else if (resultado == 1)
            {
                Console.WriteLine("DOMINGO");
            }
            else if (resultado == 2)
            {
                Console.WriteLine("LUNES");
            }
            else if (resultado == 3)
            {
                Console.WriteLine("MARTES");
            }
            else if (resultado == 4)
            {
                Console.WriteLine("MIERCOLES");
            }
            else if (resultado == 5)
            {
                Console.WriteLine("JUEVES");
            }
            else if (resultado == 6)
            {
                Console.WriteLine("VIERNES");
            }
            else
            {
                Console.WriteLine("RESULTADO INCORRECTO " + resultado);
            }
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

        //CREAMOS NUESTROS PROPIOS METODOS
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

