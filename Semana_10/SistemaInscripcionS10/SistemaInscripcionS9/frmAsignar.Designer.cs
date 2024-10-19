namespace SistemaInscripcionS10
{
    partial class frmAsignar
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
            dtgvCurso = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Curso = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Docente = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            label1 = new Label();
            btnVolverAsignar = new Button();
            label2 = new Label();
            btnAsignar = new Button();
            txtNumLegajo = new TextBox();
            label3 = new Label();
            txtIdCurso = new TextBox();
            label4 = new Label();
            btnLimpiarAsignacion = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvCurso).BeginInit();
            SuspendLayout();
            // 
            // dtgvCurso
            // 
            dtgvCurso.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvCurso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCurso.Columns.AddRange(new DataGridViewColumn[] { ID, Curso, Fecha, Docente, Precio });
            dtgvCurso.Location = new Point(37, 138);
            dtgvCurso.Name = "dtgvCurso";
            dtgvCurso.RowHeadersWidth = 50;
            dtgvCurso.RowTemplate.Height = 33;
            dtgvCurso.Size = new Size(722, 211);
            dtgvCurso.TabIndex = 0;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // Curso
            // 
            Curso.HeaderText = "CURSO";
            Curso.MinimumWidth = 6;
            Curso.Name = "Curso";
            // 
            // Fecha
            // 
            Fecha.HeaderText = "FECHA";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            // 
            // Docente
            // 
            Docente.HeaderText = "DOCENTE";
            Docente.MinimumWidth = 6;
            Docente.Name = "Docente";
            // 
            // Precio
            // 
            Precio.HeaderText = "PRECIO ($)";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(226, 64);
            label1.Name = "label1";
            label1.Size = new Size(348, 35);
            label1.TabIndex = 1;
            label1.Text = "LISTA DE CURSOS VIGENTES";
            // 
            // btnVolverAsignar
            // 
            btnVolverAsignar.Font = new Font("Futura Md BT", 12F, FontStyle.Italic, GraphicsUnit.Point);
            btnVolverAsignar.Location = new Point(640, 25);
            btnVolverAsignar.Name = "btnVolverAsignar";
            btnVolverAsignar.Size = new Size(131, 47);
            btnVolverAsignar.TabIndex = 2;
            btnVolverAsignar.Text = "Volver";
            btnVolverAsignar.UseVisualStyleBackColor = true;
            btnVolverAsignar.Click += btnVolverAsignar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(37, 447);
            label2.Name = "label2";
            label2.Size = new Size(182, 28);
            label2.TabIndex = 3;
            label2.Text = "Número de legajo";
            // 
            // btnAsignar
            // 
            btnAsignar.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnAsignar.Location = new Point(530, 430);
            btnAsignar.Name = "btnAsignar";
            btnAsignar.Size = new Size(196, 51);
            btnAsignar.TabIndex = 4;
            btnAsignar.Text = "ASIGNAR";
            btnAsignar.UseVisualStyleBackColor = true;
            btnAsignar.Click += btnAsignar_Click;
            // 
            // txtNumLegajo
            // 
            txtNumLegajo.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumLegajo.Location = new Point(37, 486);
            txtNumLegajo.Name = "txtNumLegajo";
            txtNumLegajo.Size = new Size(182, 36);
            txtNumLegajo.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(271, 447);
            label3.Name = "label3";
            label3.Size = new Size(127, 28);
            label3.TabIndex = 6;
            label3.Text = "ID del Curso";
            // 
            // txtIdCurso
            // 
            txtIdCurso.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdCurso.Location = new Point(271, 486);
            txtIdCurso.Name = "txtIdCurso";
            txtIdCurso.Size = new Size(182, 36);
            txtIdCurso.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(212, 369);
            label4.Name = "label4";
            label4.Size = new Size(316, 35);
            label4.TabIndex = 8;
            label4.Text = "ASIGNACIÓN DE CURSOS";
            // 
            // btnLimpiarAsignacion
            // 
            btnLimpiarAsignacion.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiarAsignacion.Location = new Point(530, 500);
            btnLimpiarAsignacion.Name = "btnLimpiarAsignacion";
            btnLimpiarAsignacion.Size = new Size(196, 51);
            btnLimpiarAsignacion.TabIndex = 9;
            btnLimpiarAsignacion.Text = "LIMPIAR";
            btnLimpiarAsignacion.UseVisualStyleBackColor = true;
            btnLimpiarAsignacion.Click += btnLimpiarAsignacion_Click;
            // 
            // frmAsignar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 587);
            Controls.Add(btnLimpiarAsignacion);
            Controls.Add(label4);
            Controls.Add(txtIdCurso);
            Controls.Add(label3);
            Controls.Add(txtNumLegajo);
            Controls.Add(btnAsignar);
            Controls.Add(label2);
            Controls.Add(btnVolverAsignar);
            Controls.Add(label1);
            Controls.Add(dtgvCurso);
            Name = "frmAsignar";
            Text = "frmAsignar";
            Load += frmAsignar_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvCurso).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgvCurso;
        private Label label1;
        private Button btnVolverAsignar;
        private Label label2;
        private Button btnAsignar;
        private TextBox txtNumLegajo;
        private Label label3;
        private TextBox txtIdCurso;
        private Label label4;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Curso;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Docente;
        private DataGridViewTextBoxColumn Precio;
        private Button btnLimpiarAsignacion;
    }
}