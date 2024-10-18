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
    }
}
