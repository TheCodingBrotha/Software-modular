namespace Software_Modular
{
    partial class Servicos6
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
            bt_historico = new Button();
            bt_novo_servico = new Button();
            bt_servicos = new Button();
            panel_servicos = new DataGridView();
            bt_panel = new Panel();
            ((System.ComponentModel.ISupportInitialize)panel_servicos).BeginInit();
            bt_panel.SuspendLayout();
            SuspendLayout();
            // 
            // bt_historico
            // 
            bt_historico.BackColor = Color.MidnightBlue;
            bt_historico.Dock = DockStyle.Bottom;
            bt_historico.FlatStyle = FlatStyle.Popup;
            bt_historico.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            bt_historico.ForeColor = Color.Azure;
            bt_historico.Location = new Point(0, 421);
            bt_historico.Margin = new Padding(2);
            bt_historico.Name = "bt_historico";
            bt_historico.Size = new Size(158, 29);
            bt_historico.TabIndex = 2;
            bt_historico.Text = "Histórico";
            bt_historico.UseVisualStyleBackColor = false;
            // 
            // bt_novo_servico
            // 
            bt_novo_servico.BackColor = Color.MidnightBlue;
            bt_novo_servico.Dock = DockStyle.Top;
            bt_novo_servico.FlatStyle = FlatStyle.Popup;
            bt_novo_servico.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            bt_novo_servico.ForeColor = Color.Azure;
            bt_novo_servico.Location = new Point(0, 29);
            bt_novo_servico.Margin = new Padding(2);
            bt_novo_servico.Name = "bt_novo_servico";
            bt_novo_servico.Size = new Size(158, 29);
            bt_novo_servico.TabIndex = 1;
            bt_novo_servico.Text = "Novo Serviço";
            bt_novo_servico.UseVisualStyleBackColor = false;
            bt_novo_servico.Click += bt_novo_servico_Click;
            // 
            // bt_servicos
            // 
            bt_servicos.BackColor = Color.MidnightBlue;
            bt_servicos.Dock = DockStyle.Top;
            bt_servicos.FlatStyle = FlatStyle.Popup;
            bt_servicos.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            bt_servicos.ForeColor = Color.Azure;
            bt_servicos.Location = new Point(0, 0);
            bt_servicos.Margin = new Padding(2);
            bt_servicos.Name = "bt_servicos";
            bt_servicos.Size = new Size(158, 29);
            bt_servicos.TabIndex = 0;
            bt_servicos.Text = "Serviços";
            bt_servicos.UseVisualStyleBackColor = false;
            bt_servicos.Click += bt_servicos_Click;
            // 
            // panel_servicos
            // 
            panel_servicos.BackgroundColor = Color.Azure;
            panel_servicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            panel_servicos.Dock = DockStyle.Fill;
            panel_servicos.Location = new Point(158, 0);
            panel_servicos.Margin = new Padding(2);
            panel_servicos.Name = "panel_servicos";
            panel_servicos.RowHeadersWidth = 62;
            panel_servicos.Size = new Size(642, 450);
            panel_servicos.TabIndex = 7;
            // 
            // bt_panel
            // 
            bt_panel.BackColor = Color.MidnightBlue;
            bt_panel.Controls.Add(bt_historico);
            bt_panel.Controls.Add(bt_novo_servico);
            bt_panel.Controls.Add(bt_servicos);
            bt_panel.Dock = DockStyle.Left;
            bt_panel.ForeColor = Color.MidnightBlue;
            bt_panel.Location = new Point(0, 0);
            bt_panel.Margin = new Padding(2);
            bt_panel.Name = "bt_panel";
            bt_panel.Size = new Size(158, 450);
            bt_panel.TabIndex = 6;
            // 
            // Servicos6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel_servicos);
            Controls.Add(bt_panel);
            Name = "Servicos6";
            Text = "Servicos6";
            Load += Servicos6_Load;
            ((System.ComponentModel.ISupportInitialize)panel_servicos).EndInit();
            bt_panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button bt_historico;
        private Button bt_novo_servico;
        private Button bt_servicos;
        private DataGridView panel_servicos;
        private Panel bt_panel;
    }
}