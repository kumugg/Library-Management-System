namespace Library_Management_System
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();


            LoginForm loginform = new LoginForm();

            Application.Run(loginform);

            if (loginform.IsAuthenticated && LoginForm.role == "admin")
            {
                Application.Run(new AdminDashboardForm());
            }
            else if (loginform.IsAuthenticated && LoginForm.role == "user")
            {
                Application.Run(new UserDashboardForm());
            }
        }
    }
}