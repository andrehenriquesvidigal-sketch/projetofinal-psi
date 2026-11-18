namespace projeto_final_psi
{
    partial class Perfil
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
            pictureBoxFoto = new PictureBox();
            buttonAlterarFoto = new Button();
            labelNome = new Label();
            labelEmail = new Label();
            labelSexo = new Label();
            labelDataNascimento = new Label();
            buttonVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFoto).BeginInit();
            SuspendLayout();
            //
            // labelTitulo
            //
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.ForeColor = Color.FromArgb(103, 193, 245);
            labelTitulo.Location = new Point(60, 40);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(130, 37);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Perfil";
            //
            // pictureBoxFoto
            //
            pictureBoxFoto.BackColor = Color.FromArgb(60, 75, 90);
            pictureBoxFoto.Location = new Point(60, 110);
            pictureBoxFoto.Name = "pictureBoxFoto";
            pictureBoxFoto.Size = new Size(160, 160);
            pictureBoxFoto.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxFoto.TabIndex = 1;
            pictureBoxFoto.TabStop = false;
            pictureBoxFoto.Paint += pictureBoxFoto_Paint;
            pictureBoxFoto.Resize += pictureBoxFoto_Resize;
            //
            // buttonAlterarFoto
            //
            buttonAlterarFoto.BackColor = Color.FromArgb(46, 157, 207);
            buttonAlterarFoto.FlatAppearance.BorderSize = 0;
            buttonAlterarFoto.FlatAppearance.MouseOverBackColor = Color.FromArgb(103, 193, 245);
            buttonAlterarFoto.FlatStyle = FlatStyle.Flat;
            buttonAlterarFoto.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAlterarFoto.ForeColor = Color.White;
            buttonAlterarFoto.Location = new Point(60, 285);
            buttonAlterarFoto.Name = "buttonAlterarFoto";
            buttonAlterarFoto.Size = new Size(160, 36);
            buttonAlterarFoto.TabIndex = 2;
            buttonAlterarFoto.Text = "Alterar foto";
            buttonAlterarFoto.UseVisualStyleBackColor = false;
            buttonAlterarFoto.Click += buttonAlterarFoto_Click;
            //
            // labelNome
            //
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNome.ForeColor = Color.FromArgb(198, 212, 223);
            labelNome.Location = new Point(280, 115);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(97, 25);
            labelNome.TabIndex = 3;
            labelNome.Text = "Nome: ";
            //
            // labelEmail
            //
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEmail.ForeColor = Color.FromArgb(198, 212, 223);
            labelEmail.Location = new Point(280, 155);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(97, 25);
            labelEmail.TabIndex = 4;
            labelEmail.Text = "E-mail: ";
            //
            // labelSexo
            //
            labelSexo.AutoSize = true;
            labelSexo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSexo.ForeColor = Color.FromArgb(198, 212, 223);
            labelSexo.Location = new Point(280, 195);
            labelSexo.Name = "labelSexo";
            labelSexo.Size = new Size(97, 25);
            labelSexo.TabIndex = 5;
            labelSexo.Text = "Sexo: ";
            //
            // labelDataNascimento
            //
            labelDataNascimento.AutoSize = true;
            labelDataNascimento.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDataNascimento.ForeColor = Color.FromArgb(198, 212, 223);
            labelDataNascimento.Location = new Point(280, 235);
            labelDataNascimento.Name = "labelDataNascimento";
            labelDataNascimento.Size = new Size(97, 25);
            labelDataNascimento.TabIndex = 6;
            labelDataNascimento.Text = "Nascimento: ";
            //
            // buttonVoltar
            //
            buttonVoltar.BackColor = Color.FromArgb(60, 75, 90);
            buttonVoltar.FlatAppearance.BorderSize = 0;
            buttonVoltar.FlatAppearance.MouseOverBackColor = Color.FromArgb(103, 193, 245);
            buttonVoltar.FlatStyle = FlatStyle.Flat;
            buttonVoltar.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonVoltar.ForeColor = Color.White;
            buttonVoltar.Location = new Point(60, 505);
            buttonVoltar.Name = "buttonVoltar";
            buttonVoltar.Size = new Size(140, 40);
            buttonVoltar.TabIndex = 7;
            buttonVoltar.Text = "Voltar";
            buttonVoltar.UseVisualStyleBackColor = false;
            buttonVoltar.Click += buttonVoltar_Click;
            //
            // Perfil
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 40, 56);
            ClientSize = new Size(1080, 573);
            Controls.Add(labelTitulo);
            Controls.Add(pictureBoxFoto);
            Controls.Add(buttonAlterarFoto);
            Controls.Add(labelNome);
            Controls.Add(labelEmail);
            Controls.Add(labelSexo);
            Controls.Add(labelDataNascimento);
            Controls.Add(buttonVoltar);
            Name = "Perfil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Perfil";
            Load += Perfil_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private PictureBox pictureBoxFoto;
        private Button buttonAlterarFoto;
        private Label labelNome;
        private Label labelEmail;
        private Label labelSexo;
        private Label labelDataNascimento;
        private Button buttonVoltar;
    }
}
