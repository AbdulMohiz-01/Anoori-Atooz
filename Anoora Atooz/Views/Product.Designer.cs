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
            panelheading = new Panel();
            labelHeading = new Label();
            btnSubmit = new CustomControls.RJControls.RJButton();
            btnBack = new CustomControls.RJControls.RJButton();
            panelMiddle = new Panel();
            labelDate = new Label();
            dateTimePickerCreated = new DateTimePicker();
            labelStock = new Label();
            textBoxStock = new TextBox();
            labelWholeSaleRate = new Label();
            textBoxWholeSaleRate = new TextBox();
            labelLocalRate = new Label();
            textBoxLocalRate = new TextBox();
            labelName = new Label();
            textBoxName = new TextBox();
            panelBottom = new Panel();
            panelheading.SuspendLayout();
            panelMiddle.SuspendLayout();
            panelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // panelheading
            // 
            panelheading.Anchor = AnchorStyles.Top;
            panelheading.BackColor = Color.FromArgb(10, 9, 12);
            panelheading.Controls.Add(labelHeading);
            panelheading.Location = new Point(1, 2);
            panelheading.Name = "panelheading";
            panelheading.Size = new Size(1529, 126);
            panelheading.TabIndex = 17;
            // 
            // labelHeading
            // 
            labelHeading.Anchor = AnchorStyles.Top;
            labelHeading.AutoSize = true;
            labelHeading.BackColor = Color.FromArgb(7, 57, 60);
            labelHeading.Font = new Font("Tahoma", 48F, FontStyle.Bold, GraphicsUnit.Point);
            labelHeading.ForeColor = Color.White;
            labelHeading.Location = new Point(449, 24);
            labelHeading.Name = "labelHeading";
            labelHeading.Size = new Size(591, 77);
            labelHeading.TabIndex = 4;
            labelHeading.Text = "Add New Product";
            labelHeading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSubmit.BackColor = Color.FromArgb(7, 57, 60);
            btnSubmit.BackgroundColor = Color.FromArgb(7, 57, 60);
            btnSubmit.BorderColor = Color.FromArgb(44, 102, 110);
            btnSubmit.BorderRadius = 10;
            btnSubmit.BorderSize = 2;
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(1295, 27);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(189, 74);
            btnSubmit.TabIndex = 20;
            btnSubmit.Text = "Submit";
            btnSubmit.TextColor = Color.White;
            btnSubmit.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnBack.BackColor = Color.FromArgb(7, 57, 60);
            btnBack.BackgroundColor = Color.FromArgb(7, 57, 60);
            btnBack.BorderColor = Color.FromArgb(44, 102, 110);
            btnBack.BorderRadius = 10;
            btnBack.BorderSize = 2;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(26, 27);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(189, 74);
            btnBack.TabIndex = 21;
            btnBack.Text = "Back";
            btnBack.TextColor = Color.White;
            btnBack.UseVisualStyleBackColor = false;
            // 
            // panelMiddle
            // 
            panelMiddle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMiddle.Controls.Add(labelDate);
            panelMiddle.Controls.Add(dateTimePickerCreated);
            panelMiddle.Controls.Add(labelStock);
            panelMiddle.Controls.Add(textBoxStock);
            panelMiddle.Controls.Add(labelWholeSaleRate);
            panelMiddle.Controls.Add(textBoxWholeSaleRate);
            panelMiddle.Controls.Add(labelLocalRate);
            panelMiddle.Controls.Add(textBoxLocalRate);
            panelMiddle.Controls.Add(labelName);
            panelMiddle.Controls.Add(textBoxName);
            panelMiddle.Location = new Point(1, 126);
            panelMiddle.Name = "panelMiddle";
            panelMiddle.Size = new Size(1529, 549);
            panelMiddle.TabIndex = 22;
            // 
            // labelDate
            // 
            labelDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelDate.ForeColor = Color.White;
            labelDate.Location = new Point(411, 369);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(70, 33);
            labelDate.TabIndex = 29;
            labelDate.Text = "Date";
            // 
            // dateTimePickerCreated
            // 
            dateTimePickerCreated.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePickerCreated.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerCreated.Location = new Point(661, 362);
            dateTimePickerCreated.Name = "dateTimePickerCreated";
            dateTimePickerCreated.Size = new Size(379, 40);
            dateTimePickerCreated.TabIndex = 28;
            // 
            // labelStock
            // 
            labelStock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelStock.AutoSize = true;
            labelStock.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelStock.ForeColor = Color.White;
            labelStock.Location = new Point(411, 293);
            labelStock.Name = "labelStock";
            labelStock.Size = new Size(79, 33);
            labelStock.TabIndex = 27;
            labelStock.Text = "Stock";
            // 
            // textBoxStock
            // 
            textBoxStock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxStock.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxStock.Location = new Point(661, 286);
            textBoxStock.Name = "textBoxStock";
            textBoxStock.Size = new Size(379, 40);
            textBoxStock.TabIndex = 26;
            // 
            // labelWholeSaleRate
            // 
            labelWholeSaleRate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelWholeSaleRate.AutoSize = true;
            labelWholeSaleRate.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelWholeSaleRate.ForeColor = Color.White;
            labelWholeSaleRate.Location = new Point(411, 148);
            labelWholeSaleRate.Name = "labelWholeSaleRate";
            labelWholeSaleRate.Size = new Size(208, 33);
            labelWholeSaleRate.TabIndex = 25;
            labelWholeSaleRate.Text = "Whole Sale Rate";
            // 
            // textBoxWholeSaleRate
            // 
            textBoxWholeSaleRate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxWholeSaleRate.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxWholeSaleRate.Location = new Point(661, 141);
            textBoxWholeSaleRate.Name = "textBoxWholeSaleRate";
            textBoxWholeSaleRate.Size = new Size(379, 40);
            textBoxWholeSaleRate.TabIndex = 24;
            // 
            // labelLocalRate
            // 
            labelLocalRate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelLocalRate.AutoSize = true;
            labelLocalRate.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelLocalRate.ForeColor = Color.White;
            labelLocalRate.Location = new Point(411, 222);
            labelLocalRate.Name = "labelLocalRate";
            labelLocalRate.Size = new Size(137, 33);
            labelLocalRate.TabIndex = 23;
            labelLocalRate.Text = "Local Rate";
            // 
            // textBoxLocalRate
            // 
            textBoxLocalRate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxLocalRate.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLocalRate.Location = new Point(661, 215);
            textBoxLocalRate.Name = "textBoxLocalRate";
            textBoxLocalRate.Size = new Size(379, 40);
            textBoxLocalRate.TabIndex = 22;
            // 
            // labelName
            // 
            labelName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelName.AutoSize = true;
            labelName.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.ForeColor = Color.White;
            labelName.Location = new Point(411, 83);
            labelName.Name = "labelName";
            labelName.Size = new Size(84, 33);
            labelName.TabIndex = 21;
            labelName.Text = "Name";
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxName.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(661, 76);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(379, 40);
            textBoxName.TabIndex = 20;
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(btnBack);
            panelBottom.Controls.Add(btnSubmit);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 681);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(1529, 130);
            panelBottom.TabIndex = 23;
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(10, 9, 12);
            ClientSize = new Size(1529, 811);
            Controls.Add(panelBottom);
            Controls.Add(panelMiddle);
            Controls.Add(panelheading);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Product";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product";
            WindowState = FormWindowState.Maximized;
            panelheading.ResumeLayout(false);
            panelheading.PerformLayout();
            panelMiddle.ResumeLayout(false);
            panelMiddle.PerformLayout();
            panelBottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelheading;
        private Label labelHeading;
        private CustomControls.RJControls.RJButton btnSubmit;
        private CustomControls.RJControls.RJButton btnBack;
        private Panel panelMiddle;
        private Label labelDate;
        private DateTimePicker dateTimePickerCreated;
        private Label labelStock;
        private TextBox textBoxStock;
        private Label labelWholeSaleRate;
        private TextBox textBoxWholeSaleRate;
        private Label labelLocalRate;
        private TextBox textBoxLocalRate;
        private Label labelName;
        private TextBox textBoxName;
        private Panel panelBottom;
    }
}