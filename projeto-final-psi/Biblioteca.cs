using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace projeto_final_psi
{
    public partial class Biblioteca : Form
    {
        private record Jogo(string Nome, string Ficheiro, string Genero, string Descricao);

        // As imagens são copiadas para a pasta do .exe (ver .csproj), por isso funciona em qualquer PC.
        private static readonly string pastaImagens = Path.Combine(AppContext.BaseDirectory, "jogos");

        private static readonly Jogo[] jogos =
        {
            new Jogo("Counter-Strike 2", "cs2.jpg.png", "FPS competitivo",
                "Duas equipas, terroristas e contra-terroristas, enfrentam-se em rondas táticas onde a pontaria e o trabalho de equipa decidem tudo."),
            new Jogo("Half-Life: Alyx", "alyx.jpg", "Aventura em realidade virtual",
                "Uma aventura em VR passada antes de Half-Life 2. Joga como Alyx Vance e enfrenta a Combine numa luta pela sobrevivência."),
            new Jogo("Portal 2", "portal2.jpg", "Puzzle",
                "Usa a arma de portais para resolver enigmas nos laboratórios da Aperture Science, sozinho ou em modo cooperativo."),
            new Jogo("Team Fortress 2", "tf2.jpg", "FPS de equipa",
                "Escolhe entre nove classes únicas e luta em equipa num shooter cheio de humor e estilo cartoon."),
            new Jogo("Dota 2", "dota2.jpg", "MOBA",
                "Duas equipas de cinco heróis lutam para destruir a base inimiga. Estratégia, coordenação e mais de cem heróis para dominar.")
        };

        public static int TotalJogos => jogos.Length;

        private readonly Dictionary<string, Image> fotos = new Dictionary<string, Image>();

        public Biblioteca()
        {
            InitializeComponent();
        }

        private void Biblioteca_Load(object sender, EventArgs e)
        {
            if (Globais.utilizadoratual >= 0)
            {
                labelBemVindo.Text = "Bem-vindo, " + Globais.utilizadores[Globais.utilizadoratual].nome
                    + " — " + jogos.Length + " jogos";
            }

            listBoxJogos.DrawMode = DrawMode.OwnerDrawFixed;
            listBoxJogos.ItemHeight = 70;
            listBoxJogos.DrawItem += listBoxJogos_DrawItem;

            listBoxJogos.Items.Clear();
            foreach (Jogo jogo in jogos)
            {
                string caminho = Path.Combine(pastaImagens, jogo.Ficheiro);
                if (File.Exists(caminho))
                    fotos[jogo.Nome] = Image.FromFile(caminho);

                listBoxJogos.Items.Add(jogo.Nome);
            }

            if (listBoxJogos.Items.Count > 0)
                listBoxJogos.SelectedIndex = 0;
        }

        private void listBoxJogos_DrawItem(object? sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            bool selecionado = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
            Color fundo = selecionado ? Color.FromArgb(46, 157, 207) : Color.FromArgb(42, 71, 94);
            using (SolidBrush pincel = new SolidBrush(fundo))
                e.Graphics.FillRectangle(pincel, e.Bounds);

            string nome = listBoxJogos.Items[e.Index].ToString() ?? "";

            if (fotos.TryGetValue(nome, out Image? foto))
                e.Graphics.DrawImage(foto, e.Bounds.Left + 8, e.Bounds.Top + 8, 96, 54);

            TextRenderer.DrawText(e.Graphics, nome, listBoxJogos.Font,
                new Point(e.Bounds.Left + 118, e.Bounds.Top + 24), Color.White);

            using (Pen linha = new Pen(Color.FromArgb(27, 40, 56)))
                e.Graphics.DrawLine(linha, e.Bounds.Left, e.Bounds.Bottom - 1, e.Bounds.Right, e.Bounds.Bottom - 1);
        }

        private void listBoxJogos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = listBoxJogos.SelectedIndex;
            if (i < 0) return;

            Jogo jogo = jogos[i];
            labelNomeJogo.Text = jogo.Nome;
            labelGenero.Text = jogo.Genero;
            labelDescricao.Text = jogo.Descricao;
            pictureBoxCapa.Image = fotos.TryGetValue(jogo.Nome, out Image? foto) ? foto : null;
            buttonJogar.Enabled = true;
        }

        private void buttonJogar_Click(object sender, EventArgs e)
        {
            if (listBoxJogos.SelectedIndex < 0) return;
            MessageBox.Show("A iniciar " + jogos[listBoxJogos.SelectedIndex].Nome + "... Bom jogo!",
                "Jogar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonPerfil_Click(object sender, EventArgs e)
        {
            Globais.Navegar(this, new Perfil());
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Globais.Navegar(this, new menu());
        }
    }
}
