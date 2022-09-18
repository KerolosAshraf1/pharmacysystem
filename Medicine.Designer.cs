
namespace PharmacyMangment
{
    partial class Medicine
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
            this.label1 = new System.Windows.Forms.Label();
            this.MedicineGridView = new System.Windows.Forms.DataGridView();
            this.MedicineName = new System.Windows.Forms.TextBox();
            this.BPtb = new System.Windows.Forms.TextBox();
            this.SPtb = new System.Windows.Forms.TextBox();
            this.Quantb = new System.Windows.Forms.TextBox();
            this.ExpireDate = new System.Windows.Forms.DateTimePicker();
            this.Companycb = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MedicineGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Medicine Stock";
            // 
            // MedicineGridView
            // 
            this.MedicineGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.MedicineGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MedicineGridView.Location = new System.Drawing.Point(470, 16);
            this.MedicineGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MedicineGridView.Name = "MedicineGridView";
            this.MedicineGridView.RowHeadersWidth = 51;
            this.MedicineGridView.RowTemplate.Height = 25;
            this.MedicineGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MedicineGridView.Size = new System.Drawing.Size(710, 677);
            this.MedicineGridView.TabIndex = 1;
            this.MedicineGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MedicineGridView_CellContentClick);
            // 
            // MedicineName
            // 
            this.MedicineName.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MedicineName.ForeColor = System.Drawing.Color.Brown;
            this.MedicineName.Location = new System.Drawing.Point(15, 116);
            this.MedicineName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MedicineName.Name = "MedicineName";
            this.MedicineName.Size = new System.Drawing.Size(193, 30);
            this.MedicineName.TabIndex = 2;
            this.MedicineName.Text = "MedicineName";
            this.MedicineName.TextChanged += new System.EventHandler(this.MedicineName_TextChanged);
            // 
            // BPtb
            // 
            this.BPtb.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BPtb.ForeColor = System.Drawing.Color.Brown;
            this.BPtb.Location = new System.Drawing.Point(303, 116);
            this.BPtb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BPtb.Name = "BPtb";
            this.BPtb.Size = new System.Drawing.Size(159, 30);
            this.BPtb.TabIndex = 3;
            this.BPtb.Text = "BuyingPrice";
            this.BPtb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SPtb
            // 
            this.SPtb.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SPtb.ForeColor = System.Drawing.Color.Brown;
            this.SPtb.Location = new System.Drawing.Point(303, 209);
            this.SPtb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SPtb.Name = "SPtb";
            this.SPtb.Size = new System.Drawing.Size(159, 30);
            this.SPtb.TabIndex = 4;
            this.SPtb.Text = "SellingPrice";
            // 
            // Quantb
            // 
            this.Quantb.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Quantb.ForeColor = System.Drawing.Color.Brown;
            this.Quantb.Location = new System.Drawing.Point(303, 317);
            this.Quantb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Quantb.Name = "Quantb";
            this.Quantb.Size = new System.Drawing.Size(159, 30);
            this.Quantb.TabIndex = 5;
            this.Quantb.Text = "Quantitiy";
            // 
            // ExpireDate
            // 
            this.ExpireDate.CalendarFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExpireDate.CalendarMonthBackground = System.Drawing.Color.Red;
            this.ExpireDate.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.ExpireDate.CalendarTitleForeColor = System.Drawing.Color.Brown;
            this.ExpireDate.Location = new System.Drawing.Point(15, 209);
            this.ExpireDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ExpireDate.Name = "ExpireDate";
            this.ExpireDate.Size = new System.Drawing.Size(218, 27);
            this.ExpireDate.TabIndex = 6;
            // 
            // Companycb
            // 
            this.Companycb.FormattingEnabled = true;
            this.Companycb.Location = new System.Drawing.Point(14, 317);
            this.Companycb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Companycb.Name = "Companycb";
            this.Companycb.Size = new System.Drawing.Size(185, 28);
            this.Companycb.TabIndex = 7;
            this.Companycb.SelectedIndexChanged += new System.EventHandler(this.Companycb_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Brown;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(14, 468);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 64);
            this.button1.TabIndex = 8;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Brown;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(152, 468);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 64);
            this.button2.TabIndex = 9;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Brown;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(303, 468);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 64);
            this.button3.TabIndex = 10;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Brown;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(152, 569);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 64);
            this.button4.TabIndex = 11;
            this.button4.Text = "BACK";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Medicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 709);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Companycb);
            this.Controls.Add(this.ExpireDate);
            this.Controls.Add(this.Quantb);
            this.Controls.Add(this.SPtb);
            this.Controls.Add(this.BPtb);
            this.Controls.Add(this.MedicineName);
            this.Controls.Add(this.MedicineGridView);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Medicine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medicine";
            this.Load += new System.EventHandler(this.Medicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MedicineGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView MedicineGridView;
        private System.Windows.Forms.TextBox MedicineName;
        private System.Windows.Forms.TextBox BPtb;
        private System.Windows.Forms.TextBox SPtb;
        private System.Windows.Forms.TextBox Quantb;
        private System.Windows.Forms.DateTimePicker ExpireDate;
        private System.Windows.Forms.ComboBox Compantcd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox Companycb;
    }
}