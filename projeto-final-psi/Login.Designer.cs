namespace projeto_final_psi
{
    partial class Login
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
            labelTitulo = new Label();
            labelEmail = new Label();
            textBoxEmail = new TextBox();
            labelPassword = new Label();
            textBoxPassword = new TextBox();
            buttonEntrar = new Button();
            linkLabelCriarConta = new LinkLabel();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.ForeColor = Color.FromArgb(103, 193, 245);
            labelTitulo.Location = new Point(380, 60);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(89, 37);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Login";
            //
            // labelEmail
            //
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEmail.ForeColor = Color.FromArgb(198, 212, 223);
            labelEmail.Location = new Point(355, 150);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(67, 25);
            labelEmail.TabIndex = 1;
            labelEmail.Text = "E-mail";
            //
            // textBoxEmail
            //
            textBoxEmail.BackColor = Color.FromArgb(60, 75, 90);
            textBoxEmail.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmail.ForeColor = Color.White;
            textBoxEmail.Location = new Point(355, 190);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(300, 23);
            textBoxEmail.TabIndex = 2;
            //
            // labelPassword
            //
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPassword.ForeColor = Color.FromArgb(198, 212, 223);
            labelPassword.Location = new Point(355, 240);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(97, 25);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Password";
            //
            // textBoxPassword
            //
            textBoxPassword.BackColor = Color.FromArgb(60, 75, 90);
            textBoxPassword.BorderStyle = BorderStyle.FixedSingle;
            textBoxPassword.ForeColor = Color.White;
            textBoxPassword.Location = new Point(355, 280);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(300, 23);
            textBoxPassword.TabIndex = 4;
            //
            // buttonEntrar
            //
            buttonEntrar.BackColor = Color.FromArgb(46, 157, 207);
            buttonEntrar.FlatAppearance.BorderSize = 0;
            buttonEntrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(103, 193, 245);
            buttonEntrar.FlatStyle = FlatStyle.Flat;
            buttonEntrar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEntrar.ForeColor = Color.White;
            buttonEntrar.Location = new Point(430, 340);
            buttonEntrar.Name = "buttonEntrar";
            buttonEntrar.Size = new Size(150, 50);
            buttonEntrar.TabIndex = 5;
            buttonEntrar.Text = "Entrar";
            buttonEntrar.UseVisualStyleBackColor = false;
            buttonEntrar.Click += buttonEntrar_Click;
            //
            // linkLabelCriarConta
            //
            linkLabelCriarConta.AutoSize = true;
            linkLabelCriarConta.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabelCriarConta.LinkColor = Color.FromArgb(102, 192, 244);
            linkLabelCriarConta.Location = new Point(390, 420);
            linkLabelCriarConta.Name = "linkLabelCriarConta";
            linkLabelCriarConta.Size = new Size(177, 19);
            linkLabelCriarConta.TabIndex = 6;
            linkLabelCriarConta.TabStop = true;
            linkLabelCriarConta.Text = "Não tem conta? Criar conta";
            linkLabelCriarConta.VisitedLinkColor = Color.FromArgb(102, 192, 244);
            linkLabelCriarConta.LinkClicked += linkLabelCriarConta_LinkClicked;
            //
            // Login
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 40, 56);
            ClientSize = new Size(1055, 573);
            Controls.Add(labelTitulo);
            Controls.Add(labelEmail);
            Controls.Add(textBoxEmail);
            Controls.Add(labelPassword);
            Controls.Add(textBoxPassword);
            Controls.Add(buttonEntrar);
            Controls.Add(linkLabelCriarConta);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private Label labelEmail;
        private TextBox textBoxEmail;
        private Label labelPassword;
        private TextBox textBoxPassword;
        private Button buttonEntrar;
        private LinkLabel linkLabelCriarConta;
    }
}