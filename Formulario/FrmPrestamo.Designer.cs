namespace Formulario
{
    partial class FrmPrestamo
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
            this.lstTipoPrestamo = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdCliente = new Formulario.TextoNumerico();
            this.txtTNA = new Formulario.TextoNumerico();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLinea = new Formulario.TextoSoloCaracter();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMonto = new Formulario.TextoNumerico();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPlazo = new Formulario.TextoNumerico();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSimular = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCuotaCapital = new System.Windows.Forms.TextBox();
            this.txtCuotaInteres = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCuotaTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lstPrestamos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstTipoPrestamo
            // 
            this.lstTipoPrestamo.FormattingEnabled = true;
            this.lstTipoPrestamo.ItemHeight = 16;
            this.lstTipoPrestamo.Location = new System.Drawing.Point(12, 59);
            this.lstTipoPrestamo.Name = "lstTipoPrestamo";
            this.lstTipoPrestamo.Size = new System.Drawing.Size(278, 484);
            this.lstTipoPrestamo.TabIndex = 0;
            this.lstTipoPrestamo.DoubleClick += new System.EventHandler(this.lstTipoPrestamo_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "IdCliente";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(462, 56);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(160, 22);
            this.txtIdCliente.TabIndex = 2;
            // 
            // txtTNA
            // 
            this.txtTNA.Enabled = false;
            this.txtTNA.Location = new System.Drawing.Point(462, 136);
            this.txtTNA.Name = "txtTNA";
            this.txtTNA.Size = new System.Drawing.Size(160, 22);
            this.txtTNA.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "TNA";
            // 
            // txtLinea
            // 
            this.txtLinea.Enabled = false;
            this.txtLinea.Location = new System.Drawing.Point(462, 98);
            this.txtLinea.Name = "txtLinea";
            this.txtLinea.Size = new System.Drawing.Size(160, 22);
            this.txtLinea.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Linea";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(462, 183);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(160, 22);
            this.txtMonto.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Monto";
            // 
            // txtPlazo
            // 
            this.txtPlazo.Location = new System.Drawing.Point(462, 226);
            this.txtPlazo.Name = "txtPlazo";
            this.txtPlazo.Size = new System.Drawing.Size(160, 22);
            this.txtPlazo.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(335, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Plazo";
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(338, 280);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(284, 60);
            this.btnSimular.TabIndex = 11;
            this.btnSimular.Text = "SIMULAR";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(338, 483);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(284, 60);
            this.btnAlta.TabIndex = 12;
            this.btnAlta.Text = "ALTA";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(335, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "CuotaCapital";
            // 
            // txtCuotaCapital
            // 
            this.txtCuotaCapital.Enabled = false;
            this.txtCuotaCapital.Location = new System.Drawing.Point(462, 364);
            this.txtCuotaCapital.Name = "txtCuotaCapital";
            this.txtCuotaCapital.Size = new System.Drawing.Size(160, 22);
            this.txtCuotaCapital.TabIndex = 14;
            // 
            // txtCuotaInteres
            // 
            this.txtCuotaInteres.Enabled = false;
            this.txtCuotaInteres.Location = new System.Drawing.Point(462, 401);
            this.txtCuotaInteres.Name = "txtCuotaInteres";
            this.txtCuotaInteres.Size = new System.Drawing.Size(160, 22);
            this.txtCuotaInteres.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(335, 404);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "CuotaInteres";
            // 
            // txtCuotaTotal
            // 
            this.txtCuotaTotal.Enabled = false;
            this.txtCuotaTotal.Location = new System.Drawing.Point(462, 439);
            this.txtCuotaTotal.Name = "txtCuotaTotal";
            this.txtCuotaTotal.Size = new System.Drawing.Size(160, 22);
            this.txtCuotaTotal.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(335, 442);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 21);
            this.label8.TabIndex = 17;
            this.label8.Text = "Cuota Total";
            // 
            // lstPrestamos
            // 
            this.lstPrestamos.FormattingEnabled = true;
            this.lstPrestamos.ItemHeight = 16;
            this.lstPrestamos.Location = new System.Drawing.Point(654, 56);
            this.lstPrestamos.Name = "lstPrestamos";
            this.lstPrestamos.Size = new System.Drawing.Size(426, 484);
            this.lstPrestamos.TabIndex = 19;
            // 
            // FrmPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 647);
            this.Controls.Add(this.lstPrestamos);
            this.Controls.Add(this.txtCuotaTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCuotaInteres);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCuotaCapital);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.btnSimular);
            this.Controls.Add(this.txtPlazo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLinea);
            this.Controls.Add(this.txtTNA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstTipoPrestamo);
            this.Name = "FrmPrestamo";
            this.Text = "FrmPrestamo";
            this.Load += new System.EventHandler(this.FrmPrestamo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTipoPrestamo;
        private System.Windows.Forms.Label label1;
        private TextoNumerico txtIdCliente;
        private TextoNumerico txtTNA;
        private System.Windows.Forms.Label label2;
        private TextoSoloCaracter txtLinea;
        private System.Windows.Forms.Label label3;
        private TextoNumerico txtMonto;
        private System.Windows.Forms.Label label4;
        private TextoNumerico txtPlazo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCuotaCapital;
        private System.Windows.Forms.TextBox txtCuotaInteres;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCuotaTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lstPrestamos;
    }
}