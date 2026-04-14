namespace Software_Modular
{
    partial class Concluir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Concluir));
            tb_NomeServico = new TextBox();
            label4 = new Label();
            tb_idp = new TextBox();
            label5 = new Label();
            bt_CadastrarPedido = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            tb_NomeCliente = new TextBox();
            label1 = new Label();
            tb_idCLiente = new TextBox();
            label3 = new Label();
            tb_idServico = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tb_NomeServico
            // 
            tb_NomeServico.Location = new Point(249, 171);
            tb_NomeServico.Name = "tb_NomeServico";
            tb_NomeServico.Size = new Size(221, 23);
            tb_NomeServico.TabIndex = 37;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Bold);
            label4.Location = new Point(249, 151);
            label4.Name = "label4";
            label4.Size = new Size(115, 17);
            label4.TabIndex = 38;
            label4.Text = "Nome do Serviço:";
            // 
            // tb_idp
            // 
            tb_idp.Location = new Point(77, 40);
            tb_idp.Name = "tb_idp";
            tb_idp.Size = new Size(36, 23);
            tb_idp.TabIndex = 39;
            tb_idp.Leave += tb_qtd_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Bold);
            label5.Location = new Point(77, 20);
            label5.Name = "label5";
            label5.Size = new Size(90, 17);
            label5.TabIndex = 40;
            label5.Text = "ID do Pedido:";
            // 
            // bt_CadastrarPedido
            // 
            bt_CadastrarPedido.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            bt_CadastrarPedido.Location = new Point(81, 228);
            bt_CadastrarPedido.Name = "bt_CadastrarPedido";
            bt_CadastrarPedido.Size = new Size(130, 28);
            bt_CadastrarPedido.TabIndex = 43;
            bt_CadastrarPedido.Text = "Concluir";
            bt_CadastrarPedido.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(539, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 44;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Bold);
            label2.Location = new Point(249, 77);
            label2.Name = "label2";
            label2.Size = new Size(113, 17);
            label2.TabIndex = 34;
            label2.Text = "Nome do Cliente:";
            // 
            // tb_NomeCliente
            // 
            tb_NomeCliente.Location = new Point(249, 97);
            tb_NomeCliente.Name = "tb_NomeCliente";
            tb_NomeCliente.Size = new Size(221, 23);
            tb_NomeCliente.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Bold);
            label1.Location = new Point(78, 77);
            label1.Name = "label1";
            label1.Size = new Size(89, 17);
            label1.TabIndex = 32;
            label1.Text = "ID do Cliente:";
            // 
            // tb_idCLiente
            // 
            tb_idCLiente.Location = new Point(81, 97);
            tb_idCLiente.Name = "tb_idCLiente";
            tb_idCLiente.Size = new Size(36, 23);
            tb_idCLiente.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Bold);
            label3.Location = new Point(78, 151);
            label3.Name = "label3";
            label3.Size = new Size(91, 17);
            label3.TabIndex = 36;
            label3.Text = "ID do Serviço:";
            // 
            // tb_idServico
            // 
            tb_idServico.Location = new Point(81, 171);
            tb_idServico.Name = "tb_idServico";
            tb_idServico.Size = new Size(36, 23);
            tb_idServico.TabIndex = 35;
            // 
            // Concluir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(bt_CadastrarPedido);
            Controls.Add(label5);
            Controls.Add(tb_idp);
            Controls.Add(label4);
            Controls.Add(tb_NomeServico);
            Controls.Add(label3);
            Controls.Add(tb_idServico);
            Controls.Add(label2);
            Controls.Add(tb_NomeCliente);
            Controls.Add(label1);
            Controls.Add(tb_idCLiente);
            Name = "Concluir";
            Text = "Concluir";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_NomeServico;
        private Label label4;
        private TextBox tb_idp;
        private Label label5;
        private Button bt_CadastrarPedido;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox tb_NomeCliente;
        private Label label1;
        private TextBox tb_idCLiente;
        private Label label3;
        private TextBox tb_idServico;
    }
}