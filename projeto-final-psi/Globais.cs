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
        }
        public static Utilizador[] utilizadores = new Utilizador[100];
        public static int posiçãovazia = 0;
        public static int utilizadoratual = -1;
    }
}

