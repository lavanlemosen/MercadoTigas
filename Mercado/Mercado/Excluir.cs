using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercado
{
    public partial class Excluir : Form
    {
        public Excluir()
        {
            InitializeComponent();
        }
        Funcoes fun = new Funcoes();

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Variaveis.exclusao(produtos.SelectedIndex);
                MessageBox.Show("Exclusao bem sucedida", "MercadoTigas");
            }
            catch (FormatException)
            {
                MessageBox.Show("exclusao impossivel", "MercadoTigas");
            }
        }

        private void Excluir_Activated(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < Variaveis.Quantidade_produtos; i++)
            {
                produtos.Items.Add(Variaveis.Nome_produto[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i;
            produtos.Items.Clear();
            for (i = 0; i < Variaveis.Quantidade_produtos; i++)
            {
                produtos.Items.Add(Variaveis.Nome_produto[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fun.pesquisa(PesquisaBox, produtos);

        }
    }
}
