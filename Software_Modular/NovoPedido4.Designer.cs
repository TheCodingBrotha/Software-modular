namespace Software_Modular
{
    partial class NovoPedido4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovoPedido4));
            tb_idCLiente = new TextBox();
            label1 = new Label();
            tb_NomeCliente = new TextBox();
            label2 = new Label();
            tb_idServico = new TextBox();
            label3 = new Label();
            tb_NomeServico = new TextBox();
            label4 = new Label();
            tb_qtd = new TextBox();
            label5 = new Label();
            tb_obs = new TextBox();
            label6 = new Label();
            bt_CadastrarPedido = new Button();
            pictureBox1 = new PictureBox();
            tb_data = new TextBox();
            lb = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tb_idCLiente
            // 
            tb_idCLiente.Location = new Point(26, 91);
            tb_idCLiente.Name = "tb_idCLiente";
            tb_idCLiente.Size = new Size(36, 23);
            tb_idCLiente.TabIndex = 0;
            tb_idCLiente.Leave += tb_idCLiente_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Bold);
            label1.Location = new Point(23, 71);
            label1.Name = "label1";
            label1.Size = new Size(89, 17);
            label1.TabIndex = 1;
            label1.Text = "ID do Cliente:";
            // 
            // tb_NomeCliente
            // 
            tb_NomeCliente.Location = new Point(194, 91);
            tb_NomeCliente.Name = "tb_NomeCliente";
            tb_NomeCliente.Size = new Size(221, 23);
            tb_NomeCliente.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Bold);
            label2.Location = new Point(194, 71);
            label2.Name = "label2";
            label2.Size = new Size(113, 17);
            label2.TabIndex = 3;
            label2.Text = "Nome do Cliente:";
            // 
            // tb_idServico
            // 
            tb_idServico.Location = new Point(26, 165);
            tb_idServico.Name = "tb_idServico";
            tb_idServico.Size = new Size(36, 23);
            tb_idServico.TabIndex = 4;
            tb_idServico.Leave += tb_idServico_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Bold);
            label3.Location = new Point(23, 145);
            label3.Name = "label3";
            label3.Size = new Size(91, 17);
            label3.TabIndex = 5;
            label3.Text = "ID do Serviço:";
            // 
            // tb_NomeServico
            // 
            tb_NomeServico.Location = new Point(194, 165);
            tb_NomeServico.Name = "tb_NomeServico";
            tb_NomeServico.Size = new Size(221, 23);
            tb_NomeServico.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Bold);
            label4.Location = new Point(194, 145);
            label4.Name = "label4";
            label4.Size = new Size(115, 17);
            label4.TabIndex = 7;
            label4.Text = "Nome do Serviço:";
            // 
            // tb_qtd
            // 
            tb_qtd.Location = new Point(26, 230);
            tb_qtd.Name = "tb_qtd";
            tb_qtd.Size = new Size(36, 23);
            tb_qtd.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Bold);
            label5.Location = new Point(26, 210);
            label5.Name = "label5";
            label5.Size = new Size(34, 17);
            label5.TabIndex = 9;
            label5.Text = "Qtd.";
            // 
            // tb_obs
            // 
            tb_obs.Location = new Point(26, 294);
            tb_obs.Multiline = true;
            tb_obs.Name = "tb_obs";
            tb_obs.Size = new Size(389, 23);
            tb_obs.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Bold);
            label6.Location = new Point(26, 274);
            label6.Name = "label6";
            label6.Size = new Size(88, 17);
            label6.TabIndex = 11;
            label6.Text = "Observações:";
            // 
            // bt_CadastrarPedido
            // 
            bt_CadastrarPedido.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            bt_CadastrarPedido.Location = new Point(26, 339);
            bt_CadastrarPedido.Name = "bt_CadastrarPedido";
            bt_CadastrarPedido.Size = new Size(130, 28);
            bt_CadastrarPedido.TabIndex = 12;
            bt_CadastrarPedido.Text = "Cadastrar";
            bt_CadastrarPedido.UseVisualStyleBackColor = true;
            bt_CadastrarPedido.Click += bt_CadastrarPedido_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(484, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // tb_data
            // 
            tb_data.Location = new Point(194, 230);
            tb_data.Name = "tb_data";
            tb_data.Size = new Size(88, 23);
            tb_data.TabIndex = 29;
            // 
            // lb
            // 
            lb.AutoSize = true;
            lb.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Bold);
            lb.Location = new Point(194, 210);
            lb.Name = "lb";
            lb.Size = new Size(39, 17);
            lb.TabIndex = 30;
            lb.Text = "Data:";
            // 
            // NovoPedido4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(734, 450);
            Controls.Add(lb);
            Controls.Add(tb_data);
            Controls.Add(pictureBox1);
            Controls.Add(bt_CadastrarPedido);
            Controls.Add(label6);
            Controls.Add(tb_obs);
            Controls.Add(label5);
            Controls.Add(tb_qtd);
            Controls.Add(label4);
            Controls.Add(tb_NomeServico);
            Controls.Add(label3);
            Controls.Add(tb_idServico);
            Controls.Add(label2);
            Controls.Add(tb_NomeCliente);
            Controls.Add(label1);
            Controls.Add(tb_idCLiente);
            ForeColor = Color.MidnightBlue;
            Name = "NovoPedido4";
            Text = "NovoPedido4";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_idCLiente;
        private Label label1;
        private TextBox tb_NomeCliente;
        private Label label2;
        private TextBox tb_idServico;
        private Label label3;
        private TextBox tb_NomeServico;
        private Label label4;
        private TextBox tb_qtd;
        private Label label5;
        private TextBox tb_obs;
        private Label label6;
        private Button bt_CadastrarPedido;
        private PictureBox pictureBox1;
        private TextBox tb_data;
        private Label lb;
    }
}