﻿using QuanLySinhVien.DAL.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var mh = MonHoc.GetMH();
            bdsMonHoc.DataSource = mh;
            cbxMonHoc.DataSource = bdsMonHoc;
            cbxMonHoc.DisplayMember = "tenmonhoc";
        }

        private void CbxMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            var monhoc = (MonHoc)cbxMonHoc.SelectedItem;
            if(monhoc != null)
            {
                bdsLopHocPhan.DataSource = LopHocPhan.GetLHPtheoMaMonHoc(monhoc.mamonhoc);
                dgvLopHocPhan.DataSource = bdsLopHocPhan;
            }
        }

        private void DgvLopHocPhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var lophocphan = (LopHocPhan)bdsLopHocPhan.Current;
            bdsSinhVien.DataSource = SinhVien.GetSVtheoMaLop(lophocphan.malophocphan);
            dgvSinhVien.DataSource = bdsSinhVien;
            lblMaLHP.Text = lophocphan.malophocphan;
            lblGiaoVienPhuTrach.Text = lophocphan.giaovienphutrach;
            lblSoLuongDK.Text = lophocphan.soluongdangky.ToString();
            lblMinMax.Text = lophocphan.soluongmin.ToString() + "/" + lophocphan.soluongmax.ToString();
        }
    }
}