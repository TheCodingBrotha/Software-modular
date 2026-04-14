namespace Software_Modular
{
    partial class NovoCliente5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovoCliente5));
            pictureBox1 = new PictureBox();
            bt_CadastrarCliente = new Button();
            label5 = new Label();
            tb_tel = new TextBox();
            label4 = new Label();
            tb_email = new TextBox();
            label3 = new Label();
            tb_doc = new TextBox();
            label2 = new Label();
            tb_nome = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(431, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // bt_CadastrarCliente
            // 
            bt_CadastrarCliente.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            bt_CadastrarCliente.Location = new Point(26, 303);
            bt_CadastrarCliente.Name = "bt_CadastrarCliente";
            bt_CadastrarCliente.Size = new Size(221, 35);
            bt_CadastrarCliente.TabIndex = 26;
            bt_CadastrarCliente.Text = "Cadastrar";
            bt_CadastrarCliente.UseVisualStyleBackColor = true;
            bt_CadastrarCliente.Click += bt_CadastrarCliente_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Bold);
            label5.Location = new Point(26, 177);
            label5.Name = "label5";
            label5.Size = new Size(61, 17);
            label5.TabIndex = 23;
            label5.Text = "Telefone:";
            label5.Click += label5_Click;
            // 
            // tb_tel
            // 
            tb_tel.Location = new Point(26, 195);
            tb_tel.Name = "tb_tel";
            tb_tel.Size = new Size(168, 23);
            tb_tel.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Bold);
            label4.Location = new Point(26, 232);
            label4.Name = "label4";
            label4.Size = new Size(48, 17);
            label4.TabIndex = 21;
            label4.Text = "E-mail:";
            // 
            // tb_email
            // 
            tb_email.Location = new Point(26, 250);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(221, 23);
            tb_email.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Bold);
            label3.Location = new Point(26, 120);
            label3.Name = "label3";
            label3.Size = new Size(89, 17);
            label3.TabIndex = 19;
            label3.Text = "CPF ou CNPJ:";
            // 
            // tb_doc
            // 
            tb_doc.Location = new Point(26, 138);
            tb_doc.Name = "tb_doc";
            tb_doc.Size = new Size(168, 23);
            tb_doc.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Bold);
            label2.Location = new Point(26, 65);
            label2.Name = "label2";
            label2.Size = new Size(117, 17);
            label2.TabIndex = 17;
            label2.Text = "Nome do Cliente: ";
            // 
            // tb_nome
            // 
            tb_nome.Location = new Point(26, 83);
            tb_nome.Name = "tb_nome";
            tb_nome.Size = new Size(349, 23);
            tb_nome.TabIndex = 16;
            // 
            // NovoCliente5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(bt_CadastrarCliente);
            Controls.Add(label5);
            Controls.Add(tb_tel);
            Controls.Add(label4);
            Controls.Add(tb_email);
            Controls.Add(label3);
            Controls.Add(tb_doc);
            Controls.Add(label2);
            Controls.Add(tb_nome);
            ForeColor = Color.MidnightBlue;
            Name = "NovoCliente5";
            Text = "NovoCliente";
            Load += NovoCliente5_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button bt_CadastrarCliente;
        private Label label6;
        private TextBox tb_obs;
        private Label label5;
        private TextBox tb_tel;
        private Label label4;
        private TextBox tb_email;
        private Label label3;
        private TextBox tb_doc;
        private Label label2;
        private TextBox tb_nome;
    }
}