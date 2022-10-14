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
    public partial class Attendance_Record : Form
    {
        public Attendance_Record()
        {
            InitializeComponent();
        }
        EmployeeDatabaseEntities6 contex = new EmployeeDatabaseEntities6();
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Date")
            {
                panel2.Visible = true;
                panel3.Visible = false;
            }
            else
            {
                if(comboBox2.Text == "Month")
                {
                    panel3.Visible=true;
                    panel2.Visible=false;
                }
                else
                {
                    panel2.Visible=false;
                    panel3.Visible = false;
                    dataGridView1.DataSource = (from b in contex.Atendances
                                                where b.Id.Equals(comboBox1.Text)
                                                select new { b.Id, b.date, b.attendance}).ToList();
                                                
                }
        }
    }

        private void Attendance_Record_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeDatabaseDataSet1.Atendance' table. You can move, or remove it, as needed.
           // this.atendanceTableAdapter.Fill(this.employeeDatabaseDataSet1.Atendance);
            panel2.Visible = false;
            panel3.Visible = false;
            cn = new SqlConnection(@"Data Source=JAYESH-PC\WINCCPLUSMIG2014;Initial Catalog=EmployeeDatabase;Integrated Security=True");
            cn.Open();

            BindData();
            cn.Close();
        }
        public void BindData()
        {
            cmd = new SqlCommand("select Id from Employee", cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0].ToString());
            }
            dr.Close();
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            User_Attendance obj = new User_Attendance();
            obj.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from b in contex.Atendances
                                        where b.Id.Equals(comboBox1.Text) && b.date.Equals(dateTimePicker1.Text)
                                        select new { b.Id, b.date, b.attendance }).ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from b in contex.Atendances
                                        where b.Id.Equals(comboBox1.Text)  && b.month.Equals(comboBox3.Text)
                                        select new { b.Id, b.date, b.attendance , b.month}).ToList();
         
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
              if (dataGridView1.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.ApplicationClass XcelApp = new Microsoft.Office.Interop.Excel.ApplicationClass();
                XcelApp.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    XcelApp.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        try
                        {
                            XcelApp.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                            
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("File created Sucessfully");
                            break;
                        }

                    }
                }
                XcelApp.Columns.AutoFit();
                XcelApp.Visible = true;
            }
        }
    }
        
}
