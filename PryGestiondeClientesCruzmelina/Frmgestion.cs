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

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void listadoDeClientesDeuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientesDeudores frmClientesDeudores = new ClientesDeudores();
            frmClientesDeudores.Show();
        }

        private void listadoDeClientesOrdenadosPorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientesOrdenar frmClientesOrdenar = new FrmClientesOrdenar();
            frmClientesOrdenar.Show();
        }
    }
}
