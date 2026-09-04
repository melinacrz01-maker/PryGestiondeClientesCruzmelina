namespace PryGestiondeClientesCruzmelina
{
    partial class FrmListadoClientes
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
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbldeuda = new System.Windows.Forms.Label();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDeudatotal = new System.Windows.Forms.Label();
            this.lblclientescant = new System.Windows.Forms.Label();
            this.lblpromdeuda = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTabla
            // 
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvTabla.Location = new System.Drawing.Point(88, 50);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.Size = new System.Drawing.Size(438, 237);
            this.dgvTabla.TabIndex = 0;
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
            // lbldeuda
            // 
            this.lbldeuda.AutoSize = true;
            this.lbldeuda.Location = new System.Drawing.Point(301, 315);
            this.lbldeuda.Name = "lbldeuda";
            this.lbldeuda.Size = new System.Drawing.Size(79, 13);
            this.lbldeuda.TabIndex = 1;
            this.lbldeuda.Text = "Total de deuda";
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Location = new System.Drawing.Point(277, 341);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(103, 13);
            this.lblcantidad.TabIndex = 2;
            this.lblcantidad.Text = "Cantidad de clientes";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(281, 374);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(99, 13);
            this.lblPromedio.TabIndex = 3;
            this.lblPromedio.Text = "Promedio de deuda";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(465, 341);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 4;
            // 
            // lblDeudatotal
            // 
            this.lblDeudatotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDeudatotal.Location = new System.Drawing.Point(386, 305);
            this.lblDeudatotal.Name = "lblDeudatotal";
            this.lblDeudatotal.Size = new System.Drawing.Size(150, 23);
            this.lblDeudatotal.TabIndex = 5;
            // 
            // lblclientescant
            // 
            this.lblclientescant.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblclientescant.Location = new System.Drawing.Point(386, 331);
            this.lblclientescant.Name = "lblclientescant";
            this.lblclientescant.Size = new System.Drawing.Size(150, 23);
            this.lblclientescant.TabIndex = 6;
            // 
            // lblpromdeuda
            // 
            this.lblpromdeuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblpromdeuda.Location = new System.Drawing.Point(386, 364);
            this.lblpromdeuda.Name = "lblpromdeuda";
            this.lblpromdeuda.Size = new System.Drawing.Size(150, 23);
            this.lblpromdeuda.TabIndex = 7;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(451, 400);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 8;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // FrmListadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 445);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.lblpromdeuda);
            this.Controls.Add(this.lblclientescant);
            this.Controls.Add(this.lblDeudatotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.lblcantidad);
            this.Controls.Add(this.lbldeuda);
            this.Controls.Add(this.dgvTabla);
            this.Name = "FrmListadoClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListadoClientes";
            this.Load += new System.EventHandler(this.FrmListadoClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label lbldeuda;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDeudatotal;
        private System.Windows.Forms.Label lblclientescant;
        private System.Windows.Forms.Label lblpromdeuda;
        private System.Windows.Forms.Button btnListar;
    }
}