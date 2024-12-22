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
    public partial class FormClientes : Form
    {
        #region Patron Singleton
        private static FormClientes instancia = null;
        public static FormClientes ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed)
                {
                instancia = new FormClientes();
            }
            return instancia;
        }
        #endregion
        private FormClientes()
        {
            InitializeComponent();
        }

        //Actualizacion de todos lso registros sin condicion
        private void FormClientes_Load(object sender, EventArgs e)
        {
            VerRegistros("");
        }

        public void VerRegistros(string condicion)
        {

            ClienteDAO clienteDAO = new ClienteDAO();
            dataGridView1.DataSource = clienteDAO.VerRegistros(condicion);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            VerRegistros(tbBuscar.Text);
        }

        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            VerRegistros(tbBuscar.Text);
        }

        private void FormClientes_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
