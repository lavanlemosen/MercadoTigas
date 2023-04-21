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
    public partial class Mercado : Form
    {
        public Mercado()
        {
            InitializeComponent();
        }
        Funcoes fun = new Funcoes();

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Mercado_Activated(object sender, EventArgs e)
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
            for (i = 0; i < Variaveis.Quantidade_produtos; i++)
            {
                produtos.Items.Add(Variaveis.Nome_produto[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fun.pesquisa(PesquisaBox, produtos);
        }

        private void produtos_SelectedIndexChanged(object sender, EventArgs e)
        {
            nomeBox.Text = Variaveis.Nome_produto[produtos.SelectedIndex];
            PrecosBox.Text = Convert.ToString(Variaveis.Precos[produtos.SelectedIndex] - Variaveis.Preco_promocao[produtos.SelectedIndex]);
            QuantidadeBox.Text = Convert.ToString(Variaveis.Quantidade_estoque[produtos.SelectedIndex]);
        }

        private void PesquisaBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            fun.confere_letras(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            fun.confere_numerosinteiros(e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int quantidade_desejada;
            double total = 0, totalfinal;
            try
            {
                quantidade_desejada = Convert.ToInt32(DesejadoBox.Text);
                if (quantidade_desejada > 0 && quantidade_desejada <= Variaveis.Quantidade_estoque[produtos.SelectedIndex])
                {
                    total = Convert.ToDouble(PrecosBox.Text) * quantidade_desejada;
                    totalfinal = Convert.ToDouble(TotalBox.Text) + total;
                    TotalBox.Text = totalfinal.ToString("n");
                    listBox1.Items.Add(nomeBox.Text + "|Quantidade vendida:" + DesejadoBox.Text + "|Preco da venda:" + total.ToString("n"));
                    Variaveis.Quantidade_estoque[produtos.SelectedIndex] -= quantidade_desejada;
                    QuantidadeBox.Text = Convert.ToString(Variaveis.Quantidade_estoque[produtos.SelectedIndex]);
                    MessageBox.Show("Compra bem sucedida");
                }
                else
                {
                    MessageBox.Show("quantidade invalida");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("formato invalido");
            }
        }
    }
}
