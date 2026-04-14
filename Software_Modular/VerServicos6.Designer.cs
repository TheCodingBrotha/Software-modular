namespace Software_Modular
{
    partial class VerServicos6
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
            Grid_VerServicos = new DataGridView();
            pedidos = new Label();
            ((System.ComponentModel.ISupportInitialize)Grid_VerServicos).BeginInit();
            SuspendLayout();
            // 
            // Grid_VerServicos
            // 
            Grid_VerServicos.BackgroundColor = SystemColors.ActiveBorder;
            Grid_VerServicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grid_VerServicos.Location = new Point(12, 46);
            Grid_VerServicos.Name = "Grid_VerServicos";
            Grid_VerServicos.Size = new Size(776, 394);
            Grid_VerServicos.TabIndex = 5;
            // 
            // pedidos
            // 
            pedidos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pedidos.AutoSize = true;
            pedidos.Font = new Font("Yu Gothic UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pedidos.ForeColor = Color.MidnightBlue;
            pedidos.Location = new Point(344, 9);
            pedidos.Name = "pedidos";
            pedidos.Size = new Size(86, 28);
            pedidos.TabIndex = 4;
            pedidos.Text = "Serviços";
            // 
            // VerServicos6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(800, 450);
            Controls.Add(Grid_VerServicos);
            Controls.Add(pedidos);
            Name = "VerServicos6";
            Text = "VerServicos6";
            Load += VerServicos6_Load;
            ((System.ComponentModel.ISupportInitialize)Grid_VerServicos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Grid_VerServicos;
        private Label pedidos;
    }
}