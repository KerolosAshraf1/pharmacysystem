using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;

namespace PharmacyMangment
{
    public partial class Company : Form
    {
        //[Table("InstitucionesMilitares", Schema = "configuracion")]
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kiro\Documents\Pharmacenter_db.mdf;Integrated Security=True;Connect Timeout=30");

        public void Populate()
        {
            Con.Open();
            string Myquery = "select * from Company_tb1";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            //CompanyDataGridView.ReadOnly = true;
            CompanyDataGridView.DataSource = ds.Tables[0];
            Con.Close();
           // Con.Open();
            /*string Myquery = "select * from Company_tbl";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder CommandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            CompanyDataGridView.ReadOnly = true;
            CompanyDataGridView.DataSource = ds.Tables[0];
            Con.Close();*/
        }
        public Company()
        {
            InitializeComponent();
        }

        private void Empphonetb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Company_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            HomeForm homef = new HomeForm();
            homef.Show();
            this.Hide();
        }

        private void AddCompbtn_Click(object sender, EventArgs e)
        {
            if (CompId.Text == "" || CompNametb.Text == "" || CompPhonetb.Text == "" || CompAddresstb.Text == "")
            {
                MessageBox.Show("Wrong Input All Filled");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into Company_tb1 values('" + CompId.Text + "','" + CompNametb.Text + "','" + CompPhonetb.Text + "','" + CompAddresstb.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Company Successfully Aded");
                Con.Close();
                Populate();
            }
            /*if (CompId.Text == "" || CompNametb.Text == "" || CompPhonetb.Text == "" || CompAddresstb.Text == "")
            {
                MessageBox.Show("Wrong Input All Filled");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into Company_tb1 values('" + CompId.Text + "','" + CompNametb.Text + "','" + CompPhonetb.Text + "','" + CompAddresstb.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Company Successfully Aded");
                Con.Close();
                Populate();*/
        
        }

        private void UpdateCompbtn_Click(object sender, EventArgs e)
        {
            
            Con.Open();
            string Myquery = "UPDATE Company_tb1 SET Compname ='" + CompNametb.Text + "', CompPhone = '" + CompPhonetb.Text + "', CompAddress = '" + CompAddresstb.Text + "'WHERE  CompId ='" + CompId.Text+"';";
            SqlCommand cmd = new SqlCommand(Myquery,Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Company Updated Successfully");
            Con.Close();
            Populate();


             /*
            Con.Open();
            string Myquery = "UPDATE Company_tb1 SET Compname = " + CompNametb.Text + ",CompPhone ='" + CompPhonetb.Text + "',CompAddress ='" + CompAddresstb.Text + "'where CompId ='" + CompId.Text + "';";
            SqlCommand cmd = new SqlCommand(Myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Company Updated Successfully");
            Con.Close();
            Populate();
             */
            /*Con.Open();
            string Myquery = "UPDATE Combany_tbl SET Compname='" + CompNametb.Text + "',Compphone='" + CompPhonetb.Text + "',Compaddress='" + CompAddresstb.Text + "'WHERE Compid='" + CompId.Text + "';";
            SqlCommand cmd = new SqlCommand(Myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Company Updated Successfully");
            Con.Close();
            Populate();*/
        }

        private void CompanyDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CompId.Text = CompanyDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            CompNametb.Text = CompanyDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            CompPhonetb.Text = CompanyDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            CompAddresstb.Text = CompanyDataGridView.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void DelCompbtn_Click(object sender, EventArgs e)
        {
            if (CompId.Text == "")
            {

                MessageBox.Show("Wrong Operation.Click on the Company to be Deleted");
}
            else
            {
                Con.Open();
                string query = "delete from Company_tb1 where CompId ='" + CompId.Text + "';";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Company Deleted Successfully");
                Con.Close();
                Populate();
                /*Con.Open();
                string query = "delete from Company_tbl WHERE CompId='" + CompId.Text + "';";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Company Deleted Successfully");
                Con.Close();
                Populate();*/

            }
        }

        private void CompId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
