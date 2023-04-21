namespace Mercado
{
    partial class Editarprodutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PrecosBox = new TextBox();
            label4 = new Label();
            QuantidadeBox = new TextBox();
            label3 = new Label();
            nomeBox = new TextBox();
            label2 = new Label();
            PromoBox = new TextBox();
            label6 = new Label();
            produtos = new ComboBox();
            PesquisaBox = new TextBox();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // PrecosBox
            // 
            PrecosBox.Location = new Point(33, 244);
            PrecosBox.Name = "PrecosBox";
            PrecosBox.Size = new Size(121, 23);
            PrecosBox.TabIndex = 13;
            PrecosBox.KeyPress += PrecoBox_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Mongolian Baiti", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(33, 216);
            label4.Name = "label4";
            label4.Size = new Size(178, 25);
            label4.TabIndex = 12;
            label4.Text = "Preço do produto";
            // 
            // QuantidadeBox
            // 
            QuantidadeBox.Location = new Point(33, 152);
            QuantidadeBox.Name = "QuantidadeBox";
            QuantidadeBox.Size = new Size(94, 23);
            QuantidadeBox.TabIndex = 11;
            QuantidadeBox.KeyPress += QuantidadeBox_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Mongolian Baiti", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(24, 124);
            label3.Name = "label3";
            label3.Size = new Size(238, 25);
            label3.TabIndex = 10;
            label3.Text = "Quantidade em estoque";
            // 
            // nomeBox
            // 
            nomeBox.Location = new Point(33, 63);
            nomeBox.Name = "nomeBox";
            nomeBox.Size = new Size(269, 23);
            nomeBox.TabIndex = 9;
            nomeBox.KeyPress += nomeBox_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Mongolian Baiti", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(33, 25);
            label2.Name = "label2";
            label2.Size = new Size(181, 25);
            label2.TabIndex = 8;
            label2.Text = "Nome do produto";
            // 
            // PromoBox
            // 
            PromoBox.Location = new Point(24, 333);
            PromoBox.Name = "PromoBox";
            PromoBox.Size = new Size(138, 23);
            PromoBox.TabIndex = 15;
            PromoBox.KeyPress += PromoBox_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Mongolian Baiti", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(24, 305);
            label6.Name = "label6";
            label6.Size = new Size(315, 25);
            label6.TabIndex = 14;
            label6.Text = "Preço do produto em promoção";
            // 
            // produtos
            // 
            produtos.FormattingEnabled = true;
            produtos.Location = new Point(582, 30);
            produtos.Name = "produtos";
            produtos.Size = new Size(121, 23);
            produtos.TabIndex = 16;
            produtos.Text = "Nome do produto";
            produtos.SelectedIndexChanged += produtos_SelectedIndexChanged;
            // 
            // PesquisaBox
            // 
            PesquisaBox.Location = new Point(475, 141);
            PesquisaBox.Name = "PesquisaBox";
            PesquisaBox.Size = new Size(269, 23);
            PesquisaBox.TabIndex = 17;
            PesquisaBox.KeyPress += PesquisaBox_KeyPress;
            // 
            // button1
            // 
            button1.Location = new Point(496, 187);
            button1.Name = "button1";
            button1.Size = new Size(75, 35);
            button1.TabIndex = 18;
            button1.Text = "Pesquisar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Mongolian Baiti", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(513, 113);
            label1.Name = "label1";
            label1.Size = new Size(160, 25);
            label1.TabIndex = 19;
            label1.Text = "Nome desejado";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(621, 187);
            button2.Name = "button2";
            button2.Size = new Size(134, 35);
            button2.TabIndex = 20;
            button2.Text = "Reiniciar Pesquisar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(33, 389);
            button3.Name = "button3";
            button3.Size = new Size(75, 35);
            button3.TabIndex = 21;
            button3.Text = "Alterar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Mongolian Baiti", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(329, 9);
            label5.Name = "label5";
            label5.Size = new Size(152, 25);
            label5.TabIndex = 25;
            label5.Text = "Editar no tigas";
            // 
            // Editarprodutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(PesquisaBox);
            Controls.Add(produtos);
            Controls.Add(PromoBox);
            Controls.Add(label6);
            Controls.Add(PrecosBox);
            Controls.Add(label4);
            Controls.Add(QuantidadeBox);
            Controls.Add(label3);
            Controls.Add(nomeBox);
            Controls.Add(label2);
            Name = "Editarprodutos";
            Text = "Editarprodutos";
            Activated += Editarprodutos_Activated;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox PrecosBox;
        private Label label4;
        private TextBox QuantidadeBox;
        private Label label3;
        private TextBox nomeBox;
        private Label label2;
        private TextBox PromoBox;
        private Label label6;
        private ComboBox produtos;
        private TextBox PesquisaBox;
        private Button button1;
        private Label label1;
        private Button button2;
        private Button button3;
        private Label label5;
    }
}