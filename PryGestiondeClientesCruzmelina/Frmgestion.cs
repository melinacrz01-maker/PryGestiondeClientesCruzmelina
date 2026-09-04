using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryGestiondeClientesCruzmelina
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            
        }

        private void agregarNuevosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmagregarclientes frmAgregarClientes = new Frmagregarclientes();
            frmAgregarClientes.Show();
        }

        private void listadoDeTodosLosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListadoClientes frmListadoClientes = new FrmListadoClientes();
            frmListadoClientes.Show();
        }
    }
}
