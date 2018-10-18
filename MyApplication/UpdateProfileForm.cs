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
    public partial class UpdateProfileForm :Infrastructure.BaseForm
    {
        public UpdateProfileForm()
        {
            InitializeComponent();
        }
        private void UpdateProfileForm_Load(object sender,System.EventArgs e)
        {
            Models.DatabaseContext databaseContext = null;
            try
            {
                databaseContext = new Models.DatabaseContext();
                Models.User currentUser = databaseContext.Users.Where(current => current.Id == Infrastructure.Utility.AuthenticatedUser.Id).FirstOrDefault();
                if(currentUser==null)
                {
                    System.Windows.Forms.Application.Exit();
                }
                fullNameLable.Text = currentUser.FullName;
                descriptionTextBox.Text = currentUser.Description;
            }
            catch(System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error:" + ex.Message);
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
        private void SaveButton_Click(object sender,System.EventArgs e)
        {
            Models.DatabaseContext databaseContext = null;
            try
            {
                databaseContext = new Models.DatabaseContext();
                Models.User currentUser = databaseContext.Users.Where(current => current.Id == Infrastructure.Utility.AuthenticatedUser.Id).FirstOrDefault();
                if (currentUser == null)
                {
                    System.Windows.Forms.Application.Exit();
                }
                currentUser.FullName = fullNameLable.Text;
                currentUser.Description = descriptionTextBox.Text;
                databaseContext.SaveChanges();
                Infrastructure.Utility.AuthenticatedUser = currentUser;
                ((MainForm)this.MdiParent).UpdateWelcomeToolstripStatusLabel();
                System.Windows.Forms.MessageBox.Show("your profile is updated successfully....");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Eroor:" + ex.Message);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fullNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
