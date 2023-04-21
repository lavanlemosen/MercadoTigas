namespace Mercado
{
    partial class Mercado
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
            listBox1 = new ListBox();
            PrecosBox = new TextBox();
            label4 = new Label();
            QuantidadeBox = new TextBox();
            label3 = new Label();
            nomeBox = new TextBox();
            label2 = new Label();
            DesejadoBox = new TextBox();
            label1 = new Label();
            button2 = new Button();
            label5 = new Label();
            button1 = new Button();
            PesquisaBox = new TextBox();
            produtos = new ComboBox();
            TotalBox = new TextBox();
            label6 = new Label();
            button3 = new Button();
            label7 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(681, 141);
            listBox1.Name = "listBox1";
            listBox1.ScrollAlwaysVisible = true;
            listBox1.Size = new Size(311, 319);
            listBox1.TabIndex = 0;
            // 
            // PrecosBox
            // 
            PrecosBox.Enabled = false;
            PrecosBox.Location = new Point(22, 233);
            PrecosBox.Name = "PrecosBox";
            PrecosBox.Size = new Size(168, 23);
            PrecosBox.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Mongolian Baiti", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 205);
            label4.Name = "label4";
            label4.Size = new Size(178, 25);
            label4.TabIndex = 18;
            label4.Text = "Preço do produto";
            // 
            // QuantidadeBox
            // 
            QuantidadeBox.Enabled = false;
            QuantidadeBox.Location = new Point(22, 169);
            QuantidadeBox.Name = "QuantidadeBox";
            QuantidadeBox.Size = new Size(228, 23);
            QuantidadeBox.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Mongolian Baiti", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 141);
            label3.Name = "label3";
            label3.Size = new Size(238, 25);
            label3.TabIndex = 16;
            label3.Text = "Quantidade em estoque";
            // 
            // nomeBox
            // 
            nomeBox.Enabled = false;
            nomeBox.Location = new Point(22, 109);
            nomeBox.Name = "nomeBox";
            nomeBox.Size = new Size(269, 23);
            nomeBox.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Mongolian Baiti", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(22, 81);
            label2.Name = "label2";
            label2.Size = new Size(181, 25);
            label2.TabIndex = 14;
            label2.Text = "Nome do produto";
            // 
            // DesejadoBox
            // 
            DesejadoBox.Location = new Point(336, 169);
            DesejadoBox.Name = "DesejadoBox";
            DesejadoBox.Size = new Size(166, 23);
            DesejadoBox.TabIndex = 21;
            DesejadoBox.KeyPress += textBox1_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Mongolian Baiti", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(337, 141);
            label1.Name = "label1";
            label1.Size = new Size(212, 25);
            label1.TabIndex = 20;
            label1.Text = "Quantidade desejada";
            // 
            // button2
            // 
            button2.Location = new Point(806, 93);
            button2.Name = "button2";
            button2.Size = new Size(134, 35);
            button2.TabIndex = 25;
            button2.Text = "Reiniciar Pesquisar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Mongolian Baiti", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(698, 19);
            label5.Name = "label5";
            label5.Size = new Size(160, 25);
            label5.TabIndex = 24;
            label5.Text = "Nome desejado";
            // 
            // button1
            // 
            button1.Location = new Point(681, 93);
            button1.Name = "button1";
            button1.Size = new Size(75, 35);
            button1.TabIndex = 23;
            button1.Text = "Pesquisar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PesquisaBox
            // 
            PesquisaBox.Location = new Point(660, 47);
            PesquisaBox.Name = "PesquisaBox";
            PesquisaBox.Size = new Size(269, 23);
            PesquisaBox.TabIndex = 22;
            PesquisaBox.KeyPress += PesquisaBox_KeyPress;
            // 
            // produtos
            // 
            produtos.FormattingEnabled = true;
            produtos.Location = new Point(31, 47);
            produtos.Name = "produtos";
            produtos.Size = new Size(121, 23);
            produtos.TabIndex = 26;
            produtos.Text = "Nome do produto";
            produtos.SelectedIndexChanged += produtos_SelectedIndexChanged;
            // 
            // TotalBox
            // 
            TotalBox.Enabled = false;
            TotalBox.Location = new Point(336, 233);
            TotalBox.Name = "TotalBox";
            TotalBox.Size = new Size(166, 23);
            TotalBox.TabIndex = 28;
            TotalBox.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Mongolian Baiti", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(351, 205);
            label6.Name = "label6";
            label6.Size = new Size(141, 25);
            label6.TabIndex = 27;
            label6.Text = "Total a Pagar\r\n";
            label6.Click += label6_Click;
            // 
            // button3
            // 
            button3.Location = new Point(31, 324);
            button3.Name = "button3";
            button3.Size = new Size(94, 32);
            button3.TabIndex = 29;
            button3.Text = "Comprar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Mongolian Baiti", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(332, 19);
            label7.Name = "label7";
            label7.Size = new Size(178, 25);
            label7.TabIndex = 30;
            label7.Text = "Comprar no tigas";
            // 
            // Mercado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 515);
            Controls.Add(label7);
            Controls.Add(button3);
            Controls.Add(TotalBox);
            Controls.Add(label6);
            Controls.Add(produtos);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(PesquisaBox);
            Controls.Add(DesejadoBox);
            Controls.Add(label1);
            Controls.Add(PrecosBox);
            Controls.Add(label4);
            Controls.Add(QuantidadeBox);
            Controls.Add(label3);
            Controls.Add(nomeBox);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Name = "Mercado";
            Text = "Mercado";
            Activated += Mercado_Activated;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private TextBox PrecosBox;
        private Label label4;
        private TextBox QuantidadeBox;
        private Label label3;
        private TextBox nomeBox;
        private Label label2;
        private TextBox DesejadoBox;
        private Label label1;
        private Button button2;
        private Label label5;
        private Button button1;
        private TextBox PesquisaBox;
        private ComboBox produtos;
        private TextBox TotalBox;
        private Label label6;
        private Button button3;
        private Label label7;
    }
}