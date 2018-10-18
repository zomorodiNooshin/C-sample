using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void asswToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateWelcomeToolstripStatusLabel();
            usernameToolStripStatusLabel.Text = "Welcome";
            adminToolStripMenuItem.Visible = Infrastructure.Utility.AuthenticatedUser.IsAdmin;

        }
        public void UpdateWelcomeToolstripStatusLabel ()
        {
            usernameToolStripStatusLabel.Text = $"Welcome{Infrastructure.Utility.AuthenticatedUser.Username}!";
        }

        private void usernameToolStripStatusLabel_Click(object sender, EventArgs e)
        {

        }
        private UpdateProfileForm updateProfileForm;
        private void updateProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //UpdateProfileForm updateProfileForm = new UpdateProfileForm();
            //updateProfileForm.MdiParent = this;
            //updateProfileForm.Show();
            if ((updateProfileForm==null)||(updateProfileForm.IsDisposed))
            {
                updateProfileForm = new UpdateProfileForm
                {
                    MdiParent = this
                };
            }
            updateProfileForm.Show();
        }

        private ChangePasswordForm changePasswordForm;
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((changePasswordForm == null) || (changePasswordForm.IsDisposed))
            {
                changePasswordForm = new ChangePasswordForm
                {
                    MdiParent = this
                };
            }
            changePasswordForm.Show();
        }

        //private void usersListToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //}
        private Admin.UsersListForm usersListForm;
        private void usersListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((usersListForm == null) || (usersListForm.IsDisposed))
            {
                usersListForm = new Admin.UsersListForm
                {
                    MdiParent = this
                };
            }
            usersListForm.Show();
        }

        private Admin.UpdateUserForm updateUserForm;
        private void updateUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((updateUserForm == null) || (updateUserForm.IsDisposed))
            {
                updateUserForm = new Admin.UpdateUserForm
                {
                    MdiParent = this
                };
            }
            updateUserForm.Show();
        }
    }
}
