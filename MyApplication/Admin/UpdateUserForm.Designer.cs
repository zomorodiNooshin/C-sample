namespace MyApplication.Admin
{
    partial class UpdateUserForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fullNameTextbox = new System.Windows.Forms.TextBox();
            this.descriptionTexbox = new System.Windows.Forms.TextBox();
            this.activeCheckBox = new System.Windows.Forms.CheckBox();
            this.adminCheckBox = new System.Windows.Forms.CheckBox();
            this.saveAndCloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // fullNameTextbox
            // 
            this.fullNameTextbox.Location = new System.Drawing.Point(89, 12);
            this.fullNameTextbox.Name = "fullNameTextbox";
            this.fullNameTextbox.Size = new System.Drawing.Size(223, 20);
            this.fullNameTextbox.TabIndex = 1;
            // 
            // descriptionTexbox
            // 
            this.descriptionTexbox.Location = new System.Drawing.Point(89, 48);
            this.descriptionTexbox.Multiline = true;
            this.descriptionTexbox.Name = "descriptionTexbox";
            this.descriptionTexbox.Size = new System.Drawing.Size(223, 132);
            this.descriptionTexbox.TabIndex = 3;
            // 
            // activeCheckBox
            // 
            this.activeCheckBox.AutoSize = true;
            this.activeCheckBox.Location = new System.Drawing.Point(89, 205);
            this.activeCheckBox.Name = "activeCheckBox";
            this.activeCheckBox.Size = new System.Drawing.Size(56, 17);
            this.activeCheckBox.TabIndex = 4;
            this.activeCheckBox.Text = "Active";
            this.activeCheckBox.UseVisualStyleBackColor = true;
            // 
            // adminCheckBox
            // 
            this.adminCheckBox.AutoSize = true;
            this.adminCheckBox.Location = new System.Drawing.Point(89, 232);
            this.adminCheckBox.Name = "adminCheckBox";
            this.adminCheckBox.Size = new System.Drawing.Size(55, 17);
            this.adminCheckBox.TabIndex = 5;
            this.adminCheckBox.Text = "Admin";
            this.adminCheckBox.UseVisualStyleBackColor = true;
            // 
            // saveAndCloseButton
            // 
            this.saveAndCloseButton.Location = new System.Drawing.Point(89, 268);
            this.saveAndCloseButton.Name = "saveAndCloseButton";
            this.saveAndCloseButton.Size = new System.Drawing.Size(102, 23);
            this.saveAndCloseButton.TabIndex = 6;
            this.saveAndCloseButton.Text = "Save And Close";
            this.saveAndCloseButton.UseVisualStyleBackColor = true;
            this.saveAndCloseButton.Click += new System.EventHandler(this.saveAndCloseButton_Click);
            // 
            // UpdateUserForm
            // 
            this.AcceptButton = this.saveAndCloseButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 303);
            this.Controls.Add(this.saveAndCloseButton);
            this.Controls.Add(this.adminCheckBox);
            this.Controls.Add(this.activeCheckBox);
            this.Controls.Add(this.descriptionTexbox);
            this.Controls.Add(this.fullNameTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(340, 342);
            this.MinimumSize = new System.Drawing.Size(340, 342);
            this.Name = "UpdateUserForm";
            this.Text = "UpdateUserForm";
            this.Load += new System.EventHandler(this.UpdateUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fullNameTextbox;
        private System.Windows.Forms.TextBox descriptionTexbox;
        private System.Windows.Forms.CheckBox activeCheckBox;
        private System.Windows.Forms.CheckBox adminCheckBox;
        private System.Windows.Forms.Button saveAndCloseButton;
    }
}