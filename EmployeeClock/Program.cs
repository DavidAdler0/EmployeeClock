using EmployeeClock.DAL;
using Microsoft.Extensions.Configuration;

namespace EmployeeClock
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //Console.WriteLine($"The secret value is: {connString}");
            ApplicationConfiguration.Initialize();
            FormHandler.ShowForm("LoginForm");
            Application.Run();
            
        }
    }
}