using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2212346_window_forms_57
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ckbMauchu_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ckbMauchu.Checked)
                this.btnButton.ForeColor = Color.Red;
            else
                this.btnButton.ForeColor = Color.Black;
        }

        private void txbMaunen_CheckedChanged(object sender, EventArgs e)
        {
            if (this.txbMaunen.Checked)
                this.btnButton.BackColor = Color.LightCyan;
            else
                this.btnButton.BackColor = this.rdFlat.BackColor;
        }

        private void rdFlat_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rdFlat.Checked)
                this.rdFlat.FlatStyle = FlatStyle.Flat;
            else
                this.rdFlat.FlatStyle = FlatStyle.Popup;
        }
    }   
}
