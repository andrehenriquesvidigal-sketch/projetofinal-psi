using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace projeto_final_psi
{
    public partial class Biblioteca : Form
    {
        private const string pastaImagens = @"C:\Users\laudl\OneDrive\Desktop\trab\projetofinal-psi\projeto-final-psi\jogos\";

        private static readonly Dictionary<string, string> jogos = new Dictionary<string, string>
        {
            { "Counter-Strike 2", "cs2.jpg.png" },
            { "Half-Life: Alyx", "alyx.jpg" },
            { "Portal 2", "portal2.jpg" },
            { "Team Fortress 2", "tf2.jpg" },
            { "Dota 2", "dota2.jpg" }
        };
        

        private readonly Dictionary<string, Image> fotos = new Dictionary<string, Image>();

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

            listBoxJogos.DrawMode = DrawMode.OwnerDrawFixed;
            listBoxJogos.ItemHeight = 60;
            listBoxJogos.DrawItem += listBoxJogos_DrawItem;

            listBoxJogos.Items.Clear();
            foreach (string nome in jogos.Keys)
            {
                string caminho = Path.Combine(pastaImagens, jogos[nome]);
                if (File.Exists(caminho))
                    fotos[nome] = Image.FromFile(caminho);

                listBoxJogos.Items.Add(nome);
            }
        }

        private void listBoxJogos_DrawItem(object? sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            e.DrawBackground();
            string nome = listBoxJogos.Items[e.Index].ToString() ?? "";

            if (fotos.TryGetValue(nome, out Image? foto))
                e.Graphics.DrawImage(foto, e.Bounds.Left + 5, e.Bounds.Top + 5, 90, 50);

            TextRenderer.DrawText(e.Graphics, nome, listBoxJogos.Font,
                new Point(e.Bounds.Left + 105, e.Bounds.Top + 20), e.ForeColor);

            e.DrawFocusRectangle();
        }

        private void listBoxJogos_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void buttonPerfil_Click(object sender, EventArgs e)
        {
            Perfil perfil = new Perfil();
            perfil.Show();
            Close();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Globais.utilizadoratual = -1;
            iniciar inicio = new iniciar();
            inicio.Show();
            Close();
        }
    }
}