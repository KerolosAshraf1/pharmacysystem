
namespace PharmacyMangment
{
    partial class Employees
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
            this.Empsaltd = new System.Windows.Forms.TextBox();
            this.Empagetb = new System.Windows.Forms.TextBox();
            this.Empnametd = new System.Windows.Forms.TextBox();
            this.Empidtd = new System.Windows.Forms.TextBox();
            this.Empphonetb = new System.Windows.Forms.TextBox();
            this.Backbtn = new System.Windows.Forms.Button();
            this.DelEmpbtn = new System.Windows.Forms.Button();
            this.UpdateEmpbtn = new System.Windows.Forms.Button();
            this.AddEmpbtn = new System.Windows.Forms.Button();
            this.EmployeeDataGridView = new System.Windows.Forms.DataGridView();
            this.Emppasstb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Emplabel
            // 
            this.Emplabel.AutoSize = true;
            this.Emplabel.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Emplabel.ForeColor = System.Drawing.Color.Brown;
            this.Emplabel.Location = new System.Drawing.Point(99, 52);
            this.Emplabel.Name = "Emplabel";
            this.Emplabel.Size = new System.Drawing.Size(289, 53);
            this.Emplabel.TabIndex = 1;
            this.Emplabel.Text = "Employees";
            // 
            // Empsaltd
            // 
            this.Empsaltd.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Empsaltd.ForeColor = System.Drawing.Color.Brown;
            this.Empsaltd.Location = new System.Drawing.Point(261, 188);
            this.Empsaltd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Empsaltd.Name = "Empsaltd";
            this.Empsaltd.Size = new System.Drawing.Size(173, 30);
            this.Empsaltd.TabIndex = 11;
            this.Empsaltd.Text = "Salary";
            // 
            // Empagetb
            // 
            this.Empagetb.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Empagetb.ForeColor = System.Drawing.Color.Brown;
            this.Empagetb.Location = new System.Drawing.Point(14, 351);
            this.Empagetb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Empagetb.Name = "Empagetb";
            this.Empagetb.Size = new System.Drawing.Size(179, 30);
            this.Empagetb.TabIndex = 10;
            this.Empagetb.Text = "Employee Age";
            // 
            // Empnametd
            // 
            this.Empnametd.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Empnametd.ForeColor = System.Drawing.Color.Brown;
            this.Empnametd.Location = new System.Drawing.Point(14, 268);
            this.Empnametd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Empnametd.Name = "Empnametd";
            this.Empnametd.Size = new System.Drawing.Size(179, 30);
            this.Empnametd.TabIndex = 9;
            this.Empnametd.Text = "Employee Name";
            // 
            // Empidtd
            // 
            this.Empidtd.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Empidtd.ForeColor = System.Drawing.Color.Brown;
            this.Empidtd.Location = new System.Drawing.Point(14, 188);
            this.Empidtd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Empidtd.Name = "Empidtd";
            this.Empidtd.Size = new System.Drawing.Size(179, 30);
            this.Empidtd.TabIndex = 8;
            this.Empidtd.Text = "Employee Id";
            // 
            // Empphonetb
            // 
            this.Empphonetb.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Empphonetb.ForeColor = System.Drawing.Color.Brown;
            this.Empphonetb.Location = new System.Drawing.Point(261, 268);
            this.Empphonetb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Empphonetb.Name = "Empphonetb";
            this.Empphonetb.Size = new System.Drawing.Size(173, 30);
            this.Empphonetb.TabIndex = 13;
            this.Empphonetb.Text = "Phone Number";
            // 
            // Backbtn
            // 
            this.Backbtn.BackColor = System.Drawing.Color.Brown;
            this.Backbtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Backbtn.ForeColor = System.Drawing.Color.White;
            this.Backbtn.Location = new System.Drawing.Point(167, 577);
            this.Backbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(111, 64);
            this.Backbtn.TabIndex = 17;
            this.Backbtn.Text = "BACK";
            this.Backbtn.UseVisualStyleBackColor = false;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // DelEmpbtn
            // 
            this.DelEmpbtn.BackColor = System.Drawing.Color.Brown;
            this.DelEmpbtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DelEmpbtn.ForeColor = System.Drawing.Color.White;
            this.DelEmpbtn.Location = new System.Drawing.Point(307, 472);
            this.DelEmpbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DelEmpbtn.Name = "DelEmpbtn";
            this.DelEmpbtn.Size = new System.Drawing.Size(127, 64);
            this.DelEmpbtn.TabIndex = 16;
            this.DelEmpbtn.Text = "DELETE";
            this.DelEmpbtn.UseVisualStyleBackColor = false;
            this.DelEmpbtn.Click += new System.EventHandler(this.DelEmpbtn_Click);
            // 
            // UpdateEmpbtn
            // 
            this.UpdateEmpbtn.BackColor = System.Drawing.Color.Brown;
            this.UpdateEmpbtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UpdateEmpbtn.ForeColor = System.Drawing.Color.White;
            this.UpdateEmpbtn.Location = new System.Drawing.Point(156, 472);
            this.UpdateEmpbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UpdateEmpbtn.Name = "UpdateEmpbtn";
            this.UpdateEmpbtn.Size = new System.Drawing.Size(133, 64);
            this.UpdateEmpbtn.TabIndex = 15;
            this.UpdateEmpbtn.Text = "UPDATE";
            this.UpdateEmpbtn.UseVisualStyleBackColor = false;
            this.UpdateEmpbtn.Click += new System.EventHandler(this.UpdateEmpbtn_Click);
            // 
            // AddEmpbtn
            // 
            this.AddEmpbtn.BackColor = System.Drawing.Color.Brown;
            this.AddEmpbtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddEmpbtn.ForeColor = System.Drawing.Color.White;
            this.AddEmpbtn.Location = new System.Drawing.Point(30, 472);
            this.AddEmpbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddEmpbtn.Name = "AddEmpbtn";
            this.AddEmpbtn.Size = new System.Drawing.Size(111, 64);
            this.AddEmpbtn.TabIndex = 14;
            this.AddEmpbtn.Text = "ADD";
            this.AddEmpbtn.UseVisualStyleBackColor = false;
            this.AddEmpbtn.Click += new System.EventHandler(this.AddEmpbtn_Click);
            // 
            // EmployeeDataGridView
            // 
            this.EmployeeDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.EmployeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeDataGridView.Location = new System.Drawing.Point(443, 16);
            this.EmployeeDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmployeeDataGridView.Name = "EmployeeDataGridView";
            this.EmployeeDataGridView.RowHeadersWidth = 51;
            this.EmployeeDataGridView.RowTemplate.Height = 25;
            this.EmployeeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmployeeDataGridView.Size = new System.Drawing.Size(718, 625);
            this.EmployeeDataGridView.TabIndex = 18;
            this.EmployeeDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Emppasstb
            // 
            this.Emppasstb.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Emppasstb.ForeColor = System.Drawing.Color.Brown;
            this.Emppasstb.Location = new System.Drawing.Point(261, 351);
            this.Emppasstb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Emppasstb.Name = "Emppasstb";
            this.Emppasstb.Size = new System.Drawing.Size(173, 30);
            this.Emppasstb.TabIndex = 19;
            this.Emppasstb.Text = "EmpPassword";
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 657);
            this.Controls.Add(this.Emppasstb);
            this.Controls.Add(this.EmployeeDataGridView);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.DelEmpbtn);
            this.Controls.Add(this.UpdateEmpbtn);
            this.Controls.Add(this.AddEmpbtn);
            this.Controls.Add(this.Empphonetb);
            this.Controls.Add(this.Empsaltd);
            this.Controls.Add(this.Empagetb);
            this.Controls.Add(this.Empnametd);
            this.Controls.Add(this.Empidtd);
            this.Controls.Add(this.Emplabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Employees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Emplabel;
        private System.Windows.Forms.TextBox Empsaltd;
        private System.Windows.Forms.TextBox Empagetb;
        private System.Windows.Forms.TextBox Empnametd;
        private System.Windows.Forms.TextBox Empidtd;
        private System.Windows.Forms.TextBox Empphonetb;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.Button DelEmpbtn;
        private System.Windows.Forms.Button UpdateEmpbtn;
        private System.Windows.Forms.Button AddEmpbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Emppasstb;
        private System.Windows.Forms.DataGridView EmployeeDataGridView;
    }
}