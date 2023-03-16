﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void rdNu_CheckedChanged(object sender, EventArgs e)
        {
            if (rdNu.Checked)
            MessageBox.Show($"Bạn đã chọn giới tính nữ.", "Thông báo");
        }

        private void btToMau_Click(object sender, EventArgs e)
        {
            if (rdDo.Checked)
                txtHopMau.BackColor = Color.Red;
            if (rdXanh.Checked)
                txtHopMau.BackColor = Color.Blue;
        }

        private void RdNam_CheckedChanged(object sender, EventArgs e)
        {
            if (rdNam.Checked)
                MessageBox.Show($"Bạn đã chọn giới tính nam.", "Thông báo");
        }
    }
}
