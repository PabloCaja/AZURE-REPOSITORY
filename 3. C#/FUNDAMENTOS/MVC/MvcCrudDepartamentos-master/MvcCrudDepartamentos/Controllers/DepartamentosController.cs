using Microsoft.AspNetCore.Mvc;
using MvcCrudDepartamentos.Models;
using MvcCrudDepartamentos.Repositories;

namespace MvcCrudDepartamentos.Controllers
{
    public class DepartamentosController : Controller
    {
        private RepositoryDepartamentos repo;
        public DepartamentosController(RepositoryDepartamentos repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            List<Departamento> departamentos = this.repo.GetDepartamentos();
            return View(departamentos);
        }
        //CREAMOS UNA VISTA LLAMADA DETALLES PARA LOS DETALLES DE LOS DEPARTAMENTOS

        public IActionResult Detalles(int id)
        {
            Departamento departamento = this.repo.FindDepartamento(id);
            return View(departamento);
        }

        //CREAMOS UNA VISTA LLAMADA INSERT PARA INSERTAR NUEVOS DEPARTAMENTOS
        //CUANDO PUELSE UN BOTON
        public IActionResult Insertar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Insertar(Departamento dept)
        {
            this.repo.InsertDepartamento(dept.IdDepartamento, dept.Nombre, dept.Localidad);
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id) 
        {
            Departamento departamento = this.repo.FindDepartamento(id);
            return View(departamento); 
        }

        [HttpPost]
        public IActionResult Update(Departamento dept)
        {
            this.repo.UpdateDepartamento(dept.IdDepartamento, dept.Nombre, dept.Localidad);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id) 
        {
            this.repo.DeleteDepartamento(id);
            return RedirectToAction("Index");
        }
    }
}
