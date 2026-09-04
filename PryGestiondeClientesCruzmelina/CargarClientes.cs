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
    public partial class Frmagregarclientes : Form
    {
        public Frmagregarclientes()
        {
            InitializeComponent();
        }

        ClsArchivo x = new ClsArchivo();
        private void btnCargar_Click(object sender, EventArgs e)
        {
            x.Grabar(txtCode.Text, txtNombre.Text, txtDeuda.Text, txtCredito.Text);

            MessageBox.Show("Se ha cargado correctamente el cliente", "Carga de clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtCode.Clear();
        }
    }
}
