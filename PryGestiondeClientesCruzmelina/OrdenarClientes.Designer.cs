namespace PryGestiondeClientesCruzmelina
{
    partial class FrmClientesOrdenar
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
            this.cmbAscendente = new System.Windows.Forms.ComboBox();
            this.cmbDatos = new System.Windows.Forms.ComboBox();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.btnLISTARCLIENTES = new System.Windows.Forms.Button();
            this.lblModo = new System.Windows.Forms.Label();
            this.lblCampo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.grpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbAscendente
            // 
            this.cmbAscendente.FormattingEnabled = true;
            this.cmbAscendente.Items.AddRange(new object[] {
            "ASCEDENTE",
            "DESCEDENTE"});
            this.cmbAscendente.Location = new System.Drawing.Point(314, 59);
            this.cmbAscendente.Name = "cmbAscendente";
            this.cmbAscendente.Size = new System.Drawing.Size(143, 21);
            this.cmbAscendente.TabIndex = 0;
            // 
            // cmbDatos
            // 
            this.cmbDatos.FormattingEnabled = true;
            this.cmbDatos.Items.AddRange(new object[] {
            "Còdigo",
            "Nombre y Apellido",
            "Limite de credito",
            "Deuda"});
            this.cmbDatos.Location = new System.Drawing.Point(93, 59);
            this.cmbDatos.Name = "cmbDatos";
            this.cmbDatos.Size = new System.Drawing.Size(143, 21);
            this.cmbDatos.TabIndex = 1;
            // 
            // dgvTabla
            // 
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvTabla.Location = new System.Drawing.Point(29, 109);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.Size = new System.Drawing.Size(438, 237);
            this.dgvTabla.TabIndex = 2;
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
            // grpDatos
            // 
            this.grpDatos.BackColor = System.Drawing.Color.PapayaWhip;
            this.grpDatos.Controls.Add(this.btnLISTARCLIENTES);
            this.grpDatos.Controls.Add(this.lblModo);
            this.grpDatos.Controls.Add(this.lblCampo);
            this.grpDatos.Controls.Add(this.cmbAscendente);
            this.grpDatos.Controls.Add(this.cmbDatos);
            this.grpDatos.Controls.Add(this.dgvTabla);
            this.grpDatos.Location = new System.Drawing.Point(52, 30);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(497, 416);
            this.grpDatos.TabIndex = 3;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Ordenar Clientes";
            // 
            // btnLISTARCLIENTES
            // 
            this.btnLISTARCLIENTES.BackColor = System.Drawing.Color.Beige;
            this.btnLISTARCLIENTES.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLISTARCLIENTES.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnLISTARCLIENTES.Location = new System.Drawing.Point(379, 366);
            this.btnLISTARCLIENTES.Name = "btnLISTARCLIENTES";
            this.btnLISTARCLIENTES.Size = new System.Drawing.Size(88, 27);
            this.btnLISTARCLIENTES.TabIndex = 5;
            this.btnLISTARCLIENTES.Text = "Listar";
            this.btnLISTARCLIENTES.UseVisualStyleBackColor = false;
            this.btnLISTARCLIENTES.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblModo
            // 
            this.lblModo.AutoSize = true;
            this.lblModo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModo.Location = new System.Drawing.Point(265, 60);
            this.lblModo.Name = "lblModo";
            this.lblModo.Size = new System.Drawing.Size(43, 15);
            this.lblModo.TabIndex = 4;
            this.lblModo.Text = "Modo";
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampo.Location = new System.Drawing.Point(35, 60);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(52, 15);
            this.lblCampo.TabIndex = 3;
            this.lblCampo.Text = "Campo";
            // 
            // FrmClientesOrdenar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(611, 458);
            this.Controls.Add(this.grpDatos);
            this.Name = "FrmClientesOrdenar";
            this.Text = "OrdenarClientes";
            this.Load += new System.EventHandler(this.FrmClientesOrdenar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAscendente;
        private System.Windows.Forms.ComboBox cmbDatos;
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label lblModo;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Button btnLISTARCLIENTES;
    }
}