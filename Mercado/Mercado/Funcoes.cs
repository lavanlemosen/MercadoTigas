using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado
{
    public class Funcoes
    {
   
        public void confere_numeros(KeyPressEventArgs e,TextBox texto)
        {
            e.Handled = (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ',') ? true : (e.KeyChar == ',' && (texto.Text.Contains(",")) ? true : false);
        }
        public void confere_letras( KeyPressEventArgs e)
        {
            e.Handled = (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar!=32) ? true : false;
        }
        public void confere_numerosinteiros(KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) ? true : false;
        }

        public void pesquisa(TextBox texto,ComboBox produto)
        {
            int i;
            produto.Items.Clear();
            for (i = 0; i < Variaveis.Quantidade_produtos; i++)
            {
                if (Variaveis.Nome_produto[i].Contains(texto.Text))
                {
                    produto.Items.Add(Variaveis.Nome_produto[i]);
                }
            }
        }

 
    }
  
}
