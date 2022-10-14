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

    public partial class markattendence : Form
    {
        string presenty;
        public markattendence()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


           // String CS = @"Data Source=JAYESH-PC\WINCCPLUSMIG2014;Initial Catalog=EmployeeDatabase;Integrated Security=True";
          //  SqlConnection con = new SqlConnection(CS);

           // SqlCommand cmd = new SqlCommand("select * from Atendance where Id='" + ClassLibrary.userid + "' and date='" + ClassLibrary.date + "';", con);
            //   cmd.Parameters.AddWithValue("@Id", ClassLibrary.userid);
            //   cmd.Parameters.AddWithValue("@date", ClassLibrary.date);
            //   cmd.Parameters.AddWithValue("@attendance", presenty);
        //    try
        //    {
        //        con.Open();
        //        SqlDataReader dr = cmd.ExecuteReader();
        //        if (dr.Read())
        //        {
        //            panel1.Visible = false;
                    
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
            
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                
                presenty = "P";

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
                        dr.Close();
                    }
                    else
                    {
                        String CS1 = @"Data Source=JAYESH-PC\WINCCPLUSMIG2014;Initial Catalog=EmployeeDatabase;Integrated Security=True";
                        SqlConnection con1 = new SqlConnection(CS1);

                        SqlCommand cmd1 = new SqlCommand("insert into Atendance values(@Id , @attendance ,@date ,@month);", con1);

                        DateTime dt = DateTime.Now;
                        string Month = (dt.Month).ToString();
                        //select * from Employee where Id like @Id and password like @password;", con);

                        cmd1.Parameters.AddWithValue("@Id", ClassLibrary.userid);
                        cmd1.Parameters.AddWithValue("@date", dateTimePicker1.Text);
                        cmd1.Parameters.AddWithValue("@attendance", presenty);
                        cmd1.Parameters.AddWithValue("@month", Month);

                        con1.Open();
                        cmd1.ExecuteNonQuery();
                        con1.Close();

                        MessageBox.Show("Attendance Marked  Sucessfully");
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
            else
            {
                MessageBox.Show("Please select Checkbox");
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {



        }
    }
}