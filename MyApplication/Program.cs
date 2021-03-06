﻿using System.Linq;

namespace MyApplication
{
	internal static class Program
	{
		static Program()
		{
		}

		[System.STAThread]
		internal static void Main()
		{
			// **************************************************
			System.Windows.Forms.Application.EnableVisualStyles();
			System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
			// **************************************************

			// **************************************************
			Models.DatabaseContext databaseContext = null;

			try
			{
				databaseContext =
					new Models.DatabaseContext();

				//int adminCount =
				//	databaseContext.Users
				//	.Where(current => current.IsAdmin)
				//	.Count();

				//int userCount =
				//	databaseContext.Users
				//	.Count();

				bool hasAnyUser =
					databaseContext.Users
					.Any();

				if (hasAnyUser == false)
				{
					Models.User adminUser = new Models.User();

					adminUser.IsAdmin = true;
					adminUser.IsActive = true;

					adminUser.Username = "Dariush";
					adminUser.Password = "1234512345";
					adminUser.FullName = "Mr. Dariush Tasdighi";

					databaseContext.Users.Add(adminUser);

					databaseContext.SaveChanges();
				}
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);

				return;
			}
			finally
			{
				if (databaseContext != null)
				{
					databaseContext.Dispose();
					databaseContext = null;
				}
			}
            // **************************************************

            // **************************************************
            //System.Windows.Forms.Application.Run(new StartupForm());

            //#region Runing Startup Form and then Disposing!
            //RegisterForm startupForm = new RegisterForm();

            //System.Windows.Forms.Application.Run(startupForm);

            //if (startupForm != null)
            //{
            //    if (startupForm.IsDisposed == false)
            //    {
            //        startupForm.Dispose();
            //    }

            //    startupForm = null;
            //}
            //#endregion /Runing Startup Form and then Disposing!
            //**************************************************

            //Infrastructure.BaseForm startupForm = new LoginForm();
            //System.Windows.Forms.Application.Run(startupForm);
            //if (startupForm!=null)
            //{
            //    if (startupForm.IsDisposed == false)
            //    {
            //        startupForm.Dispose();
            //    }
            //    startupForm = null;
            //}

            Infrastructure.BaseForm startupForm = new LoginForm();
            System.Windows.Forms.Application.Run(startupForm);
            if (startupForm != null)
            {
                if (startupForm.IsDisposed == false)
                {
                    startupForm.Dispose();
                }
                startupForm = null;
            }

            //System.Windows.Forms.Application.Run(Infrastructure.Utility)
        }
	}
}
