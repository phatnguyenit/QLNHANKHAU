using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using prjQLNK.Control;
using prjQLNK.Model;

namespace prjQLNK
{
    public partial class frmChiTietNguoiMat : DevExpress.XtraEditors.XtraForm
    {
        public frmChiTietNguoiMat()
        {
            InitializeComponent();
        }

        Process ctrl;
        DataTable tblBaoTu, tblCanBo;
        private void LoadTTBaoTu()
        {
            ctrl = new Process();
            string makhaisinh = MKSNguoiMat.MaKhaiSinh;
            tblBaoTu = ctrl.LayDuLieuCoDK("BAOTU", "MAKHAISINH='" + makhaisinh + "'");
        }

        private void LayTenCB()
        {
            ctrl = new Process();
            tblCanBo = ctrl.LayDuLieuCoDK("CANBO", "MACANBO='" + macanbo + "'");
            GanTenCanBo(tblCanBo);
        }

        private void GanTenCanBo(DataTable tbl)
        {
            if (tbl.Rows.Count > 0)
            {
                DataRow Dong = tbl.Rows[0];
                lblNguoilap.Text = Dong["TENCANBO"].ToString();
            }
        }

        string macanbo;
        private void GanDuLieu(DataTable tbl)
        {
            if (tbl.Rows.Count > 0)
            {
                DataRow Dong = tbl.Rows[0];
                dpkNgaymat.Text = Dong["NGAYMAT"].ToString();
                txtLydomat.Text = Dong["LYDOMAT"].ToString();
                txtGhichu.Text = Dong["GHICHU"].ToString();
                txtNguoikhai.Text = Dong["NGUOIKHAI"].ToString();
                lblNgayKhai.Text = Dong["NGAYKHAI"].ToString();
                macanbo = Dong["MACANBO"].ToString();
                LayTenCB();
            }
        }

        private void frmChiTietNguoiMat_Load(object sender, EventArgs e)
        {
            DataProvider.connecstring = Ketnoi.strConnection;
            LoadTTBaoTu();
            GanDuLieu(tblBaoTu);
        }

        private bool BatLoi()
        {
            if (dpkNgaymat.Value.Day> NgayThang.ngay || dpkNgaymat.Value.Month>NgayThang.thang || dpkNgaymat.Value.Year>NgayThang.nam)
            {
                Messages.MessagesBox.Error("Ngày mất không hợp lệ!");
                dpkNgaymat.Focus();
                return false;
            }
            else if (txtLydomat.Text == "")
            {
                Messages.MessagesBox.Error("Nhập lý do mất!");
                txtLydomat.Focus();
                return false;
            }
            else if (txtNguoikhai.Text == "")
            {
                Messages.MessagesBox.Error("Nhập người khai tử!");
                txtNguoikhai.Focus();
                return false;
            }
            else
                return true;
        }

        private void CapNhatDong(DataTable tbl)
        {
            DataRow Dong = tbl.Rows[0];
            Dong["NGAYMAT"] = dpkNgaymat.Value;
            Dong["LYDOMAT"] = txtLydomat.Text;
            Dong["GHICHU"] = txtGhichu.Text;
            Dong["NGUOIKHAI"] = txtNguoikhai.Text;
            Dong["NGAYKHAI"] = DateTime.Parse(lblNgayKhai.Text);
            Dong["MACANBO"] = ThongTinDN.Macanbo;
        }

        bool t = true;
        private void AnHien()
        {
            dpkNgaymat.Enabled = t;
            txtGhichu.Enabled = t;
            txtLydomat.Enabled = t;
            txtNguoikhai.Enabled = t;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Text == "Sửa")
            {
                btnSua.Text = "Lưu";
                btnSua.Image = Properties.Resources.Save1;
                btnDong.Image = Properties.Resources.cancel;
                t = true;
                AnHien();
                btnDong.Text = "Hủy";
                lblNguoilap.Text = ThongTinDN.Tencanbo;
            }
            else if (btnSua.Text == "Lưu")
            {
                if (BatLoi())
                {
                    if (Messages.MessagesBox.YesNo("Lưu thay đổi ?") == DialogResult.Yes)
                    {
                        ctrl = new Process();
                        CapNhatDong(tblBaoTu);
                        ctrl.CapNhatDuLieuBang1("BAOTU", "1=1", tblBaoTu);
                        t = false;
                        AnHien();
                        Messages.MessagesBox.Success("Đã lưu.");
                        btnSua.Text = "Sửa";
                        btnSua.Image = Properties.Resources.edit;
                        btnDong.Image = Properties.Resources.Close;
                        btnDong.Text = "Đóng";
                    }
                }
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (btnDong.Text == "Hủy")
            {
                t = false;
                AnHien();
                btnDong.Text = "Đóng";
                btnSua.Text = "Sửa";
                btnSua.Image = Properties.Resources.edit;
                btnDong.Image = Properties.Resources.Close;
                GanDuLieu(tblBaoTu);
            }
            else
                this.Close();
        }
    }
}