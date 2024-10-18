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
            panel1.Controls.Add(lblTitulo);
            panel1.Location = new Point(12, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 78);
            panel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(281, 29);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(220, 25);
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
            label1.Location = new Point(37, 21);
            label1.Name = "label1";
            label1.Size = new Size(189, 25);
            label1.TabIndex = 2;
            label1.Text = "INSTITUTO TERCIARIO";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(281, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 112);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(12, 113);
            panel2.Name = "panel2";
            panel2.Size = new Size(384, 112);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
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
            label5.Location = new Point(13, 66);
            label5.Name = "label5";
            label5.Size = new Size(368, 25);
            label5.TabIndex = 6;
            label5.Text = "DATOS GENERALES DEL INSTITUTO TÉCNICO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 12);
            label4.Name = "label4";
            label4.Size = new Size(61, 25);
            label4.TabIndex = 5;
            label4.Text = "Fecha:";
            // 
            // lblDFecha
            // 
            lblDFecha.AutoSize = true;
            lblDFecha.Location = new Point(136, 12);
            lblDFecha.Name = "lblDFecha";
            lblDFecha.Size = new Size(106, 25);
            lblDFecha.TabIndex = 4;
            lblDFecha.Text = "00/00/0000";
            // 
            // panel4
            // 
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
            lblValor.Location = new Point(668, 204);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(62, 25);
            lblValor.TabIndex = 15;
            lblValor.Text = "11111";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(538, 204);
            label13.Name = "label13";
            label13.Size = new Size(85, 25);
            label13.TabIndex = 14;
            label13.Text = "Monto: $";
            // 
            // lblPago
            // 
            lblPago.AutoSize = true;
            lblPago.Location = new Point(251, 204);
            lblPago.Name = "lblPago";
            lblPago.Size = new Size(74, 25);
            lblPago.TabIndex = 13;
            lblPago.Text = "efectivo";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(37, 204);
            label11.Name = "label11";
            label11.Size = new Size(137, 25);
            label11.TabIndex = 12;
            label11.Text = "Forma de Pago:";
            // 
            // lblDia
            // 
            lblDia.AutoSize = true;
            lblDia.Location = new Point(375, 139);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(106, 25);
            lblDia.TabIndex = 11;
            lblDia.Text = "00/00/0000";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(37, 139);
            label9.Name = "label9";
            label9.Size = new Size(171, 25);
            label9.TabIndex = 10;
            label9.Text = "Fecha de Comienzo:";
            // 
            // lblCurso
            // 
            lblCurso.AutoSize = true;
            lblCurso.Location = new Point(375, 88);
            lblCurso.Name = "lblCurso";
            lblCurso.Size = new Size(58, 25);
            lblCurso.TabIndex = 9;
            lblCurso.Text = "Curso";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(37, 88);
            label7.Name = "label7";
            label7.Size = new Size(196, 25);
            label7.TabIndex = 8;
            label7.Text = "Se inscribio en el curso:";
            // 
            // lblAlumno
            // 
            lblAlumno.AutoSize = true;
            lblAlumno.Location = new Point(37, 37);
            lblAlumno.Name = "lblAlumno";
            lblAlumno.Size = new Size(78, 25);
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