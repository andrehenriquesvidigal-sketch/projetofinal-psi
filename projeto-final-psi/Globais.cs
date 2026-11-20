using System;
using System.Collections.Generic;
using System.Text;

namespace projeto_final_psi
{
    internal class Globais
    {
        public struct Utilizador
        {
            public string nome;
            public string email;
            public string password;
            public string sexo;
            public DateTime dataNascimento;
            public string fotoCaminho;
        }
        public static Utilizador[] utilizadores = new Utilizador[100];
        public static int posiçãovazia = 0;
        public static int utilizadoratual = -1;

        // Abre o form novo e esconde o atual; fecha a aplicação quando o utilizador fecha a última janela visível.
        public static void Navegar(Form atual, Form novo)
        {
            novo.FormClosed += (s, e) =>
            {
                foreach (Form f in Application.OpenForms)
                    if (f.Visible) return;
                Application.Exit();
            };
            novo.Show();
            atual.Hide();
        }
    }
}

