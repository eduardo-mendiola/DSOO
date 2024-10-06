namespace DiseñoLoginS8
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
            lblNombre = new Label();
            lblDocumento = new Label();
            lblApellido = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDocumento = new TextBox();
            btnIngresar = new Button();
            btnLimpiar = new Button();
            lblTipo = new Label();
            cboComboBoxTipo = new ComboBox();
            dtgvPostulante = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            Documento = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgvPostulante).BeginInit();
            SuspendLayout();
            // 
            // lblNombre2
            // 
            lblNombre.BackColor = Color.FromArgb(224, 224, 224);
            lblNombre.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(53, 55);
            lblNombre.Name = "lblNombre2";
            lblNombre.Size = new Size(111, 25);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre2";
            lblNombre.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblDocumento2
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.BackColor = Color.FromArgb(224, 224, 224);
            lblDocumento.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblDocumento.Location = new Point(328, 215);
            lblDocumento.Name = "lblDocumento2";
            lblDocumento.Size = new Size(111, 25);
            lblDocumento.TabIndex = 1;
            lblDocumento.Text = "Documento2";
            // 
            // lblApellido2
            // 
            lblApellido.BackColor = Color.FromArgb(224, 224, 224);
            lblApellido.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellido.Location = new Point(53, 147);
            lblApellido.Name = "lblApellido2";
            lblApellido.Size = new Size(111, 25);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido2";
            lblApellido.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtNombre2
            // 
            txtNombre.Location = new Point(234, 56);
            txtNombre.Name = "txtNombre2";
            txtNombre.Size = new Size(205, 31);
            txtNombre.TabIndex = 3;
            // 
            // txtApellido2
            // 
            txtApellido.Location = new Point(234, 147);
            txtApellido.Name = "txtApellido2";
            txtApellido.Size = new Size(205, 31);
            txtApellido.TabIndex = 4;
            // 
            // txtDocumento2
            // 
            txtDocumento.Location = new Point(462, 212);
            txtDocumento.Name = "txtDocumento2";
            txtDocumento.Size = new Size(205, 31);
            txtDocumento.TabIndex = 5;
            // 
            // btnIngresar2
            // 
            btnIngresar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.Location = new Point(497, 56);
            btnIngresar.Name = "btnIngresar2";
            btnIngresar.Size = new Size(170, 52);
            btnIngresar.TabIndex = 6;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnLimpiar2
            // 
            btnLimpiar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(497, 126);
            btnLimpiar.Name = "btnLimpiar2";
            btnLimpiar.Size = new Size(170, 52);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblTipo2
            // 
            lblTipo.AutoSize = true;
            lblTipo.BackColor = Color.FromArgb(224, 224, 224);
            lblTipo.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTipo.Location = new Point(53, 218);
            lblTipo.Name = "lblTipo2";
            lblTipo.Size = new Size(50, 25);
            lblTipo.TabIndex = 8;
            lblTipo.Text = "Tipo2";
            // 
            // cboComboBoxTipo2
            // 
            cboComboBoxTipo.FormattingEnabled = true;
            cboComboBoxTipo.Items.AddRange(new object[] { "DNI", "PASAPORTE", "EXTRANJERO" });
            cboComboBoxTipo.Location = new Point(138, 214);
            cboComboBoxTipo.Name = "cboComboBoxTipo2";
            cboComboBoxTipo.Size = new Size(150, 33);
            cboComboBoxTipo.TabIndex = 9;
            // 
            // dtgvPostulante2
            // 
            dtgvPostulante.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvPostulante.Columns.AddRange(new DataGridViewColumn[] { Nombre, Apellido, Tipo, Documento });
            dtgvPostulante.Location = new Point(53, 303);
            dtgvPostulante.Name = "dtgvPostulante2";
            dtgvPostulante.RowHeadersWidth = 51;
            dtgvPostulante.RowTemplate.Height = 33;
            dtgvPostulante.Size = new Size(614, 188);
            dtgvPostulante.TabIndex = 10;
            // 
            // Nombre2
            // 
            Nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nombre.HeaderText = "Nombre2";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre2";
            // 
            // Apellido2
            // 
            Apellido.HeaderText = "Apellido2";
            Apellido.MinimumWidth = 6;
            Apellido.Name = "Apellido2";
            Apellido.Width = 125;
            // 
            // Tipo2
            // 
            Tipo.HeaderText = "Tipo2";
            Tipo.MinimumWidth = 6;
            Tipo.Name = "Tipo2";
            Tipo.Width = 125;
            // 
            // Documento2
            // 
            Documento.HeaderText = "Documento2";
            Documento.MinimumWidth = 6;
            Documento.Name = "Documento2";
            Documento.Width = 125;
            // 
            // frmInscripcion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(708, 522);
            Controls.Add(dtgvPostulante);
            Controls.Add(cboComboBoxTipo);
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
            Text = "PRIMER PROYECTO";
            ((System.ComponentModel.ISupportInitialize)dtgvPostulante).EndInit();
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
        private ComboBox cboComboBoxTipo;
        private DataGridView dtgvPostulante;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Documento;
    }
}
