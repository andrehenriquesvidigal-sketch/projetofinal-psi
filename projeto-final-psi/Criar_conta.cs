namespace projeto_final_psi
{
    public partial class Criar_conta : Form
    {
        public Criar_conta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox4.Text == "")
                {
                    throw new ValidaçãoCamposVaziosExecption("Preencha todos os campos");
                }
                if (!textBox2.Text.Contains("@") || !textBox2.Text.Contains("."))
                {
                    throw new ValidaçãoEmailException("O email tem de incluir um @ e um .");
                }
                for (int i = 0; i < Globais.posiçãovazia; i++)
                {
                    if (Globais.utilizadores[i].email == textBox2.Text)
                    {
                        throw new ValidaçãoEmailException("Este email já está a ser usado");
                    }
                }
                if (textBox3.Text != textBox4.Text)
                {
                    throw new ValidaçãoPalavraPasseEcxeption("As palavras passe tem de coincidir");
                }
                if (dateTimePicker1.Value.Date.AddYears(18) > DateTime.Today)
                {
                    throw new MenorDeIdadeException("Tem que ser maior de idade para prosseguir");
                }
                if (comboBoxSexo.SelectedIndex < 0)
                {
                    throw new ValidaçãoCamposVaziosExecption("Escolha o sexo");
                }
                if (Globais.posiçãovazia >= Globais.utilizadores.Length)
                {
                    throw new Exception("Já não é possível criar mais contas");
                }
                Globais.Utilizador novoUtilizador = new Globais.Utilizador();
                novoUtilizador.nome = textBox1.Text;
                novoUtilizador.email = textBox2.Text;
                novoUtilizador.password = textBox4.Text;
                novoUtilizador.dataNascimento = dateTimePicker1.Value.Date;
                novoUtilizador.sexo = comboBoxSexo.Text;
                Globais.utilizadores[Globais.posiçãovazia] = novoUtilizador;
                Globais.posiçãovazia++;
                MessageBox.Show("A sua conta foi registada com sucesso", "Registo da conta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Globais.Navegar(this, new Login());
            }
            catch (ValidaçãoCamposVaziosExecption ex)
            {
                MessageBox.Show(ex.Message, "Validação campos vazios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ValidaçãoEmailException ex)
            {
                MessageBox.Show(ex.Message, "Validação email", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ValidaçãoPalavraPasseEcxeption ex)
            {
                MessageBox.Show(ex.Message, "Validação palavra passe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MenorDeIdadeException ex)
            {
                MessageBox.Show(ex.Message, "Validação de idade", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_sair_Click_1(object sender, EventArgs e)
        {
            Globais.Navegar(this, new iniciar());
        }
    }
}
