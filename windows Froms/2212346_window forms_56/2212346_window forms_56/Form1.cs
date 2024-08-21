using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2212346_window_forms_56
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbNam.Checked)
                MessageBox.Show("Giới bạn là :" + rbNam.Text);
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbNu.Checked)
                MessageBox.Show("Giới bạn là :" + rbNu.Text);
        }

    }
}
