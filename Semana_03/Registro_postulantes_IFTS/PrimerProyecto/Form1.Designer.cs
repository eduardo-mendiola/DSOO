namespace PrimerProyecto
{
    partial class frmPrincipal
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
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.BackColor = Color.FromArgb(224, 224, 224);
            lblNombre.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(53, 55);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(111, 25);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            lblNombre.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblDocumento
            // 
            lblDocumento.AutoSize = true;
            lblDocumento.BackColor = Color.FromArgb(224, 224, 224);
            lblDocumento.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblDocumento.Location = new Point(328, 215);
            lblDocumento.Name = "lblDocumento";
            lblDocumento.Size = new Size(111, 25);
            lblDocumento.TabIndex = 1;
            lblDocumento.Text = "Documento";
            // 
            // lblApellido
            // 
            lblApellido.BackColor = Color.FromArgb(224, 224, 224);
            lblApellido.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellido.Location = new Point(53, 147);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(111, 25);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido";
            lblApellido.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(234, 56);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(205, 31);
            txtNombre.TabIndex = 3;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(234, 147);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(205, 31);
            txtApellido.TabIndex = 4;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(462, 212);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(205, 31);
            txtDocumento.TabIndex = 5;
            // 
            // btnIngresar
            // 
            btnIngresar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.Location = new Point(497, 56);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(170, 52);
            btnIngresar.TabIndex = 6;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.Location = new Point(497, 126);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(170, 52);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.BackColor = Color.FromArgb(224, 224, 224);
            lblTipo.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTipo.Location = new Point(53, 218);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(50, 25);
            lblTipo.TabIndex = 8;
            lblTipo.Text = "Tipo";
            // 
            // cboComboBoxTipo
            // 
            cboComboBoxTipo.FormattingEnabled = true;
            cboComboBoxTipo.Items.AddRange(new object[] { "DNI", "PASAPORTE", "EXTRANJERO" });
            cboComboBoxTipo.Location = new Point(138, 214);
            cboComboBoxTipo.Name = "cboComboBoxTipo";
            cboComboBoxTipo.Size = new Size(150, 33);
            cboComboBoxTipo.TabIndex = 9;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(708, 291);
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
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PRIMAR PROYECTO";
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
    }
}
