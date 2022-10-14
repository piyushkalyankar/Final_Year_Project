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
    public partial class ViewRecord : Form
    {
        public string temp;
        public ViewRecord()
        {
            InitializeComponent();


        }
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;

        EmployeeDatabaseEntities6 contex = new EmployeeDatabaseEntities6();

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

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            if(ClassLibrary.usertype == "User")
            {
           
            if (comboBox1.Text == "All")
            {
                dataGridView1.DataSource = (from b in contex.Employees
                                            select new { b.Id, b.name, b.address, b.gender, b.position, b.birthdate, b.eduaction, b.phone, b.mail, b.salary, b.password, b.usertype }).ToList();
            }
            else
            {
                //Employee emp = null;
                dataGridView1.DataSource = (from b in contex.Employees
                                            where b.Id.Equals(comboBox1.Text)
                                            select new { b.Id , b.name , b.address , b.gender , b.position , b.birthdate , b.eduaction, b.phone , b.mail , b.salary , b.password , b.usertype}).ToList();
            }
               
            }
            else
            {
                dataGridView1.DataSource = (from b in contex.Employees
                                            where b.Id.Equals(label2.Text)
                                            select new { b.Id, b.name, b.address, b.gender, b.position, b.birthdate, b.eduaction, b.phone, b.mail, b.salary, b.password, b.usertype }).ToList();
                

            }
        }

        private void ViewRecord_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;

            if (ClassLibrary.usertype == "User")
            {
                panel2.Visible = true;

            }
            else
            {
                panel3.Visible = true;
                label2.Text = ClassLibrary.userid;
            }

            cn = new SqlConnection(@"Data Source=JAYESH-PC\WINCCPLUSMIG2014;Initial Catalog=EmployeeDatabase;Integrated Security=True");  
            cn.Open();  
  
            BindData();
            cn.Close();
            panel1.Visible = false;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ClassLibrary.usertype == "User")
            {
                HomePage hp = new HomePage();
                hp.Show();
                this.Hide();
            }
            else
            {
                EmployeeHome ehp = new EmployeeHome();
                ehp.Show();
                this.Hide();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
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
