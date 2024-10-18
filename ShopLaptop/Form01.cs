﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace ShopLaptop
{
    public partial class ShopLaptop : Form
    {
        public ShopLaptop()
        {
            InitializeComponent();
        }

        private void btn_TrangChu_Click(object sender, EventArgs e)
        {
            gunaPictureBox.Image = Properties.Resources.dashboard;
            gunaLabel.Text = "Trang chủ";
            container(new Form_TrangChu());
        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            gunaPictureBox.Image = Properties.Resources.employee;
            gunaLabel.Text = "Nhân viên";
            container(new Form_NhanVien());
        }

        private void btn_Laptop_Click(object sender, EventArgs e)
        {
            gunaPictureBox.Image = Properties.Resources.laptop;
            gunaLabel.Text = "Laptop";
            container(new Form_Laptop());
        }

        private void btn_NhaCungCap_Click(object sender, EventArgs e)
        {
            gunaPictureBox.Image = Properties.Resources.box;
            gunaLabel.Text = "Nhà cung cấp";
            container(new Form_NhaCungCap());
        }

        private void btn_PhieuNhapKho_Click(object sender, EventArgs e)
        {
            gunaPictureBox.Image = Properties.Resources.detail;
            gunaLabel.Text = "Phiếu nhập kho";
            container(new Form_PhieuNhapKho());
        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            gunaPictureBox.Image = Properties.Resources.receipt;
            gunaLabel.Text = "Hóa đơn";
            container(new Form_HoaDon());
        }

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            gunaPictureBox.Image = Properties.Resources.customer;
            gunaLabel.Text = "Khách hàng";
            container(new Form_KhachHang());
        }

        private void btn_TraGop_Click(object sender, EventArgs e)
        {
            gunaPictureBox.Image = Properties.Resources.credit;
            gunaLabel.Text = "Trả góp";
            container(new Form_TraGop());
        }

        private void btn_BaoHanh_Click(object sender, EventArgs e)
        {
            gunaPictureBox.Image = Properties.Resources.warranty;
            gunaLabel.Text = "Bảo hành";
            container(new Form_BaoHanh());
        }

        private void btn_NangCap_Click(object sender, EventArgs e)
        {
            gunaPictureBox.Image = Properties.Resources.upgrade;
            gunaLabel.Text = "Nâng cấp";
            container(new Form_NangCap());
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            gunaPictureBox.Image = Properties.Resources.chart;
            container(new Form_VeDoThi());
        }

        int x = 160, y = 15, a = 1;
        Random random = new Random();

      

        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                x += a;
                gunaLabelWelcome.Location = new Point(x, y);
                if (x >= 600)
                {
                    a = -2;
                }
                if (x <= 185)
                {
                    a = 2;
                }
            }
            catch (Exception ex)
            { 
                ex.Source = "Error";
            }
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            gunaPictureBox.Image = Properties.Resources.chart;
            container(new Form_ChiTietHoaDon());
        }

        private void btn_CTPN_Click(object sender, EventArgs e)
        {
            gunaPictureBox.Image = Properties.Resources.chart;
            container(new Form_ChiTietPhieuNhap());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            container(new Form_CaiDat());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Form_DangNhap dn = new Form_DangNhap();
            this.Hide();
            dn.ShowDialog();
            this.Close();
        }

        private void container(object _form)
        {
            if(panelContent.Controls.Count > 0) 
                 panelContent.Controls.Clear();
            Form form = _form as Form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelContent.Controls.Add(form);
            panelContent.Tag = form;
            form.Show();
        }
        public void ShowForm(Form form)
        {
            if (panelContent.Controls.Count > 0)
                panelContent.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelContent.Controls.Add(form);
            panelContent.Tag = form;
            form.Show();
        }
    }
}
