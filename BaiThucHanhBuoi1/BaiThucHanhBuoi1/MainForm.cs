﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanhBuoi1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var TenDaNhap = txtTen.Text;
            MessageBox.Show($"Xin chào bạn {TenDaNhap}. Rất vui được gặp bạn!", "Thông điệp chào mừng");
        }

        private void btnSaoChep_Click(object sender, EventArgs e)
        {
            var txtSaoChep = txtTen.Text;
        }

        private void txtTen_TextChanged_1(object sender, EventArgs e)
        {
            txtSaoChep.Text = txtTen.Text;
        }
    }
}
