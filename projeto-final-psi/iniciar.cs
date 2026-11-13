namespace projeto_final_psi
{
    public partial class iniciar : Form
    {
        public iniciar()
        {
            InitializeComponent();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Hide();
        }

        private void buttonCriarConta_Click(object sender, EventArgs e)
        {
            Criar_conta registo = new Criar_conta();
            registo.Show();
            Hide();
        }

        private void iniciar_Load(object sender, EventArgs e)
        {

        }

       
    }
}
