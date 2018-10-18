namespace MyApplication.Admin
{
    partial class UsersListForm
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
            this.fullnameLable = new System.Windows.Forms.Label();
            this.fullNameTexbox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.deleteUsersButton = new System.Windows.Forms.Button();
            this.usersListbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // fullnameLable
            // 
            this.fullnameLable.AutoSize = true;
            this.fullnameLable.Location = new System.Drawing.Point(15, 15);
            this.fullnameLable.Name = "fullnameLable";
            this.fullnameLable.Size = new System.Drawing.Size(63, 13);
            this.fullnameLable.TabIndex = 0;
            this.fullnameLable.Text = "Full Name";
            // 
            // fullNameTexbox
            // 
            this.fullNameTexbox.Location = new System.Drawing.Point(103, 12);
            this.fullNameTexbox.Name = "fullNameTexbox";
            this.fullNameTexbox.Size = new System.Drawing.Size(214, 21);
            this.fullNameTexbox.TabIndex = 1;
            this.fullNameTexbox.TextChanged += new System.EventHandler(this.fullNameTexbox_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(103, 38);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(87, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // deleteUsersButton
            // 
            this.deleteUsersButton.Location = new System.Drawing.Point(14, 173);
            this.deleteUsersButton.Name = "deleteUsersButton";
            this.deleteUsersButton.Size = new System.Drawing.Size(148, 23);
            this.deleteUsersButton.TabIndex = 4;
            this.deleteUsersButton.Text = "&Delete Users";
            this.deleteUsersButton.UseVisualStyleBackColor = true;
            this.deleteUsersButton.Click += new System.EventHandler(this.deleteUsersButton_Click);
            // 
            // usersListbox
            // 
            this.usersListbox.FormattingEnabled = true;
            this.usersListbox.Location = new System.Drawing.Point(14, 72);
            this.usersListbox.Name = "usersListbox";
            this.usersListbox.Size = new System.Drawing.Size(303, 95);
            this.usersListbox.TabIndex = 3;
            this.usersListbox.SelectedIndexChanged += new System.EventHandler(this.usersListbox_SelectedIndexChanged);
            this.usersListbox.DoubleClick += new System.EventHandler(this.usersListbox_DoubleClick);
            // 
            // UsersListForm
            // 
            this.AcceptButton = this.searchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 212);
            this.Controls.Add(this.usersListbox);
            this.Controls.Add(this.deleteUsersButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.fullNameTexbox);
            this.Controls.Add(this.fullnameLable);
            this.MaximumSize = new System.Drawing.Size(347, 251);
            this.MinimumSize = new System.Drawing.Size(347, 251);
            this.Name = "UsersListForm";
            this.Text = "UsersListForm";
            this.Load += new System.EventHandler(this.UsersListForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fullnameLable;
        private System.Windows.Forms.TextBox fullNameTexbox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button deleteUsersButton;
        private System.Windows.Forms.ListBox usersListbox;
    }
}