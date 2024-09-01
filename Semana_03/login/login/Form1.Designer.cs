namespace login
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
            lblTitulo = new Label();
            pictureBox1 = new PictureBox();
            btnIngresar = new Button();
            txtUsuario = new TextBox();
            txtPass = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(330, 78);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(131, 24);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Diseño de login";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.users;
            pictureBox1.Location = new Point(58, 122);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(238, 231);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(435, 294);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(222, 64);
            btnIngresar.TabIndex = 2;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = true;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(368, 147);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(341, 31);
            txtUsuario.TabIndex = 3;
            txtUsuario.Text = "USUARIO";
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(368, 221);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(341, 31);
            txtPass.TabIndex = 4;
            txtPass.Text = "CONTRASEÑA";
            txtPass.Enter += txtPass_Enter;
            txtPass.Leave += txtPass_Leave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPass);
            Controls.Add(txtUsuario);
            Controls.Add(btnIngresar);
            Controls.Add(pictureBox1);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private PictureBox pictureBox1;
        private Button btnIngresar;
        private TextBox txtUsuario;
        private TextBox txtPass;
    }
}
