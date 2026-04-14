namespace Software_Modular
{
    partial class Pedidos4
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
            bt_panel = new Panel();
            bt_historico = new Button();
            bt_novo_pedido = new Button();
            bt_pedidos = new Button();
            panel_pedidos = new DataGridView();
            bt_concluir = new Button();
            bt_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panel_pedidos).BeginInit();
            SuspendLayout();
            // 
            // bt_panel
            // 
            bt_panel.BackColor = Color.MidnightBlue;
            bt_panel.Controls.Add(bt_concluir);
            bt_panel.Controls.Add(bt_historico);
            bt_panel.Controls.Add(bt_novo_pedido);
            bt_panel.Controls.Add(bt_pedidos);
            bt_panel.Dock = DockStyle.Left;
            bt_panel.ForeColor = Color.MidnightBlue;
            bt_panel.Location = new Point(0, 0);
            bt_panel.Margin = new Padding(2);
            bt_panel.Name = "bt_panel";
            bt_panel.Size = new Size(158, 450);
            bt_panel.TabIndex = 2;
            // 
            // bt_historico
            // 
            bt_historico.BackColor = Color.MidnightBlue;
            bt_historico.Dock = DockStyle.Bottom;
            bt_historico.FlatStyle = FlatStyle.Popup;
            bt_historico.ForeColor = Color.Azure;
            bt_historico.Location = new Point(0, 421);
            bt_historico.Margin = new Padding(2);
            bt_historico.Name = "bt_historico";
            bt_historico.Size = new Size(158, 29);
            bt_historico.TabIndex = 2;
            bt_historico.Text = "Histórico";
            bt_historico.UseVisualStyleBackColor = false;
            bt_historico.Click += bt_historico_Click;
            // 
            // bt_novo_pedido
            // 
            bt_novo_pedido.BackColor = Color.MidnightBlue;
            bt_novo_pedido.Dock = DockStyle.Top;
            bt_novo_pedido.FlatStyle = FlatStyle.Popup;
            bt_novo_pedido.ForeColor = Color.Azure;
            bt_novo_pedido.Location = new Point(0, 29);
            bt_novo_pedido.Margin = new Padding(2);
            bt_novo_pedido.Name = "bt_novo_pedido";
            bt_novo_pedido.Size = new Size(158, 29);
            bt_novo_pedido.TabIndex = 1;
            bt_novo_pedido.Text = "Novo Pedido";
            bt_novo_pedido.UseVisualStyleBackColor = false;
            bt_novo_pedido.Click += bt_novo_pedido_Click;
            // 
            // bt_pedidos
            // 
            bt_pedidos.BackColor = Color.MidnightBlue;
            bt_pedidos.Dock = DockStyle.Top;
            bt_pedidos.FlatStyle = FlatStyle.Popup;
            bt_pedidos.ForeColor = Color.Azure;
            bt_pedidos.Location = new Point(0, 0);
            bt_pedidos.Margin = new Padding(2);
            bt_pedidos.Name = "bt_pedidos";
            bt_pedidos.Size = new Size(158, 29);
            bt_pedidos.TabIndex = 0;
            bt_pedidos.Text = "Pedidos";
            bt_pedidos.UseVisualStyleBackColor = false;
            bt_pedidos.Click += bt_pedidos_Click;
            // 
            // panel_pedidos
            // 
            panel_pedidos.BackgroundColor = Color.Azure;
            panel_pedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            panel_pedidos.Dock = DockStyle.Fill;
            panel_pedidos.Location = new Point(158, 0);
            panel_pedidos.Margin = new Padding(2);
            panel_pedidos.Name = "panel_pedidos";
            panel_pedidos.RowHeadersWidth = 62;
            panel_pedidos.Size = new Size(642, 450);
            panel_pedidos.TabIndex = 3;
            panel_pedidos.CellContentClick += panel_pedidos_CellContentClick;
            // 
            // bt_concluir
            // 
            bt_concluir.BackColor = Color.MidnightBlue;
            bt_concluir.Dock = DockStyle.Top;
            bt_concluir.FlatStyle = FlatStyle.Popup;
            bt_concluir.ForeColor = Color.Azure;
            bt_concluir.Location = new Point(0, 58);
            bt_concluir.Margin = new Padding(2);
            bt_concluir.Name = "bt_concluir";
            bt_concluir.Size = new Size(158, 29);
            bt_concluir.TabIndex = 3;
            bt_concluir.Text = "Concluir Pedido";
            bt_concluir.UseVisualStyleBackColor = false;
            bt_concluir.Click += bt_concluir_Click;
            // 
            // Pedidos4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel_pedidos);
            Controls.Add(bt_panel);
            Name = "Pedidos4";
            Text = "Pedidos4";
            Load += Pedidos4_Load;
            bt_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panel_pedidos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel bt_panel;
        private Button bt_pedidos;
        private DataGridView panel_pedidos;
        private Button bt_historico;
        private Button bt_novo_pedido;
        private Button bt_concluir;
    }
}