namespace S2_Ingresando_Datos
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
            lblDato1 = new Label();
            lblDato2 = new Label();
            txtDato1 = new TextBox();
            txtDato2 = new TextBox();
            btnAceptar = new Button();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblDato1
            // 
            lblDato1.AutoSize = true;
            lblDato1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblDato1.Location = new Point(34, 80);
            lblDato1.Name = "lblDato1";
            lblDato1.Size = new Size(76, 25);
            lblDato1.TabIndex = 0;
            lblDato1.Text = "DATO 1";
            // 
            // lblDato2
            // 
            lblDato2.AutoSize = true;
            lblDato2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblDato2.Location = new Point(34, 155);
            lblDato2.Name = "lblDato2";
            lblDato2.Size = new Size(71, 25);
            lblDato2.TabIndex = 1;
            lblDato2.Text = "DATO2";
            // 
            // txtDato1
            // 
            txtDato1.Location = new Point(152, 80);
            txtDato1.Name = "txtDato1";
            txtDato1.Size = new Size(215, 31);
            txtDato1.TabIndex = 2;
            // 
            // txtDato2
            // 
            txtDato2.Location = new Point(152, 149);
            txtDato2.Name = "txtDato2";
            txtDato2.Size = new Size(215, 31);
            txtDato2.TabIndex = 3;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(181, 254);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(157, 50);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(181, 352);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(157, 50);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 450);
            Controls.Add(btnCalcular);
            Controls.Add(btnAceptar);
            Controls.Add(txtDato2);
            Controls.Add(txtDato1);
            Controls.Add(lblDato2);
            Controls.Add(lblDato1);
            Name = "Form1";
            Text = "INGRESO Y MUESTRA DE DATOS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDato1;
        private Label lblDato2;
        private TextBox txtDato1;
        private TextBox txtDato2;
        private Button btnAceptar;
        private Button btnCalcular;
    }
}
