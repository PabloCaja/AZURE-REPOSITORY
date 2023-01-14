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

    }
}
