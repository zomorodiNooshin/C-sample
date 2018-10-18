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
	public partial class RegisterForm : Infrastructure.BaseForm
	{
		public RegisterForm()
		{
			InitializeComponent();
		}

		private void RegisterForm_Load(object sender, EventArgs e)
		{

		}

		private void RegisterButton_click(object sender, EventArgs e)
		{
			Models.DatabaseContext databaseContext = null;
			databaseContext = new Models.DatabaseContext();
            try
			{
				Models.User user = databaseContext.Users.Where(current => string.Compare(current.Username, usernameTextBox.Text, true) == 0).FirstOrDefault();
				if (user != null)
				{
					System.Windows.Forms.MessageBox.Show("This username is already exist!");
					usernameTextBox.Focus();
					return;
				}

				user = new Models.User();

				user.FullName = fullnameTextBox.Text;
				user.Password = passwordTextBox.Text;
				user.Username = usernameTextBox.Text;
				user.IsActive = true;
				databaseContext.Users.Add(user);
				databaseContext.SaveChanges();
				System.Windows.Forms.MessageBox.Show("Registration Done!");
				resetButton_click(null, null);

			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show("Error: " + ex.Message);
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					databaseContext = null;
				}
			}

			//if ((string.IsNullOrWhiteSpace(usernameTextBox.Text)) || (string.IsNullOrWhiteSpace(passwordTextBox.Text))) {
			//	usernameTextBox.Text = usernameTextBox.Text.Replace("", string.Empty);
			//	passwordTextBox.Text = passwordTextBox.Text.Replace("", string.Empty);
			//	System.Windows.Forms.MessageBox.Show("username and password is required!");



			//	Models.DatabaseContext databaseContext = null;
			//	try
			//	{
			//		databaseContext = new Models.DatabaseContext();
			//		Models.User user = databaseContext.Users.Where(current => string.Compare(current.Username, usernameTextBox.Text, true) == 0).FirstOrDefault();

			//		if (user != null)
			//		{
			//			System.Windows.Forms.MessageBox.Show("this username is already exist!");
			//			usernameTextBox.Focus();
			//			return;
			//		}
			//		user = new Models.User();
			//		user.Username = usernameTextBox.Text;
			//		user.Password = passwordTextBox.Text;
			//		user.FullName = passwordTextBox.Text;

			//		user.IsActive = true;
			//		databaseContext.Users.Add(user);
			//		databaseContext.SaveChanges();

			//		System.Windows.Forms.MessageBox.Show("Registration done!");

			//		resetButton_click(null, null);
			//	}
			//	catch (System.Exception ex)
			//	{
			//		System.Windows.Forms.MessageBox.Show("Error:", ex.Message);

			//	}
			//	finally
			//	{
			//		if (databaseContext != null)
			//		{
			//			databaseContext.Dispose();
			//			databaseContext = null;
			//		}
			//	}
			//}
		}

		private void resetButton_click(object sender, EventArgs e)
		{
			usernameTextBox.Text = string.Empty;
			passwordTextBox.Text = string.Empty;
			fullnameTextBox.Text = string.Empty;

			usernameTextBox.Focus();
		}

		private void loginButton_click(object sender, EventArgs e)
		{
			Hide();
			LoginForm loginform = new LoginForm();
			loginform.Show();
			
		}
        private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
