namespace SistemaInscripcionS10
{
    partial class frmPagar
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
            lblIngreseNumero = new Label();
            groupBox1 = new GroupBox();
            optTarjeta = new RadioButton();
            optEfvo = new RadioButton();
            txtNro = new TextBox();
            btnPagar = new Button();
            btnComprobante = new Button();
            btnVolver = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblIngreseNumero
            // 
            lblIngreseNumero.AutoSize = true;
            lblIngreseNumero.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblIngreseNumero.Location = new Point(28, 47);
            lblIngreseNumero.Name = "lblIngreseNumero";
            lblIngreseNumero.Size = new Size(367, 35);
            lblIngreseNumero.TabIndex = 0;
            lblIngreseNumero.Text = "Ingrese Número de Inscipción";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightGray;
            groupBox1.Controls.Add(optTarjeta);
            groupBox1.Controls.Add(optEfvo);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(425, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(214, 156);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Forma de Pago";
            // 
            // optTarjeta
            // 
            optTarjeta.AutoSize = true;
            optTarjeta.Location = new Point(38, 102);
            optTarjeta.Name = "optTarjeta";
            optTarjeta.Size = new Size(90, 32);
            optTarjeta.TabIndex = 1;
            optTarjeta.TabStop = true;
            optTarjeta.Text = "Tarjeta";
            optTarjeta.UseVisualStyleBackColor = true;
            // 
            // optEfvo
            // 
            optEfvo.AutoSize = true;
            optEfvo.Location = new Point(38, 54);
            optEfvo.Name = "optEfvo";
            optEfvo.Size = new Size(102, 32);
            optEfvo.TabIndex = 0;
            optEfvo.TabStop = true;
            optEfvo.Text = "Efectivo";
            optEfvo.UseVisualStyleBackColor = true;
            // 
            // txtNro
            // 
            txtNro.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtNro.Location = new Point(95, 131);
            txtNro.Name = "txtNro";
            txtNro.Size = new Size(200, 41);
            txtNro.TabIndex = 2;
            // 
            // btnPagar
            // 
            btnPagar.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnPagar.Location = new Point(95, 209);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(200, 60);
            btnPagar.TabIndex = 3;
            btnPagar.Text = "PAGAR";
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Click += btnPagar_Click;
            // 
            // btnComprobante
            // 
            btnComprobante.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnComprobante.Location = new Point(95, 306);
            btnComprobante.Name = "btnComprobante";
            btnComprobante.Size = new Size(200, 60);
            btnComprobante.TabIndex = 4;
            btnComprobante.Text = "COMPROBANTE";
            btnComprobante.UseVisualStyleBackColor = true;
            btnComprobante.Click += btnComprobante_Click;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolver.Location = new Point(424, 306);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(200, 60);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // frmPagar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 415);
            Controls.Add(btnVolver);
            Controls.Add(btnComprobante);
            Controls.Add(btnPagar);
            Controls.Add(txtNro);
            Controls.Add(groupBox1);
            Controls.Add(lblIngreseNumero);
            Name = "frmPagar";
            Text = "frmPagar";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIngreseNumero;
        private GroupBox groupBox1;
        private RadioButton optTarjeta;
        private RadioButton optEfvo;
        private TextBox txtNro;
        private Button btnPagar;
        private Button btnComprobante;
        private Button btnVolver;
    }
}