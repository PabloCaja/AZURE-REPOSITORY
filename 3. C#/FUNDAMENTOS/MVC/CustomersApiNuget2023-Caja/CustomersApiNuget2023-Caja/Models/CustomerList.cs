using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CustomersApiNuget2023_Caja.Models
{
    public class CustomerList
    {
        [JsonProperty("value")]
        public List<Customer> Customers { get; set; }
    }

}
