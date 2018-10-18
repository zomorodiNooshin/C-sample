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
    public partial class UsersListForm : Infrastructure.BaseForm
    {
        public UsersListForm()
        {
            InitializeComponent();
        }

        private void fullNameTexbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Search();
        }
        private void Search()
        {
            Models.DatabaseContext databaseContext = null;
            try
            {
                databaseContext = new Models.DatabaseContext();
                System.Collections.Generic.List<Models.User> users = null;
                fullNameTexbox.Text = fullNameTexbox.Text.Trim();
                while (fullNameTexbox.Text.Contains("  "))
                {
                    fullNameTexbox.Text = fullNameTexbox.Text.Replace("  ", " ");
                }
                if (fullNameTexbox.Text==string.Empty)
                {
                    users = databaseContext.Users.OrderBy(current => current.FullName).ToList();
                }
                else
                {
                    users = databaseContext.Users
                        .Where(current => current.FullName.Contains(fullNameTexbox.Text))
                        .OrderBy(current => current.FullName).ToList();
                }
                usersListbox.ValueMember = "id";
                usersListbox.DisplayMember = "FullName";
                usersListbox.DataSource = users;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                if (databaseContext!=null)
                {
                    databaseContext.Dispose();
                    databaseContext = null;
                }
            }
        }

        private void UsersListForm_Load(object sender, EventArgs e)
        {

        }

        private void usersListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private Admin.UpdateUserForm updateUserForm;
        private void usersListbox_DoubleClick(object sender, EventArgs e)
        {
            Models.User selectedUser = usersListbox.SelectedItem as Models.User;
            if (selectedUser != null)
            {
                UpdateUserForm updateUserForm = new UpdateUserForm
                {
                    SelectedUser = selectedUser
                };

                updateUserForm.ShowDialog();
                Search();
            }

            //if ((updateUserForm == null) || (updateUserForm.IsDisposed))
            //{
            //    updateUserForm = new Admin.UpdateUserForm
            //    {
            //        MdiParent = this
            //    };
            //}
            //updateUserForm.Show();
        }

        private void deleteUsersButton_Click(object sender, EventArgs e)
        {
            if (usersListbox.SelectedItems.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("You did not select any users for deleting!");
                return;
            }
            Models.DatabaseContext databaseContext = null;
            try
            {
                databaseContext = new Models.DatabaseContext();
                foreach (var selectedItem in usersListbox.SelectedItems)
                {
                    Models.User selectedUser = selectedItem as Models.User;
                    if (selectedUser != null)
                    {
                        if (selectedUser.IsAdmin == false)
                        {
                            databaseContext.Entry(selectedUser).State = System.Data.Entity.EntityState.Deleted;
                            databaseContext.SaveChanges();
                        }
                    }
                }
                Search();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                if (databaseContext != null)
                {
                    databaseContext.Dispose();
                    databaseContext = null;
                }
            }
        }
    }
}
