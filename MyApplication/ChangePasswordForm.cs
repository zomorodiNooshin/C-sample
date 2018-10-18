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
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            Models.DatabaseContext databaseContext = null;
            try
            {
                databaseContext = new Models.DatabaseContext();
                Models.User currentUser = databaseContext.Users.
                    Where(current => current.Id == Infrastructure.Utility.AuthenticatedUser.Id).FirstOrDefault();
                if (currentUser == null)
                {
                    System.Windows.Forms.Application.Exit();
                }
                if (string.Compare(currentUser.Password,oldPasswordTextBox.Text,ignoreCase:false)!=0)
                {
                    System.Windows.Forms.MessageBox.Show("your old Password is not correct");
                    oldPasswordTextBox.Focus();
                    return;
                }
                currentUser.Password = newPasswordTextBox.Text;
                databaseContext.SaveChanges();
                System.Windows.Forms.MessageBox.Show("your password changed successfully");
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
