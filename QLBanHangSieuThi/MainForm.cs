﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHangSieuThi
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            panelTongquan.Controls.Add(new Layout.FormTongQuan());
        }
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private void btexit_Click(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }
        private void minimize_Click(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            panelTongquan.Controls.Clear();
            panelTongquan.Controls.Add(new Layout.FormTongQuan());
            panelLine.Height = bunifuFlatButton1.Height-2;
            panelLine.Top = bunifuFlatButton1.Top+1;
        }

        private void btdonhang_Click(object sender, EventArgs e)
        {
            panelTongquan.Controls.Clear();
            panelTongquan.Controls.Add(new Layout.FormDonHang());
            panelLine.Height = btdonhang.Height-2;
            panelLine.Top = btdonhang.Top+1;
            
        }

        private void bthanghoa_Click(object sender, EventArgs e)
        {
            panelTongquan.Controls.Clear();
            panelTongquan.Controls.Add(new Layout.FormHangHoa());
            panelLine.Height = bthanghoa.Height-2;
            panelLine.Top = bthanghoa.Top+1;
        }

        private void btkhachhang_Click(object sender, EventArgs e)
        {
            panelTongquan.Controls.Clear();
            panelTongquan.Controls.Add(new Layout.FormKhachHang());
            panelLine.Height = btkhachhang.Height-2;
            panelLine.Top = btkhachhang.Top+1;
        }

        private void btkhuyenmai_Click(object sender, EventArgs e)
        {
            panelTongquan.Controls.Clear();
            panelTongquan.Controls.Add(new Layout.FormKhuyenMai());
            panelLine.Height = btkhuyenmai.Height - 2;
            panelLine.Top = btkhuyenmai.Top + 1;
        }

        private void btdoanhthu_Click(object sender, EventArgs e)
        {
            panelTongquan.Controls.Clear();
            panelTongquan.Controls.Add(new Layout.FormDoanhThu());
            panelLine.Height = btdoanhthu.Height - 2;
            panelLine.Top = btdoanhthu.Top + 1;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string privilege = string.Empty;
            if (UserInfo.Quyen == "2") privilege = "Cao";
            if (UserInfo.Quyen == "1") 
            {
                privilege = "Trung bình";
                EditAccess.Enabled = false;
                label5.Enabled = false;
            }
            UserDetails.Text = "Người dùng: " + UserInfo.HoTen+"   Cấp: "+privilege;
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Close();
            login.Show();
        }

        private void EditAccess_Click(object sender, EventArgs e)
        {
            panelTongquan.Controls.Clear();
            panelTongquan.Controls.Add(new Layout.FormUsers());
        }
    }
}