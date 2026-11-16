using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projeto_final_psi
{
    public partial class Biblioteca : Form
    {
        private static readonly string[] jogosExemplo = new string[]
        {
            "Counter-Strike 2",
            "Half-Life: Alyx",
            "Portal 2",
            "Team Fortress 2",
            "Dota 2"
        };

        public Biblioteca()
        {
            InitializeComponent();
        }

        private void Biblioteca_Load(object sender, EventArgs e)
        {
            if (Globais.utilizadoratual >= 0)
            {
                labelBemVindo.Text = "Bem-vindo, " + Globais.utilizadores[Globais.utilizadoratual].nome;
            }

            listBoxJogos.Items.Clear();
            listBoxJogos.Items.AddRange(jogosExemplo);
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Globais.utilizadoratual = -1;
            iniciar inicio = new iniciar();
            inicio.Show();
            Hide();
            Close();
        }
    }
}
