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
    public partial class ClientesDeudores : Form
    {
        public ClientesDeudores()
        {
            InitializeComponent();
        }

        ClsArchivo x = new ClsArchivo();

        private void lblDEUDAclientes_Click(object sender, EventArgs e)
        {

        }

        private void btnListaR_Click(object sender, EventArgs e)
        {
            x.listardeudores(dgvCuadro);
            lblDeudatotal.Text = x.Totaldeuda().ToString();
            lblclientescantA.Text = x.Cantidaddeudores().ToString();
            lblDEUDAclientes.Text = x.Promediodeudores().ToString();
        }

        private void ClientesDeudores_Load(object sender, EventArgs e)
        {

        }
    }
}
