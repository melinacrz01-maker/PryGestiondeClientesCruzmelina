namespace PryGestiondeClientesCruzmelina
{
    partial class ClientesDeudores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvCuadro = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnListaR = new System.Windows.Forms.Button();
            this.lblDEUDAclientes = new System.Windows.Forms.Label();
            this.lblclientescantA = new System.Windows.Forms.Label();
            this.lblDeudatotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPromediO = new System.Windows.Forms.Label();
            this.lblcantidadD = new System.Windows.Forms.Label();
            this.lbltotaldeuda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuadro)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCuadro
            // 
            this.dgvCuadro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuadro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvCuadro.Location = new System.Drawing.Point(40, 34);
            this.dgvCuadro.Name = "dgvCuadro";
            this.dgvCuadro.Size = new System.Drawing.Size(438, 200);
            this.dgvCuadro.TabIndex = 1;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Còdigo";
            this.Column4.Name = "Column4";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre y Apellido";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Limite de Credito";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Deuda";
            this.Column3.Name = "Column3";
            // 
            // btnListaR
            // 
            this.btnListaR.Location = new System.Drawing.Point(371, 329);
            this.btnListaR.Name = "btnListaR";
            this.btnListaR.Size = new System.Drawing.Size(97, 35);
            this.btnListaR.TabIndex = 16;
            this.btnListaR.Text = "Listar";
            this.btnListaR.UseVisualStyleBackColor = true;
            this.btnListaR.Click += new System.EventHandler(this.btnListaR_Click);
            // 
            // lblDEUDAclientes
            // 
            this.lblDEUDAclientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDEUDAclientes.Location = new System.Drawing.Point(146, 334);
            this.lblDEUDAclientes.Name = "lblDEUDAclientes";
            this.lblDEUDAclientes.Size = new System.Drawing.Size(150, 30);
            this.lblDEUDAclientes.TabIndex = 15;
            this.lblDEUDAclientes.Click += new System.EventHandler(this.lblDEUDAclientes_Click);
            // 
            // lblclientescantA
            // 
            this.lblclientescantA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblclientescantA.Location = new System.Drawing.Point(146, 292);
            this.lblclientescantA.Name = "lblclientescantA";
            this.lblclientescantA.Size = new System.Drawing.Size(150, 29);
            this.lblclientescantA.TabIndex = 14;
            // 
            // lblDeudatotal
            // 
            this.lblDeudatotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDeudatotal.Location = new System.Drawing.Point(146, 257);
            this.lblDeudatotal.Name = "lblDeudatotal";
            this.lblDeudatotal.Size = new System.Drawing.Size(150, 26);
            this.lblDeudatotal.TabIndex = 13;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(511, 398);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 12;
            // 
            // lblPromediO
            // 
            this.lblPromediO.AutoSize = true;
            this.lblPromediO.Location = new System.Drawing.Point(37, 351);
            this.lblPromediO.Name = "lblPromediO";
            this.lblPromediO.Size = new System.Drawing.Size(99, 13);
            this.lblPromediO.TabIndex = 11;
            this.lblPromediO.Text = "Promedio de deuda";
            // 
            // lblcantidadD
            // 
            this.lblcantidadD.AutoSize = true;
            this.lblcantidadD.Location = new System.Drawing.Point(37, 308);
            this.lblcantidadD.Name = "lblcantidadD";
            this.lblcantidadD.Size = new System.Drawing.Size(103, 13);
            this.lblcantidadD.TabIndex = 10;
            this.lblcantidadD.Text = "Cantidad de clientes";
            // 
            // lbltotaldeuda
            // 
            this.lbltotaldeuda.AutoSize = true;
            this.lbltotaldeuda.Location = new System.Drawing.Point(57, 270);
            this.lbltotaldeuda.Name = "lbltotaldeuda";
            this.lbltotaldeuda.Size = new System.Drawing.Size(79, 13);
            this.lbltotaldeuda.TabIndex = 9;
            this.lbltotaldeuda.Text = "Total de deuda";
            // 
            // ClientesDeudores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 409);
            this.Controls.Add(this.btnListaR);
            this.Controls.Add(this.lblDEUDAclientes);
            this.Controls.Add(this.lblclientescantA);
            this.Controls.Add(this.lblDeudatotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblPromediO);
            this.Controls.Add(this.lblcantidadD);
            this.Controls.Add(this.lbltotaldeuda);
            this.Controls.Add(this.dgvCuadro);
            this.Name = "ClientesDeudores";
            this.Text = "ClientesDeudores";
            this.Load += new System.EventHandler(this.ClientesDeudores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuadro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCuadro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnListaR;
        private System.Windows.Forms.Label lblDEUDAclientes;
        private System.Windows.Forms.Label lblclientescantA;
        private System.Windows.Forms.Label lblDeudatotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPromediO;
        private System.Windows.Forms.Label lblcantidadD;
        private System.Windows.Forms.Label lbltotaldeuda;
    }
}