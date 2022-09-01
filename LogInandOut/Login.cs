using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogInandOut
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection sv = new SqlConnection(@"Data Source=DESKTOP-0KPCRQF\SQLEXPRESS;Initial Catalog=Test;Integrated Security=True");
            try
            {
                sv.Open();
                string userName = TBusername.Text;
                string passWord = TBpassword.Text;
                string DT = "select * from S_User where username = '" + userName + "' and password = '" + passWord + "' ";
                SqlCommand cmd = new SqlCommand(DT, sv);
                SqlDataReader read = cmd.ExecuteReader();   
                if (read.Read() == true)
                {
                    MessageBox.Show("Login successful");
                }
                else
                {
                    MessageBox.Show("Login error, wrong username or password");
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Connection error");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
