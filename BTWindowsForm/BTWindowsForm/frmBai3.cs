using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTWindowsForm
{
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnXemKetQua_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtSoA.Text);
            int b = int.Parse(txtSoB.Text);
            int n = int.Parse(txtSoN.Text);
            int kq = 0;

            if (rdTongAB.Checked)
                TinhToan.TongHaiSo(a, b, ref kq);
            else
               kq = TinhToan.TongDaySo(n);

            //hiển thị kq
            lblKetQua.Text = kq.ToString();
        }

        private void txtSoA_TextChanged(object sender, EventArgs e)
        {
            txtSoA.Text = "";
        }

        private void txtSoA_MouseClick(object sender, MouseEventArgs e)
        {
            txtSoA.Text = "";
        }

        private void txtSoB_MouseClick(object sender, MouseEventArgs e)
        {
            txtSoB.Text = "";
        }

        private void txtSoN_MouseClick(object sender, MouseEventArgs e)
        {
            txtSoN.Text = "";
        }
    }
}
