namespace Anoora_Atooz
{
    partial class Home
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonCompany = new System.Windows.Forms.Button();
            this.buttonInvoice = new System.Windows.Forms.Button();
            this.buttonHistory = new System.Windows.Forms.Button();
            this.buttonProdcuts = new System.Windows.Forms.Button();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.Controls.Add(this.buttonCompany);
            this.panel3.Controls.Add(this.buttonInvoice);
            this.panel3.Controls.Add(this.buttonHistory);
            this.panel3.Controls.Add(this.buttonProdcuts);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1505, 126);
            this.panel3.TabIndex = 16;
            // 
            // buttonCompany
            // 
            this.buttonCompany.Location = new System.Drawing.Point(322, 20);
            this.buttonCompany.Name = "buttonCompany";
            this.buttonCompany.Size = new System.Drawing.Size(165, 71);
            this.buttonCompany.TabIndex = 41;
            this.buttonCompany.Text = "Company";
            this.buttonCompany.UseVisualStyleBackColor = true;
            // 
            // buttonInvoice
            // 
            this.buttonInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInvoice.Location = new System.Drawing.Point(1277, 20);
            this.buttonInvoice.Name = "buttonInvoice";
            this.buttonInvoice.Size = new System.Drawing.Size(165, 71);
            this.buttonInvoice.TabIndex = 40;
            this.buttonInvoice.Text = "Invoice";
            this.buttonInvoice.UseVisualStyleBackColor = true;
            // 
            // buttonHistory
            // 
            this.buttonHistory.AutoSize = true;
            this.buttonHistory.Location = new System.Drawing.Point(996, 20);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(165, 71);
            this.buttonHistory.TabIndex = 39;
            this.buttonHistory.Text = "History";
            this.buttonHistory.UseVisualStyleBackColor = true;
            // 
            // buttonProdcuts
            // 
            this.buttonProdcuts.Location = new System.Drawing.Point(663, 20);
            this.buttonProdcuts.Name = "buttonProdcuts";
            this.buttonProdcuts.Size = new System.Drawing.Size(165, 71);
            this.buttonProdcuts.TabIndex = 38;
            this.buttonProdcuts.Text = "Prodcuts";
            this.buttonProdcuts.UseVisualStyleBackColor = true;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.rjButton1.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 10;
            this.rjButton1.BorderSize = 1;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(459, 227);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(161, 53);
            this.rjButton1.TabIndex = 17;
            this.rjButton1.Text = "rjButton1";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1529, 811);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.panel3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anoora Atooz";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel3;
        private Button buttonInvoice;
        private Button buttonHistory;
        private Button buttonProdcuts;
        private Button buttonCompany;
        private CustomControls.RJControls.RJButton rjButton1;
    }
}