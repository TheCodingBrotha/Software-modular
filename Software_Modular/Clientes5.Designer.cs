namespace Software_Modular
{
    partial class Clientes5
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
            panel_clientes = new DataGridView();
            bt_panel = new Panel();
            bt_historico = new Button();
            bt_novo_cliente = new Button();
            bt_clientes = new Button();
            ((System.ComponentModel.ISupportInitialize)panel_clientes).BeginInit();
            bt_panel.SuspendLayout();
            SuspendLayout();
            // 
            // panel_clientes
            // 
            panel_clientes.BackgroundColor = Color.Azure;
            panel_clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            panel_clientes.Dock = DockStyle.Fill;
            panel_clientes.Location = new Point(158, 0);
            panel_clientes.Margin = new Padding(2);
            panel_clientes.Name = "panel_clientes";
            panel_clientes.RowHeadersWidth = 62;
            panel_clientes.Size = new Size(642, 450);
            panel_clientes.TabIndex = 5;
            // 
            // bt_panel
            // 
            bt_panel.BackColor = Color.MidnightBlue;
            bt_panel.Controls.Add(bt_historico);
            bt_panel.Controls.Add(bt_novo_cliente);
            bt_panel.Controls.Add(bt_clientes);
            bt_panel.Dock = DockStyle.Left;
            bt_panel.ForeColor = Color.MidnightBlue;
            bt_panel.Location = new Point(0, 0);
            bt_panel.Margin = new Padding(2);
            bt_panel.Name = "bt_panel";
            bt_panel.Size = new Size(158, 450);
            bt_panel.TabIndex = 4;
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
            // 
            // bt_novo_cliente
            // 
            bt_novo_cliente.BackColor = Color.MidnightBlue;
            bt_novo_cliente.Dock = DockStyle.Top;
            bt_novo_cliente.FlatStyle = FlatStyle.Popup;
            bt_novo_cliente.ForeColor = Color.Azure;
            bt_novo_cliente.Location = new Point(0, 29);
            bt_novo_cliente.Margin = new Padding(2);
            bt_novo_cliente.Name = "bt_novo_cliente";
            bt_novo_cliente.Size = new Size(158, 29);
            bt_novo_cliente.TabIndex = 1;
            bt_novo_cliente.Text = "Novo Cliente";
            bt_novo_cliente.UseVisualStyleBackColor = false;
            bt_novo_cliente.Click += bt_novo_cliente_Click;
            // 
            // bt_clientes
            // 
            bt_clientes.BackColor = Color.MidnightBlue;
            bt_clientes.Dock = DockStyle.Top;
            bt_clientes.FlatStyle = FlatStyle.Popup;
            bt_clientes.ForeColor = Color.Azure;
            bt_clientes.Location = new Point(0, 0);
            bt_clientes.Margin = new Padding(2);
            bt_clientes.Name = "bt_clientes";
            bt_clientes.Size = new Size(158, 29);
            bt_clientes.TabIndex = 0;
            bt_clientes.Text = "Clientes";
            bt_clientes.UseVisualStyleBackColor = false;
            bt_clientes.Click += bt_clientes_Click;
            // 
            // Clientes5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel_clientes);
            Controls.Add(bt_panel);
            Name = "Clientes5";
            Text = "Clientes5";
            Load += Clientes5_Load;
            ((System.ComponentModel.ISupportInitialize)panel_clientes).EndInit();
            bt_panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView panel_clientes;
        private Panel bt_panel;
        private Button bt_historico;
        private Button bt_novo_cliente;
        private Button bt_clientes;
    }
}