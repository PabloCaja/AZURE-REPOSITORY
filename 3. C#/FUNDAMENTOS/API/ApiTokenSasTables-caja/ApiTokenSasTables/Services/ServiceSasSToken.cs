using Azure;
using Azure.Data.Tables;
using Azure.Data.Tables.Sas;
using System.Runtime.CompilerServices;

namespace ApiTokenSasTables.Services
{
    public class ServiceSasSToken
    {
        //NECESITAMOS EL CLIENTE DE LA TABLA PARA GENERAR EL TOKEN
        private TableClient tableClient;

        public ServiceSasSToken(string azurekeys)
        {
            TableServiceClient serviceClient = new TableServiceClient(azurekeys);
            this.tableClient = serviceClient.GetTableClient("alumnos");

        }

        //TENDREMOS UN METODO QUE GENERARA UN TOKEN DEVOLVIENDO SOLAMENTE PERMISOS
        //SOBRE UN CURSO DE LOS ALUMNOS DE LA TABLA "alumnos"
        public string GenerateSaSToken(string curso)
        {
            //DEBEMOS INDICAR LOS PERMISOS QUE DEJAREMOS SOBRE EL TOKEN
            TableSasPermissions permisos = TableSasPermissions.Read | TableSasPermissions.Delete;
            //DEBEMOS INDICAR EL TIEMPO DE DURACION DE LOS PERMISOS
            TableSasBuilder builder = this.tableClient.GetSasBuilder(permisos, DateTime.Now.AddDays(1));
            //COMO ESTAMOS CON TABLAS, SOLAMENTE VAMOS A PERMITIR
            //ACCESO A UN DETERMINADO CURSOS ENTRE LOS DATOS
            builder.PartitionKeyStart = curso;
            builder.PartitionKeyEnd = curso;
            //CON TODO ESTO CONFIGURADO, SE GENERA UNA URL (Uri)
            //CON LOS PERMISOS DE ACCESO Y EL TOKEN
            Uri uriToken = this.tableClient.GenerateSasUri(builder);
            //EXTRAEMOS DEL URI LA RUTA http DE ACCESO
            string token = uriToken.AbsoluteUri;
            return token;
        }
    }
}
