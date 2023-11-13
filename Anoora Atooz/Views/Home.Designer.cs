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
            panel3 = new Panel();
            buttonInvoice = new Button();
            buttonHistory = new Button();
            buttonProdcuts = new Button();
            buttonHome = new Button();
            buttonCompany = new Button();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(buttonCompany);
            panel3.Controls.Add(buttonInvoice);
            panel3.Controls.Add(buttonHistory);
            panel3.Controls.Add(buttonProdcuts);
            panel3.Controls.Add(buttonHome);
            panel3.Location = new Point(12, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(1505, 126);
            panel3.TabIndex = 16;
            // 
            // buttonInvoice
            // 
            buttonInvoice.Location = new Point(1277, 20);
            buttonInvoice.Name = "buttonInvoice";
            buttonInvoice.Size = new Size(165, 71);
            buttonInvoice.TabIndex = 40;
            buttonInvoice.Text = "Invoice";
            buttonInvoice.UseVisualStyleBackColor = true;
            // 
            // buttonHistory
            // 
            buttonHistory.Location = new Point(996, 20);
            buttonHistory.Name = "buttonHistory";
            buttonHistory.Size = new Size(165, 71);
            buttonHistory.TabIndex = 39;
            buttonHistory.Text = "History";
            buttonHistory.UseVisualStyleBackColor = true;
            // 
            // buttonProdcuts
            // 
            buttonProdcuts.Location = new Point(663, 20);
            buttonProdcuts.Name = "buttonProdcuts";
            buttonProdcuts.Size = new Size(165, 71);
            buttonProdcuts.TabIndex = 38;
            buttonProdcuts.Text = "Prodcuts";
            buttonProdcuts.UseVisualStyleBackColor = true;
            buttonProdcuts.Click += buttonProdcuts_Click;
            // 
            // buttonHome
            // 
            buttonHome.FlatAppearance.BorderSize = 0;
            buttonHome.Location = new Point(26, 20);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(165, 71);
            buttonHome.TabIndex = 37;
            buttonHome.Text = "Home";
            buttonHome.UseVisualStyleBackColor = true;
            // 
            // buttonCompany
            // 
            buttonCompany.Location = new Point(322, 20);
            buttonCompany.Name = "buttonCompany";
            buttonCompany.Size = new Size(165, 71);
            buttonCompany.TabIndex = 41;
            buttonCompany.Text = "Company";
            buttonCompany.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1529, 811);
            Controls.Add(panel3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Anoora Atooz";
            WindowState = FormWindowState.Maximized;
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private Button buttonInvoice;
        private Button buttonHistory;
        private Button buttonProdcuts;
        private Button buttonHome;
        private Button buttonCompany;
    }
}