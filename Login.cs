using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace PharmacyMangment
{
    public partial class Login : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kiro\Documents\Pharmacenter_db.mdf;Integrated Security=True;Connect Timeout=30");
        public Login()
        {
            InitializeComponent();
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeForm hf = new HomeForm();

            /*if(Username.Text == "Admin" && Password.Text == "Admin")
            {
                hf.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }*/
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select COUNT(*) from Emplyee_tb1 where Empname = '" + Username.Text + "' and EmpPassword ='" + Password.Text + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                hf.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or Passward");
            }
            Con.Close();
        }
    }
}
