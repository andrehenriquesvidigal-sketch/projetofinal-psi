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
            panelDetalhes = new Panel();
            pictureBoxCapa = new PictureBox();
            labelNomeJogo = new Label();
            labelGenero = new Label();
            labelDescricao = new Label();
            buttonJogar = new Button();
            buttonSair = new Button();
            buttonPerfil = new Button();
            panelDetalhes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCapa).BeginInit();
            SuspendLayout();
            //
            // labelTitulo
            //
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.ForeColor = Color.FromArgb(103, 193, 245);
            labelTitulo.Location = new Point(60, 30);
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
            labelBemVindo.Location = new Point(63, 75);
            labelBemVindo.Name = "labelBemVindo";
            labelBemVindo.Size = new Size(76, 19);
            labelBemVindo.TabIndex = 1;
            labelBemVindo.Text = "Bem-vindo";
            //
            // listBoxJogos
            //
            listBoxJogos.BackColor = Color.FromArgb(42, 71, 94);
            listBoxJogos.BorderStyle = BorderStyle.None;
            listBoxJogos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBoxJogos.ForeColor = Color.White;
            listBoxJogos.FormattingEnabled = true;
            listBoxJogos.Location = new Point(60, 115);
            listBoxJogos.Name = "listBoxJogos";
            listBoxJogos.Size = new Size(420, 370);
            listBoxJogos.TabIndex = 2;
            listBoxJogos.SelectedIndexChanged += listBoxJogos_SelectedIndexChanged;
            //
            // panelDetalhes
            //
            panelDetalhes.BackColor = Color.FromArgb(23, 26, 33);
            panelDetalhes.Controls.Add(pictureBoxCapa);
            panelDetalhes.Controls.Add(labelNomeJogo);
            panelDetalhes.Controls.Add(labelGenero);
            panelDetalhes.Controls.Add(labelDescricao);
            panelDetalhes.Controls.Add(buttonJogar);
            panelDetalhes.Location = new Point(510, 115);
            panelDetalhes.Name = "panelDetalhes";
            panelDetalhes.Size = new Size(510, 370);
            panelDetalhes.TabIndex = 3;
            //
            // pictureBoxCapa
            //
            pictureBoxCapa.BackColor = Color.FromArgb(42, 47, 58);
            pictureBoxCapa.Location = new Point(20, 20);
            pictureBoxCapa.Name = "pictureBoxCapa";
            pictureBoxCapa.Size = new Size(470, 160);
            pictureBoxCapa.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCapa.TabIndex = 0;
            pictureBoxCapa.TabStop = false;
            //
            // labelNomeJogo
            //
            labelNomeJogo.AutoSize = true;
            labelNomeJogo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNomeJogo.ForeColor = Color.White;
            labelNomeJogo.Location = new Point(18, 190);
            labelNomeJogo.Name = "labelNomeJogo";
            labelNomeJogo.Size = new Size(200, 30);
            labelNomeJogo.TabIndex = 1;
            labelNomeJogo.Text = "Seleciona um jogo";
            //
            // labelGenero
            //
            labelGenero.AutoSize = true;
            labelGenero.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelGenero.ForeColor = Color.FromArgb(103, 193, 245);
            labelGenero.Location = new Point(21, 222);
            labelGenero.Name = "labelGenero";
            labelGenero.Size = new Size(0, 19);
            labelGenero.TabIndex = 2;
            //
            // labelDescricao
            //
            labelDescricao.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDescricao.ForeColor = Color.FromArgb(198, 212, 223);
            labelDescricao.Location = new Point(21, 248);
            labelDescricao.Name = "labelDescricao";
            labelDescricao.Size = new Size(470, 60);
            labelDescricao.TabIndex = 3;
            //
            // buttonJogar
            //
            buttonJogar.BackColor = Color.FromArgb(91, 163, 30);
            buttonJogar.Enabled = false;
            buttonJogar.FlatAppearance.BorderSize = 0;
            buttonJogar.FlatAppearance.MouseOverBackColor = Color.FromArgb(117, 191, 54);
            buttonJogar.FlatStyle = FlatStyle.Flat;
            buttonJogar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonJogar.ForeColor = Color.White;
            buttonJogar.Location = new Point(20, 315);
            buttonJogar.Name = "buttonJogar";
            buttonJogar.Size = new Size(160, 40);
            buttonJogar.TabIndex = 4;
            buttonJogar.Text = "▶  JOGAR";
            buttonJogar.UseVisualStyleBackColor = false;
            buttonJogar.Click += buttonJogar_Click;
            //
            // buttonSair
            //
            buttonSair.BackColor = Color.FromArgb(60, 75, 90);
            buttonSair.FlatAppearance.BorderSize = 0;
            buttonSair.FlatAppearance.MouseOverBackColor = Color.FromArgb(103, 193, 245);
            buttonSair.FlatStyle = FlatStyle.Flat;
            buttonSair.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSair.ForeColor = Color.White;
            buttonSair.Location = new Point(60, 505);
            buttonSair.Name = "buttonSair";
            buttonSair.Size = new Size(140, 40);
            buttonSair.TabIndex = 4;
            buttonSair.Text = "← Menu";
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
            buttonPerfil.TabIndex = 5;
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
            Controls.Add(panelDetalhes);
            Controls.Add(buttonSair);
            Controls.Add(buttonPerfil);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Biblioteca";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Biblioteca de Jogos";
            Load += Biblioteca_Load;
            panelDetalhes.ResumeLayout(false);
            panelDetalhes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCapa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private Label labelBemVindo;
        private ListBox listBoxJogos;
        private Panel panelDetalhes;
        private PictureBox pictureBoxCapa;
        private Label labelNomeJogo;
        private Label labelGenero;
        private Label labelDescricao;
        private Button buttonJogar;
        private Button buttonSair;
        private Button buttonPerfil;
    }
}
