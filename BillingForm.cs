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
    public partial class BillingForm : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kiro\Documents\Pharmacenter_db.mdf;Integrated Security=True;Connect Timeout=30");
        public void populatecombobox()
        {
            string sql = "Select * from Medicine_tb1";
            SqlCommand cnd = new SqlCommand(sql, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("MidName", typeof(string));
                rdr = cnd.ExecuteReader();
                dt.Load(rdr);
                comboBox1.ValueMember = "MidName";
                comboBox1.DataSource = dt;
                Con.Close();
            }
            catch
            {

            }
        }
        public BillingForm()
        {
            InitializeComponent();
        }
        int x, unitp;
        public void fetchQty()
        {
            Con.Open();
            string mysql = "Select * from Medicine_tb1 where MidName = '" +comboBox1.SelectedValue.ToString()+ " '; ";
            SqlCommand cnd = new SqlCommand(mysql, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cnd);
            da.Fill(dt);
            //da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                x = Convert.ToInt32(dr["MedQty"].ToString());
                unitp = Convert.ToInt32(dr["Sprice"].ToString());
                Stocklbl.Text = "Available Stock is " + dr["MedQty"].ToString();
                Stocklbl.Visible = true;
            }
            Con.Close();
        }
        public void updateMedicine()
        {
            Con.Open();
            int newQty = x - (Convert.ToInt32(Qty.Text));
            string Myquery = "UPDATE Medicine_tb1 SET MedQty= '" + newQty + "' WHERE MidName= '" + comboBox1.Text + "';";
            SqlCommand cmd = new SqlCommand(Myquery, Con);
            cmd.ExecuteNonQuery();
            //MessageBox.Show("Company Updated Successfully");
            Con.Close();

        }
        private void Stocklbl_Click(object sender, EventArgs e)
        {

        }

        private void MedicineGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        int GrdTotal = 0;
        private void Qty_MouseDown(object sender, EventArgs e)
        {
            Qty.Text = " ";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void MedicineName_TextChanged(object sender, EventArgs e)
        {

        }
        Bitmap bitmap;
        private void Printbtn_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics graphics = panel.CreateGraphics();
            Size size = this.ClientSize;
            bitmap = new Bitmap(size.Width, size.Height, graphics);
            graphics = Graphics.FromImage(bitmap);
            Point point = PointToScreen(panel.Location);
            graphics.CopyFromScreen(point.X, point.Y, 0, 0, size);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void BillingForm_Load(object sender, EventArgs e)
        {
           
            Con.Open();
            SqlCommand cmd = new SqlCommand("select MidName from Medicine_tb1", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("MidName", typeof(string));
            dt.Load(rdr);
            comboBox1.ValueMember = "MidName";
            comboBox1.DataSource = dt;
            Con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeForm homf = new HomeForm();
            homf.Show();
            this.Hide();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchQty();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            int n = 0;
            if (Qty.Text == "" || Convert.ToInt32(Qty.Text) > x)
            {
                MessageBox.Show("No Enough Stock Please Check Available Stock");
            }
            else
            {
                int total = Convert.ToInt32(Qty.Text) * unitp;
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(BillGridView);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = comboBox1.SelectedValue.ToString();
                newRow.Cells[2].Value = Qty.Text;
                newRow.Cells[3].Value = unitp;
                newRow.Cells[4].Value = unitp * Convert.ToInt32(Qty.Text);
                BillGridView.Rows.Add(newRow);
                GrdTotal = GrdTotal + total;
                totalamount.Text = "Rs" + GrdTotal;
                updateMedicine();
            };
        }
    }
}
