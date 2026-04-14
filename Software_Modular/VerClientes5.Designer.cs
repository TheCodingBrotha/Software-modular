namespace Software_Modular
{
    partial class VerClientes5
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
            Grid_VerClientes = new DataGridView();
            pedidos = new Label();
            ((System.ComponentModel.ISupportInitialize)Grid_VerClientes).BeginInit();
            SuspendLayout();
            // 
            // Grid_VerClientes
            // 
            Grid_VerClientes.BackgroundColor = SystemColors.ActiveBorder;
            Grid_VerClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_VerClientes.Location = new Point(12, 46);
            Grid_VerClientes.Name = "Grid_VerClientes";
            Grid_VerClientes.Size = new Size(776, 394);
            Grid_VerClientes.TabIndex = 3;
            // 
            // pedidos
            // 
            pedidos.AutoSize = true;
            pedidos.Font = new Font("Yu Gothic UI", 15F, FontStyle.Bold);
            pedidos.ForeColor = Color.MidnightBlue;
            pedidos.Location = new Point(355, 11);
            pedidos.Name = "pedidos";
            pedidos.Size = new Size(84, 28);
            pedidos.TabIndex = 2;
            pedidos.Text = "Clientes";
            // 
            // VerClientes5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(800, 450);
            Controls.Add(Grid_VerClientes);
            Controls.Add(pedidos);
            Name = "VerClientes5";
            Text = "VerClientes5";
            Load += VerClientes5_Load;
            ((System.ComponentModel.ISupportInitialize)Grid_VerClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Grid_VerClientes;
        private Label pedidos;
    }
}