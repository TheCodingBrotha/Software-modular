namespace Software_Modular
{
    partial class VerPedidos4
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
            pedidos = new Label();
            Grid_VerPedidos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)Grid_VerPedidos).BeginInit();
            SuspendLayout();
            // 
            // pedidos
            // 
            pedidos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pedidos.AutoSize = true;
            pedidos.Font = new Font("Yu Gothic UI", 15F, FontStyle.Bold);
            pedidos.Location = new Point(355, 9);
            pedidos.Name = "pedidos";
            pedidos.Size = new Size(85, 28);
            pedidos.TabIndex = 0;
            pedidos.Text = "Pedidos";
            pedidos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Grid_VerPedidos
            // 
            Grid_VerPedidos.BackgroundColor = SystemColors.ActiveBorder;
            Grid_VerPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_VerPedidos.Location = new Point(12, 44);
            Grid_VerPedidos.Name = "Grid_VerPedidos";
            Grid_VerPedidos.Size = new Size(962, 382);
            Grid_VerPedidos.TabIndex = 1;
            // 
            // VerPedidos4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(800, 450);
            Controls.Add(Grid_VerPedidos);
            Controls.Add(pedidos);
            ForeColor = Color.MidnightBlue;
            Name = "VerPedidos4";
            Text = "VerPedidos4";
            Load += VerPedidos4_Load;
            ((System.ComponentModel.ISupportInitialize)Grid_VerPedidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label pedidos;
        private DataGridView Grid_VerPedidos;
    }
}