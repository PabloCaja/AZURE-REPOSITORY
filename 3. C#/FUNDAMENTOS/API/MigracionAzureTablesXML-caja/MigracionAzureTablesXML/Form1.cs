using Azure.Data.Tables;
using MigracionAzureTablesXML.Model;
using System.Xml.Linq;


namespace MigracionAzureTablesXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void botonMigrar_Click(object sender, EventArgs e)
        {
            //COMENZAMOS RECUPERANDO EL DOCUEMNTO XML INCRUSTADO
            //PARA ELLO, DEBEMOS ACCEDER AL ASSEMBLY Y NOS 
            //DEVOLVERA UN Stream
            //EL DOCUMENTO TENDRÁ EL namespace DEL NOMBRE DE NUESTRO PROYECTO Y EL NOMBRE DEL FICHERO
            // MigracionAzureTablesXML.alumnos.xml
            string assemblypath = "MigracionAzureTablesXML.alumnos.xml";
            Stream stream = this.GetType().Assembly.GetManifestResourceStream(assemblypath);
            XDocument document = XDocument.Load(stream);
            //UN DOCUMENTO XML DIFERENCIA MAYUSCULAS DE MINUSCULAS
            // SE RECUPERAN SUS ELEMENTOS POR NODOS, ES DECIR, POR UN CONJUNTO DE ETIQUETAS (Element)
            //QUE PUEDEN TENER MÁS ETIQUETAS EN SU INTERIOR
            //con Descendants("TAG") INDICAMOS EL GRUPO DE ETIQUETAS QUE DESEAMOS RECUPERAR (alumno)
            //SE RRECORRE CON var consulta = from datos...
            //datos ES CADA Element DENTRO DE LA ETIQUETA. datos.Element("tag").Value
            //var consulta = from datos in document.Descendants("alumno")
            //               select datos;
            //List<Alumno> alumnos = new List<Alumno>();
            ////RECORREMOS TODAS LAS ETIQUETAS ALUMNO
            //foreach (var item in consulta)
            //{
            //    Alumno alumno = new Alumno();
            //    alumno.IdAlumno = item.Element("idalumno").Value;
            //    alumno.Nombre = item.Element("nombre").Value;
            //    alumno.Apellidos = item.Element("apellidos").Value;
            //    alumno.Curso = item.Element("curso").Value;
            //    alumno.Nota = int.Parse(item.Element("nota").Value);
            //    alumnos.Add(alumno);
            //}
            //TAMBIEN PODEMOS REALIZAR LA CONSULTA Linq to XML
            //Y GENERAR LAS CLASES NECESARIAS EN LA PROPIA CONSULTA
            var consulta = from datos in document.Descendants("alumno")
                           select new Alumno
                           {
                               IdAlumno = datos.Element("idalumno").Value,
                               Nombre = datos.Element("nombre").Value,
                               Apellidos = datos.Element("apellidos").Value,
                               Curso = datos.Element("curso").Value,
                               Nota = int.Parse(datos.Element("nota").Value)
                           };
            //AHORA MISMO consulta ES UNA COLECCION DE ALUMNOS
            List<Alumno> alumnos = consulta.ToList();

            //NO VAMOS A CREAR NI SERVICE NI NADA, YA QUE ESTA APP ES UNA UTILIDAD 
            //PARA RELLENAR UNA TABLA DE AZURE Y HACER LA PRACTICA REAL CON AZURE
            string connectionString = "DefaultEndpointsProtocol=https;AccountName=storageeoicaja;AccountKey=Hhxt98JrsoFaUS654XYV6DkUOB1Z6vPm87H+Wgk098UZr9Um86S7AaFgo02R/CSF6wQqt6i5f92B+AStTV/wfA==;EndpointSuffix=core.windows.net";
            //string connectionString = "UseDevelopmentStorage=true";
            //CREAMOS EL SERVICIO DE AZURE TABLES
            TableServiceClient serviceClient = new TableServiceClient(connectionString);
            //CREAMOS EL ACCESO A LA TABLA
            TableClient tableClient = serviceClient.GetTableClient("alumnos");
            //CREAMOS LA TABLA EN AZURE SI NO EXISTE
            await tableClient.CreateIfNotExistsAsync();
            //RECORREMOS TODOS LOS ALUMNOS QUE DESEAMOS LLEVAR A AZURE
            foreach (Alumno alumno in alumnos)
            {
                //INSERTAMOS CADA ALUMNO EN AZURE
                tableClient.AddEntityAsync<Alumno>(alumno);
            }
            //PARA COMPROBAR SI FUNCIONA, LO DIBUJAMOS EN LA APP
            this.dataGridView1.DataSource= alumnos;
        }
    }
}