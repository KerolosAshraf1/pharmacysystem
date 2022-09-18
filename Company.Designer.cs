
namespace PharmacyMangment
{
    partial class Company
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
            this.Emplabel = new System.Windows.Forms.Label();
            this.CompAddresstb = new System.Windows.Forms.TextBox();
            this.CompPhonetb = new System.Windows.Forms.TextBox();
            this.CompNametb = new System.Windows.Forms.TextBox();
            this.CompId = new System.Windows.Forms.TextBox();
            this.Backbtn = new System.Windows.Forms.Button();
            this.DelCompbtn = new System.Windows.Forms.Button();
            this.UpdateCompbtn = new System.Windows.Forms.Button();
            this.AddCompbtn = new System.Windows.Forms.Button();
            this.CompanyDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Emplabel
            // 
            this.Emplabel.AutoSize = true;
            this.Emplabel.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Emplabel.ForeColor = System.Drawing.Color.Brown;
            this.Emplabel.Location = new System.Drawing.Point(-7, 12);
            this.Emplabel.Name = "Emplabel";
            this.Emplabel.Size = new System.Drawing.Size(540, 48);
            this.Emplabel.TabIndex = 2;
            this.Emplabel.Text = "Medicine Manufacturer";
            // 
            // CompAddresstb
            // 
            this.CompAddresstb.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CompAddresstb.ForeColor = System.Drawing.Color.Brown;
            this.CompAddresstb.Location = new System.Drawing.Point(258, 249);
            this.CompAddresstb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CompAddresstb.Name = "CompAddresstb";
            this.CompAddresstb.Size = new System.Drawing.Size(187, 30);
            this.CompAddresstb.TabIndex = 23;
            this.CompAddresstb.Text = "Address";
            // 
            // CompPhonetb
            // 
            this.CompPhonetb.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CompPhonetb.ForeColor = System.Drawing.Color.Brown;
            this.CompPhonetb.Location = new System.Drawing.Point(258, 167);
            this.CompPhonetb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CompPhonetb.Name = "CompPhonetb";
            this.CompPhonetb.Size = new System.Drawing.Size(187, 30);
            this.CompPhonetb.TabIndex = 22;
            this.CompPhonetb.Text = "PhoneNumber";
            this.CompPhonetb.TextChanged += new System.EventHandler(this.Empphonetb_TextChanged);
            // 
            // CompNametb
            // 
            this.CompNametb.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CompNametb.ForeColor = System.Drawing.Color.Brown;
            this.CompNametb.Location = new System.Drawing.Point(14, 247);
            this.CompNametb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CompNametb.Name = "CompNametb";
            this.CompNametb.Size = new System.Drawing.Size(193, 30);
            this.CompNametb.TabIndex = 21;
            this.CompNametb.Text = "CompanyName";
            // 
            // CompId
            // 
            this.CompId.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CompId.ForeColor = System.Drawing.Color.Brown;
            this.CompId.Location = new System.Drawing.Point(14, 167);
            this.CompId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CompId.Name = "CompId";
            this.CompId.Size = new System.Drawing.Size(193, 30);
            this.CompId.TabIndex = 20;
            this.CompId.Text = "CompanyId";
            this.CompId.TextChanged += new System.EventHandler(this.CompId_TextChanged);
            // 
            // Backbtn
            // 
            this.Backbtn.BackColor = System.Drawing.Color.Brown;
            this.Backbtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Backbtn.ForeColor = System.Drawing.Color.White;
            this.Backbtn.Location = new System.Drawing.Point(174, 567);
            this.Backbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(111, 64);
            this.Backbtn.TabIndex = 27;
            this.Backbtn.Text = "BACK";
            this.Backbtn.UseVisualStyleBackColor = false;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // DelCompbtn
            // 
            this.DelCompbtn.BackColor = System.Drawing.Color.Brown;
            this.DelCompbtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DelCompbtn.ForeColor = System.Drawing.Color.White;
            this.DelCompbtn.Location = new System.Drawing.Point(325, 465);
            this.DelCompbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DelCompbtn.Name = "DelCompbtn";
            this.DelCompbtn.Size = new System.Drawing.Size(120, 64);
            this.DelCompbtn.TabIndex = 26;
            this.DelCompbtn.Text = "DELETE";
            this.DelCompbtn.UseVisualStyleBackColor = false;
            this.DelCompbtn.Click += new System.EventHandler(this.DelCompbtn_Click);
            // 
            // UpdateCompbtn
            // 
            this.UpdateCompbtn.BackColor = System.Drawing.Color.Brown;
            this.UpdateCompbtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UpdateCompbtn.ForeColor = System.Drawing.Color.White;
            this.UpdateCompbtn.Location = new System.Drawing.Point(174, 465);
            this.UpdateCompbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UpdateCompbtn.Name = "UpdateCompbtn";
            this.UpdateCompbtn.Size = new System.Drawing.Size(133, 64);
            this.UpdateCompbtn.TabIndex = 25;
            this.UpdateCompbtn.Text = "UPDATE";
            this.UpdateCompbtn.UseVisualStyleBackColor = false;
            this.UpdateCompbtn.Click += new System.EventHandler(this.UpdateCompbtn_Click);
            // 
            // AddCompbtn
            // 
            this.AddCompbtn.BackColor = System.Drawing.Color.Brown;
            this.AddCompbtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddCompbtn.ForeColor = System.Drawing.Color.White;
            this.AddCompbtn.Location = new System.Drawing.Point(35, 465);
            this.AddCompbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddCompbtn.Name = "AddCompbtn";
            this.AddCompbtn.Size = new System.Drawing.Size(111, 64);
            this.AddCompbtn.TabIndex = 24;
            this.AddCompbtn.Text = "ADD";
            this.AddCompbtn.UseVisualStyleBackColor = false;
            this.AddCompbtn.Click += new System.EventHandler(this.AddCompbtn_Click);
            // 
            // CompanyDataGridView
            // 
            this.CompanyDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.CompanyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CompanyDataGridView.Location = new System.Drawing.Point(481, 16);
            this.CompanyDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CompanyDataGridView.Name = "CompanyDataGridView";
            this.CompanyDataGridView.RowHeadersWidth = 51;
            this.CompanyDataGridView.RowTemplate.Height = 25;
            this.CompanyDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CompanyDataGridView.Size = new System.Drawing.Size(683, 625);
            this.CompanyDataGridView.TabIndex = 28;
            this.CompanyDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CompanyDataGridView_CellContentClick);
            // 
            // Company
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 657);
            this.Controls.Add(this.CompanyDataGridView);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.DelCompbtn);
            this.Controls.Add(this.UpdateCompbtn);
            this.Controls.Add(this.AddCompbtn);
            this.Controls.Add(this.CompAddresstb);
            this.Controls.Add(this.CompPhonetb);
            this.Controls.Add(this.CompNametb);
            this.Controls.Add(this.CompId);
            this.Controls.Add(this.Emplabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Company";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Company";
            this.Load += new System.EventHandler(this.Company_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CompanyDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Emplabel;
        private System.Windows.Forms.TextBox CompAddresstb;
        private System.Windows.Forms.TextBox CompPhonetb;
        private System.Windows.Forms.TextBox Compnametd;
        private System.Windows.Forms.TextBox CompId;
        private System.Windows.Forms.TextBox CompNametb;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.Button DelEmpbtn;
        private System.Windows.Forms.Button UpdateEmpbtn;
        private System.Windows.Forms.Button AddCompbtn;
        private System.Windows.Forms.DataGridView CompanyDataGridView;
        private System.Windows.Forms.Button UpdateCompbtn;
        private System.Windows.Forms.Button DelCompbtn;
    }
}