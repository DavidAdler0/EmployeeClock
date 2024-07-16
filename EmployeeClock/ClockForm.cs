using EmployeeClock.DAL;
using System.Data;

namespace EmployeeClock
{
    public partial class ClockForm : Form
    {
        private DBcontext _dbContext;
        private string Tz;
        public ClockForm(DBcontext dbContext, string tz)
        {

            InitializeComponent();
            _dbContext = dbContext;
            Tz = tz;
            this.id.Text = tz;
            try
            {
                DataTable dt = _dbContext.MakeQuery($"select * from EmployeeAttendance where EmployeeID = {tz} order by EntryTime desc");
                string entry = dt.Rows[0]["EntryTime"].ToString();
                string exit = dt.Rows[0]["ExitTime"].ToString();
                if (entry == "" && exit == "")
                {
                    this.entryDate.Text = "No excistent entry";
                    buttonArrive.Enabled = true;
                    this.exitDate.Text = "No exicstent exit";
                }
                else if (exit == "")
                {
                    this.entryDate.Text = entry;
                    this.exitDate.Text = "No exicstent exit";
                    buttonExit.Enabled = true;

                }
                else
                {
                    this.entryDate.Text = entry;
                    this.exitDate.Text = exit;
                    buttonArrive.Enabled = true;

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("an error" + ex.Message);
            }


        }



        private void delete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormHandler.ShowForm("LoginForm");
        }


        private void buttonArrive_Click(object sender, EventArgs e)
        {

            _dbContext.CommandNonQuery($"insert into EmployeeAttendance (EmployeeID, EntryTime) Values ({this.Tz}, GETDATE());");
            MessageBox.Show("You entered successfully");
            buttonArrive.Enabled = false;
            buttonExit.Enabled = true;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            buttonExit.Enabled = false;
            _dbContext.CommandNonQuery($"UPDATE EmployeeAttendance SET ExitTime = GETDATE() WHERE EmployeeID = {this.Tz} and ExitTime is null;");
            MessageBox.Show("You exited successfully");

        }
    }
}
