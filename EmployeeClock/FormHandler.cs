using EmployeeClock.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClock
{
    public static class FormHandler

    {
        public static bool toExit = true;


        
        static private DBcontext dbContext = new DBcontext();
        public static void CloseAll()
        {
            List<Form> openForms = new List<Form>(Application.OpenForms.Cast<Form>());
            foreach (Form item in openForms)
            {
 
                item.Close();

            }
        }
        public static void ShowForm(string formName, string? tzz = null)
        {
            toExit = false;
            CloseAll();
            toExit = true;
            Form form = formName switch
            {
                "ClockForm" => new ClockForm(dbContext, tzz),
                "LoginForm" => new LoginForm(dbContext),
                "PasswordCangerForm" => new PasswordCangerForm(dbContext),
                _ => throw new ArgumentException("invalid form name", nameof(formName)),
            };
            form.Show();
            
        }
    }
}
