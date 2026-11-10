using System;
using System.Collections.Generic;
using System.Text;

namespace projeto_final_psi
{
    internal class ValidaçãoCamposVaziosExecption : System.Exception
    {
        internal ValidaçãoCamposVaziosExecption(string mensagem) : base(mensagem)
        {

        }
    }
}
