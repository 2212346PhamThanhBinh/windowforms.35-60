using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2212346_window_forms_60
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void clbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection items;
            string s = "";
            items = this.clbMonHoc.CheckedItems;
            foreach (object ob in items)
            {
                s += ob.ToString() + ",";

            }
            MessageBox.Show("Danh sach mon hoc:" + s);
        }
    }
}

