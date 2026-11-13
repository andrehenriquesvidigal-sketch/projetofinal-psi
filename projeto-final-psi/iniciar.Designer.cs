namespace projeto_final_psi
{
    partial class iniciar
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
            labelSubtitulo = new Label();
            buttonEntrar = new Button();
            buttonCriarConta = new Button();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(300, 120);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(292, 47);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Projeto Final PSI";
            // 
            // labelSubtitulo
            // 
            labelSubtitulo.AutoSize = true;
            labelSubtitulo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSubtitulo.Location = new Point(355, 190);
            labelSubtitulo.Name = "labelSubtitulo";
            labelSubtitulo.Size = new Size(230, 21);
            labelSubtitulo.TabIndex = 1;
            labelSubtitulo.Text = "Bem-vindo! O que deseja fazer?";
            // 
            // buttonEntrar
            // 
            buttonEntrar.BackColor = SystemColors.Highlight;
            buttonEntrar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEntrar.Location = new Point(355, 260);
            buttonEntrar.Name = "buttonEntrar";
            buttonEntrar.Size = new Size(300, 50);
            buttonEntrar.TabIndex = 2;
            buttonEntrar.Text = "Entrar";
            buttonEntrar.UseVisualStyleBackColor = false;
            buttonEntrar.Click += buttonEntrar_Click;
            // 
            // buttonCriarConta
            // 
            buttonCriarConta.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCriarConta.Location = new Point(355, 330);
            buttonCriarConta.Name = "buttonCriarConta";
            buttonCriarConta.Size = new Size(300, 50);
            buttonCriarConta.TabIndex = 3;
            buttonCriarConta.Text = "Criar Conta";
            buttonCriarConta.UseVisualStyleBackColor = true;
            buttonCriarConta.Click += buttonCriarConta_Click;
            // 
            // iniciar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 573);
            Controls.Add(labelTitulo);
            Controls.Add(labelSubtitulo);
            Controls.Add(buttonEntrar);
            Controls.Add(buttonCriarConta);
            Name = "iniciar";
            Text = "Projeto Final PSI";
            Load += iniciar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private Label labelSubtitulo;
        private Button buttonEntrar;
        private Button buttonCriarConta;
    }
}
