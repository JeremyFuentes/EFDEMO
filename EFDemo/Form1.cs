using AccesoDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private CustomerRepository cr = new CustomerRepository();

        private void btnObtenerTodos_Click(object sender, EventArgs e)
        {
            var cliente = cr.ObtenerTodos();
            dgvCustomers.DataSource = cliente;
        }

        private void btnObtenerPorID_Click(object sender, EventArgs e)
        {
            var cliente = cr.ObtenerPorID(tboxObtenerPorID.Text);
            List<Customers> lista1 = new List<Customers> { cliente };
            dgvCustomers.DataSource = lista1;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (tbxCustomerID.Text != "")
            {
                var cliente = CrearCliente();
                var resultado = cr.InsertarCliente(cliente);
                MessageBox.Show($"Se inserto {resultado}");
            }
            else
            {
                MessageBox.Show("No se puede insertar un cliente en blanco");
            }

            VaciarTbox();
            var clientes = cr.ObtenerTodos();
            dgvCustomers.DataSource = clientes;
        }

        private Customers CrearCliente()
        {
            var cliente = new Customers()
            {
                CustomerID = tbxCustomerID.Text,
                CompanyName = tbxCompanyName.Text,
                ContactName = tbxContactName.Text,
                ContactTitle = tbxContactTitle.Text,
                Address = tbxAddress.Text,
            };

            return cliente;
        }

        private void VaciarTbox()
        {
            tbxCustomerID.Text = "";
            tbxCompanyName.Text = "";
            tbxContactName.Text = "";
            tbxContactTitle.Text = "";
            tbxAddress.Text = "";
        }
    }
}
