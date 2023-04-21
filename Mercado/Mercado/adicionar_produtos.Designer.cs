namespace Mercado
{
    partial class adicionar_produtos
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
            label1 = new Label();
            label2 = new Label();
            nomeBox = new TextBox();
            QuantidadeBox = new TextBox();
            label3 = new Label();
            PrecoBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            promocoes = new ComboBox();
            PromoBox = new TextBox();
            label6 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Mongolian Baiti", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(119, 19);
            label1.Name = "label1";
            label1.Size = new Size(453, 30);
            label1.TabIndex = 1;
            label1.Text = "Adicionar produtos no Mercado tigas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Mongolian Baiti", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(21, 106);
            label2.Name = "label2";
            label2.Size = new Size(181, 25);
            label2.TabIndex = 2;
            label2.Text = "Nome do produto";
            // 
            // nomeBox
            // 
            nomeBox.Location = new Point(21, 144);
            nomeBox.Name = "nomeBox";
            nomeBox.Size = new Size(269, 23);
            nomeBox.TabIndex = 3;
            nomeBox.KeyPress += textBox1_KeyPress;
            // 
            // QuantidadeBox
            // 
            QuantidadeBox.Location = new Point(21, 233);
            QuantidadeBox.Name = "QuantidadeBox";
            QuantidadeBox.Size = new Size(94, 23);
            QuantidadeBox.TabIndex = 5;
            QuantidadeBox.KeyPress += QuantidadeBox_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Mongolian Baiti", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 205);
            label3.Name = "label3";
            label3.Size = new Size(238, 25);
            label3.TabIndex = 4;
            label3.Text = "Quantidade em estoque";
            // 
            // PrecoBox
            // 
            PrecoBox.Location = new Point(21, 325);
            PrecoBox.Name = "PrecoBox";
            PrecoBox.Size = new Size(121, 23);
            PrecoBox.TabIndex = 7;
            PrecoBox.KeyPress += PrecoBox_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Mongolian Baiti", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(21, 297);
            label4.Name = "label4";
            label4.Size = new Size(178, 25);
            label4.TabIndex = 6;
            label4.Text = "Preço do produto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Mongolian Baiti", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(393, 106);
            label5.Name = "label5";
            label5.Size = new Size(282, 25);
            label5.TabIndex = 8;
            label5.Text = "Desejar dar uma promoção?";
            // 
            // promocoes
            // 
            promocoes.FormattingEnabled = true;
            promocoes.Items.AddRange(new object[] { "Não", "Sim" });
            promocoes.Location = new Point(393, 145);
            promocoes.Name = "promocoes";
            promocoes.Size = new Size(121, 23);
            promocoes.TabIndex = 9;
            promocoes.SelectedIndexChanged += promocoes_SelectedIndexChanged;
            // 
            // PromoBox
            // 
            PromoBox.Enabled = false;
            PromoBox.Location = new Point(393, 233);
            PromoBox.Name = "PromoBox";
            PromoBox.Size = new Size(138, 23);
            PromoBox.TabIndex = 11;
            PromoBox.Text = "0";
            PromoBox.KeyPress += PromoBox_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Mongolian Baiti", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(393, 205);
            label6.Name = "label6";
            label6.Size = new Size(315, 25);
            label6.TabIndex = 10;
            label6.Text = "Preço do produto em promoção";
            // 
            // button1
            // 
            button1.Font = new Font("Mongolian Baiti", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(393, 314);
            button1.Name = "button1";
            button1.Size = new Size(123, 34);
            button1.TabIndex = 12;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // adicionar_produtos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 370);
            Controls.Add(button1);
            Controls.Add(PromoBox);
            Controls.Add(label6);
            Controls.Add(promocoes);
            Controls.Add(label5);
            Controls.Add(PrecoBox);
            Controls.Add(label4);
            Controls.Add(QuantidadeBox);
            Controls.Add(label3);
            Controls.Add(nomeBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "adicionar_produtos";
            Text = "adicionar_produtos";
            Activated += adicionar_produtos_Activated;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox nomeBox;
        private TextBox QuantidadeBox;
        private Label label3;
        private TextBox PrecoBox;
        private Label label4;
        private Label label5;
        private ComboBox promocoes;
        private TextBox PromoBox;
        private Label label6;
        private Button button1;
    }
}