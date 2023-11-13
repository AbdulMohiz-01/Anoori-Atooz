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
            btnHome = new CustomControls.RJControls.RJButton();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top;
            panel3.Location = new Point(12, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(1505, 126);
            panel3.TabIndex = 16;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.RoyalBlue;
            btnHome.BackgroundColor = Color.RoyalBlue;
            btnHome.BorderColor = Color.Blue;
            btnHome.BorderRadius = 10;
            btnHome.BorderSize = 1;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(459, 227);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(190, 68);
            btnHome.TabIndex = 17;
            btnHome.Text = "Home";
            btnHome.TextColor = Color.White;
            btnHome.UseVisualStyleBackColor = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1529, 811);
            Controls.Add(btnHome);
            Controls.Add(panel3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Anoora Atooz";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private Button buttonInvoice;
        private Button buttonHistory;
        private Button buttonProdcuts;
        private Button buttonCompany;
        private CustomControls.RJControls.RJButton btnHome;
    }
}