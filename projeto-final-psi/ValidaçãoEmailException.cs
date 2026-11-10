using System;
using System.Collections.Generic;
using System.Text;

namespace projeto_final_psi
{
    internal class ValidaçãoEmailException : System.Exception
    {
        internal ValidaçãoEmailException(string mensagem) : base(mensagem)
        {

        }
    }
}
