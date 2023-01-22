using Microsoft.AspNetCore.Mvc;
using RolPrueba1.Models;
using RolPrueba1.Repository;

namespace RolPrueba1.Controllers
{
    public class SeresController : Controller
    {
        RepositorySeres repo;

        public SeresController(RepositorySeres repo)
        {
            this.repo = repo;
        }

        //AQUI MOSTRAMOS TODOS LOS DEPARTAMENTOS
        public IActionResult Index()
        {
            List<Seres> seres = this.repo.GetSeres();
            return View(seres);
        }

        public IActionResult Create()
        {
            return View();
        }
        //VAMOS A RECIBIR TODO EL OBJETO DEPARTAMENTO
        //TENEMOS DOS OPCIONES:
        //1) RECIBIMOS TODO EL OBJETO
        //2) RECIBIMOS CADA VARIABLE
        [HttpPost]
        public IActionResult Create(Seres ser)
        {
            this.repo.InsertSeres(ser.Nombre, ser.Especie, ser.Planeta, ser.Agresividad, ser.Habilidades, ser.Debilidad, ser.Bioma);
            //EN LUGAR DE MOSTRAR UN MENSAJE O ALGO, LO QUE VAMOS A REALIZAR
            //ES VOLVER A LA VISTA DONDE ESTAN TODOS LOS DEPARTAMENTOS (Index)
            return RedirectToAction("Index");
        }

        //AL EDITAR, VAMOS A RECIBIR UN ID DEL DEPARTAMENTO
        //LO QUE HAREMOS SERA BUSCAR EL DEPARTAMENTO POR SU ID
        //Y LO ENVIAREMOS A LA VISTA PARA MOSTRAR SUS DATOS 
        //EN LAS CAJAS
        public IActionResult Edit(string nombreseres)
        {
            Seres ser = this.repo.FindSeres(nombreseres);
            return View(ser);
        }

        [HttpPost]
        public IActionResult Edit(Seres ser)
        {
            this.repo.UpdateDepartamento(ser.Nombre, ser.Especie, ser.Planeta, ser.Agresividad, ser.Habilidades, ser.Debilidad, ser.Bioma);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(string nombreseres)
        {
            this.repo.DeleteSeres(nombreseres);
            return RedirectToAction("Index");
        }
    }

}

