namespace Software_Modular
{
    partial class Historico
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
            Grid_VerPedidos = new DataGridView();
            pedidos = new Label();
            ((System.ComponentModel.ISupportInitialize)Grid_VerPedidos).BeginInit();
            SuspendLayout();
            // 
            // Grid_VerPedidos
            // 
            Grid_VerPedidos.BackgroundColor = SystemColors.ActiveBorder;
            Grid_VerPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_VerPedidos.Location = new Point(-81, 52);
            Grid_VerPedidos.Name = "Grid_VerPedidos";
            Grid_VerPedidos.Size = new Size(958, 382);
            Grid_VerPedidos.TabIndex = 3;
            // 
            // pedidos
            // 
            pedidos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pedidos.AutoSize = true;
            pedidos.Font = new Font("Yu Gothic UI", 15F, FontStyle.Bold);
            pedidos.ForeColor = Color.MidnightBlue;
            pedidos.Location = new Point(262, 17);
            pedidos.Name = "pedidos";
            pedidos.Size = new Size(201, 28);
            pedidos.TabIndex = 2;
            pedidos.Text = "Histórico de Pedidos";
            pedidos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Historico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(800, 450);
            Controls.Add(Grid_VerPedidos);
            Controls.Add(pedidos);
            Name = "Historico";
            Text = "Historico";
            ((System.ComponentModel.ISupportInitialize)Grid_VerPedidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Grid_VerPedidos;
        private Label pedidos;
    }
}