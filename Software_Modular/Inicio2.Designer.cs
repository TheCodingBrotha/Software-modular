namespace Software_Modular
{
    partial class Inicio2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio2));
            toolStrip1 = new ToolStrip();
            menu_home = new ToolStripButton();
            menu_pedidos = new ToolStripButton();
            menu_clientes = new ToolStripButton();
            menu_servicos = new ToolStripButton();
            menu_sair = new ToolStripButton();
            menu_saiba = new ToolStripButton();
            panel_telas = new Panel();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.MidnightBlue;
            toolStrip1.Items.AddRange(new ToolStripItem[] { menu_home, menu_pedidos, menu_clientes, menu_servicos, menu_sair, menu_saiba });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.Professional;
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "menu_strip";
            // 
            // menu_home
            // 
            menu_home.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            menu_home.ForeColor = Color.Azure;
            menu_home.Image = (Image)resources.GetObject("menu_home.Image");
            menu_home.ImageTransparentColor = Color.Magenta;
            menu_home.Name = "menu_home";
            menu_home.Size = new Size(60, 22);
            menu_home.Text = "Home";
            menu_home.Click += menu_home_Click;
            // 
            // menu_pedidos
            // 
            menu_pedidos.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            menu_pedidos.ForeColor = Color.Azure;
            menu_pedidos.Image = (Image)resources.GetObject("menu_pedidos.Image");
            menu_pedidos.ImageTransparentColor = Color.Magenta;
            menu_pedidos.Name = "menu_pedidos";
            menu_pedidos.Size = new Size(69, 22);
            menu_pedidos.Text = "Pedidos";
            menu_pedidos.Click += menu_pedidos_Click;
            // 
            // menu_clientes
            // 
            menu_clientes.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            menu_clientes.ForeColor = Color.Azure;
            menu_clientes.Image = (Image)resources.GetObject("menu_clientes.Image");
            menu_clientes.ImageTransparentColor = Color.Magenta;
            menu_clientes.Name = "menu_clientes";
            menu_clientes.Size = new Size(68, 22);
            menu_clientes.Text = "Clientes";
            menu_clientes.Click += menu_clientes_Click;
            // 
            // menu_servicos
            // 
            menu_servicos.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            menu_servicos.ForeColor = Color.Azure;
            menu_servicos.Image = (Image)resources.GetObject("menu_servicos.Image");
            menu_servicos.ImageTransparentColor = Color.Magenta;
            menu_servicos.Name = "menu_servicos";
            menu_servicos.Size = new Size(71, 22);
            menu_servicos.Text = "Serviços";
            menu_servicos.Click += menu_servicos_Click;
            // 
            // menu_sair
            // 
            menu_sair.Alignment = ToolStripItemAlignment.Right;
            menu_sair.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            menu_sair.ForeColor = Color.Azure;
            menu_sair.Image = (Image)resources.GetObject("menu_sair.Image");
            menu_sair.ImageTransparentColor = Color.Magenta;
            menu_sair.Name = "menu_sair";
            menu_sair.Size = new Size(47, 22);
            menu_sair.Text = "Sair";
            menu_sair.Click += menu_sair_Click;
            // 
            // menu_saiba
            // 
            menu_saiba.Alignment = ToolStripItemAlignment.Right;
            menu_saiba.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            menu_saiba.ForeColor = Color.Azure;
            menu_saiba.Image = (Image)resources.GetObject("menu_saiba.Image");
            menu_saiba.ImageTransparentColor = Color.Magenta;
            menu_saiba.Name = "menu_saiba";
            menu_saiba.Size = new Size(88, 22);
            menu_saiba.Text = "Saiba Mais!";
            menu_saiba.Click += menu_saiba_Click;
            // 
            // panel_telas
            // 
            panel_telas.Dock = DockStyle.Fill;
            panel_telas.Location = new Point(0, 25);
            panel_telas.Name = "panel_telas";
            panel_telas.Size = new Size(800, 425);
            panel_telas.TabIndex = 1;
            // 
            // Inicio2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(800, 450);
            Controls.Add(panel_telas);
            Controls.Add(toolStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Inicio2";
            Text = "Software Modular";
            Load += Inicio2_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private Panel panel_telas;
        private ToolStripButton menu_home;
        private ToolStripButton menu_pedidos;
        private ToolStripButton menu_servicos;
        private ToolStripButton menu_clientes;
        private ToolStripButton menu_saiba;
        private ToolStripButton menu_sair;
    }
}