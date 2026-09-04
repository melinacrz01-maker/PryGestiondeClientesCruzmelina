using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryGestiondeClientesCruzmelina

{
    internal class ClsArchivo


    {
        public string NombreArchivo = "clientes.csv";

        public void Grabar(string cod, string nombre, string deuda, string limite)
        {
            StreamWriter AD = new StreamWriter(NombreArchivo);

            AD.Write("cod");

            AD.Write(";");

            AD.Write("nombre");

            AD.Write(";");

            AD.Write("deuda");

            AD.Write(";");

            AD.WriteLine("limite");

            AD.Close();

            AD.Dispose();

        }
        public void Listar(DataGridView Grilla)
        {
            string DatosLeidos = "";

            string[] vecDatos = new string[4];


            StreamReader AD = new StreamReader(NombreArchivo);

            DatosLeidos = AD.ReadLine();

            Grilla.Rows.Clear();
            while (DatosLeidos != null)
            {
                vecDatos = DatosLeidos.Split(';');

                Grilla.Rows.Add(vecDatos[0], vecDatos[1], vecDatos[3], vecDatos[2]);

                DatosLeidos = AD.ReadLine();
            }

            AD.Close();
            AD.Dispose();
        }
        public int Cantidadclientes()
        {

            int c = 0;
            string DatosLeidos = "";
            StreamReader AD = new StreamReader(NombreArchivo);
            DatosLeidos = AD.ReadLine();
            while (DatosLeidos != null)
            {
                c++;
                DatosLeidos = AD.ReadLine();
            }
            AD.Close();
            AD.Dispose();
            return c;
        }
        public decimal Totaldeuda()
        {
            decimal total = 0;
            string DatosLeidos = "";
            string[] vecDatos = new string[4];
            StreamReader AD = new StreamReader(NombreArchivo);
            DatosLeidos = AD.ReadLine();
            while (DatosLeidos != null)
            {
                vecDatos = DatosLeidos.Split(';');

                // grilla.Rows.Add(vecDatos[0], vecDatos[1], vecDatos[3], vecDatos[2]);

                total = total + Convert.ToDecimal(vecDatos[2]);

                DatosLeidos = AD.ReadLine();
            }
            AD.Close();
            AD.Dispose();

            return total;
        }
    }
}
