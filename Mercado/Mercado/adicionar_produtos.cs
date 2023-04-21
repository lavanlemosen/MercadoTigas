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
    public partial class adicionar_produtos : Form
    {
        public adicionar_produtos()
        {

            InitializeComponent();
        }
        public Funcoes fun = new Funcoes();


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            fun.confere_letras(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(QuantidadeBox.Text) > 0 && Convert.ToDouble(PrecoBox.Text) > 0 )
                {
                    Variaveis.incrementar();
                    Variaveis.setNome(Variaveis.Quantidade_produtos - 1, nomeBox.Text);
                    Variaveis.setEstoque(Variaveis.Quantidade_produtos - 1, Convert.ToInt32(QuantidadeBox.Text));
                    Variaveis.setPreco(Variaveis.Quantidade_produtos - 1, Convert.ToDouble(PrecoBox.Text));
                    if (promocoes.SelectedIndex == 0)
                    {
                        Variaveis.setPrecopromo(Variaveis.Quantidade_produtos - 1, 0);
                    }
                    else
                    {
                        if (Convert.ToDouble(PromoBox.Text) > 0 && Convert.ToDouble(PrecoBox.Text)>Convert.ToDouble(PromoBox.Text)) 
                        {
                            Variaveis.setPrecopromo(Variaveis.Quantidade_produtos - 1, Convert.ToDouble(PromoBox.Text));
                        }
                        else
                        {
                            MessageBox.Show("promoção invalida");
                        }
                    }
                    MessageBox.Show("Cadastrado com sucesso", "MercadoTigas");
                    nomeBox.Clear();
                    QuantidadeBox.Clear();
                    PrecoBox.Clear();
                    PromoBox.Clear();
                    promocoes.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("quantidades invalidas detectadas", "MercadoTigas");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Impossivel concluir");
            }
        }


        private void QuantidadeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            fun.confere_numerosinteiros(e);
        }

        private void PrecoBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            fun.confere_numeros(e, PrecoBox);
        }

        private void adicionar_produtos_Activated(object sender, EventArgs e)
        {
            promocoes.SelectedIndex = 0;
        }

        private void PromoBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            fun.confere_numeros(e, PromoBox);
        }

        private void promocoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (promocoes.SelectedIndex == 0)
            {
                PromoBox.Enabled = false;
            }
            else
            {
                PromoBox.Enabled = true;
            }
        }
    }
}
