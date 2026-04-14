namespace Software_Modular
{
    partial class Login1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login1));
            Lb_user = new Label();
            tb_user = new TextBox();
            lb_senha = new Label();
            bt_login = new Button();
            bt_saiba = new LinkLabel();
            pictureBox1 = new PictureBox();
            rb_mostrar = new RadioButton();
            tb_senha = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Lb_user
            // 
            Lb_user.AutoSize = true;
            Lb_user.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            Lb_user.ForeColor = Color.Azure;
            Lb_user.Location = new Point(73, 65);
            Lb_user.Name = "Lb_user";
            Lb_user.Size = new Size(47, 15);
            Lb_user.TabIndex = 0;
            Lb_user.Text = "Usuário";
            // 
            // tb_user
            // 
            tb_user.BackColor = Color.Azure;
            tb_user.Location = new Point(73, 83);
            tb_user.Name = "tb_user";
            tb_user.Size = new Size(165, 23);
            tb_user.TabIndex = 1;
            // 
            // lb_senha
            // 
            lb_senha.AutoSize = true;
            lb_senha.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            lb_senha.ForeColor = Color.Azure;
            lb_senha.Location = new Point(73, 138);
            lb_senha.Name = "lb_senha";
            lb_senha.Size = new Size(40, 15);
            lb_senha.TabIndex = 2;
            lb_senha.Text = "Senha";
            // 
            // bt_login
            // 
            bt_login.BackColor = Color.Azure;
            bt_login.FlatStyle = FlatStyle.Popup;
            bt_login.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            bt_login.Location = new Point(73, 209);
            bt_login.Name = "bt_login";
            bt_login.Size = new Size(75, 23);
            bt_login.TabIndex = 4;
            bt_login.Text = "Entrar";
            bt_login.UseVisualStyleBackColor = false;
            bt_login.Click += bt_login_Click_1;
            // 
            // bt_saiba
            // 
            bt_saiba.AutoSize = true;
            bt_saiba.BackColor = Color.MidnightBlue;
            bt_saiba.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            bt_saiba.LinkColor = Color.Lavender;
            bt_saiba.Location = new Point(163, 213);
            bt_saiba.Name = "bt_saiba";
            bt_saiba.Size = new Size(68, 15);
            bt_saiba.TabIndex = 6;
            bt_saiba.TabStop = true;
            bt_saiba.Text = "Saiba Mais!";
            bt_saiba.LinkClicked += bt_saiba_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(502, 48);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(254, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // rb_mostrar
            // 
            rb_mostrar.AutoCheck = false;
            rb_mostrar.AutoSize = true;
            rb_mostrar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            rb_mostrar.ForeColor = Color.Azure;
            rb_mostrar.Location = new Point(255, 157);
            rb_mostrar.Margin = new Padding(2);
            rb_mostrar.Name = "rb_mostrar";
            rb_mostrar.Size = new Size(74, 19);
            rb_mostrar.TabIndex = 13;
            rb_mostrar.TabStop = true;
            rb_mostrar.Text = "Mostrar";
            rb_mostrar.UseVisualStyleBackColor = true;
            rb_mostrar.CheckedChanged += rb_mostrar_CheckedChanged;
            rb_mostrar.Click += rb_mostrar_Click;
            // 
            // tb_senha
            // 
            tb_senha.BackColor = Color.Azure;
            tb_senha.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            tb_senha.Location = new Point(73, 155);
            tb_senha.Margin = new Padding(2);
            tb_senha.Name = "tb_senha";
            tb_senha.Size = new Size(165, 21);
            tb_senha.TabIndex = 14;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(549, 178);
            label2.Name = "label2";
            label2.Size = new Size(166, 25);
            label2.TabIndex = 15;
            label2.Text = "Software Modular";
            // 
            // Login1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(tb_senha);
            Controls.Add(rb_mostrar);
            Controls.Add(pictureBox1);
            Controls.Add(bt_saiba);
            Controls.Add(bt_login);
            Controls.Add(lb_senha);
            Controls.Add(tb_user);
            Controls.Add(Lb_user);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login1";
            Text = "Bem-vindo(a)!";
            Load += Login1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lb_user;
        private TextBox tb_user;
        private Label lb_senha;
        private Button bt_login;
        private LinkLabel bt_saiba;
        private PictureBox pictureBox1;
        private RadioButton rb_mostrar;
        private TextBox tb_senha;
        private Label label2;
    }
}
