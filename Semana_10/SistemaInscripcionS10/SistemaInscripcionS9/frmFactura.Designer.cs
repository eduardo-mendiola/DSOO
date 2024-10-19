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
            pnlTitulo = new Panel();
            lblTitulo = new Label();
            btnImprimir = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pnlNombreInstitudo = new Panel();
            pnlDatosInstituto = new Panel();
            label5 = new Label();
            label4 = new Label();
            lblDFecha = new Label();
            pnlDatos = new Panel();
            lblValor = new Label();
            label13 = new Label();
            lblPago = new Label();
            label11 = new Label();
            lblDia = new Label();
            label9 = new Label();
            lblCurso = new Label();
            label7 = new Label();
            lblAlumno = new Label();
            pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlNombreInstitudo.SuspendLayout();
            pnlDatosInstituto.SuspendLayout();
            pnlDatos.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.Beige;
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.Location = new Point(12, 19);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(776, 78);
            pnlTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(234, 17);
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
            // pnlNombreInstitudo
            // 
            pnlNombreInstitudo.BackColor = Color.OldLace;
            pnlNombreInstitudo.Controls.Add(label1);
            pnlNombreInstitudo.Controls.Add(pictureBox1);
            pnlNombreInstitudo.Location = new Point(12, 113);
            pnlNombreInstitudo.Name = "pnlNombreInstitudo";
            pnlNombreInstitudo.Size = new Size(384, 112);
            pnlNombreInstitudo.TabIndex = 1;
            // 
            // pnlDatosInstituto
            // 
            pnlDatosInstituto.BackColor = Color.OldLace;
            pnlDatosInstituto.Controls.Add(label5);
            pnlDatosInstituto.Controls.Add(label4);
            pnlDatosInstituto.Controls.Add(lblDFecha);
            pnlDatosInstituto.Location = new Point(404, 113);
            pnlDatosInstituto.Name = "pnlDatosInstituto";
            pnlDatosInstituto.Size = new Size(384, 112);
            pnlDatosInstituto.TabIndex = 2;
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
            // pnlDatos
            // 
            pnlDatos.BackColor = Color.Beige;
            pnlDatos.Controls.Add(lblValor);
            pnlDatos.Controls.Add(label13);
            pnlDatos.Controls.Add(lblPago);
            pnlDatos.Controls.Add(label11);
            pnlDatos.Controls.Add(lblDia);
            pnlDatos.Controls.Add(label9);
            pnlDatos.Controls.Add(lblCurso);
            pnlDatos.Controls.Add(label7);
            pnlDatos.Controls.Add(lblAlumno);
            pnlDatos.Location = new Point(12, 242);
            pnlDatos.Name = "pnlDatos";
            pnlDatos.Size = new Size(776, 267);
            pnlDatos.TabIndex = 1;
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
            Controls.Add(pnlDatos);
            Controls.Add(pnlDatosInstituto);
            Controls.Add(pnlNombreInstitudo);
            Controls.Add(btnImprimir);
            Controls.Add(pnlTitulo);
            Name = "frmFactura";
            Text = "frmFactura";
            Load += frmFactura_Load;
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlNombreInstitudo.ResumeLayout(false);
            pnlNombreInstitudo.PerformLayout();
            pnlDatosInstituto.ResumeLayout(false);
            pnlDatosInstituto.PerformLayout();
            pnlDatos.ResumeLayout(false);
            pnlDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitulo;
        private Button btnImprimir;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel pnlNombreInstitudo;
        private Panel pnlDatosInstituto;
        private Panel pnlDatos;
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