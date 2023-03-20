namespace Assignment
{
    partial class CreateBox
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.costBox = new System.Windows.Forms.TextBox();
            this.weightBox = new System.Windows.Forms.TextBox();
            this.cleaningBox = new System.Windows.Forms.TextBox();
            this.protectiveBox = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.cleaningLabel = new System.Windows.Forms.Label();
            this.protectionLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.itemTypeBox = new System.Windows.Forms.ComboBox();
            this.itemTypeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(130, 95);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(131, 23);
            this.nameBox.TabIndex = 0;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // costBox
            // 
            this.costBox.Location = new System.Drawing.Point(130, 124);
            this.costBox.Name = "costBox";
            this.costBox.Size = new System.Drawing.Size(131, 23);
            this.costBox.TabIndex = 1;
            // 
            // weightBox
            // 
            this.weightBox.Location = new System.Drawing.Point(130, 153);
            this.weightBox.Name = "weightBox";
            this.weightBox.Size = new System.Drawing.Size(131, 23);
            this.weightBox.TabIndex = 2;
            // 
            // cleaningBox
            // 
            this.cleaningBox.Location = new System.Drawing.Point(130, 182);
            this.cleaningBox.Name = "cleaningBox";
            this.cleaningBox.Size = new System.Drawing.Size(131, 23);
            this.cleaningBox.TabIndex = 3;
            // 
            // protectiveBox
            // 
            this.protectiveBox.Location = new System.Drawing.Point(130, 211);
            this.protectiveBox.Name = "protectiveBox";
            this.protectiveBox.Size = new System.Drawing.Size(131, 23);
            this.protectiveBox.TabIndex = 4;
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(130, 243);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(131, 23);
            this.Description.TabIndex = 5;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(30, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(231, 37);
            this.titleLabel.TabIndex = 6;
            this.titleLabel.Text = "Create a new Item";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 98);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(39, 15);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Name";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(12, 127);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(31, 15);
            this.costLabel.TabIndex = 8;
            this.costLabel.Text = "Cost";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(12, 156);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(45, 15);
            this.weightLabel.TabIndex = 9;
            this.weightLabel.Text = "Weight";
            // 
            // cleaningLabel
            // 
            this.cleaningLabel.AutoSize = true;
            this.cleaningLabel.Location = new System.Drawing.Point(12, 185);
            this.cleaningLabel.Name = "cleaningLabel";
            this.cleaningLabel.Size = new System.Drawing.Size(90, 15);
            this.cleaningLabel.TabIndex = 10;
            this.cleaningLabel.Text = "Cleaning Magic";
            // 
            // protectionLabel
            // 
            this.protectionLabel.AutoSize = true;
            this.protectionLabel.Location = new System.Drawing.Point(12, 214);
            this.protectionLabel.Name = "protectionLabel";
            this.protectionLabel.Size = new System.Drawing.Size(98, 15);
            this.protectionLabel.TabIndex = 11;
            this.protectionLabel.Text = "Protection Magic";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(12, 246);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(67, 15);
            this.descriptionLabel.TabIndex = 12;
            this.descriptionLabel.Text = "Description";
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addButton.Location = new System.Drawing.Point(50, 278);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(72, 31);
            this.addButton.TabIndex = 13;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancelButton.Location = new System.Drawing.Point(172, 278);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(72, 31);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // itemTypeBox
            // 
            this.itemTypeBox.BackColor = System.Drawing.SystemColors.Window;
            this.itemTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemTypeBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.itemTypeBox.FormattingEnabled = true;
            this.itemTypeBox.Items.AddRange(new object[] {
            "Clothing",
            "Spell",
            "Two Handed",
            "Right Handed",
            "Left Handed"});
            this.itemTypeBox.Location = new System.Drawing.Point(130, 49);
            this.itemTypeBox.Name = "itemTypeBox";
            this.itemTypeBox.Size = new System.Drawing.Size(143, 23);
            this.itemTypeBox.TabIndex = 15;
            // 
            // itemTypeLabel
            // 
            this.itemTypeLabel.AutoSize = true;
            this.itemTypeLabel.Location = new System.Drawing.Point(12, 52);
            this.itemTypeLabel.Name = "itemTypeLabel";
            this.itemTypeLabel.Size = new System.Drawing.Size(58, 15);
            this.itemTypeLabel.TabIndex = 16;
            this.itemTypeLabel.Text = "Item Type";
            // 
            // CreateBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 321);
            this.Controls.Add(this.itemTypeLabel);
            this.Controls.Add(this.itemTypeBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.protectionLabel);
            this.Controls.Add(this.cleaningLabel);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.protectiveBox);
            this.Controls.Add(this.cleaningBox);
            this.Controls.Add(this.weightBox);
            this.Controls.Add(this.costBox);
            this.Controls.Add(this.nameBox);
            this.Name = "CreateBox";
            this.Text = "CreateBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox costBox;
        private System.Windows.Forms.TextBox weightBox;
        private System.Windows.Forms.TextBox cleaningBox;
        private System.Windows.Forms.TextBox protectiveBox;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label cleaningLabel;
        private System.Windows.Forms.Label protectionLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox itemTypeBox;
        private System.Windows.Forms.Label itemTypeLabel;
    }
}