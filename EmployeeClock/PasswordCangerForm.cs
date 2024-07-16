using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeClock.DAL;


namespace EmployeeClock
{
    public partial class PasswordCangerForm : Form
    {
        private DBcontext _dbContext;

        public PasswordCangerForm(DBcontext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
  
        }



        private void linkLabelCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormHandler.ShowForm("LoginForm");
        }

        private void buttonChangeP_Click(object sender, EventArgs e)
        {
            if (textBoxTaz.Text == "" | textBoxOP.Text == "" | textBoxNewP.Text == "" | textBoxConfirmP.Text == "")
            {
                MessageBox.Show("please fill all fields!");
            }
            int? res = _dbContext.CommandScalar($"select count (*) from Passwords where EmployeeID = {textBoxTaz.Text} and EmployeePassword = {textBoxOP.Text}; ");
            if (res == 0)
            {
                MessageBox.Show("Incorect details");
            }
            if (textBoxNewP.Text != textBoxConfirmP.Text)
            {
                MessageBox.Show("Check the password confirmation");
            }
            else
            {
                _dbContext.CommandNonQuery($"update Passwords set EmployeePassword = {textBoxNewP.Text} where EmployeeID = {textBoxTaz.Text}");
                MessageBox.Show("Password updated successfully");
            }
            
            /*
             עצירת התוכנית, אקזיסט, הודעת תאימות סיסמא, טרנזקשנים החזרת משתנה
             */

        }
    }
}
