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
            panelTop = new Panel();
            btnInvoice = new CustomControls.RJControls.RJButton();
            btnHistory = new CustomControls.RJControls.RJButton();
            btnProduct = new CustomControls.RJControls.RJButton();
            btnCompany = new CustomControls.RJControls.RJButton();
            btnHome = new CustomControls.RJControls.RJButton();
            panelSearch = new Panel();
            labelSearch = new Label();
            textBoxSearch = new TextBox();
            panelTop.SuspendLayout();
            panelSearch.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Anchor = AnchorStyles.Top;
            panelTop.BackColor = Color.FromArgb(10, 9, 12);
            panelTop.Controls.Add(btnInvoice);
            panelTop.Controls.Add(btnHistory);
            panelTop.Controls.Add(btnProduct);
            panelTop.Controls.Add(btnCompany);
            panelTop.Controls.Add(btnHome);
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1529, 126);
            panelTop.TabIndex = 16;
            // 
            // btnInvoice
            // 
            btnInvoice.BackColor = Color.FromArgb(7, 57, 60);
            btnInvoice.BackgroundColor = Color.FromArgb(7, 57, 60);
            btnInvoice.BorderColor = Color.FromArgb(44, 102, 110);
            btnInvoice.BorderRadius = 10;
            btnInvoice.BorderSize = 2;
            btnInvoice.FlatAppearance.BorderSize = 0;
            btnInvoice.FlatStyle = FlatStyle.Flat;
            btnInvoice.Font = new Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnInvoice.ForeColor = Color.White;
            btnInvoice.Location = new Point(1288, 26);
            btnInvoice.Name = "btnInvoice";
            btnInvoice.Size = new Size(189, 74);
            btnInvoice.TabIndex = 21;
            btnInvoice.Text = "Slip";
            btnInvoice.TextColor = Color.White;
            btnInvoice.UseVisualStyleBackColor = false;
            // 
            // btnHistory
            // 
            btnHistory.BackColor = Color.FromArgb(7, 57, 60);
            btnHistory.BackgroundColor = Color.FromArgb(7, 57, 60);
            btnHistory.BorderColor = Color.FromArgb(44, 102, 110);
            btnHistory.BorderRadius = 10;
            btnHistory.BorderSize = 2;
            btnHistory.FlatAppearance.BorderSize = 0;
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Font = new Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnHistory.ForeColor = Color.White;
            btnHistory.Location = new Point(966, 26);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(189, 74);
            btnHistory.TabIndex = 20;
            btnHistory.Text = "Hisab Kitab";
            btnHistory.TextColor = Color.White;
            btnHistory.UseVisualStyleBackColor = false;
            // 
            // btnProduct
            // 
            btnProduct.BackColor = Color.FromArgb(7, 57, 60);
            btnProduct.BackgroundColor = Color.FromArgb(7, 57, 60);
            btnProduct.BorderColor = Color.FromArgb(44, 102, 110);
            btnProduct.BorderRadius = 10;
            btnProduct.BorderSize = 2;
            btnProduct.FlatAppearance.BorderSize = 0;
            btnProduct.FlatStyle = FlatStyle.Flat;
            btnProduct.Font = new Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnProduct.ForeColor = Color.White;
            btnProduct.Location = new Point(639, 26);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(189, 74);
            btnProduct.TabIndex = 19;
            btnProduct.Text = "Samaan";
            btnProduct.TextColor = Color.White;
            btnProduct.UseVisualStyleBackColor = false;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnCompany
            // 
            btnCompany.BackColor = Color.FromArgb(7, 57, 60);
            btnCompany.BackgroundColor = Color.FromArgb(7, 57, 60);
            btnCompany.BorderColor = Color.FromArgb(44, 102, 110);
            btnCompany.BorderRadius = 10;
            btnCompany.BorderSize = 2;
            btnCompany.FlatAppearance.BorderSize = 0;
            btnCompany.FlatStyle = FlatStyle.Flat;
            btnCompany.Font = new Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnCompany.ForeColor = Color.White;
            btnCompany.Location = new Point(317, 26);
            btnCompany.Name = "btnCompany";
            btnCompany.Size = new Size(189, 74);
            btnCompany.TabIndex = 18;
            btnCompany.Text = "Company";
            btnCompany.TextColor = Color.White;
            btnCompany.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(7, 57, 60);
            btnHome.BackgroundColor = Color.FromArgb(7, 57, 60);
            btnHome.BorderColor = Color.FromArgb(44, 102, 110);
            btnHome.BorderRadius = 10;
            btnHome.BorderSize = 2;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(20, 26);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(189, 74);
            btnHome.TabIndex = 17;
            btnHome.Text = "Home ";
            btnHome.TextColor = Color.White;
            btnHome.UseVisualStyleBackColor = false;
            // 
            // panelSearch
            // 
            panelSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelSearch.Controls.Add(labelSearch);
            panelSearch.Controls.Add(textBoxSearch);
            panelSearch.Location = new Point(12, 132);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(1505, 667);
            panelSearch.TabIndex = 17;
            // 
            // labelSearch
            // 
            labelSearch.Anchor = AnchorStyles.Top;
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelSearch.ForeColor = Color.White;
            labelSearch.Location = new Point(486, 24);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(95, 33);
            labelSearch.TabIndex = 1;
            labelSearch.Text = "Search";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Top;
            textBoxSearch.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearch.Location = new Point(605, 17);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(379, 40);
            textBoxSearch.TabIndex = 0;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(10, 9, 12);
            ClientSize = new Size(1529, 811);
            Controls.Add(panelSearch);
            Controls.Add(panelTop);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Anoora Atooz";
            WindowState = FormWindowState.Maximized;
            panelTop.ResumeLayout(false);
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelTop;
        private Button buttonInvoice;
        private Button buttonHistory;
        private Button buttonProdcuts;
        private Button buttonCompany;
        private CustomControls.RJControls.RJButton btnHome;
        private CustomControls.RJControls.RJButton btnHistory;
        private CustomControls.RJControls.RJButton btnProduct;
        private CustomControls.RJControls.RJButton btnCompany;
        private CustomControls.RJControls.RJButton btnInvoice;
        private Panel panelSearch;
        private Label labelSearch;
        private TextBox textBoxSearch;
    }
}