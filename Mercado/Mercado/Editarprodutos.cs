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
    public partial class Editarprodutos : Form
    {
        public Editarprodutos()
        {
            InitializeComponent();
        }
        Funcoes func = new Funcoes();
        private void Editarprodutos_Activated(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < Variaveis.Quantidade_produtos; i++)
            {
                produtos.Items.Add(Variaveis.Nome_produto[i]);
            }
        }

        private void produtos_SelectedIndexChanged(object sender, EventArgs e)
        {
            nomeBox.Text = Variaveis.Nome_produto[produtos.SelectedIndex];
            PrecosBox.Text = Convert.ToString(Variaveis.Precos[produtos.SelectedIndex]);
            PromoBox.Text = Convert.ToString(Variaveis.Preco_promocao[produtos.SelectedIndex]);
            QuantidadeBox.Text = Convert.ToString(Variaveis.Quantidade_estoque[produtos.SelectedIndex]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            func.pesquisa(PesquisaBox, produtos);
        }

        private void nomeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            func.confere_letras(e);
        }

        private void PesquisaBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            func.confere_letras(e);
        }

        private void QuantidadeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            func.confere_numerosinteiros(e);
        }

        private void PrecoBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            func.confere_numeros(e, PrecosBox);
        }

        private void PromoBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            func.confere_numeros(e, PromoBox);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(QuantidadeBox.Text) > 0 && Convert.ToDouble(PrecosBox.Text) > 0 && Convert.ToDouble(PromoBox.Text) > 0 && Convert.ToDouble(PrecosBox.Text) > Convert.ToDouble(PromoBox.Text))
                {
                    Variaveis.setNome(produtos.SelectedIndex, nomeBox.Text);
                    Variaveis.setEstoque(produtos.SelectedIndex, Convert.ToInt32(QuantidadeBox.Text));
                    Variaveis.setPreco(produtos.SelectedIndex, Convert.ToDouble(PrecosBox.Text));
                    Variaveis.setPrecopromo(produtos.SelectedIndex, Convert.ToDouble(PromoBox.Text));
                    MessageBox.Show("Editado com sucesso", "MercadoTigas");
                }
                else
                {
                    MessageBox.Show("Quantidades invalidas detectadas", "MercadoTigas");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Nao vou deixa isso nao", "MercadoTigas");
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



        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
