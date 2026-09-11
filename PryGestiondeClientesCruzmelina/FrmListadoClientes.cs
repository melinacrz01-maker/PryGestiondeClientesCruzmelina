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
    public partial class FrmListadoClientes : Form
    {
        public FrmListadoClientes()
        {
            InitializeComponent();
        }
        ClsArchivo x = new ClsArchivo();
        private void btnListar_Click(object sender, EventArgs e)
        {
            x.Listar(dgvTabla);
            lblclientescant.Text = x.Cantidadclientes().ToString();
            lblDeudatotal.Text = x.Totaldeuda().ToString();
            lblpromdeuda.Text = x.Promediodeuda().ToString();

        }

        private void FrmListadoClientes_Load(object sender, EventArgs e)
        {

        }

        private void lblclientescant_Click(object sender, EventArgs e)
        {

        }

        private void lblDeudatotal_Click(object sender, EventArgs e)
        {

        }

        private void lbldeuda_Click(object sender, EventArgs e)
        {

        }

        private void dgvTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnreportes_Click(object sender, EventArgs e)
        {
            x.GenerarReporte();
            MessageBox.Show("Reporte generado correctamente en la carpeta de reportes");
        }
    }
}
