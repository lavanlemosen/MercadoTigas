namespace Mercado
{
    public partial class Form1 : Form
    {
        Funcoes fun = new Funcoes();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adicionar_produtos adicionar = new adicionar_produtos();
            adicionar.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Editarprodutos editar = new Editarprodutos();
            editar.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Excluir excluir = new Excluir();
            excluir.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Mercado mercado = new Mercado();
            mercado.Visible = true;
        }
    }
}