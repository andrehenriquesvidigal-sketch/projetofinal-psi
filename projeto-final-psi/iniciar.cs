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
            Globais.Navegar(this, new Login());
        }

        private void buttonCriarConta_Click(object sender, EventArgs e)
        {
            Globais.Navegar(this, new Criar_conta());
        }

        private void iniciar_Load(object sender, EventArgs e)
        {

        }

       
    }
}
