namespace Anoora_Atooz.Views
{
    partial class Product
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
            panel1 = new Panel();
            panel2 = new Panel();
            label5 = new Label();
            textBoxStock = new TextBox();
            label4 = new Label();
            textBoxRate = new TextBox();
            label3 = new Label();
            textBoxName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnSubmit = new CustomControls.RJControls.RJButton();
            btnBack = new CustomControls.RJControls.RJButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1080, 596);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnBack);
            panel2.Controls.Add(btnSubmit);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textBoxStock);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textBoxRate);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBoxName);
            panel2.Location = new Point(0, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(1080, 516);
            panel2.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(21, 159);
            label5.Name = "label5";
            label5.Size = new Size(73, 23);
            label5.TabIndex = 5;
            label5.Text = "Tadaad";
            // 
            // textBoxStock
            // 
            textBoxStock.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxStock.Location = new Point(117, 156);
            textBoxStock.Name = "textBoxStock";
            textBoxStock.PlaceholderText = "Samaan ki kul Tadaad";
            textBoxStock.Size = new Size(249, 30);
            textBoxStock.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(46, 98);
            label4.Name = "label4";
            label4.Size = new Size(48, 23);
            label4.TabIndex = 3;
            label4.Text = "Rate";
            label4.Click += label4_Click;
            // 
            // textBoxRate
            // 
            textBoxRate.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxRate.Location = new Point(117, 95);
            textBoxRate.Name = "textBoxRate";
            textBoxRate.PlaceholderText = "Samaan ka Rate";
            textBoxRate.Size = new Size(249, 30);
            textBoxRate.TabIndex = 2;
            textBoxRate.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(35, 42);
            label3.Name = "label3";
            label3.Size = new Size(59, 23);
            label3.TabIndex = 1;
            label3.Text = "Naam";
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Tahoma", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(117, 39);
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "Saman ka naam";
            textBoxName.Size = new Size(249, 30);
            textBoxName.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 22.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(400, 36);
            label2.TabIndex = 2;
            label2.Text = "Nae Samaan ki tafseel dalay ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(654, -3);
            label1.Name = "label1";
            label1.Size = new Size(426, 42);
            label1.TabIndex = 1;
            label1.Text = "مصنوعات کی معلومات ڈالیں";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(7, 57, 60);
            btnSubmit.BackgroundColor = Color.FromArgb(7, 57, 60);
            btnSubmit.BorderColor = Color.FromArgb(44, 102, 110);
            btnSubmit.BorderRadius = 10;
            btnSubmit.BorderSize = 2;
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(0, 471);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(403, 45);
            btnSubmit.TabIndex = 19;
            btnSubmit.Text = "Jama Krae";
            btnSubmit.TextColor = Color.White;
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnCompany_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.DimGray;
            btnBack.BackgroundColor = Color.DimGray;
            btnBack.BorderColor = Color.FromArgb(44, 102, 110);
            btnBack.BorderRadius = 10;
            btnBack.BorderSize = 2;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(677, 471);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(403, 45);
            btnBack.TabIndex = 20;
            btnBack.Text = "Wapis Jae";
            btnBack.TextColor = Color.White;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 9, 12);
            ClientSize = new Size(1104, 620);
            Controls.Add(panel1);
            Name = "Product";
            Text = "Product";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Label label4;
        private TextBox textBoxRate;
        private Label label3;
        private TextBox textBoxName;
        private NumericUpDown numericUpDown1;
        private Label label5;
        private TextBox textBoxStock;
        private CustomControls.RJControls.RJButton btnSubmit;
        private CustomControls.RJControls.RJButton btnBack;
    }
}