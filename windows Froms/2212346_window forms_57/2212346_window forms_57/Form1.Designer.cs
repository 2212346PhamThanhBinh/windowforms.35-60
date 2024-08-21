namespace _2212346_window_forms_57
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
            this.btnButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ckbMauchu = new System.Windows.Forms.CheckBox();
            this.txbMaunen = new System.Windows.Forms.CheckBox();
            this.rdFlat = new System.Windows.Forms.RadioButton();
            this.rdPopup = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnButton
            // 
            this.btnButton.Location = new System.Drawing.Point(63, 86);
            this.btnButton.Name = "btnButton";
            this.btnButton.Size = new System.Drawing.Size(75, 23);
            this.btnButton.TabIndex = 0;
            this.btnButton.Text = "Button";
            this.btnButton.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(63, 149);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button Flat";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ckbMauchu
            // 
            this.ckbMauchu.AutoSize = true;
            this.ckbMauchu.Checked = true;
            this.ckbMauchu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbMauchu.Location = new System.Drawing.Point(188, 69);
            this.ckbMauchu.Name = "ckbMauchu";
            this.ckbMauchu.Size = new System.Drawing.Size(112, 17);
            this.ckbMauchu.TabIndex = 2;
            this.ckbMauchu.Text = "Thay đổi màu chữ";
            this.ckbMauchu.UseVisualStyleBackColor = true;
            this.ckbMauchu.CheckedChanged += new System.EventHandler(this.ckbMauchu_CheckedChanged);
            // 
            // txbMaunen
            // 
            this.txbMaunen.AutoSize = true;
            this.txbMaunen.Checked = true;
            this.txbMaunen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.txbMaunen.Location = new System.Drawing.Point(188, 92);
            this.txbMaunen.Name = "txbMaunen";
            this.txbMaunen.Size = new System.Drawing.Size(112, 17);
            this.txbMaunen.TabIndex = 3;
            this.txbMaunen.Text = "Thay đổi màu nền";
            this.txbMaunen.UseVisualStyleBackColor = true;
            this.txbMaunen.CheckedChanged += new System.EventHandler(this.txbMaunen_CheckedChanged);
            // 
            // rdFlat
            // 
            this.rdFlat.AutoSize = true;
            this.rdFlat.Location = new System.Drawing.Point(188, 149);
            this.rdFlat.Name = "rdFlat";
            this.rdFlat.Size = new System.Drawing.Size(66, 17);
            this.rdFlat.TabIndex = 4;
            this.rdFlat.Text = "Kiều Flat";
            this.rdFlat.UseVisualStyleBackColor = true;
            this.rdFlat.CheckedChanged += new System.EventHandler(this.rdFlat_CheckedChanged);
            // 
            // rdPopup
            // 
            this.rdPopup.AutoSize = true;
            this.rdPopup.Checked = true;
            this.rdPopup.Location = new System.Drawing.Point(188, 172);
            this.rdPopup.Name = "rdPopup";
            this.rdPopup.Size = new System.Drawing.Size(80, 17);
            this.rdPopup.TabIndex = 5;
            this.rdPopup.TabStop = true;
            this.rdPopup.Text = "Kiểu Popup";
            this.rdPopup.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rdPopup);
            this.Controls.Add(this.rdFlat);
            this.Controls.Add(this.txbMaunen);
            this.Controls.Add(this.ckbMauchu);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox ckbMauchu;
        private System.Windows.Forms.CheckBox txbMaunen;
        private System.Windows.Forms.RadioButton rdFlat;
        private System.Windows.Forms.RadioButton rdPopup;
    }
}

