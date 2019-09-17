namespace ArrayReverse
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
            this.showButton = new System.Windows.Forms.Button();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.inputSizeTextBox = new System.Windows.Forms.TextBox();
            this.elementTextBox = new System.Windows.Forms.TextBox();
            this.elementLabel = new System.Windows.Forms.Label();
            this.inputSizeButton = new System.Windows.Forms.Button();
            this.ElementAddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(365, 234);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 0;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(79, 36);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(54, 13);
            this.sizeLabel.TabIndex = 1;
            this.sizeLabel.Text = "Input Size";
            // 
            // inputSizeTextBox
            // 
            this.inputSizeTextBox.Location = new System.Drawing.Point(203, 33);
            this.inputSizeTextBox.Name = "inputSizeTextBox";
            this.inputSizeTextBox.Size = new System.Drawing.Size(128, 20);
            this.inputSizeTextBox.TabIndex = 2;
            // 
            // elementTextBox
            // 
            this.elementTextBox.Location = new System.Drawing.Point(203, 95);
            this.elementTextBox.Name = "elementTextBox";
            this.elementTextBox.Size = new System.Drawing.Size(128, 20);
            this.elementTextBox.TabIndex = 4;
            // 
            // elementLabel
            // 
            this.elementLabel.AutoSize = true;
            this.elementLabel.Location = new System.Drawing.Point(79, 102);
            this.elementLabel.Name = "elementLabel";
            this.elementLabel.Size = new System.Drawing.Size(45, 13);
            this.elementLabel.TabIndex = 3;
            this.elementLabel.Text = "Element";
            // 
            // inputSizeButton
            // 
            this.inputSizeButton.Location = new System.Drawing.Point(365, 30);
            this.inputSizeButton.Name = "inputSizeButton";
            this.inputSizeButton.Size = new System.Drawing.Size(75, 23);
            this.inputSizeButton.TabIndex = 5;
            this.inputSizeButton.Text = "Input";
            this.inputSizeButton.UseVisualStyleBackColor = true;
            this.inputSizeButton.Click += new System.EventHandler(this.inputSizeButton_Click);
            // 
            // ElementAddButton
            // 
            this.ElementAddButton.Location = new System.Drawing.Point(365, 97);
            this.ElementAddButton.Name = "ElementAddButton";
            this.ElementAddButton.Size = new System.Drawing.Size(75, 23);
            this.ElementAddButton.TabIndex = 6;
            this.ElementAddButton.Text = "Add";
            this.ElementAddButton.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 382);
            this.Controls.Add(this.ElementAddButton);
            this.Controls.Add(this.inputSizeButton);
            this.Controls.Add(this.elementTextBox);
            this.Controls.Add(this.elementLabel);
            this.Controls.Add(this.inputSizeTextBox);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.showButton);
            this.Name = "Home";
            this.Text = "Array";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.TextBox inputSizeTextBox;
        private System.Windows.Forms.TextBox elementTextBox;
        private System.Windows.Forms.Label elementLabel;
        private System.Windows.Forms.Button inputSizeButton;
        private System.Windows.Forms.Button ElementAddButton;
    }
}

