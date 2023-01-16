using Microsoft.AspNetCore.Mvc;
using PrimerMVC2023.Models;

namespace PrimerMVC2023.Controllers
{
    public class PracticasController : Controller
    {
        public IActionResult Menu()
        {
            return View();
        }
        public IActionResult ListaComics()
        {
            //NECESITAMOS CREARNOS UNA SERIE DE COMICS
            List<Comic> comics = new List<Comic>();
            Comic comic = new Comic();
            comic.Nombre = "Spiderman";
            comic.Descripcion = "Erase una vez un hombre araña...";
            comic.Imagen = "https://m.media-amazon.com/images/I/61Oq6BSis7L.jpg";
            comics.Add(comic);
            comic = new Comic();
            comic.Nombre = "Batman";
            comic.Descripcion = "Hombre murcielago";
            comic.Imagen = "https://media.revistagq.com/photos/621f76f3e90a38b0c1d2f3e2/master/w_1988,h_3056,c_limit/D4qal3gXkAENcQD.jpg";
            comics.Add(comic);
            comic = new Comic();
            comic.Nombre = "Avengers";
            comic.Descripcion = "Grupo de gente con poderes y tal...";
            comic.Imagen = "https://static.carrefour.es/hd_510x_/crs/cdn_static/catalog/hd/516127_00_1.jpg";
            comics.Add(comic);
            return View(comics);
        }
        public IActionResult SumarNumeros()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SumarNumeros(int numero1, int numero2)
        {
            int suma = numero1 + numero2;
            ViewData["MENSAJE"] = "La suma de " + numero1 + " + " + numero2 + " es " + suma;
            return View();
        }
        public IActionResult TablaMultiplicarSimple()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TablaMultiplicarSimple(int numero)
        {
            //DEVOLVEREMOS A LA VISTA UN CONJUNTO DE NUMEROS
            List<int> resultados = new List<int>();
            //REALIZAMOS EL BUCLE PARA LA TABLA DE MULTIPLICAR
            for (int i = 1; i <= 10; i++)
            {
                int operacion = numero * i;
                resultados.Add(operacion);
            }
            return View(resultados);
        }
        public IActionResult TablaMultiplicarModel()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TablaMultiplicarModel(int numero)
        {
            List<FilaTabla> filas = new List<FilaTabla>();
            for (int i = 1; i <= 10; i++)
            {
                string operacion = numero + " * " + i;
                int resultado = numero * i;
                FilaTabla fila = new FilaTabla();
                fila.Operacion = operacion;
                fila.Resultado = resultado;
                filas.Add(fila);
            }
            return View(filas);
        }
        public IActionResult ConjeturaCollatzMultiple()
        {
            //VAMOS A GENERAR UNA SERIE DE NUMEROS ALEATORIOS
            List<int> numerosRandom = new List<int>();
            Random random = new Random();
            for (int i = 1; i <= 5; i++)
            {
                int aleat = random.Next(1, 120);
                numerosRandom.Add(aleat);
            }
            ViewData["RANDOM"] = numerosRandom;
            return View();
        }

        [HttpPost]
        public IActionResult ConjeturaCollatzMultiple(int numeroCollatz)
        {
            List<int> listaNumeros = new List<int>();
            while (numeroCollatz != 1)
            {
                if (numeroCollatz % 2 == 0)
                {
                    numeroCollatz = numeroCollatz / 2;
                }
                else
                {
                    numeroCollatz = numeroCollatz * 3 + 1;
                }
                listaNumeros.Add(numeroCollatz);
            }
            //SIEMPRE DEBEMOS ENVIAR VIEWDATA TANTO EN GET COMO EN POST
            List<int> numerosRandom = new List<int>();
            Random random = new Random();
            for (int i = 1; i <= 5; i++)
            {
                int aleat = random.Next(1, 120);
                numerosRandom.Add(aleat);
            }
            ViewData["RANDOM"] = numerosRandom;
            return View(listaNumeros);
        }



    }
}
