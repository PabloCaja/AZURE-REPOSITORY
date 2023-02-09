using CustomersApiNuget2023;
using CustomersApiNuget2023.Models;

namespace PruebaApiNugetCustomers_Caja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            CustomerContext context = new CustomerContext();
            CustomerList customerList = await context.GetCustomerListAsync();
            List<Customer> clientes = customerList.Customers;
            foreach (Customer cliente in clientes)
            {
                this.listBox1.Items.Add(cliente.Name + " - " + cliente.Company);
            }
        }

    }
}