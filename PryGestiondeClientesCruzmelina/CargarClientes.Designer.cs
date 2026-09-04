namespace PryGestiondeClientesCruzmelina
{
    partial class Frmagregarclientes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblDeuda = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblLimite = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtDeuda = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCredito = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCargar);
            this.groupBox1.Controls.Add(this.txtCredito);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtDeuda);
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Controls.Add(this.lblLimite);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.lblDeuda);
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Location = new System.Drawing.Point(40, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 211);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(43, 47);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo:";
            // 
            // lblDeuda
            // 
            this.lblDeuda.AutoSize = true;
            this.lblDeuda.Location = new System.Drawing.Point(43, 85);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(42, 13);
            this.lblDeuda.TabIndex = 1;
            this.lblDeuda.Text = "Deuda:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(260, 47);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(95, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre y Apellido:";
            // 
            // lblLimite
            // 
            this.lblLimite.AutoSize = true;
            this.lblLimite.Location = new System.Drawing.Point(260, 95);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(88, 13);
            this.lblLimite.TabIndex = 3;
            this.lblLimite.Text = "Limite de Crèdito:";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(93, 47);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 20);
            this.txtCode.TabIndex = 4;
            // 
            // txtDeuda
            // 
            this.txtDeuda.Location = new System.Drawing.Point(91, 82);
            this.txtDeuda.Name = "txtDeuda";
            this.txtDeuda.Size = new System.Drawing.Size(100, 20);
            this.txtDeuda.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(361, 47);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(116, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtCredito
            // 
            this.txtCredito.Location = new System.Drawing.Point(361, 95);
            this.txtCredito.Name = "txtCredito";
            this.txtCredito.Size = new System.Drawing.Size(116, 20);
            this.txtCredito.TabIndex = 7;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(381, 136);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 8;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // Frmagregarclientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 264);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frmagregarclientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CargarClientes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDeuda;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblLimite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDeuda;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.TextBox txtCredito;
    }
}