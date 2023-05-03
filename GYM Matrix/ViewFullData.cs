using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace GYM_Matrix
{
    public partial class ViewFullData : Form
    {
        public ViewFullData()
        {
            InitializeComponent();
            ExpiredMembers();
            MembersWithDues();
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

                cmd.CommandText = "SELECT * FROM `addmembers`Renewal_Date WHERE Renewal_Date <= '" + yesterday + "'" + "ORDER BY Member_Name ASC";

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
                MessageBox.Show("Enter Data in Proper Manner or " + ex.Message);
            }
        }

        private void CloseApp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dash = new Dashboard();
            dash.Show();
        }

        private void MinimizeApp_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            ExpiredMembers();
            MembersWithDues();
        }
    }
}
