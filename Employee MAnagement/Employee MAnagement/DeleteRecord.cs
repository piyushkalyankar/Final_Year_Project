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
    public partial class DeleteRecord : Form
    {
       
        public DeleteRecord()
        {
            InitializeComponent();
            cn = new SqlConnection(@"Data Source=JAYESH-PC\WINCCPLUSMIG2014;Initial Catalog=EmployeeDatabase;Integrated Security=True");
            cn.Open();

            BindData();
          //  MessageBox.Show(comboBox1.Items.Count.ToString());  

        }

        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;

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
            if (MessageBox.Show("Are you sure you want to 'delete' this record?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                cmd = new SqlCommand("delete from Employee where Id=@Id", cn);
              //  cmd = new SqlCommand("delete from Employee where Id = @Id", cn);
                cmd.Parameters.AddWithValue("@Id", comboBox1.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted Successfully !");
            }
            //else
            //{ 
                
            //}
        }
       

        private void DeleteRecord_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            hp.Show();
            this.Hide();
        }

       
    }
}
