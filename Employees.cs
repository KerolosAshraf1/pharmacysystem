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
    public partial class Employees : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kiro\Documents\Pharmacenter_db.mdf;Integrated Security=True;Connect Timeout=30");
        public void populate()
        {
            Con.Open();
            string Myquery = "select * from Emplyee_tb1";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            EmployeeDataGridView.DataSource = ds.Tables[0];
            Con.Close();
        }
        public Employees()
        {
            InitializeComponent();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            HomeForm homef = new HomeForm();
            homef.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Empidtd.Text = EmployeeDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            Empnametd.Text = EmployeeDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            Empsaltd.Text = EmployeeDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            Empagetb.Text = EmployeeDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            Empphonetb.Text = EmployeeDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            Emppasstb.Text = EmployeeDataGridView.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void AddEmpbtn_Click(object sender, EventArgs e)
        {
            if (Empidtd.Text == "" || Empnametd.Text == "" || Empsaltd.Text == "" || Empagetb.Text == "" || Empphonetb.Text == "" || Emppasstb.Text == "")
            {
                MessageBox.Show("wrong Input.Fill All the filled");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into Emplyee_tb1 values('" + Empidtd.Text + "','" + Empnametd.Text + "','" + Empsaltd.Text + "','" + Empagetb.Text + "','" + Empphonetb.Text + "','" + Emppasstb.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Successfully Added");
                Con.Close();
                populate();
            }
        }

        private void UpdateEmpbtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "UPDATE Emplyee_tb1 SET Empname = '" + Empnametd.Text + "', Empsalary = '" + Empsaltd.Text + "', EmpAge = '" + Empagetb.Text + "' , EmpPhone = '" + Empphonetb.Text + "', EmpPassword ='" + Emppasstb.Text + "'where EmpID='" + Empidtd.Text + "';";
            SqlCommand cmd = new SqlCommand(Myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Employee Updated Successfully");
            Con.Close();
            populate();
        }

        private void DelEmpbtn_Click(object sender, EventArgs e)
        {
            if (Empidtd.Text == "")
            {
                MessageBox.Show("Wrong Operation.Click on the Employee to be Deleted");
            }
            else
            {
                Con.Open();
                string query = "delete from Emplyee_tb1 where EmpID ='" + Empidtd.Text + "';";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Deleted Successfully");
                Con.Close();
                populate();
            }
        }
    }
}
