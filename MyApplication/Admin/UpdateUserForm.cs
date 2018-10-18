using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApplication.Admin
{
    public partial class UpdateUserForm : Form
    {
        public UpdateUserForm()
        {
            InitializeComponent();
        }
        public Models.User SelectedUser { get; set; }
        private void UpdateUserForm_Load(object sender, EventArgs e)
        {
            Models.DatabaseContext databaseContext = null;
            try
            {
                databaseContext = new Models.DatabaseContext();
                Models.User foundedUser = databaseContext.Users
                    .Where(current => current.Id == SelectedUser.Id).FirstOrDefault();
                if (foundedUser == null)
                {
                    System.Windows.Forms.MessageBox.Show("There is No User!");
                    Close();
                }
                adminCheckBox.Checked = foundedUser.IsAdmin;
                activeCheckBox.Checked = foundedUser.IsActive;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                Close();
            }
        }

        private void saveAndCloseButton_Click(object sender, EventArgs e)
        {
            Models.DatabaseContext databaseContext = null;
            try
            {
                databaseContext = new Models.DatabaseContext();
                Models.User foundedUser = databaseContext.Users
                    .Where(current => current.Id == SelectedUser.Id).FirstOrDefault();
                if (foundedUser == null)
                {
                    System.Windows.Forms.MessageBox.Show("There Is No Such a USER!");
                    Close();
                }
                foundedUser.IsAdmin = adminCheckBox.Checked;
                foundedUser.IsActive = activeCheckBox.Checked;
                foundedUser.FullName = fullNameTextbox.Text;
                foundedUser.Description = descriptionTexbox.Text;
                databaseContext.SaveChanges();
                Close();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                Close();
            }
        }
    }
}
