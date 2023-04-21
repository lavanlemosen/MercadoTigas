namespace Mercado
{
    partial class Excluir
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
            button2 = new Button();
            label1 = new Label();
            button1 = new Button();
            PesquisaBox = new TextBox();
            produtos = new ComboBox();
            button3 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(148, 272);
            button2.Name = "button2";
            button2.Size = new Size(134, 35);
            button2.TabIndex = 25;
            button2.Text = "Reiniciar Pesquisar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Mongolian Baiti", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(76, 196);
            label1.Name = "label1";
            label1.Size = new Size(160, 25);
            label1.TabIndex = 24;
            label1.Text = "Nome desejado";
            // 
            // button1
            // 
            button1.Location = new Point(35, 272);
            button1.Name = "button1";
            button1.Size = new Size(75, 35);
            button1.TabIndex = 23;
            button1.Text = "Pesquisar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PesquisaBox
            // 
            PesquisaBox.Location = new Point(13, 243);
            PesquisaBox.Name = "PesquisaBox";
            PesquisaBox.Size = new Size(269, 23);
            PesquisaBox.TabIndex = 22;
            // 
            // produtos
            // 
            produtos.FormattingEnabled = true;
            produtos.Location = new Point(74, 151);
            produtos.Name = "produtos";
            produtos.Size = new Size(121, 23);
            produtos.TabIndex = 21;
            produtos.Text = "Nome do produto";
            // 
            // button3
            // 
            button3.Location = new Point(102, 369);
            button3.Name = "button3";
            button3.Size = new Size(75, 35);
            button3.TabIndex = 26;
            button3.Text = "Excluir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Mongolian Baiti", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(63, 60);
            label2.Name = "label2";
            label2.Size = new Size(163, 25);
            label2.TabIndex = 27;
            label2.Text = "Excluir no tigas";
            // 
            // Excluir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 450);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(PesquisaBox);
            Controls.Add(produtos);
            Name = "Excluir";
            Text = "Excluir";
            Activated += Excluir_Activated;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Label label1;
        private Button button1;
        private TextBox PesquisaBox;
        private ComboBox produtos;
        private Button button3;
        private Label label2;
    }
}