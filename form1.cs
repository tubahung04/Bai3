using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai3
{
    public partial class listview : Form
    {
        public listview()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            {
                ListViewItem it = new ListViewItem(txt_lastName.Text);
                it.SubItems.Add(txt_firstName.Text);
                it.SubItems.Add(txt_Phone.Text);
                lvView.Items.Add(it);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvView.SelectedItems.Count > 0)
            {
                ListViewItem item = lvView.SelectedItems[0];
                item.SubItems[0].Text = txt_lastName.Text;
                item.SubItems[1].Text = txt_firstName.Text;
                item.SubItems[2].Text = txt_Phone.Text;

            }
            else
            {
                MessageBox.Show("Chon dong de sua!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (lvView.SelectedItems.Count > 0)
            {
                lvView.Items.RemoveAt(lvView.SelectedItems[0].Index);
            }
            else
            {
                MessageBox.Show("Chon dong de xoa!");
            }
        }
    }
}
