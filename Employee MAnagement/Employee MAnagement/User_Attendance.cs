using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Employee_MAnagement
{
    public partial class User_Attendance : Form
    {
        public User_Attendance()
        {
            InitializeComponent();
        }

        private void User_Attendance_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClassLibrary.date = (dateTimePicker1.Text).ToString();
            

            String CS = @"Data Source=JAYESH-PC\WINCCPLUSMIG2014;Initial Catalog=EmployeeDatabase;Integrated Security=True";
            SqlConnection con = new SqlConnection(CS);

            SqlCommand cmd = new SqlCommand("select * from Atendance where Id='" + ClassLibrary.userid + "' and date='" + ClassLibrary.date + "';", con);
            //   cmd.Parameters.AddWithValue("@Id", ClassLibrary.userid);
            //   cmd.Parameters.AddWithValue("@date", ClassLibrary.date);
            //   cmd.Parameters.AddWithValue("@attendance", presenty);
            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    MessageBox.Show("Attendance marked already");
                }
                else
                {
                    markattendence obj = new markattendence();
                    obj.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ClassLibrary.usertype == "Employee")
            {
                EmployeeHome obj = new EmployeeHome();
                obj.Show();
                this.Hide();
            }
            else
            {
                User_Attendance obj = new User_Attendance();
                obj.Show();
                this.Hide();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HomePage obj = new HomePage();
            obj.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Attendance_Record obj = new Attendance_Record();
            obj.Show();
            this.Hide();
        }
    }
}
