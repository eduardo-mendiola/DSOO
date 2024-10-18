namespace SistemaInscripcionS10
{
    partial class frmFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFactura));
            panel1 = new Panel();
            lblTitulo = new Label();
            btnImprimir = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            label5 = new Label();
            label4 = new Label();
            lblDFecha = new Label();
            panel4 = new Panel();
            lblValor = new Label();
            label13 = new Label();
            lblPago = new Label();
            label11 = new Label();
            lblDia = new Label();
            label9 = new Label();
            lblCurso = new Label();
            label7 = new Label();
            lblAlumno = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Beige;
            panel1.Controls.Add(lblTitulo);
            panel1.Location = new Point(12, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 78);
            panel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(264, 17);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(343, 37);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "COMPROBANTE DE PAGO";
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(604, 533);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(169, 50);
            btnImprimir.TabIndex = 1;
            btnImprimir.Text = "IMPRIMIR";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(7, 12);
            label1.Name = "label1";
            label1.Size = new Size(270, 32);
            label1.TabIndex = 2;
            label1.Text = "INSTITUTO TERCIARIO";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(281, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 112);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.OldLace;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(12, 113);
            panel2.Name = "panel2";
            panel2.Size = new Size(384, 112);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.OldLace;
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(lblDFecha);
            panel3.Location = new Point(404, 113);
            panel3.Name = "panel3";
            panel3.Size = new Size(384, 112);
            panel3.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(7, 64);
            label5.Name = "label5";
            label5.Size = new Size(370, 23);
            label5.TabIndex = 6;
            label5.Text = "DATOS GENERALES DEL INSTITUTO TÉCNICO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(7, 13);
            label4.Name = "label4";
            label4.Size = new Size(74, 30);
            label4.TabIndex = 5;
            label4.Text = "Fecha:";
            // 
            // lblDFecha
            // 
            lblDFecha.AutoSize = true;
            lblDFecha.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblDFecha.Location = new Point(82, 14);
            lblDFecha.Name = "lblDFecha";
            lblDFecha.Size = new Size(127, 30);
            lblDFecha.TabIndex = 4;
            lblDFecha.Text = "00/00/0000";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Beige;
            panel4.Controls.Add(lblValor);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(lblPago);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(lblDia);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(lblCurso);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(lblAlumno);
            panel4.Location = new Point(12, 242);
            panel4.Name = "panel4";
            panel4.Size = new Size(776, 267);
            panel4.TabIndex = 1;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblValor.Location = new Point(626, 205);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(85, 35);
            lblValor.TabIndex = 15;
            lblValor.Text = "11111";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(518, 208);
            label13.Name = "label13";
            label13.Size = new Size(113, 30);
            label13.TabIndex = 14;
            label13.Text = "Monto:  $";
            // 
            // lblPago
            // 
            lblPago.AutoSize = true;
            lblPago.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblPago.Location = new Point(295, 205);
            lblPago.Name = "lblPago";
            lblPago.Size = new Size(111, 35);
            lblPago.TabIndex = 13;
            lblPago.Text = "efectivo";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(118, 208);
            label11.Name = "label11";
            label11.Size = new Size(174, 30);
            label11.TabIndex = 12;
            label11.Text = "Forma de Pago:";
            // 
            // lblDia
            // 
            lblDia.AutoSize = true;
            lblDia.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblDia.Location = new Point(295, 145);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(149, 35);
            lblDia.TabIndex = 11;
            lblDia.Text = "00/00/0000";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(74, 148);
            label9.Name = "label9";
            label9.Size = new Size(218, 30);
            label9.TabIndex = 10;
            label9.Text = "Fecha de Comienzo:";
            // 
            // lblCurso
            // 
            lblCurso.AutoSize = true;
            lblCurso.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblCurso.Location = new Point(295, 85);
            lblCurso.Name = "lblCurso";
            lblCurso.Size = new Size(82, 35);
            lblCurso.TabIndex = 9;
            lblCurso.Text = "Curso";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(38, 88);
            label7.Name = "label7";
            label7.Size = new Size(254, 30);
            label7.TabIndex = 8;
            label7.Text = "Se inscribio en el curso:";
            // 
            // lblAlumno
            // 
            lblAlumno.AutoSize = true;
            lblAlumno.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblAlumno.Location = new Point(37, 28);
            lblAlumno.Name = "lblAlumno";
            lblAlumno.Size = new Size(110, 35);
            lblAlumno.TabIndex = 7;
            lblAlumno.Text = "Nombre";
            // 
            // frmFactura
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 595);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(btnImprimir);
            Controls.Add(panel1);
            Name = "frmFactura";
            Text = "frmFactura";
            Load += frmFactura_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnImprimir;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label lblTitulo;
        private Label label5;
        private Label label4;
        private Label lblDFecha;
        private Label lblValor;
        private Label label13;
        private Label lblPago;
        private Label label11;
        private Label lblDia;
        private Label label9;
        private Label lblCurso;
        private Label label7;
        private Label lblAlumno;
    }
}