using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace projeto_final_psi
{
    public partial class Perfil : Form
    {
        public Perfil()
        {
            InitializeComponent();
        }

        private void Perfil_Load(object sender, EventArgs e)
        {
            AtualizarRegiaoCircular();

            if (Globais.utilizadoratual >= 0)
            {
                Globais.Utilizador utilizador = Globais.utilizadores[Globais.utilizadoratual];
                labelNome.Text = "Nome: " + utilizador.nome;
                labelEmail.Text = "E-mail: " + utilizador.email;
                labelSexo.Text = "Sexo: " + utilizador.sexo;
                labelDataNascimento.Text = "Nascimento: " + utilizador.dataNascimento.ToShortDateString();

                if (!string.IsNullOrEmpty(utilizador.fotoCaminho) && File.Exists(utilizador.fotoCaminho))
                {
                    pictureBoxFoto.Image = Image.FromFile(utilizador.fotoCaminho);
                }
            }
        }

        private void AtualizarRegiaoCircular()
        {
            GraphicsPath caminho = new GraphicsPath();
            caminho.AddEllipse(0, 0, pictureBoxFoto.Width - 1, pictureBoxFoto.Height - 1);
            pictureBoxFoto.Region = new Region(caminho);
        }

        private void pictureBoxFoto_Resize(object sender, EventArgs e)
        {
            AtualizarRegiaoCircular();
        }

        private void pictureBoxFoto_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using Pen pen = new Pen(Color.FromArgb(103, 193, 245), 3);
            e.Graphics.DrawEllipse(pen, 1, 1, pictureBoxFoto.Width - 3, pictureBoxFoto.Height - 3);
        }

        private void buttonAlterarFoto_Click(object sender, EventArgs e)
        {
            using OpenFileDialog dialogo = new OpenFileDialog
            {
                Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp"
            };

            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                pictureBoxFoto.Image = Image.FromFile(dialogo.FileName);

                if (Globais.utilizadoratual >= 0)
                {
                    Globais.Utilizador utilizador = Globais.utilizadores[Globais.utilizadoratual];
                    utilizador.fotoCaminho = dialogo.FileName;
                    Globais.utilizadores[Globais.utilizadoratual] = utilizador;
                }
            }
        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            Globais.Navegar(this, new menu());
        }
    }
}
