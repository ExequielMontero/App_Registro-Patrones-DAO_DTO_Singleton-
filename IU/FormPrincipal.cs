using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App_Registro.DAO;
using App_Registro.DTO;

namespace App_Registro.IU
{
    public partial class FormPrincipal : Form
    {
        FormClientes formClientes;
        public FormPrincipal()
        {
            InitializeComponent();
        }


        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            formClientes = FormClientes.ObtenerInstancia();
            formClientes.BringToFront();
            formClientes.MdiParent = this;
            formClientes.Show();

        }
    }
}
