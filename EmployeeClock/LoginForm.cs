using EmployeeClock.DAL;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeClock
{
    public partial class LoginForm : Form
    {
        private DBcontext _dbContext;
        public LoginForm(DBcontext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
        }
        private void Demo()
        {
            DataTable dt = _dbContext.MakeQuery("select EmployeePassword from dbo.Passwords\r\nwhere EmployeeID= 1");
            string dtstr = dt.Rows[0]["EmployeePassword"].ToString();
            MessageBox.Show(dtstr);
        }
        public void button1_Click(object sender, EventArgs e)
        {
            if (textBoxTaz.Text.Trim() == "" && textBoxPassword.Text.Trim() == "")
            {
                MessageBox.Show("lease enter ID and Password!");

            }
            else if (textBoxTaz.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Missing ID!\nplease fill all fields!");
            }
            else if (textBoxPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Missing password!\nplease fill all fields!");
            }
            else
            {
                DataTable dt = _dbContext.MakeQuery($"select EmployeePassword, EmployeeID from dbo.Passwords where EmployeeID = {textBoxTaz.Text}");

                if (dt.Rows.Count > 0)
                {
                    string password = dt.Rows[0]["EmployeePassword"].ToString();
                    if (password == textBoxPassword.Text)
                    {
                        MessageBox.Show("You loged in successfully!");
                        
                        FormHandler.ShowForm("ClockForm", textBoxTaz.Text);

                    }
                    else
                    {
                        MessageBox.Show("Rong password!");
                    }
                }
                else
                {
                    MessageBox.Show("You are not a registered user");
                }


            }
            //this.Demo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormHandler.ShowForm("PasswordCangerForm");
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (FormHandler.toExit == true) {
            Application.Exit();
            }

        }
    }
}
