namespace Software_Modular
{
    partial class NovoServico6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovoServico6));
            bt_CadastrarServico = new Button();
            label6 = new Label();
            tb_prazo = new TextBox();
            label4 = new Label();
            tb_valor = new TextBox();
            label2 = new Label();
            tb_servico = new TextBox();
            label3 = new Label();
            tb_tipo = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // bt_CadastrarServico
            // 
            bt_CadastrarServico.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            bt_CadastrarServico.ForeColor = Color.MidnightBlue;
            bt_CadastrarServico.Location = new Point(43, 322);
            bt_CadastrarServico.Name = "bt_CadastrarServico";
            bt_CadastrarServico.Size = new Size(119, 28);
            bt_CadastrarServico.TabIndex = 26;
            bt_CadastrarServico.Text = "Cadastrar";
            bt_CadastrarServico.UseVisualStyleBackColor = true;
            bt_CadastrarServico.Click += bt_CadastrarServico_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Bold);
            label6.Location = new Point(43, 249);
            label6.Name = "label6";
            label6.Size = new Size(151, 17);
            label6.TabIndex = 25;
            label6.Text = "Prazo de Entrega (dias):";
            label6.Click += label6_Click;
            // 
            // tb_prazo
            // 
            tb_prazo.Location = new Point(43, 269);
            tb_prazo.Name = "tb_prazo";
            tb_prazo.Size = new Size(71, 23);
            tb_prazo.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Bold);
            label4.Location = new Point(43, 174);
            label4.Name = "label4";
            label4.Size = new Size(41, 17);
            label4.TabIndex = 21;
            label4.Text = "Valor:";
            // 
            // tb_valor
            // 
            tb_valor.Location = new Point(43, 194);
            tb_valor.Name = "tb_valor";
            tb_valor.Size = new Size(119, 23);
            tb_valor.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(43, 29);
            label2.Name = "label2";
            label2.Size = new Size(115, 17);
            label2.TabIndex = 17;
            label2.Text = "Nome do Serviço:";
            // 
            // tb_servico
            // 
            tb_servico.Location = new Point(43, 49);
            tb_servico.Name = "tb_servico";
            tb_servico.Size = new Size(221, 23);
            tb_servico.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Bold);
            label3.Location = new Point(43, 105);
            label3.Name = "label3";
            label3.Size = new Size(103, 17);
            label3.TabIndex = 19;
            label3.Text = "Tipo de Serviço:";
            label3.Click += label3_Click;
            // 
            // tb_tipo
            // 
            tb_tipo.Location = new Point(43, 125);
            tb_tipo.Name = "tb_tipo";
            tb_tipo.Size = new Size(221, 23);
            tb_tipo.TabIndex = 18;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(351, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // NovoServico6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(bt_CadastrarServico);
            Controls.Add(label6);
            Controls.Add(tb_prazo);
            Controls.Add(label4);
            Controls.Add(tb_valor);
            Controls.Add(label3);
            Controls.Add(tb_tipo);
            Controls.Add(label2);
            Controls.Add(tb_servico);
            ForeColor = Color.MidnightBlue;
            Name = "NovoServico6";
            Text = "NovoServico6";
            Load += NovoServico6_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button bt_CadastrarServico;
        private Label label6;
        private TextBox tb_prazo;
        private Label label4;
        private TextBox tb_valor;
        private Label label2;
        private TextBox tb_servico;
        private Label label3;
        private TextBox tb_tipo;
        private PictureBox pictureBox1;
    }
}