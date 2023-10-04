using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapTuan3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void bnt_capNhat_MouseClick(object sender, MouseEventArgs e)
        {
            if (int.TryParse(txt_Nhap.Text, out int number))
            {
                cb.Items.Add(txt_Nhap.Text);
                txt_Nhap.Clear();
                txt_Nhap.Focus();
            }
            else
            {
                MessageBox.Show("chi duoc nhap so");
                txt_Nhap.Clear();
                txt_Nhap.Focus();
            }
        }

        private void txt_Nhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(txt_Nhap.Text, out int number))
                {
                    cb.Items.Add(txt_Nhap.Text);
                    txt_Nhap.Clear();
                    txt_Nhap.Focus();
                }
                else
                {
                    MessageBox.Show("chi duoc nhap so");
                    txt_Nhap.Clear();
                    txt_Nhap.Focus();
                }
            }
        }

        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            list_capNhat.Items.Clear();
            int so = int.Parse(cb.Text);
            for (int i = 1; i <= so; i++)
            {
                if (so % i == 0)
                {
                    list_capNhat.Items.Add(i);
                }
            }
        }

        private void bnt_TSU_Click(object sender, EventArgs e)
        {

            int tong = 0;
            for (int i = 0; i < list_capNhat.Items.Count; i++)
            {
                tong += (int)list_capNhat.Items[i];
            }
            MessageBox.Show($"{tong}");
        }

        private void bnt_SLUSChan_Click(object sender, EventArgs e)
        {
            int dem = 0;
            int n = list_capNhat.Items.Count;
            for (int i = 0; i < n; i++)
            {
                if ((int)list_capNhat.Items[i] % 2 == 0)
                {
                    dem++;
                }
            }
            MessageBox.Show($"{dem}");
        }
    }
}
