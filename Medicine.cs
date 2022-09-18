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
    public partial class Medicine : Form
    {
     SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kiro\Documents\Pharmacenter_db.mdf;Integrated Security=True;Connect Timeout=30");
        public void populate() {
            Con.Open();
            string Myquery = "select * from Medicine_tb1";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(Myquery,Con);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            MedicineGridView.ReadOnly=true;
            MedicineGridView.DataSource = ds.Tables[0];
            Con.Close();
            

        }
        public Medicine()
        {
            InitializeComponent();
        }

        private void MedicineName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MedicineName.Text == "" || BPtb.Text == "" || SPtb.Text == "" || Quantb.Text == "" || ExpireDate.Text == "" || Companycb.Text == null)
            {
                MessageBox.Show("Missing Data.Fill All the Indormation");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into Medicine_tb1 values('" + MedicineName.Text + "'," + BPtb.Text + "," + SPtb.Text + "," + Quantb.Text + ",'" + ExpireDate.Text + "','" + Companycb.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Medicine Successfully Added");
                Con.Close();
                populate();
            }
        }
        public void fullcombobox()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select Compname from Company_tb1", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Compname", typeof(string));
            dt.Load(rdr);
            Companycb.ValueMember = "Compname";
            Companycb.DataSource = dt;
            Con.Close();
            
        }
        private void Medicine_Load(object sender, EventArgs e)
        {
            populate();
            fullcombobox();
        }

        private void MedicineGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MedicineName.Text = MedicineGridView.SelectedRows[0].Cells[0].Value.ToString();
            BPtb.Text = MedicineGridView.SelectedRows[0].Cells[1].Value.ToString();
            SPtb.Text = MedicineGridView.SelectedRows[0].Cells[2].Value.ToString();
            Quantb.Text = MedicineGridView.SelectedRows[0].Cells[3].Value.ToString();
            Companycb.Text = MedicineGridView.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            string Myquery = "UPDATE Medicine_tb1 SET Bprice= " + BPtb.Text + ", Sprice = " + SPtb.Text + ", MedQty = " + Quantb.Text + " , ExpDate = '" + ExpireDate.Text + "', Company ='" + Companycb.Text + "'where Midname='" + MedicineName.Text+"';";
            SqlCommand cmd = new SqlCommand(Myquery,Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Medicine Updated Successfully");
            Con.Close();
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MedicineName.Text == "")
            {
                MessageBox.Show("Wrong Operation.Click on the medicine to be deleted");
            }
            else
            {
                Con.Open();
                string query = "delete from Medicine_tb1 where Midname ='" + MedicineName.Text + "';";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Medicine Deleted Successfully");
                Con.Close();
                populate();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomeForm homef = new HomeForm();
            homef.Show();
            this.Hide();
        }

        private void Companycb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
