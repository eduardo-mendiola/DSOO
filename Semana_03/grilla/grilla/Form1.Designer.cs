﻿namespace grilla
{
    partial class Form1
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            lblCodigo = new Label();
            lblNombre = new Label();
            lblCantidad = new Label();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            txtCantidad = new TextBox();
            btnCarga = new Button();
            btnBorrar = new Button();
            dtgvDatos = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgvDatos).BeginInit();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(82, 119);
            lblCodigo.Margin = new Padding(4, 0, 4, 0);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(220, 31);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código de producto";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(82, 212);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(230, 31);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre de producto";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(82, 300);
            lblCantidad.Margin = new Padding(4, 0, 4, 0);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(107, 31);
            lblCantidad.TabIndex = 2;
            lblCantidad.Text = "Cantidad";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(382, 112);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(125, 38);
            txtCodigo.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(382, 205);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(261, 38);
            txtNombre.TabIndex = 4;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(382, 293);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(125, 38);
            txtCantidad.TabIndex = 5;
            // 
            // btnCarga
            // 
            btnCarga.Location = new Point(728, 112);
            btnCarga.Name = "btnCarga";
            btnCarga.Size = new Size(244, 101);
            btnCarga.TabIndex = 6;
            btnCarga.Text = "Carga";
            btnCarga.UseVisualStyleBackColor = true;
            btnCarga.Click += btnCarga_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(728, 268);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(244, 101);
            btnBorrar.TabIndex = 7;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // dtgvDatos
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvDatos.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nombre, Cantidad });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dtgvDatos.DefaultCellStyle = dataGridViewCellStyle6;
            dtgvDatos.Location = new Point(82, 417);
            dtgvDatos.Name = "dtgvDatos";
            dtgvDatos.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dtgvDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dtgvDatos.RowHeadersWidth = 51;
            dtgvDatos.RowTemplate.Height = 33;
            dtgvDatos.Size = new Size(890, 188);
            dtgvDatos.TabIndex = 8;
            dtgvDatos.CellClick += dtgvDatos_CellClick;
            // 
            // Codigo
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Codigo.DefaultCellStyle = dataGridViewCellStyle3;
            Codigo.HeaderText = "Código de producto";
            Codigo.MinimumWidth = 6;
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            Codigo.Width = 150;
            // 
            // Nombre
            // 
            Nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Nombre.DefaultCellStyle = dataGridViewCellStyle4;
            Nombre.HeaderText = "Nombre de producto";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Cantidad.DefaultCellStyle = dataGridViewCellStyle5;
            Cantidad.HeaderText = "Cantidad Comprada";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 674);
            Controls.Add(dtgvDatos);
            Controls.Add(btnBorrar);
            Controls.Add(btnCarga);
            Controls.Add(txtCantidad);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Controls.Add(lblCantidad);
            Controls.Add(lblNombre);
            Controls.Add(lblCodigo);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Carga de datos en una grilla";
            ((System.ComponentModel.ISupportInitialize)dtgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private Label lblNombre;
        private Label lblCantidad;
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private TextBox txtCantidad;
        private Button btnCarga;
        private Button btnBorrar;
        private DataGridView dtgvDatos;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Cantidad;
    }
}
