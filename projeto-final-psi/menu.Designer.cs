namespace projeto_final_psi
{
    partial class menu
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
            panelTopo = new Panel();
            labelLogo = new Label();
            labelUtilizador = new Label();
            labelOla = new Label();
            labelResumo = new Label();
            buttonBiblioteca = new Button();
            buttonPerfil = new Button();
            buttonTerminarSessao = new Button();
            labelRodape = new Label();
            panelTopo.SuspendLayout();
            SuspendLayout();
            //
            // panelTopo
            //
            panelTopo.BackColor = Color.FromArgb(23, 26, 33);
            panelTopo.Controls.Add(labelLogo);
            panelTopo.Controls.Add(labelUtilizador);
            panelTopo.Dock = DockStyle.Top;
            panelTopo.Location = new Point(0, 0);
            panelTopo.Name = "panelTopo";
            panelTopo.Size = new Size(1080, 64);
            panelTopo.TabIndex = 0;
            //
            // labelLogo
            //
            labelLogo.AutoSize = true;
            labelLogo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLogo.ForeColor = Color.FromArgb(103, 193, 245);
            labelLogo.Location = new Point(30, 14);
            labelLogo.Name = "labelLogo";
            labelLogo.Size = new Size(140, 32);
            labelLogo.TabIndex = 0;
            labelLogo.Text = "PSI GAMES";
            //
            // labelUtilizador
            //
            labelUtilizador.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelUtilizador.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUtilizador.ForeColor = Color.FromArgb(198, 212, 223);
            labelUtilizador.Location = new Point(700, 20);
            labelUtilizador.Name = "labelUtilizador";
            labelUtilizador.Size = new Size(350, 25);
            labelUtilizador.TabIndex = 1;
            labelUtilizador.Text = "Utilizador";
            labelUtilizador.TextAlign = ContentAlignment.MiddleRight;
            //
            // labelOla
            //
            labelOla.AutoSize = true;
            labelOla.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelOla.ForeColor = Color.White;
            labelOla.Location = new Point(60, 100);
            labelOla.Name = "labelOla";
            labelOla.Size = new Size(120, 45);
            labelOla.TabIndex = 1;
            labelOla.Text = "Olá!";
            //
            // labelResumo
            //
            labelResumo.AutoSize = true;
            labelResumo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelResumo.ForeColor = Color.FromArgb(143, 152, 160);
            labelResumo.Location = new Point(64, 155);
            labelResumo.Name = "labelResumo";
            labelResumo.Size = new Size(200, 21);
            labelResumo.TabIndex = 2;
            labelResumo.Text = "O que queres fazer hoje?";
            //
            // buttonBiblioteca
            //
            buttonBiblioteca.BackColor = Color.FromArgb(46, 157, 207);
            buttonBiblioteca.FlatAppearance.BorderSize = 0;
            buttonBiblioteca.FlatAppearance.MouseOverBackColor = Color.FromArgb(103, 193, 245);
            buttonBiblioteca.FlatStyle = FlatStyle.Flat;
            buttonBiblioteca.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBiblioteca.ForeColor = Color.White;
            buttonBiblioteca.Location = new Point(60, 220);
            buttonBiblioteca.Name = "buttonBiblioteca";
            buttonBiblioteca.Size = new Size(300, 200);
            buttonBiblioteca.TabIndex = 3;
            buttonBiblioteca.Text = "🎮\r\nBiblioteca";
            buttonBiblioteca.UseVisualStyleBackColor = false;
            buttonBiblioteca.Click += buttonBiblioteca_Click;
            //
            // buttonPerfil
            //
            buttonPerfil.BackColor = Color.FromArgb(42, 71, 94);
            buttonPerfil.FlatAppearance.BorderSize = 0;
            buttonPerfil.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 95, 120);
            buttonPerfil.FlatStyle = FlatStyle.Flat;
            buttonPerfil.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPerfil.ForeColor = Color.White;
            buttonPerfil.Location = new Point(390, 220);
            buttonPerfil.Name = "buttonPerfil";
            buttonPerfil.Size = new Size(300, 200);
            buttonPerfil.TabIndex = 4;
            buttonPerfil.Text = "👤\r\nPerfil";
            buttonPerfil.UseVisualStyleBackColor = false;
            buttonPerfil.Click += buttonPerfil_Click;
            //
            // buttonTerminarSessao
            //
            buttonTerminarSessao.BackColor = Color.FromArgb(42, 47, 58);
            buttonTerminarSessao.FlatAppearance.BorderSize = 0;
            buttonTerminarSessao.FlatAppearance.MouseOverBackColor = Color.FromArgb(167, 33, 33);
            buttonTerminarSessao.FlatStyle = FlatStyle.Flat;
            buttonTerminarSessao.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonTerminarSessao.ForeColor = Color.White;
            buttonTerminarSessao.Location = new Point(720, 220);
            buttonTerminarSessao.Name = "buttonTerminarSessao";
            buttonTerminarSessao.Size = new Size(300, 200);
            buttonTerminarSessao.TabIndex = 5;
            buttonTerminarSessao.Text = "⏻\r\nTerminar sessão";
            buttonTerminarSessao.UseVisualStyleBackColor = false;
            buttonTerminarSessao.Click += buttonTerminarSessao_Click;
            //
            // labelRodape
            //
            labelRodape.AutoSize = true;
            labelRodape.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelRodape.ForeColor = Color.FromArgb(100, 110, 120);
            labelRodape.Location = new Point(60, 530);
            labelRodape.Name = "labelRodape";
            labelRodape.Size = new Size(160, 15);
            labelRodape.TabIndex = 6;
            labelRodape.Text = "Projeto Final PSI";
            //
            // menu
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 40, 56);
            ClientSize = new Size(1080, 573);
            Controls.Add(labelRodape);
            Controls.Add(buttonTerminarSessao);
            Controls.Add(buttonPerfil);
            Controls.Add(buttonBiblioteca);
            Controls.Add(labelResumo);
            Controls.Add(labelOla);
            Controls.Add(panelTopo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Load += menu_Load;
            panelTopo.ResumeLayout(false);
            panelTopo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTopo;
        private Label labelLogo;
        private Label labelUtilizador;
        private Label labelOla;
        private Label labelResumo;
        private Button buttonBiblioteca;
        private Button buttonPerfil;
        private Button buttonTerminarSessao;
        private Label labelRodape;
    }
}
