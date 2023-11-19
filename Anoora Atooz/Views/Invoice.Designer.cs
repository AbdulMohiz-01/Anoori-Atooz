namespace Anoora_Atooz.Views
{
    partial class Invoice
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
            panelMiddle = new Panel();
            labelCreatedDate = new Label();
            dateTimePickerCreated = new DateTimePicker();
            labelNetRate = new Label();
            textBoxNetRate = new TextBox();
            labelRate = new Label();
            textBoxRate = new TextBox();
            labelTotalDiscount = new Label();
            textBoxTotalDiscount = new TextBox();
            labelNetAmount = new Label();
            textBoxNetAmount = new TextBox();
            panelheading = new Panel();
            labelHeading = new Label();
            panelBottom = new Panel();
            btnBack = new CustomControls.RJControls.RJButton();
            btnSubmit = new CustomControls.RJControls.RJButton();
            bntSubmit = new CustomControls.RJControls.RJButton();
            labelDueDate = new Label();
            dateTimePickerDueDate = new DateTimePicker();
            labelQuantiy = new Label();
            textBoxQuantiy = new TextBox();
            labelInvoiceType = new Label();
            comboBoxInvoiceType = new ComboBox();
            labelProducts = new Label();
            textBoxProducts = new TextBox();
            panelMiddle.SuspendLayout();
            panelheading.SuspendLayout();
            panelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // panelMiddle
            // 
            panelMiddle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMiddle.Controls.Add(labelProducts);
            panelMiddle.Controls.Add(textBoxProducts);
            panelMiddle.Controls.Add(comboBoxInvoiceType);
            panelMiddle.Controls.Add(labelInvoiceType);
            panelMiddle.Controls.Add(labelQuantiy);
            panelMiddle.Controls.Add(textBoxQuantiy);
            panelMiddle.Controls.Add(labelDueDate);
            panelMiddle.Controls.Add(dateTimePickerDueDate);
            panelMiddle.Controls.Add(labelCreatedDate);
            panelMiddle.Controls.Add(dateTimePickerCreated);
            panelMiddle.Controls.Add(labelNetRate);
            panelMiddle.Controls.Add(textBoxNetRate);
            panelMiddle.Controls.Add(labelRate);
            panelMiddle.Controls.Add(textBoxRate);
            panelMiddle.Controls.Add(labelTotalDiscount);
            panelMiddle.Controls.Add(textBoxTotalDiscount);
            panelMiddle.Controls.Add(labelNetAmount);
            panelMiddle.Controls.Add(textBoxNetAmount);
            panelMiddle.Location = new Point(0, 125);
            panelMiddle.Name = "panelMiddle";
            panelMiddle.Size = new Size(1529, 549);
            panelMiddle.TabIndex = 25;
            panelMiddle.Paint += panelMiddle_Paint;
            // 
            // labelCreatedDate
            // 
            labelCreatedDate.AutoSize = true;
            labelCreatedDate.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelCreatedDate.ForeColor = Color.White;
            labelCreatedDate.Location = new Point(35, 282);
            labelCreatedDate.Name = "labelCreatedDate";
            labelCreatedDate.Size = new Size(170, 33);
            labelCreatedDate.TabIndex = 29;
            labelCreatedDate.Text = "Created Date";
            labelCreatedDate.Click += labelDate_Click;
            // 
            // dateTimePickerCreated
            // 
            dateTimePickerCreated.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerCreated.Location = new Point(246, 275);
            dateTimePickerCreated.Name = "dateTimePickerCreated";
            dateTimePickerCreated.Size = new Size(441, 40);
            dateTimePickerCreated.TabIndex = 28;
            // 
            // labelNetRate
            // 
            labelNetRate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelNetRate.AutoSize = true;
            labelNetRate.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelNetRate.ForeColor = Color.White;
            labelNetRate.Location = new Point(801, 208);
            labelNetRate.Name = "labelNetRate";
            labelNetRate.Size = new Size(118, 33);
            labelNetRate.TabIndex = 27;
            labelNetRate.Text = "Net Rate";
            // 
            // textBoxNetRate
            // 
            textBoxNetRate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxNetRate.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNetRate.Location = new Point(1051, 201);
            textBoxNetRate.Name = "textBoxNetRate";
            textBoxNetRate.Size = new Size(441, 40);
            textBoxNetRate.TabIndex = 26;
            // 
            // labelRate
            // 
            labelRate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelRate.AutoSize = true;
            labelRate.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelRate.ForeColor = Color.White;
            labelRate.Location = new Point(801, 63);
            labelRate.Name = "labelRate";
            labelRate.Size = new Size(69, 33);
            labelRate.TabIndex = 25;
            labelRate.Text = "Rate";
            // 
            // textBoxRate
            // 
            textBoxRate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxRate.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxRate.Location = new Point(1051, 56);
            textBoxRate.Name = "textBoxRate";
            textBoxRate.Size = new Size(441, 40);
            textBoxRate.TabIndex = 24;
            // 
            // labelTotalDiscount
            // 
            labelTotalDiscount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelTotalDiscount.AutoSize = true;
            labelTotalDiscount.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelTotalDiscount.ForeColor = Color.White;
            labelTotalDiscount.Location = new Point(801, 137);
            labelTotalDiscount.Name = "labelTotalDiscount";
            labelTotalDiscount.Size = new Size(185, 33);
            labelTotalDiscount.TabIndex = 23;
            labelTotalDiscount.Text = "Total Discount";
            // 
            // textBoxTotalDiscount
            // 
            textBoxTotalDiscount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxTotalDiscount.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTotalDiscount.Location = new Point(1051, 130);
            textBoxTotalDiscount.Name = "textBoxTotalDiscount";
            textBoxTotalDiscount.Size = new Size(441, 40);
            textBoxTotalDiscount.TabIndex = 22;
            // 
            // labelNetAmount
            // 
            labelNetAmount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelNetAmount.AutoSize = true;
            labelNetAmount.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelNetAmount.ForeColor = Color.White;
            labelNetAmount.Location = new Point(368, 416);
            labelNetAmount.Name = "labelNetAmount";
            labelNetAmount.Size = new Size(157, 33);
            labelNetAmount.TabIndex = 21;
            labelNetAmount.Text = "Net Amount";
            // 
            // textBoxNetAmount
            // 
            textBoxNetAmount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxNetAmount.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNetAmount.Location = new Point(618, 409);
            textBoxNetAmount.Name = "textBoxNetAmount";
            textBoxNetAmount.Size = new Size(441, 40);
            textBoxNetAmount.TabIndex = 20;
            // 
            // panelheading
            // 
            panelheading.Anchor = AnchorStyles.Top;
            panelheading.BackColor = Color.FromArgb(10, 9, 12);
            panelheading.Controls.Add(labelHeading);
            panelheading.Location = new Point(0, 1);
            panelheading.Name = "panelheading";
            panelheading.Size = new Size(1529, 126);
            panelheading.TabIndex = 24;
            // 
            // labelHeading
            // 
            labelHeading.Anchor = AnchorStyles.Top;
            labelHeading.AutoSize = true;
            labelHeading.BackColor = Color.FromArgb(7, 57, 60);
            labelHeading.Font = new Font("Tahoma", 48F, FontStyle.Bold, GraphicsUnit.Point);
            labelHeading.ForeColor = Color.White;
            labelHeading.Location = new Point(501, 27);
            labelHeading.Name = "labelHeading";
            labelHeading.Size = new Size(504, 77);
            labelHeading.TabIndex = 4;
            labelHeading.Text = "Create Invoice\r\n";
            labelHeading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(bntSubmit);
            panelBottom.Controls.Add(btnBack);
            panelBottom.Controls.Add(btnSubmit);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 683);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(1529, 128);
            panelBottom.TabIndex = 26;
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
            btnBack.Location = new Point(12, 26);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(189, 74);
            btnBack.TabIndex = 21;
            btnBack.Text = "Back";
            btnBack.TextColor = Color.White;
            btnBack.UseVisualStyleBackColor = false;
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
            btnSubmit.Location = new Point(2624, 53);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(189, 74);
            btnSubmit.TabIndex = 20;
            btnSubmit.Text = "Submit";
            btnSubmit.TextColor = Color.White;
            btnSubmit.UseVisualStyleBackColor = false;
            // 
            // bntSubmit
            // 
            bntSubmit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bntSubmit.BackColor = Color.FromArgb(7, 57, 60);
            bntSubmit.BackgroundColor = Color.FromArgb(7, 57, 60);
            bntSubmit.BorderColor = Color.FromArgb(44, 102, 110);
            bntSubmit.BorderRadius = 10;
            bntSubmit.BorderSize = 2;
            bntSubmit.FlatAppearance.BorderSize = 0;
            bntSubmit.FlatStyle = FlatStyle.Flat;
            bntSubmit.Font = new Font("Tahoma", 20F, FontStyle.Regular, GraphicsUnit.Point);
            bntSubmit.ForeColor = Color.White;
            bntSubmit.Location = new Point(1328, 26);
            bntSubmit.Name = "bntSubmit";
            bntSubmit.Size = new Size(189, 74);
            bntSubmit.TabIndex = 22;
            bntSubmit.Text = "Submit";
            bntSubmit.TextColor = Color.White;
            bntSubmit.UseVisualStyleBackColor = false;
            // 
            // labelDueDate
            // 
            labelDueDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelDueDate.AutoSize = true;
            labelDueDate.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelDueDate.ForeColor = Color.White;
            labelDueDate.Location = new Point(801, 281);
            labelDueDate.Name = "labelDueDate";
            labelDueDate.Size = new Size(125, 33);
            labelDueDate.TabIndex = 31;
            labelDueDate.Text = "Due Date";
            // 
            // dateTimePickerDueDate
            // 
            dateTimePickerDueDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePickerDueDate.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerDueDate.Location = new Point(1051, 275);
            dateTimePickerDueDate.Name = "dateTimePickerDueDate";
            dateTimePickerDueDate.Size = new Size(441, 40);
            dateTimePickerDueDate.TabIndex = 30;
            // 
            // labelQuantiy
            // 
            labelQuantiy.AutoSize = true;
            labelQuantiy.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelQuantiy.ForeColor = Color.White;
            labelQuantiy.Location = new Point(35, 70);
            labelQuantiy.Name = "labelQuantiy";
            labelQuantiy.Size = new Size(106, 33);
            labelQuantiy.TabIndex = 33;
            labelQuantiy.Text = "Quantiy";
            // 
            // textBoxQuantiy
            // 
            textBoxQuantiy.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxQuantiy.Location = new Point(246, 63);
            textBoxQuantiy.Name = "textBoxQuantiy";
            textBoxQuantiy.Size = new Size(441, 40);
            textBoxQuantiy.TabIndex = 32;
            // 
            // labelInvoiceType
            // 
            labelInvoiceType.AutoSize = true;
            labelInvoiceType.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelInvoiceType.ForeColor = Color.White;
            labelInvoiceType.Location = new Point(35, 137);
            labelInvoiceType.Name = "labelInvoiceType";
            labelInvoiceType.Size = new Size(166, 33);
            labelInvoiceType.TabIndex = 34;
            labelInvoiceType.Text = "Invoice Type";
            // 
            // comboBoxInvoiceType
            // 
            comboBoxInvoiceType.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxInvoiceType.FormattingEnabled = true;
            comboBoxInvoiceType.Items.AddRange(new object[] { "Whole Sale ", "Perchune" });
            comboBoxInvoiceType.Location = new Point(246, 135);
            comboBoxInvoiceType.Name = "comboBoxInvoiceType";
            comboBoxInvoiceType.Size = new Size(441, 41);
            comboBoxInvoiceType.TabIndex = 35;
            // 
            // labelProducts
            // 
            labelProducts.AutoSize = true;
            labelProducts.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelProducts.ForeColor = Color.White;
            labelProducts.Location = new Point(35, 215);
            labelProducts.Name = "labelProducts";
            labelProducts.Size = new Size(118, 33);
            labelProducts.TabIndex = 37;
            labelProducts.Text = "Products";
            // 
            // textBoxProducts
            // 
            textBoxProducts.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxProducts.Location = new Point(246, 208);
            textBoxProducts.Name = "textBoxProducts";
            textBoxProducts.Size = new Size(441, 40);
            textBoxProducts.TabIndex = 36;
            // 
            // Invoice
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
            MaximizeBox = false;
            Name = "Invoice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Invoice";
            WindowState = FormWindowState.Maximized;
            panelMiddle.ResumeLayout(false);
            panelMiddle.PerformLayout();
            panelheading.ResumeLayout(false);
            panelheading.PerformLayout();
            panelBottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelMiddle;
        private Label labelCreatedDate;
        private DateTimePicker dateTimePickerCreated;
        private Label labelNetRate;
        private TextBox textBoxNetRate;
        private Label labelRate;
        private TextBox textBoxRate;
        private Label labelTotalDiscount;
        private TextBox textBoxTotalDiscount;
        private Label labelNetAmount;
        private TextBox textBoxNetAmount;
        private Panel panelheading;
        private Label labelHeading;
        private Panel panelBottom;
        private CustomControls.RJControls.RJButton btnBack;
        private CustomControls.RJControls.RJButton btnSubmit;
        private CustomControls.RJControls.RJButton bntSubmit;
        private Label labelDueDate;
        private DateTimePicker dateTimePickerDueDate;
        private Label labelInvoiceType;
        private Label labelQuantiy;
        private TextBox textBoxQuantiy;
        private Label labelProducts;
        private TextBox textBoxProducts;
        private ComboBox comboBoxInvoiceType;
    }
}