﻿using MvcCrudDepartamentos.Data;
using MvcCrudDepartamentos.Models;

namespace MvcCrudDepartamentos.Repositories
{
    public class RepositoryDepartamentos
    {
        private DepartamentosContext context;

        public RepositoryDepartamentos(DepartamentosContext context)
        {
            this.context = context;
        }

        //METODO PARA DEVOLVER TODOS LOS DEPARTAMENTOS

        public List<Departamento> GetDepartamentos()
        {
            var consulta = from datos in this.context.Departamentos
                           select datos;
            return consulta.ToList();
        }

        //METODO PARA BUSCAR UN DEPARTAMENTO POR SU ID
        public Departamento FindDepartamento(int id)
        {
            var consulta = from datos in this.context.Departamentos
                           where datos.IdDepartamento == id
                           select datos;
            return consulta.FirstOrDefault();
        }

        //METODO PARA INSERTAR DEPARTAMENTO

        public void InsertDepartamento(int id, string nombre, string localidad)
        {
            Departamento departamento = new Departamento();
            departamento.IdDepartamento = id;
            departamento.Nombre= nombre;
            departamento.Localidad= localidad;
            this.context.Departamentos.Add(departamento);
            this.context.SaveChanges();
        }

        //METODO PARA ACTUALIZAR DEPARTAMENTO

        public void UpdateDepartamento(int id, string nombre, string localidad)
            {
            Departamento departamento = this.FindDepartamento(id);
            departamento.Nombre= nombre;
            departamento.Localidad= localidad;
            this.context.SaveChanges();
        }

        //METODO PARA ELIMINAR DEPARTAMENTO

        public void DeleteDepartamento(int id)
        {
            Departamento departamento = this.FindDepartamento(id);
            this.context.Departamentos.Remove(departamento);
            this.context.SaveChanges();
        }
    }
}
