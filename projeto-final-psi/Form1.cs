namespace projeto_final_psi
{
    public partial class Form1 : Form
    {
        public Form1()
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
                for (int i = 0; i < Globais.posiçãovazia; i++)
                {
                    if (Globais.utilizadores[i].dataNascimento.AddYears(18) >= DateTime.Today)
                    {
                        throw new MenorDeIdadeException("Tem que ser maior de idade para prosseguir");
                    }
                }
                Globais.Utilizador novoUtilizador = new Globais.Utilizador();
                novoUtilizador.nome = textBox1.Text;
                novoUtilizador.email = textBox2.Text;
                novoUtilizador.password = textBox4.Text;
                novoUtilizador.dataNascimento = dateTimePicker1.Value;
                Globais.utilizadores[Globais.posiçãovazia] = novoUtilizador;
                Globais.posiçãovazia++;
                MessageBox.Show("Registo da conta", "A sua conta foi registada com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
