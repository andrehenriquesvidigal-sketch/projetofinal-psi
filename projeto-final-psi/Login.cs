using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projeto_final_psi
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxEmail.Text == "" || textBoxPassword.Text == "")
                {
                    throw new ValidaçãoCamposVaziosExecption("Preencha todos os campos");
                }

                for (int i = 0; i < Globais.posiçãovazia; i++)
                {
                    if (Globais.utilizadores[i].email == textBoxEmail.Text && Globais.utilizadores[i].password == textBoxPassword.Text)
                    {
                        Globais.utilizadoratual = i;
                        MessageBox.Show("Login efetuado com sucesso", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                throw new ValidaçãoEmailException("Email ou password incorretos");
            }
            catch (ValidaçãoCamposVaziosExecption ex)
            {
                MessageBox.Show(ex.Message, "Validação campos vazios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ValidaçãoEmailException ex)
            {
                MessageBox.Show(ex.Message, "Validação login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabelCriarConta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Criar_conta registo = new Criar_conta();
            registo.Show();
            Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
