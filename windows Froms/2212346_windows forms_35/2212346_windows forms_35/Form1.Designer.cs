namespace _2212346_windows_forms_35
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
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblwed = new System.Windows.Forms.Label();
            this.llbllink = new System.Windows.Forms.LinkLabel();
            this.llbllink1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(25, 36);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(80, 13);
            this.lblDiaChi.TabIndex = 0;
            this.lblDiaChi.Text = "dia chi quan he";
            this.lblDiaChi.Click += new System.EventHandler(this.lblDiaChi_Click);
            // 
            // lblwed
            // 
            this.lblwed.AutoSize = true;
            this.lblwed.Location = new System.Drawing.Point(25, 69);
            this.lblwed.Name = "lblwed";
            this.lblwed.Size = new System.Drawing.Size(54, 13);
            this.lblwed.TabIndex = 1;
            this.lblwed.Text = "trang wed";
            this.lblwed.Click += new System.EventHandler(this.label2_Click);
            // 
            // llbllink
            // 
            this.llbllink.AutoSize = true;
            this.llbllink.Location = new System.Drawing.Point(181, 36);
            this.llbllink.Name = "llbllink";
            this.llbllink.Size = new System.Drawing.Size(92, 13);
            this.llbllink.TabIndex = 2;
            this.llbllink.TabStop = true;
            this.llbllink.Text = "ctk31@gmail.com";
            this.llbllink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // llbllink1
            // 
            this.llbllink1.AutoSize = true;
            this.llbllink1.Location = new System.Drawing.Point(181, 69);
            this.llbllink1.Name = "llbllink1";
            this.llbllink1.Size = new System.Drawing.Size(85, 13);
            this.llbllink1.TabIndex = 3;
            this.llbllink1.TabStop = true;
            this.llbllink1.Text = "www.cntk31.net";
            this.llbllink1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbllink1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.llbllink1);
            this.Controls.Add(this.llbllink);
            this.Controls.Add(this.lblwed);
            this.Controls.Add(this.lblDiaChi);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblwed;
        private System.Windows.Forms.LinkLabel llbllink;
        private System.Windows.Forms.LinkLabel llbllink1;
    }
}

