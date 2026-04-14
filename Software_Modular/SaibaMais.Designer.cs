namespace Software_Modular
{
    partial class SaibaMais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaibaMais));
            label1 = new Label();
            RichSaibamais = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(308, 9);
            label1.Name = "label1";
            label1.Size = new Size(154, 37);
            label1.TabIndex = 0;
            label1.Text = "Saiba mais.";
            // 
            // RichSaibamais
            // 
            RichSaibamais.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            RichSaibamais.BackColor = Color.Azure;
            RichSaibamais.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RichSaibamais.ForeColor = Color.Black;
            RichSaibamais.Location = new Point(73, 50);
            RichSaibamais.Name = "RichSaibamais";
            RichSaibamais.Size = new Size(656, 321);
            RichSaibamais.TabIndex = 1;
            RichSaibamais.Text = resources.GetString("RichSaibamais.Text");
            // 
            // SaibaMais
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(800, 450);
            Controls.Add(RichSaibamais);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SaibaMais";
            Text = "Info";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public RichTextBox RichSaibamais;
    }
}