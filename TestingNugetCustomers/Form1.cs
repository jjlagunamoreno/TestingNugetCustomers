using NugetCustomersJJLM.Models;
using NugetCustomersJJLM.Services;

namespace TestingNugetCustomers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnReadCustomers_Click(object sender, EventArgs e)
        {
            ServiceCustomers service =
                new ServiceCustomers();
            CustomersList data = await service.GetCustomersListAsync();
            List<Customer> customers = data.Customers;
            foreach (Customer c in customers)
            {
                this.listBox1.Items.Add
                    (c.Contacto + ", " + c.Empresa);
            }

        }
    }
}
