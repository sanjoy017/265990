namespace Day5
{
    partial class Home
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
            this.studentGroupBox = new System.Windows.Forms.GroupBox();
            this.gpaPointCheckLabel = new System.Windows.Forms.Label();
            this.mobileCheckLabel = new System.Windows.Forms.Label();
            this.nameCheckLabel = new System.Windows.Forms.Label();
            this.idCheckLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.gpaPointTextBox = new System.Windows.Forms.TextBox();
            this.gpaPointLabel = new System.Windows.Forms.Label();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.mobileTextBox = new System.Windows.Forms.TextBox();
            this.MobileLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.gpaPointGroupBox = new System.Windows.Forms.GroupBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.minNameTextBox = new System.Windows.Forms.TextBox();
            this.minNameabel = new System.Windows.Forms.Label();
            this.avgTextBox = new System.Windows.Forms.TextBox();
            this.maxNameTextBox = new System.Windows.Forms.TextBox();
            this.minTextBox = new System.Windows.Forms.TextBox();
            this.avgLabel = new System.Windows.Forms.Label();
            this.maxNameLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.maxLabel = new System.Windows.Forms.Label();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.mobileRadioButton = new System.Windows.Forms.RadioButton();
            this.nameRadioButton = new System.Windows.Forms.RadioButton();
            this.idRadioButton = new System.Windows.Forms.RadioButton();
            this.showButton = new System.Windows.Forms.Button();
            this.studentGroupBox.SuspendLayout();
            this.gpaPointGroupBox.SuspendLayout();
            this.searchGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentGroupBox
            // 
            this.studentGroupBox.Controls.Add(this.gpaPointCheckLabel);
            this.studentGroupBox.Controls.Add(this.mobileCheckLabel);
            this.studentGroupBox.Controls.Add(this.nameCheckLabel);
            this.studentGroupBox.Controls.Add(this.idCheckLabel);
            this.studentGroupBox.Controls.Add(this.addButton);
            this.studentGroupBox.Controls.Add(this.gpaPointTextBox);
            this.studentGroupBox.Controls.Add(this.gpaPointLabel);
            this.studentGroupBox.Controls.Add(this.ageTextBox);
            this.studentGroupBox.Controls.Add(this.addressTextBox);
            this.studentGroupBox.Controls.Add(this.ageLabel);
            this.studentGroupBox.Controls.Add(this.addressLabel);
            this.studentGroupBox.Controls.Add(this.mobileTextBox);
            this.studentGroupBox.Controls.Add(this.MobileLabel);
            this.studentGroupBox.Controls.Add(this.nameTextBox);
            this.studentGroupBox.Controls.Add(this.nameLabel);
            this.studentGroupBox.Controls.Add(this.idTextBox);
            this.studentGroupBox.Controls.Add(this.idLabel);
            this.studentGroupBox.Location = new System.Drawing.Point(35, 22);
            this.studentGroupBox.Name = "studentGroupBox";
            this.studentGroupBox.Size = new System.Drawing.Size(433, 308);
            this.studentGroupBox.TabIndex = 2;
            this.studentGroupBox.TabStop = false;
            this.studentGroupBox.Text = "Student";
            // 
            // gpaPointCheckLabel
            // 
            this.gpaPointCheckLabel.AutoSize = true;
            this.gpaPointCheckLabel.Location = new System.Drawing.Point(324, 220);
            this.gpaPointCheckLabel.Name = "gpaPointCheckLabel";
            this.gpaPointCheckLabel.Size = new System.Drawing.Size(37, 13);
            this.gpaPointCheckLabel.TabIndex = 18;
            this.gpaPointCheckLabel.Text = "0-4.00";
            // 
            // mobileCheckLabel
            // 
            this.mobileCheckLabel.AutoSize = true;
            this.mobileCheckLabel.Location = new System.Drawing.Point(324, 97);
            this.mobileCheckLabel.Name = "mobileCheckLabel";
            this.mobileCheckLabel.Size = new System.Drawing.Size(86, 13);
            this.mobileCheckLabel.TabIndex = 17;
            this.mobileCheckLabel.Text = "* U 11 Character";
            // 
            // nameCheckLabel
            // 
            this.nameCheckLabel.AutoSize = true;
            this.nameCheckLabel.Location = new System.Drawing.Point(321, 58);
            this.nameCheckLabel.Name = "nameCheckLabel";
            this.nameCheckLabel.Size = new System.Drawing.Size(98, 13);
            this.nameCheckLabel.TabIndex = 16;
            this.nameCheckLabel.Text = "* Max 30 Character";
            // 
            // idCheckLabel
            // 
            this.idCheckLabel.AutoSize = true;
            this.idCheckLabel.Location = new System.Drawing.Point(321, 22);
            this.idCheckLabel.Name = "idCheckLabel";
            this.idCheckLabel.Size = new System.Drawing.Size(77, 13);
            this.idCheckLabel.TabIndex = 15;
            this.idCheckLabel.Text = "* U 4Character";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(324, 263);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 39);
            this.addButton.TabIndex = 14;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // gpaPointTextBox
            // 
            this.gpaPointTextBox.Location = new System.Drawing.Point(152, 220);
            this.gpaPointTextBox.MaxLength = 4;
            this.gpaPointTextBox.Name = "gpaPointTextBox";
            this.gpaPointTextBox.Size = new System.Drawing.Size(146, 20);
            this.gpaPointTextBox.TabIndex = 8;
            this.gpaPointTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gpaPointTextBox_KeyPress);
            // 
            // gpaPointLabel
            // 
            this.gpaPointLabel.AutoSize = true;
            this.gpaPointLabel.Location = new System.Drawing.Point(15, 220);
            this.gpaPointLabel.Name = "gpaPointLabel";
            this.gpaPointLabel.Size = new System.Drawing.Size(56, 13);
            this.gpaPointLabel.TabIndex = 2;
            this.gpaPointLabel.Text = "GPA Point";
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(152, 134);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(146, 20);
            this.ageTextBox.TabIndex = 9;
            this.ageTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ageTextBox_KeyPress);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(152, 174);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(146, 20);
            this.addressTextBox.TabIndex = 10;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(22, 134);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(26, 13);
            this.ageLabel.TabIndex = 3;
            this.ageLabel.Text = "Age";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(15, 177);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(45, 13);
            this.addressLabel.TabIndex = 4;
            this.addressLabel.Text = "Address";
            // 
            // mobileTextBox
            // 
            this.mobileTextBox.Location = new System.Drawing.Point(152, 97);
            this.mobileTextBox.MaxLength = 11;
            this.mobileTextBox.Name = "mobileTextBox";
            this.mobileTextBox.Size = new System.Drawing.Size(146, 20);
            this.mobileTextBox.TabIndex = 11;
            this.mobileTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mobileNumberTextBox_KeyPress);
            // 
            // MobileLabel
            // 
            this.MobileLabel.AutoSize = true;
            this.MobileLabel.Location = new System.Drawing.Point(22, 97);
            this.MobileLabel.Name = "MobileLabel";
            this.MobileLabel.Size = new System.Drawing.Size(38, 13);
            this.MobileLabel.TabIndex = 5;
            this.MobileLabel.Text = "Mobile";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(152, 55);
            this.nameTextBox.MaxLength = 30;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(146, 20);
            this.nameTextBox.TabIndex = 12;
            this.nameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameTextBox_KeyPress);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(22, 58);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "Name";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(152, 19);
            this.idTextBox.MaxLength = 4;
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(146, 20);
            this.idTextBox.TabIndex = 13;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(22, 23);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(18, 13);
            this.idLabel.TabIndex = 7;
            this.idLabel.Text = "ID";
            // 
            // richTextBox
            // 
            this.richTextBox.Cursor = System.Windows.Forms.Cursors.No;
            this.richTextBox.Location = new System.Drawing.Point(35, 347);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(630, 98);
            this.richTextBox.TabIndex = 3;
            this.richTextBox.Text = "";
            // 
            // gpaPointGroupBox
            // 
            this.gpaPointGroupBox.Controls.Add(this.totalTextBox);
            this.gpaPointGroupBox.Controls.Add(this.totalLabel);
            this.gpaPointGroupBox.Controls.Add(this.minNameTextBox);
            this.gpaPointGroupBox.Controls.Add(this.minNameabel);
            this.gpaPointGroupBox.Controls.Add(this.avgTextBox);
            this.gpaPointGroupBox.Controls.Add(this.maxNameTextBox);
            this.gpaPointGroupBox.Controls.Add(this.minTextBox);
            this.gpaPointGroupBox.Controls.Add(this.avgLabel);
            this.gpaPointGroupBox.Controls.Add(this.maxNameLabel);
            this.gpaPointGroupBox.Controls.Add(this.minLabel);
            this.gpaPointGroupBox.Controls.Add(this.maxTextBox);
            this.gpaPointGroupBox.Controls.Add(this.maxLabel);
            this.gpaPointGroupBox.Cursor = System.Windows.Forms.Cursors.No;
            this.gpaPointGroupBox.Location = new System.Drawing.Point(53, 469);
            this.gpaPointGroupBox.Name = "gpaPointGroupBox";
            this.gpaPointGroupBox.Size = new System.Drawing.Size(604, 86);
            this.gpaPointGroupBox.TabIndex = 4;
            this.gpaPointGroupBox.TabStop = false;
            this.gpaPointGroupBox.Text = "GPA Point";
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(473, 41);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(115, 20);
            this.totalTextBox.TabIndex = 1;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(420, 41);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(31, 13);
            this.totalLabel.TabIndex = 0;
            this.totalLabel.Text = "Total";
            // 
            // minNameTextBox
            // 
            this.minNameTextBox.Location = new System.Drawing.Point(286, 41);
            this.minNameTextBox.Name = "minNameTextBox";
            this.minNameTextBox.Size = new System.Drawing.Size(115, 20);
            this.minNameTextBox.TabIndex = 1;
            // 
            // minNameabel
            // 
            this.minNameabel.AutoSize = true;
            this.minNameabel.Location = new System.Drawing.Point(207, 44);
            this.minNameabel.Name = "minNameabel";
            this.minNameabel.Size = new System.Drawing.Size(35, 13);
            this.minNameabel.TabIndex = 0;
            this.minNameabel.Text = "Name";
            // 
            // avgTextBox
            // 
            this.avgTextBox.Location = new System.Drawing.Point(473, 15);
            this.avgTextBox.Name = "avgTextBox";
            this.avgTextBox.Size = new System.Drawing.Size(115, 20);
            this.avgTextBox.TabIndex = 1;
            // 
            // maxNameTextBox
            // 
            this.maxNameTextBox.Location = new System.Drawing.Point(72, 44);
            this.maxNameTextBox.Name = "maxNameTextBox";
            this.maxNameTextBox.Size = new System.Drawing.Size(115, 20);
            this.maxNameTextBox.TabIndex = 1;
            // 
            // minTextBox
            // 
            this.minTextBox.Location = new System.Drawing.Point(286, 15);
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.Size = new System.Drawing.Size(115, 20);
            this.minTextBox.TabIndex = 1;
            // 
            // avgLabel
            // 
            this.avgLabel.AutoSize = true;
            this.avgLabel.Location = new System.Drawing.Point(420, 15);
            this.avgLabel.Name = "avgLabel";
            this.avgLabel.Size = new System.Drawing.Size(26, 13);
            this.avgLabel.TabIndex = 0;
            this.avgLabel.Text = "Avg";
            // 
            // maxNameLabel
            // 
            this.maxNameLabel.AutoSize = true;
            this.maxNameLabel.Location = new System.Drawing.Point(25, 48);
            this.maxNameLabel.Name = "maxNameLabel";
            this.maxNameLabel.Size = new System.Drawing.Size(35, 13);
            this.maxNameLabel.TabIndex = 0;
            this.maxNameLabel.Text = "Name";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(207, 18);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(24, 13);
            this.minLabel.TabIndex = 0;
            this.minLabel.Text = "Min";
            // 
            // maxTextBox
            // 
            this.maxTextBox.Location = new System.Drawing.Point(72, 18);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(115, 20);
            this.maxTextBox.TabIndex = 1;
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(25, 22);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(27, 13);
            this.maxLabel.TabIndex = 0;
            this.maxLabel.Text = "Max";
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.searchButton);
            this.searchGroupBox.Controls.Add(this.mobileRadioButton);
            this.searchGroupBox.Controls.Add(this.nameRadioButton);
            this.searchGroupBox.Controls.Add(this.idRadioButton);
            this.searchGroupBox.Location = new System.Drawing.Point(526, 38);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Size = new System.Drawing.Size(139, 174);
            this.searchGroupBox.TabIndex = 5;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Search";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(35, 131);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(82, 37);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // mobileRadioButton
            // 
            this.mobileRadioButton.AutoSize = true;
            this.mobileRadioButton.Location = new System.Drawing.Point(15, 83);
            this.mobileRadioButton.Name = "mobileRadioButton";
            this.mobileRadioButton.Size = new System.Drawing.Size(56, 17);
            this.mobileRadioButton.TabIndex = 0;
            this.mobileRadioButton.TabStop = true;
            this.mobileRadioButton.Text = "Mobile";
            this.mobileRadioButton.UseVisualStyleBackColor = true;
            // 
            // nameRadioButton
            // 
            this.nameRadioButton.AutoSize = true;
            this.nameRadioButton.Location = new System.Drawing.Point(15, 52);
            this.nameRadioButton.Name = "nameRadioButton";
            this.nameRadioButton.Size = new System.Drawing.Size(53, 17);
            this.nameRadioButton.TabIndex = 0;
            this.nameRadioButton.TabStop = true;
            this.nameRadioButton.Text = "Name";
            this.nameRadioButton.UseVisualStyleBackColor = true;
            // 
            // idRadioButton
            // 
            this.idRadioButton.AutoSize = true;
            this.idRadioButton.Location = new System.Drawing.Point(15, 23);
            this.idRadioButton.Name = "idRadioButton";
            this.idRadioButton.Size = new System.Drawing.Size(36, 17);
            this.idRadioButton.TabIndex = 0;
            this.idRadioButton.TabStop = true;
            this.idRadioButton.Text = "ID";
            this.idRadioButton.UseVisualStyleBackColor = true;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(501, 285);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(93, 39);
            this.showButton.TabIndex = 6;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 556);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.searchGroupBox);
            this.Controls.Add(this.gpaPointGroupBox);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.studentGroupBox);
            this.Name = "Home";
            this.Text = "Student Information";
            this.studentGroupBox.ResumeLayout(false);
            this.studentGroupBox.PerformLayout();
            this.gpaPointGroupBox.ResumeLayout(false);
            this.gpaPointGroupBox.PerformLayout();
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox studentGroupBox;
        private System.Windows.Forms.Label mobileCheckLabel;
        private System.Windows.Forms.Label nameCheckLabel;
        private System.Windows.Forms.Label idCheckLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox gpaPointTextBox;
        private System.Windows.Forms.Label gpaPointLabel;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox mobileTextBox;
        private System.Windows.Forms.Label MobileLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.GroupBox gpaPointGroupBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox minNameTextBox;
        private System.Windows.Forms.Label minNameabel;
        private System.Windows.Forms.TextBox avgTextBox;
        private System.Windows.Forms.TextBox maxNameTextBox;
        private System.Windows.Forms.TextBox minTextBox;
        private System.Windows.Forms.Label avgLabel;
        private System.Windows.Forms.Label maxNameLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.TextBox maxTextBox;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.RadioButton mobileRadioButton;
        private System.Windows.Forms.RadioButton nameRadioButton;
        private System.Windows.Forms.RadioButton idRadioButton;
        private System.Windows.Forms.Label gpaPointCheckLabel;
        private System.Windows.Forms.Button showButton;
    }
}

