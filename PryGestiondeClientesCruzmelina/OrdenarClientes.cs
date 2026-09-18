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
    public partial class FrmClientesOrdenar : Form
    {
        public FrmClientesOrdenar()
        {
            InitializeComponent();
        }
        ClsArchivo x = new ClsArchivo();
        private void FrmClientesOrdenar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbDatos.Text == "Nombre y Apellido")
            {
                if (cmbAscendente.Text == "ASCENDENTE")
                {
                    x.OrdenarPorNombreAscendente(dgvTabla);
                }
                else
                {
                    x.OrdenarPorNombreDescendente(dgvTabla);
                }
            }

            if (cmbDatos.Text == "Deuda")
            {
                if (cmbAscendente.Text == "ASCENDENTE")
                {
                    x.OrdenarPorDeudaAscendente(dgvTabla);
                }
                else
                {
                    x.OrdenarPorDeudaDescendente(dgvTabla);
                }
            }

            if (cmbDatos.Text == "Limite")
            {
                if (cmbAscendente.Text == "ASCENDENTE")
                {
                    x.OrdenarPorLimiteAscendente(dgvTabla);
                }
                else
                {
                    x.OrdenarPorLimiteDescendente(dgvTabla);
                }
            }

        }

    }
}
    

