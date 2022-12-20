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
            }else if (mes == 2)
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
            else if (resultado == 4) {
                Console.WriteLine("MIERCOLES");
            }else if (resultado == 5)
            {
                Console.WriteLine("JUEVES");
            }else if (resultado == 6)
            {
                Console.WriteLine("VIERNES");
            }
            else
            {
                Console.WriteLine("RESULTADO INCORRECTO " + resultado);
            }
        }
