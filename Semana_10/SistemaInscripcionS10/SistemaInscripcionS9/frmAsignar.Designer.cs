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
            label1 = new Label();
            btnVolverAsignar = new Button();
            Curso = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Docente = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgvCurso).BeginInit();
            SuspendLayout();
            // 
            // dtgvCurso
            // 
            dtgvCurso.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvCurso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCurso.Columns.AddRange(new DataGridViewColumn[] { Curso, Fecha, Docente, Precio });
            dtgvCurso.Location = new Point(41, 138);
            dtgvCurso.Name = "dtgvCurso";
            dtgvCurso.RowHeadersWidth = 50;
            dtgvCurso.RowTemplate.Height = 33;
            dtgvCurso.Size = new Size(718, 290);
            dtgvCurso.TabIndex = 0;
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
            // frmAsignar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
        private DataGridViewTextBoxColumn Curso;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Docente;
        private DataGridViewTextBoxColumn Precio;
    }
}