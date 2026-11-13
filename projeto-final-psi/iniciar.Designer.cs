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
            labelTitulo.Location = new Point(406, 162);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(191, 60);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Steam 2";
            // 
            // labelSubtitulo
            // 
            labelSubtitulo.AutoSize = true;
            labelSubtitulo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSubtitulo.Location = new Point(406, 253);
            labelSubtitulo.Name = "labelSubtitulo";
            labelSubtitulo.Size = new Size(288, 28);
            labelSubtitulo.TabIndex = 1;
            labelSubtitulo.Text = "Bem-vindo! O que deseja fazer?";
            // 
            // buttonEntrar
            // 
            buttonEntrar.BackColor = SystemColors.Highlight;
            buttonEntrar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEntrar.Location = new Point(406, 347);
            buttonEntrar.Margin = new Padding(3, 4, 3, 4);
            buttonEntrar.Name = "buttonEntrar";
            buttonEntrar.Size = new Size(343, 67);
            buttonEntrar.TabIndex = 2;
            buttonEntrar.Text = "Entrar";
            buttonEntrar.UseVisualStyleBackColor = false;
            buttonEntrar.Click += buttonEntrar_Click;
            // 
            // buttonCriarConta
            // 
            buttonCriarConta.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCriarConta.Location = new Point(406, 440);
            buttonCriarConta.Margin = new Padding(3, 4, 3, 4);
            buttonCriarConta.Name = "buttonCriarConta";
            buttonCriarConta.Size = new Size(343, 67);
            buttonCriarConta.TabIndex = 3;
            buttonCriarConta.Text = "Criar Conta";
            buttonCriarConta.UseVisualStyleBackColor = true;
            buttonCriarConta.Click += buttonCriarConta_Click;
            // 
            // iniciar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1206, 764);
            Controls.Add(labelTitulo);
            Controls.Add(labelSubtitulo);
            Controls.Add(buttonEntrar);
            Controls.Add(buttonCriarConta);
            Margin = new Padding(3, 4, 3, 4);
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
