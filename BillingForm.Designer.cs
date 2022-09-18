
namespace PharmacyMangment
{
    partial class BillingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillingForm));
            this.Emplabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Qty = new System.Windows.Forms.TextBox();
            this.Stocklbl = new System.Windows.Forms.Label();
            this.Addbtn = new System.Windows.Forms.Button();
            this.BillGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unitprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Totalprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalamount = new System.Windows.Forms.Label();
            this.Printbtn = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BillGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Emplabel
            // 
            this.Emplabel.AutoSize = true;
            this.Emplabel.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Emplabel.ForeColor = System.Drawing.Color.Brown;
            this.Emplabel.Location = new System.Drawing.Point(12, 9);
            this.Emplabel.Name = "Emplabel";
            this.Emplabel.Size = new System.Drawing.Size(245, 38);
            this.Emplabel.TabIndex = 3;
            this.Emplabel.Text = " Billing Form";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(60, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 25);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "Select Medicine";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // Qty
            // 
            this.Qty.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Qty.ForeColor = System.Drawing.Color.Brown;
            this.Qty.Location = new System.Drawing.Point(60, 181);
            this.Qty.Name = "Qty";
            this.Qty.Size = new System.Drawing.Size(169, 26);
            this.Qty.TabIndex = 5;
            this.Qty.Text = "Quantity";
            this.Qty.TextChanged += new System.EventHandler(this.MedicineName_TextChanged);
            // 
            // Stocklbl
            // 
            this.Stocklbl.AutoSize = true;
            this.Stocklbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Stocklbl.Location = new System.Drawing.Point(60, 131);
            this.Stocklbl.Name = "Stocklbl";
            this.Stocklbl.Size = new System.Drawing.Size(98, 17);
            this.Stocklbl.TabIndex = 6;
            this.Stocklbl.Text = "AvailableStock";
            this.Stocklbl.Visible = false;
            this.Stocklbl.Click += new System.EventHandler(this.Stocklbl_Click);
            // 
            // Addbtn
            // 
            this.Addbtn.BackColor = System.Drawing.Color.Brown;
            this.Addbtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Addbtn.ForeColor = System.Drawing.Color.White;
            this.Addbtn.Location = new System.Drawing.Point(12, 304);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(146, 48);
            this.Addbtn.TabIndex = 9;
            this.Addbtn.Text = "Add To Bill";
            this.Addbtn.UseVisualStyleBackColor = false;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // BillGridView
            // 
            this.BillGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.BillGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Medname,
            this.MedQty,
            this.Unitprice,
            this.Totalprice});
            this.BillGridView.Location = new System.Drawing.Point(279, 12);
            this.BillGridView.Name = "BillGridView";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BillGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            this.BillGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.BillGridView.RowTemplate.Height = 25;
            this.BillGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BillGridView.Size = new System.Drawing.Size(698, 299);
            this.BillGridView.TabIndex = 10;
            this.BillGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MedicineGridView_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "MedId";
            this.Id.Name = "Id";
            // 
            // Medname
            // 
            this.Medname.HeaderText = "Medname";
            this.Medname.Name = "Medname";
            // 
            // MedQty
            // 
            this.MedQty.HeaderText = "Quantity";
            this.MedQty.Name = "MedQty";
            // 
            // Unitprice
            // 
            this.Unitprice.HeaderText = "UnitPrice";
            this.Unitprice.Name = "Unitprice";
            // 
            // Totalprice
            // 
            this.Totalprice.HeaderText = "TotalPrice";
            this.Totalprice.Name = "Totalprice";
            // 
            // totalamount
            // 
            this.totalamount.AutoSize = true;
            this.totalamount.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalamount.ForeColor = System.Drawing.Color.Brown;
            this.totalamount.Location = new System.Drawing.Point(449, 323);
            this.totalamount.Name = "totalamount";
            this.totalamount.Size = new System.Drawing.Size(272, 38);
            this.totalamount.TabIndex = 11;
            this.totalamount.Text = " Total Amount";
            // 
            // Printbtn
            // 
            this.Printbtn.BackColor = System.Drawing.Color.Brown;
            this.Printbtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Printbtn.ForeColor = System.Drawing.Color.White;
            this.Printbtn.Location = new System.Drawing.Point(676, 375);
            this.Printbtn.Name = "Printbtn";
            this.Printbtn.Size = new System.Drawing.Size(146, 48);
            this.Printbtn.TabIndex = 12;
            this.Printbtn.Text = "PRINT";
            this.Printbtn.UseVisualStyleBackColor = false;
            this.Printbtn.Click += new System.EventHandler(this.Printbtn_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Brown;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(365, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 48);
            this.button1.TabIndex = 13;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BillingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 454);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Printbtn);
            this.Controls.Add(this.totalamount);
            this.Controls.Add(this.BillGridView);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.Stocklbl);
            this.Controls.Add(this.Qty);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Emplabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BillingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Total Amount";
            this.Load += new System.EventHandler(this.BillingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BillGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Emplabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox Qty;
        private System.Windows.Forms.Label Stocklbl;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.DataGridView BillGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medname;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unitprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Totalprice;
        private System.Windows.Forms.Label totalamount;
        private System.Windows.Forms.Button Printbtn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button button1;
    }
}