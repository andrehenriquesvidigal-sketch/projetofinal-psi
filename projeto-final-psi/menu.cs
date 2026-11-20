using System;
using System.Windows.Forms;

namespace projeto_final_psi
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            if (Globais.utilizadoratual >= 0)
            {
                string nome = Globais.utilizadores[Globais.utilizadoratual].nome;
                labelOla.Text = "Olá, " + nome + "!";
                labelUtilizador.Text = "👤 " + nome;
            }
            labelResumo.Text = "Tens " + Biblioteca.TotalJogos + " jogos na tua biblioteca. O que queres fazer hoje?";
        }

        private void buttonBiblioteca_Click(object sender, EventArgs e)
        {
            Globais.Navegar(this, new Biblioteca());
        }

        private void buttonPerfil_Click(object sender, EventArgs e)
        {
            Globais.Navegar(this, new Perfil());
        }

        private void buttonTerminarSessao_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Queres mesmo terminar a sessão?", "Terminar sessão",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Globais.utilizadoratual = -1;
                Globais.Navegar(this, new iniciar());
            }
        }
    }
}
