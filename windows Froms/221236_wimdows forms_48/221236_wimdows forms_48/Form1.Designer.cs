namespace _221236_wimdows_forms_48
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
            this.cboNgoaiNgu = new System.Windows.Forms.ComboBox();
            this.lblchon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboNgoaiNgu
            // 
            this.cboNgoaiNgu.FormattingEnabled = true;
            this.cboNgoaiNgu.Items.AddRange(new object[] {
            "Tiếng anh",
            "Tiếng Pháp\t",
            "Tiếng Nhật"});
            this.cboNgoaiNgu.Location = new System.Drawing.Point(332, 97);
            this.cboNgoaiNgu.Name = "cboNgoaiNgu";
            this.cboNgoaiNgu.Size = new System.Drawing.Size(121, 21);
            this.cboNgoaiNgu.TabIndex = 0;
            this.cboNgoaiNgu.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblchon
            // 
            this.lblchon.AutoSize = true;
            this.lblchon.Location = new System.Drawing.Point(242, 100);
            this.lblchon.Name = "lblchon";
            this.lblchon.Size = new System.Drawing.Size(84, 13);
            this.lblchon.TabIndex = 1;
            this.lblchon.Text = "Chọn Ngôn Ngữ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblchon);
            this.Controls.Add(this.cboNgoaiNgu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboNgoaiNgu;
        private System.Windows.Forms.Label lblchon;
    }
}

