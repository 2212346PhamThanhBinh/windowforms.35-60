using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2212346_window_forms_52
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblDB_Click(object sender, EventArgs e)
        {

        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            int itemsselect = lbDanhsach.SelectedItems.Count - 1;
            for (int i = itemsselect; i >= 0; i--)
            {
                lbDanhsachChon.Items.Add(lbDanhsach.SelectedItems[i]);
                lbDanhsach.Items.Remove(lbDanhsach.SelectedItems[i]);
                // lstDanhsach.Items.RemoveAt(lstDanhsach.SelectedIndices[i]);

            }




        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            int i = lbDanhsachChon.SelectedItems.Count - 1;
            while (i >= 0)
            {
                lbDanhsachChon.Items.RemoveAt(lbDanhsachChon.SelectedIndices[i]);
                i--;
            }
        }
    }
}
