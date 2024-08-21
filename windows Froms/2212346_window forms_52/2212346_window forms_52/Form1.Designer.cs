namespace _2212346_window_forms_52
{
    partial class Form1
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
            this.lbDanhsach = new System.Windows.Forms.ListBox();
            this.lbDanhsachChon = new System.Windows.Forms.ListBox();
            this.lblDS = new System.Windows.Forms.Label();
            this.lblDB = new System.Windows.Forms.Label();
            this.btnADD = new System.Windows.Forms.Button();
            this.btnXOA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDanhsach
            // 
            this.lbDanhsach.FormattingEnabled = true;
            this.lbDanhsach.Items.AddRange(new object[] {
            "Pham Vu Ngoc Ha",
            "Hoang Van Hung",
            "Le Thi Van",
            "Nguyen Thi Thu",
            "Le Van Quoc",
            "Le Van Phuoc",
            "Truong Van Dang"});
            this.lbDanhsach.Location = new System.Drawing.Point(41, 66);
            this.lbDanhsach.Name = "lbDanhsach";
            this.lbDanhsach.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbDanhsach.Size = new System.Drawing.Size(120, 95);
            this.lbDanhsach.TabIndex = 0;
            // 
            // lbDanhsachChon
            // 
            this.lbDanhsachChon.FormattingEnabled = true;
            this.lbDanhsachChon.Items.AddRange(new object[] {
            "Tran The Anh\t",
            "Nguyen Thi Lan Huong"});
            this.lbDanhsachChon.Location = new System.Drawing.Point(248, 66);
            this.lbDanhsachChon.Name = "lbDanhsachChon";
            this.lbDanhsachChon.Size = new System.Drawing.Size(187, 95);
            this.lbDanhsachChon.TabIndex = 1;
            this.lbDanhsachChon.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblDS
            // 
            this.lblDS.AutoSize = true;
            this.lblDS.Location = new System.Drawing.Point(38, 50);
            this.lblDS.Name = "lblDS";
            this.lblDS.Size = new System.Drawing.Size(121, 13);
            this.lblDS.TabIndex = 2;
            this.lblDS.Text = "Danh sách sinh viên lớp";
            // 
            // lblDB
            // 
            this.lblDB.AutoSize = true;
            this.lblDB.Location = new System.Drawing.Point(245, 50);
            this.lblDB.Name = "lblDB";
            this.lblDB.Size = new System.Drawing.Size(190, 13);
            this.lblDB.TabIndex = 3;
            this.lblDB.Text = "Danh sách sinh viên tham gia đá bóng";
            this.lblDB.Click += new System.EventHandler(this.lblDB_Click);
            // 
            // btnADD
            // 
            this.btnADD.Location = new System.Drawing.Point(167, 91);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(75, 23);
            this.btnADD.TabIndex = 4;
            this.btnADD.Text = "Chon";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // btnXOA
            // 
            this.btnXOA.Location = new System.Drawing.Point(167, 120);
            this.btnXOA.Name = "btnXOA";
            this.btnXOA.Size = new System.Drawing.Size(75, 23);
            this.btnXOA.TabIndex = 5;
            this.btnXOA.Text = "Xoa";
            this.btnXOA.UseVisualStyleBackColor = true;
            this.btnXOA.Click += new System.EventHandler(this.btnXOA_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnXOA);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.lblDB);
            this.Controls.Add(this.lblDS);
            this.Controls.Add(this.lbDanhsachChon);
            this.Controls.Add(this.lbDanhsach);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbDanhsach;
        private System.Windows.Forms.ListBox lbDanhsachChon;
        private System.Windows.Forms.Label lblDS;
        private System.Windows.Forms.Label lblDB;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Button btnXOA;
    }
}

