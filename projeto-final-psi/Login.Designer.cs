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
            button1 = new Button();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(434, 80);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(110, 46);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Login";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEmail.Location = new Point(406, 200);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(82, 31);
            labelEmail.TabIndex = 1;
            labelEmail.Text = "E-mail";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(406, 253);
            textBoxEmail.Margin = new Padding(3, 4, 3, 4);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(342, 27);
            textBoxEmail.TabIndex = 2;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPassword.Location = new Point(406, 320);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(114, 31);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Password";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(406, 373);
            textBoxPassword.Margin = new Padding(3, 4, 3, 4);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(342, 27);
            textBoxPassword.TabIndex = 4;
            // 
            // buttonEntrar
            // 
            buttonEntrar.BackColor = SystemColors.Highlight;
            buttonEntrar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEntrar.Location = new Point(491, 453);
            buttonEntrar.Margin = new Padding(3, 4, 3, 4);
            buttonEntrar.Name = "buttonEntrar";
            buttonEntrar.Size = new Size(171, 67);
            buttonEntrar.TabIndex = 5;
            buttonEntrar.Text = "Entrar";
            buttonEntrar.UseVisualStyleBackColor = false;
            buttonEntrar.Click += buttonEntrar_Click;
            // 
            // linkLabelCriarConta
            // 
            linkLabelCriarConta.AutoSize = true;
            linkLabelCriarConta.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabelCriarConta.Location = new Point(446, 560);
            linkLabelCriarConta.Name = "linkLabelCriarConta";
            linkLabelCriarConta.Size = new Size(222, 23);
            linkLabelCriarConta.TabIndex = 6;
            linkLabelCriarConta.TabStop = true;
            linkLabelCriarConta.Text = "Não tem conta? Criar conta";
            linkLabelCriarConta.LinkClicked += linkLabelCriarConta_LinkClicked;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(153, 62);
            button1.TabIndex = 7;
            button1.Text = "Voltar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1206, 764);
            Controls.Add(button1);
            Controls.Add(labelTitulo);
            Controls.Add(labelEmail);
            Controls.Add(textBoxEmail);
            Controls.Add(labelPassword);
            Controls.Add(textBoxPassword);
            Controls.Add(buttonEntrar);
            Controls.Add(linkLabelCriarConta);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            Text = "Login";
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
        private Button button1;
    }
}