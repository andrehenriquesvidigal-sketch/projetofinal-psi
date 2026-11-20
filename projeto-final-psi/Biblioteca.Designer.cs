namespace projeto_final_psi
{
    partial class Biblioteca
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
            labelBemVindo = new Label();
            listBoxJogos = new ListBox();
            buttonSair = new Button();
            buttonPerfil = new Button();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.ForeColor = Color.FromArgb(103, 193, 245);
            labelTitulo.Location = new Point(60, 40);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(267, 37);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Biblioteca de Jogos";
            // 
            // labelBemVindo
            // 
            labelBemVindo.AutoSize = true;
            labelBemVindo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelBemVindo.ForeColor = Color.FromArgb(198, 212, 223);
            labelBemVindo.Location = new Point(63, 85);
            labelBemVindo.Name = "labelBemVindo";
            labelBemVindo.Size = new Size(76, 19);
            labelBemVindo.TabIndex = 1;
            labelBemVindo.Text = "Bem-vindo";
            // 
            // listBoxJogos
            // 
            listBoxJogos.BackColor = Color.FromArgb(42, 71, 94);
            listBoxJogos.BorderStyle = BorderStyle.FixedSingle;
            listBoxJogos.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxJogos.ForeColor = Color.White;
            listBoxJogos.FormattingEnabled = true;
            listBoxJogos.Location = new Point(60, 130);
            listBoxJogos.Name = "listBoxJogos";
            listBoxJogos.Size = new Size(960, 342);
            listBoxJogos.TabIndex = 2;
            listBoxJogos.SelectedIndexChanged += listBoxJogos_SelectedIndexChanged;
            // 
            // buttonSair
            // 
            buttonSair.BackColor = Color.FromArgb(167, 33, 33);
            buttonSair.FlatAppearance.BorderSize = 0;
            buttonSair.FlatAppearance.MouseOverBackColor = Color.FromArgb(200, 50, 50);
            buttonSair.FlatStyle = FlatStyle.Flat;
            buttonSair.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSair.ForeColor = Color.White;
            buttonSair.Location = new Point(60, 505);
            buttonSair.Name = "buttonSair";
            buttonSair.Size = new Size(140, 40);
            buttonSair.TabIndex = 3;
            buttonSair.Text = "Sair";
            buttonSair.UseVisualStyleBackColor = false;
            buttonSair.Click += buttonSair_Click;
            //
            // buttonPerfil
            //
            buttonPerfil.BackColor = Color.FromArgb(60, 75, 90);
            buttonPerfil.FlatAppearance.BorderSize = 0;
            buttonPerfil.FlatAppearance.MouseOverBackColor = Color.FromArgb(103, 193, 245);
            buttonPerfil.FlatStyle = FlatStyle.Flat;
            buttonPerfil.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPerfil.ForeColor = Color.White;
            buttonPerfil.Location = new Point(220, 505);
            buttonPerfil.Name = "buttonPerfil";
            buttonPerfil.Size = new Size(140, 40);
            buttonPerfil.TabIndex = 4;
            buttonPerfil.Text = "Perfil";
            buttonPerfil.UseVisualStyleBackColor = false;
            buttonPerfil.Click += buttonPerfil_Click;
            //
            // Biblioteca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 40, 56);
            ClientSize = new Size(1080, 573);
            Controls.Add(labelTitulo);
            Controls.Add(labelBemVindo);
            Controls.Add(listBoxJogos);
            Controls.Add(buttonSair);
            Controls.Add(buttonPerfil);
            Name = "Biblioteca";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Biblioteca de Jogos";
            Load += Biblioteca_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private Label labelBemVindo;
        private ListBox listBoxJogos;
        private Button buttonSair;
        private Button buttonPerfil;
    }
}
