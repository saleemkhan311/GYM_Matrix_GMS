using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace GYM_Matrix
{

    public partial class Dashboard : Form
    {

        public string username;
        
        public Dashboard()
        {
            InitializeComponent();
            ExpiringMembers();
            ExpiredMembers();
            MembersWithDues();
            TotalMembers();
            TotalMaleMembers();
            TotalFemaleMembers();
            totalStaff();
            TotalFeePaid();
            TotalExpenses();

            if (LoginPage.username != null)
            {
                UserLabel.Text = LoginPage.username ;
            }
        }

        private void TotalExpenses()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(AppSettings.ConString());
                con.Open();
                string query = "SELECT SUM(Expense_Amount) AS total_amount FROM expenses;";
                MySqlCommand cmd = new MySqlCommand(query, con);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                ExpenseLabel.Text = count.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Make Sure Xampp Services are Running or  " + ex.Message);
            }
        }

        private void TotalFeePaid()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(AppSettings.ConString());
                con.Open();
                string query = "SELECT SUM(Fee_Paid) as total_Fee_Paid FROM addmembers;";
                MySqlCommand cmd = new MySqlCommand(query, con);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                FeePaidLabel.Text = count.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Make Sure Xampp Services are Running or  " + ex.Message);
            }
        }

        private void totalStaff()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(AppSettings.ConString());
                con.Open();
                string query = "SELECT COUNT(*) AS COUNT_staff FROM staff;";
                MySqlCommand cmd = new MySqlCommand(query, con);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                StaffLabel.Text = count.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Make Sure Xampp Services are Running or  " + ex.Message);
            }
        }

        private void TotalFemaleMembers()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(AppSettings.ConString());
                con.Open();
                string query = "SELECT COUNT(*) AS COUNT_addmembers FROM addmembers Gender WHERE Gender = 'Female';";
                MySqlCommand cmd = new MySqlCommand(query, con);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                TotalFemaleMembersLabel.Text = count.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Make Sure Xampp Services are Running or " + ex.Message);
            }
        }

        private void TotalMaleMembers()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(AppSettings.ConString());
                con.Open();
                string query = "SELECT COUNT(*) AS COUNT_addmembers FROM addmembers Gender WHERE Gender = 'Male';";
                MySqlCommand cmd = new MySqlCommand(query, con);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                TotalMaleMembersLabel.Text = count.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Make Sure Xampp Services are Running or " + ex.Message);
            }
        }

        private void TotalMembers()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(AppSettings.ConString());
                con.Open();
                string query = "SELECT COUNT(*) AS COUNT_addmembers FROM addmembers;";
                MySqlCommand cmd = new MySqlCommand(query,con);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                TotalMembersLabel.Text = count.ToString();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Make Sure Xampp Services are Running or "+ex.Message);
            }

        }

        
        string yesterday = DateTime.Now.AddDays(0).ToString("yyyy/MM/dd");
        string Week = DateTime.Now.AddDays(+7).ToString("yyyy/MM/dd");
        string today = DateTime.Now.ToString("yyyy/MM/dd");
        private void ExpiredMembers()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(AppSettings.ConString());
                con.Open();
                MySqlCommand cmd;
                cmd = con.CreateCommand();

                cmd.CommandText = "SELECT * FROM `addmembers`Renewal_Date WHERE Renewal_Date <= '" + yesterday + "'"+ "ORDER BY Member_Name ASC";

                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable Records = new DataTable();
                Records.Load(reader);

                ExpiredMembersTable.DataSource = Records;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter Data in Proper Manner or " + ex.Message);
            }
        }

        private void MembersWithDues()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(AppSettings.ConString());
                con.Open();
                MySqlCommand cmd;
                cmd = con.CreateCommand();

                cmd.CommandText = "SELECT * FROM addmembers WHERE Dues > 0 ORDER BY Member_Name ASC;";

                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable Records = new DataTable();
                Records.Load(reader);

                MemberDuesTable.DataSource = Records;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter Data in Proper Manner or "+ex.Message);
            }
        }

        private void ExpiringMembers()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(AppSettings.ConString());
                con.Open();
                MySqlCommand cmd;
                cmd = con.CreateCommand();

                cmd.CommandText = "SELECT * FROM `addmembers`Renewal_Date WHERE Renewal_Date BETWEEN '"+today+"' AND '"+Week+"';";

                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable Records = new DataTable();
                Records.Load(reader);
                ExpiringMembersTabel.DataSource = Records;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter Data in Proper Manner or "+ex.Message);
            }

        }

        private void AddMember(object sender, EventArgs e)
        {

            AddMemebers AddMembers = new AddMemebers();


            AddMembers.Show();
            this.Hide();
        }

        private void RenewMember(object sender, EventArgs e)
        {
            Renewal renewal = new Renewal();
            renewal.Show();
            this.Hide();
        }

        private void AddStaff(object sender, EventArgs e)
        {
            AddStaff addStaff = new AddStaff();
            this.Hide();
            addStaff.Show();

        }

        private void AddExpense(object sender, EventArgs e)
        {
            Add_Expenses addExpense = new Add_Expenses();
            addExpense.Show();
            this.Hide();
        }

        private void ViewMembers(object sender, EventArgs e)
        {
            ViewMembers viewMembers = new ViewMembers();
            viewMembers.Show();
            this.Hide();
        }

        private void ViewStaff(object sender, EventArgs e)
        {
            View_Staff viewStaff = new View_Staff();
            viewStaff.Show();
            this.Hide();
        }

        private void ViewExpense(object sender, EventArgs e)
        {
            ViewExpenses viewExpense = new ViewExpenses();
            viewExpense.Show();
            this.Hide();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void SettingsButton(object sender, EventArgs e)
        {
            UserPanel userpanel = new UserPanel();
            userpanel.Show();
            this.Hide();
        }



        private void IncomeRecords(object sender, EventArgs e)
        {
            TotalIncome income = new TotalIncome();
            income.Show();
            this.Hide();
        }

        

       

        private void Refresh_Button(object sender, EventArgs e)
        {
            ExpiringMembers();
            ExpiredMembers();
            MembersWithDues();
            TotalMembers();
            TotalMaleMembers();
            TotalFemaleMembers();
            totalStaff();
            TotalFeePaid();
            TotalExpenses();
        }

        private void CloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeApp_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void SendResminder(object sender, EventArgs e)
        {
            //WhatsAppAPIManagement.Fee_Reminder();
            MessageBox.Show("Fee Remider Has been sent to the Members WhtasApp Number");
        }

        private void ViewFullData_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewFullData fulldata = new ViewFullData();
            fulldata.Show();
        }
    }
}
