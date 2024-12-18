﻿namespace SistemaInscripcionS10
{
    partial class frmInscripcion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInscripcion));
            lblNombre = new Label();
            lblDocumento = new Label();
            lblApellido = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDocumento = new TextBox();
            btnIngresar = new Button();
            btnLimpiar = new Button();
            lblTipo = new Label();
            cboTipo = new ComboBox();
            pictureBox1 = new PictureBox();
            lblInscripcion = new Label();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.Font = new Font("Futura Md BT", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(436, 123);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(111, 25);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            lblNombre.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.Font = new Font("Futura Md BT", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDocumento.Location = new Point(639, 298);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(122, 24);
            lblDocumento.TabIndex = 1;
            lblDocumento.Text = "Documento";
            // 
            // lblApellido
            // 
            lblApellido.Font = new Font("Futura Md BT", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellido.Location = new Point(436, 208);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(111, 25);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido";
            lblApellido.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(555, 120);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(354, 36);
            txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new Point(555, 205);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(354, 36);
            txtApellido.TabIndex = 1;
            // 
            // txtDocumento
            // 
            txtDocumento.Font = new Font("Futura Md BT", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtDocumento.Location = new Point(770, 294);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(220, 33);
            txtDocumento.TabIndex = 3;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.White;
            btnIngresar.Font = new Font("Futura Md BT", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.Location = new Point(391, 367);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(170, 52);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.White;
            btnLimpiar.Font = new Font("Futura Md BT", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(617, 367);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(170, 52);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Futura Md BT", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTipo.Location = new Point(391, 297);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(52, 24);
            lblTipo.TabIndex = 8;
            lblTipo.Text = "Tipo";
            // 
            // cboTipo
            // 
            cboTipo.Font = new Font("Futura Md BT", 13F, FontStyle.Regular, GraphicsUnit.Point);
            cboTipo.FormattingEnabled = true;
            cboTipo.Items.AddRange(new object[] { "DNI", "PASAPORTE", "EXTRANJERO" });
            cboTipo.Location = new Point(462, 292);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(150, 34);
            cboTipo.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(370, 427);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // lblInscripcion
            // 
            lblInscripcion.AutoSize = true;
            lblInscripcion.Font = new Font("Futura Md BT", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblInscripcion.ForeColor = Color.Peru;
            lblInscripcion.Location = new Point(483, 38);
            lblInscripcion.Name = "lblInscripcion";
            lblInscripcion.Size = new Size(427, 32);
            lblInscripcion.TabIndex = 11;
            lblInscripcion.Text = "INSCRIPCIÓN DE POSTULANTE";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.White;
            btnVolver.Font = new Font("Futura Md BT", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Location = new Point(835, 367);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(170, 52);
            btnVolver.TabIndex = 6;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // frmInscripcion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(1022, 431);
            Controls.Add(btnVolver);
            Controls.Add(lblInscripcion);
            Controls.Add(pictureBox1);
            Controls.Add(cboTipo);
            Controls.Add(lblTipo);
            Controls.Add(btnLimpiar);
            Controls.Add(btnIngresar);
            Controls.Add(txtDocumento);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblApellido);
            Controls.Add(lblDocumento);
            Controls.Add(lblNombre);
            Name = "frmInscripcion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "INSCRIPCIÓN DE POSTULANTE";
            Load += frmInscripcion_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblDocumento;
        private Label lblApellido;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDocumento;
        private Button btnIngresar;
        private Button btnLimpiar;
        private Label lblTipo;
        private ComboBox cboTipo;
        private PictureBox pictureBox1;
        private Label lblInscripcion;
        private Button btnVolver;
    }
}
