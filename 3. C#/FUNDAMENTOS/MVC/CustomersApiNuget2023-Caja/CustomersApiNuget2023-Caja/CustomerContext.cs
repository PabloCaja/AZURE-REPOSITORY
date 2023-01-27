using CustomersApiNuget2023_Caja.Models;
using Newtonsoft.Json;
using System.Net;

namespace CustomersApiNuget2023_Caja
{
    public class CustomerContext
    {
        //VAMOS A LEER TODOS LOS CUSTOMER DE UN API DE INTERNET
        //NECESITAMOS QUE EL METODO SEA ASINCRONO
        public async Task<CustomerList> GetCustomerListAsync()
        {
            WebClient client = new WebClient();
            //INDICAMOS QUE TIPO DE DATO VAMOS A LEER
            client.Headers["content-type"] = "application/json";
            string urlApi = "https://services.odata.org/V4/Northwind/Northwind.svc/Customers";
            //LEEMOS EL API Y DESCARGAMOS TODO EL CONTENIDO (string) JSON
            string json = await client.DownloadStringTaskAsync(urlApi);
            //LA LIBRERIA NewtonSoft.json CON LOS MAPEOS QUE HEMOS REALIZADO
            //AUTOMATICAMENTE ENLAZA CADA PROPIEDAD CON CADA DATO DEL JSON
            CustomerList customers =
                JsonConvert.DeserializeObject<CustomerList>(json);
            return customers;
        }
    }

}