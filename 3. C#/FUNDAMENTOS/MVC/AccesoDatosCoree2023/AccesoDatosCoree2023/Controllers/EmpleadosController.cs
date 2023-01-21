using System.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;
using AccesoDatosCoree2023.Models;

namespace AccesoDatosCoree2023.Controllers
{
    public class EmpleadosController : Controller
    {
        //NECESITAMOS NUESTROS OBJETOS DE BASE DE DATOS
        string connectionString;
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        //EN EL CONSTRUCTOR, CREAREMOS LOS OBJETOS
        public EmpleadosController()
        {
            this.connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa";
            this.cn = new SqlConnection(this.connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.com.CommandType = System.Data.CommandType.Text;
        }

        public IActionResult Index()
        {
            //VAMOS A CARGAR LOS EMPLEADOS Y DEVOLVERLOS
            List<Empleado> empleados = new List<Empleado>();
            string sql = "SELECT * FROM EMP";
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            //RECORREMOS TODOS LOS DATOS DEL READER
            while (this.reader.Read())
            {
                //POR CADA DATO EN EL BUCLE, CREAMOS UN NUEVO EMPLEADO
                Empleado emp = new Empleado();
                //ASIGNAMOS LOS DATOS AL OBJETO EMP
                emp.IdEmpleado = int.Parse(this.reader["EMP_NO"].ToString());
                emp.Apellido = this.reader["APELLIDO"].ToString();
                emp.Oficio = this.reader["OFICIO"].ToString();
                emp.Salario = int.Parse(this.reader["SALARIO"].ToString());
                //AÑADIMOS CADA EMPLEADO A LA COLECCION
                empleados.Add(emp);
            }
            this.cn.Close();
            this.reader.Close();
            return View(empleados);
        }

    }
}
