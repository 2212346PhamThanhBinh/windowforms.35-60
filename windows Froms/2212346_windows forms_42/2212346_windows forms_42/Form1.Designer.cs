namespace _2212346_windows_forms_42
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
            this.lblUser = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblDes = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(75, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(27, 13);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "user";
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(165, 36);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(66, 20);
            this.textPassword.TabIndex = 1;
            this.textPassword.TextChanged += new System.EventHandler(this.textPassword_TextChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(109, 192);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 27);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(75, 36);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // lblDes
            // 
            this.lblDes.AutoSize = true;
            this.lblDes.Location = new System.Drawing.Point(75, 65);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(60, 13);
            this.lblDes.TabIndex = 5;
            this.lblDes.Text = "Description";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(165, 6);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(66, 20);
            this.txtUser.TabIndex = 6;
            this.txtUser.Text = "User";
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(78, 91);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(245, 95);
            this.txtDescription.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(216, 196);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblDes);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.lblUser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnCancel;
    }
}

