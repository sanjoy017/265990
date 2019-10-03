namespace Day8
{
    partial class customerInformationForm
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
            this.addButton = new System.Windows.Forms.Button();
            this.customerInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.deletedIDTextBox = new System.Windows.Forms.TextBox();
            this.deletedIDLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.contactNoTextBox = new System.Windows.Forms.TextBox();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.contactNoLabel = new System.Windows.Forms.Label();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.showDataGridView = new System.Windows.Forms.DataGridView();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchNameLabel = new System.Windows.Forms.Label();
            this.customerInformationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(11, 222);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // customerInformationGroupBox
            // 
            this.customerInformationGroupBox.Controls.Add(this.deletedIDTextBox);
            this.customerInformationGroupBox.Controls.Add(this.deletedIDLabel);
            this.customerInformationGroupBox.Controls.Add(this.deleteButton);
            this.customerInformationGroupBox.Controls.Add(this.updateButton);
            this.customerInformationGroupBox.Controls.Add(this.showButton);
            this.customerInformationGroupBox.Controls.Add(this.addressTextBox);
            this.customerInformationGroupBox.Controls.Add(this.contactNoTextBox);
            this.customerInformationGroupBox.Controls.Add(this.customerNameTextBox);
            this.customerInformationGroupBox.Controls.Add(this.addressLabel);
            this.customerInformationGroupBox.Controls.Add(this.contactNoLabel);
            this.customerInformationGroupBox.Controls.Add(this.customerNameLabel);
            this.customerInformationGroupBox.Controls.Add(this.addButton);
            this.customerInformationGroupBox.Location = new System.Drawing.Point(46, 35);
            this.customerInformationGroupBox.Name = "customerInformationGroupBox";
            this.customerInformationGroupBox.Size = new System.Drawing.Size(248, 305);
            this.customerInformationGroupBox.TabIndex = 1;
            this.customerInformationGroupBox.TabStop = false;
            this.customerInformationGroupBox.Text = "Customer Information";
            // 
            // deletedIDTextBox
            // 
            this.deletedIDTextBox.Location = new System.Drawing.Point(135, 167);
            this.deletedIDTextBox.MaxLength = 100;
            this.deletedIDTextBox.Name = "deletedIDTextBox";
            this.deletedIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.deletedIDTextBox.TabIndex = 10;
            this.deletedIDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DeletedId_KeyPress);
            // 
            // deletedIDLabel
            // 
            this.deletedIDLabel.AutoSize = true;
            this.deletedIDLabel.Location = new System.Drawing.Point(30, 170);
            this.deletedIDLabel.Name = "deletedIDLabel";
            this.deletedIDLabel.Size = new System.Drawing.Size(18, 13);
            this.deletedIDLabel.TabIndex = 9;
            this.deletedIDLabel.Text = "ID";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(112, 263);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(7, 263);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 7;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(112, 222);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 7;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(135, 116);
            this.addressTextBox.MaxLength = 50;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox.TabIndex = 6;
            // 
            // contactNoTextBox
            // 
            this.contactNoTextBox.Location = new System.Drawing.Point(135, 72);
            this.contactNoTextBox.Name = "contactNoTextBox";
            this.contactNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.contactNoTextBox.TabIndex = 5;
            this.contactNoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ContactNoTextBox_KeyPress);
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(135, 37);
            this.customerNameTextBox.MaxLength = 50;
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.customerNameTextBox.TabIndex = 4;
            this.customerNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustomerNameTextBox_KeyPress);
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(27, 116);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(45, 13);
            this.addressLabel.TabIndex = 3;
            this.addressLabel.Text = "Address";
            // 
            // contactNoLabel
            // 
            this.contactNoLabel.AutoSize = true;
            this.contactNoLabel.Location = new System.Drawing.Point(27, 80);
            this.contactNoLabel.Name = "contactNoLabel";
            this.contactNoLabel.Size = new System.Drawing.Size(61, 13);
            this.contactNoLabel.TabIndex = 2;
            this.contactNoLabel.Text = "Contact No";
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(27, 37);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(82, 13);
            this.customerNameLabel.TabIndex = 1;
            this.customerNameLabel.Text = "Customer Name";
            // 
            // showDataGridView
            // 
            this.showDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showDataGridView.Location = new System.Drawing.Point(300, 35);
            this.showDataGridView.Name = "showDataGridView";
            this.showDataGridView.Size = new System.Drawing.Size(425, 198);
            this.showDataGridView.TabIndex = 2;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(433, 253);
            this.searchTextBox.MaxLength = 50;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchTextBox.TabIndex = 3;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(539, 253);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchNameLabel
            // 
            this.searchNameLabel.AutoSize = true;
            this.searchNameLabel.Location = new System.Drawing.Point(381, 257);
            this.searchNameLabel.Name = "searchNameLabel";
            this.searchNameLabel.Size = new System.Drawing.Size(35, 13);
            this.searchNameLabel.TabIndex = 5;
            this.searchNameLabel.Text = "Name";
            // 
            // customerInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 375);
            this.Controls.Add(this.searchNameLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.showDataGridView);
            this.Controls.Add(this.customerInformationGroupBox);
            this.Name = "customerInformationForm";
            this.Text = "Customer Information";
            this.customerInformationGroupBox.ResumeLayout(false);
            this.customerInformationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.GroupBox customerInformationGroupBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox contactNoTextBox;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label contactNoLabel;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.DataGridView showDataGridView;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label searchNameLabel;
        private System.Windows.Forms.TextBox deletedIDTextBox;
        private System.Windows.Forms.Label deletedIDLabel;
    }
}

