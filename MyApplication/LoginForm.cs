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
	public partial class LoginForm : Infrastructure.BaseForm
	{
		public LoginForm()
		{
			InitializeComponent();
		}

		private void loginButton_click(object sender, EventArgs e)
		{
			Models.DatabaseContext databaseContext = null;
			try
			{
				databaseContext = new Models.DatabaseContext();
				Models.User foundeduser = databaseContext.Users.Where(current => string.Compare(current.Username, usernameTextBox.Text, true) == 0).FirstOrDefault();

				if (foundeduser == null)
				{

					System.Windows.Forms.MessageBox.Show("your username or password is wrong!");
                    usernameTextBox.Focus();
					return;
				}
                if (string.Compare(foundeduser.Password, passwordTextBox.Text, ignoreCase:false)!=0)
                {
                    System.Windows.Forms.MessageBox.Show("your username or password is wrong!");
                    usernameTextBox.Focus();
                    return;
                }
                if (foundeduser.IsActive == false)
                {
                    System.Windows.Forms.MessageBox.Show("You can not Login to This Application");
                    usernameTextBox.Focus();
                    return;
                }
                System.Windows.Forms.MessageBox.Show("Welcome!");

                Infrastructure.Utility.AuthenticatedUser = foundeduser;
                Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
                //foundeduser = new Models.User();
                //foundeduser.Username = usernameTextBox.Text;
                //foundeduser.Password = passwordTextBox.Text;

            }
            catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show("Error:", ex.Message);

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

		private void registerButton_click(object sender, EventArgs e)
		{
			Hide();
			RegisterForm registerform = new RegisterForm();
			registerform.Show();
		}

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        
         private void exitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
       

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void resetButton_Click(object sender, EventArgs e)
        {

        }
    }
}
