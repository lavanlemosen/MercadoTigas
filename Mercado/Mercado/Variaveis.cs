using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Mercado
{

    public static class Variaveis
    {
        public static string[] Nome_produto = new string[1];
        public static double[] Precos = new double[1], Preco_promocao = new double[1];
        public static  int[] Quantidade_estoque = new int[1];
        public static  int Quantidade_produtos = 0;
       

        public static void incrementar()
        {
            Quantidade_produtos++;
            Array.Resize<string>(ref Nome_produto, Quantidade_produtos);
            Array.Resize<int>(ref Quantidade_estoque, Quantidade_produtos);
            Array.Resize<double>(ref Precos, Quantidade_produtos);
            Array.Resize<double>(ref Preco_promocao, Quantidade_produtos);
        }
        public static void setNome(int iden,string nome)
        {
            Nome_produto[iden] = nome;
        }
        public static void setEstoque(int iden,int estoque)
        {
            Quantidade_estoque[iden] = estoque;

        }

        public static void setPreco(int iden, double preco)
        {
            Precos[iden] = preco;
        }

        public static void setPrecopromo(int iden, double preco)
        {
           Preco_promocao[iden] = preco;
        }

     

        public static void exclusao(int ide)
        {
            int i, j;
            j = Quantidade_produtos-1;
           for(i = ide; i < Quantidade_produtos; i++)
            {
                Nome_produto[i] = Nome_produto[j];
                Quantidade_estoque[i] = Quantidade_estoque[j];
                Precos[i] = Precos[j];
                Preco_promocao[i] = Preco_promocao[j];
                j--;
            }
                Quantidade_produtos--;
                Array.Resize<string>(ref Nome_produto, Quantidade_produtos);
                Array.Resize<int>(ref Quantidade_estoque, Quantidade_produtos);
                Array.Resize<double>(ref Precos, Quantidade_produtos);
                Array.Resize<double>(ref Preco_promocao, Quantidade_produtos);
            
        }

    }
}
