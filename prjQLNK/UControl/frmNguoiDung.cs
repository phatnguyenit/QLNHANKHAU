using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using prjQLNK.Control;
using prjQLNK.Model;
using DevExpress.XtraEditors;

namespace prjQLNK
{
    public partial class frmThongTinNguoiDung : XtraForm
    {
        public frmThongTinNguoiDung()
        {
            InitializeComponent();
        }

        Process ctrl;
        private void LoadCanBo()
        {
            ctrl = new Process();
            gridCanBo.DataSource = ctrl.LoadCanBo();
            ctrl.Disconnect_process();
        }

        private void frmThongTinNguoiDung_Load(object sender, EventArgs e)
        {
            DataProvider.connecstring = Ketnoi.strConnection;
            cboQuyenhan.SelectedIndex = 0;
            LoadCanBo();
        }

        private void btnIn_Click_1(object sender, EventArgs e)
        {
            gridCanBo.ShowPrintPreview();
        }

        public bool Kiemtraemail(string diachiemail)
        {
            string dinhdang = @"^(([^<>()[\]\\.,;:\s@\""]+"
            + @"(\.[^<>()[\]\\.,;:\s@\""]+)*)|(\"".+\""))@"
            + @"((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}"
            + @"\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+"
            + @"[a-zA-Z]{2,}))$";
            Regex hanche = new Regex(dinhdang);
            bool kiemtra = hanche.IsMatch(diachiemail);
            return kiemtra;
        }

        string err;
        private bool KiemTraNhapTT()
        {
            if (txtHoten.Text == "")
            {
                err = "Nhập họ tên!";
                txtHoten.Focus();
                return false;
            }
            else if (dpkNgaySinh.Text == "")
            {
                err = "Nhập ngày sinh!";
                dpkNgaySinh.Focus();
                return false;
            }
            else if (dpkNgaySinh.Value.Year>(NgayThang.nam-18))
            {
                err = "Nhập ngày sinh không hợp lệ!.";
                dpkNgaySinh.Focus();
                return false;
            }
            else if (txtDiachi.Text == "")
            {
                err = "Nhập địa chỉ!";
                txtDiachi.Focus();
                return false;
            }
            else if (txtSDT.Text == "")
            {
                err = "Nhập số điện thoại!";
                txtSDT.Focus();
                return false;
            }
            else if (txtSDT.Text.Length < 10)
            {
                err = "Số điện thoại tối thiểu 10 số";
                txtSDT.Focus();
                return false;
            }
            else if (txtEmail.Text == "")
            {
                err = "Nhập Email!";
                txtEmail.Focus();
                return false;
            }
            else if (Kiemtraemail(txtEmail.Text) == false)
            {
                err = "Email không hợp lệ!";
                txtEmail.Focus();
                return false;
            }
            else if (txtChucvu.Text == "")
            {
                err = "Nhập chức vụ!";
                txtChucvu.Focus();
                return false;
            }
            return true;
        }

        DataTable tblCanbo;
        private void CapNhatDong(DataTable tbl)
        {
            DataRow Dong = tbl.Rows[0];
            Dong["TENCANBO"] = txtHoten.Text;
            if (radNam.Checked == true)
                Dong["GIOITINH"] = 1;
            else
                Dong["GIOITINH"] = 0;
            Dong["NGAYSINH"] = dpkNgaySinh.Value;
            Dong["DIACHI"] = txtDiachi.Text;
            Dong["SDT"] = txtSDT.Text;
            Dong["EMAIL"] = txtEmail.Text;
            Dong["CHUCVU"] = txtChucvu.Text;
            Dong["QUYENHAN"] = cboQuyenhan.Text;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (BangNguoiDung.DataSource == null || lblMaso.Text == "")
            {
                Messages.MessagesBox.Error("Cán bộ trống!");
                return;
            }
            if (ThongTinDN.Quyenhan == 1)
            {
                if (lblMaso.Text != "")
                {
                    if (btnSua.Text == "Sửa")
                    {
                        if (Process.Macanbo == "CB01")
                            cboQuyenhan.Enabled = false;
                        else
                            cboQuyenhan.Enabled = true;
                        btnSua.Text = "Lưu";
                        btnSua.Image = Properties.Resources.Save1;
                        pannelThongTin.Enabled = true;
                        btnXoa.Enabled = false;
                        btnHuy.Enabled = true;
                        gridCanBo.Enabled = false;
                    }
                    else if (btnSua.Text == "Lưu")
                    {
                        if (KiemTraNhapTT())
                        {
                            if (Messages.MessagesBox.YesNo("Cập nhật thông tin cán bộ?") == DialogResult.Yes)
                            {
                                CapNhatDong(tblCanbo);
                                ctrl = new Process();
                                ctrl.CapNhatDuLieuBang1("CANBO", "1=1", tblCanbo);
                                Messages.MessagesBox.Success("Cập nhật thành công.");
                                btnSua.Text = "Sửa";
                                btnSua.Image = Properties.Resources.edit;
                                frmThongTinNguoiDung_Load(sender, e);
                                pannelThongTin.Enabled = false;
                                btnXoa.Enabled = true;
                                btnHuy.Enabled = false;
                                gridCanBo.Enabled = true;
                                cboQuyenhan.Enabled = true;
                            }
                            else
                                return;
                        }
                        else
                            Messages.MessagesBox.Error(err);
                    }
                }
            }
            else
            {
                Messages.MessagesBox.Error("Chức năng bị từ chối, chỉ quản lý mới có thể chỉnh sửa!");
                btnHuy.PerformClick();
            }
        }

        private void GanDuLieu(DataTable tbl)
        {
            if (tbl.Rows.Count > 0)
            {
                DataRow Dong = tbl.Rows[0];
                lblMaso.Text = Dong["MACANBO"].ToString();
                txtHoten.Text = Dong["TENCANBO"].ToString();
                if ((int)Dong["GIOITINH"] == 1)
                    radNam.Checked = true;
                else
                    radNu.Checked = true;
                dpkNgaySinh.Text = Dong["NGAYSINH"].ToString();
                txtDiachi.Text = Dong["DIACHI"].ToString();
                txtSDT.Text = Dong["SDT"].ToString();
                txtEmail.Text = Dong["EMAIL"].ToString();
                txtChucvu.Text = Dong["CHUCVU"].ToString();
                cboQuyenhan.Text = Dong["QUYENHAN"].ToString();
            }            
        }

        string macanbo = "";
        private void Loadlai()
        {
            if (BangNguoiDung.GetFocusedRowCellValue("MACANBO") == null)
                return;
            else
            {
                ctrl = new Process();
                macanbo = BangNguoiDung.GetFocusedRowCellValue("MACANBO").ToString();
                tblCanbo = ctrl.LayDuLieuCoDK("CANBO", "MACANBO='" + macanbo + "'");
                GanDuLieu(tblCanbo);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnSua.Text = "Sửa";
            btnSua.Image = Properties.Resources.edit;
            pannelThongTin.Enabled = false;
            btnXoa.Enabled = true;
            btnHuy.Enabled = false;
            gridCanBo.Enabled = true;
            lblMaso.Visible = true;
            txtMaso.Visible = false;
            btnHuy.Enabled = false;
            btnSua.Enabled = true;
            if (gridCanBo.DataSource != null)
            {
                ctrl = new Process();
                macanbo = BangNguoiDung.GetFocusedRowCellValue("MACANBO").ToString();
                tblCanbo = ctrl.LayDuLieuCoDK("CANBO", "MACANBO='" + macanbo + "'");
                GanDuLieu(tblCanbo);
            }
            cboQuyenhan.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (ThongTinDN.Quyenhan == 1)
            {
                if (BangNguoiDung.DataSource == null || lblMaso.Text == "")
                {
                    Messages.MessagesBox.Error("Cán bộ trống!");
                    return;
                }
                else if (Process.Macanbo == "CB01")
                {
                    Messages.MessagesBox.Error("Không thể xóa cán bộ này!");
                    return;
                }
                else if (Messages.MessagesBox.YesNo("Xóa cán bộ " + txtHoten.Text + "?") == DialogResult.Yes)
                {
                    ctrl = new Process();
                    ctrl.Xoa("CANBO", "MACANBO='" + macanbo + "'");
                    Messages.MessagesBox.Success("Xóa thành công!");
                    frmThongTinNguoiDung_Load(sender, e);
                    btnXoa.Enabled = true;
                    btnSua.Enabled = true;
                    Loadlai();
                    BangNguoiDung_FocusedRowChanged(sender1, e1);
                }
            }
            else
            {
                Messages.MessagesBox.Error("Chức năng bị từ chối, chỉ quản lý mới có thể xóa!");
                btnHuy.PerformClick();
            }
        }  

        Canbo canbo;
        private void LayDuLieuTT()
        {
            canbo = new Canbo();
            canbo.Macanbo = txtMaso.Text;
            canbo.Tencanbo = txtHoten.Text;
            if (radNam.Checked)
                canbo.Gioitinh = 1;
            else
                canbo.Gioitinh = 0;
            canbo.Ngaysinh = dpkNgaySinh.Value;
            canbo.Chucvu = txtChucvu.Text;
            canbo.Diachi = txtDiachi.Text;
            canbo.Sdt = txtSDT.Text;
            canbo.Email = txtEmail.Text;
            canbo.Quyenhan = cboQuyenhan.Text;
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                Messages.MessagesBox.Error("Chỉ được nhập số.");
                e.Handled = true;
            }
        }       

        private void txtSDT_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                Messages.MessagesBox.Error("Vui lòng nhập số.");
                e.Handled = true;
            }
        }

        public DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e { get; set; }

        public object sender { get; set; }

        public object sender1 { get; set; }

        public DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e1 { get; set; }

        private void BangNguoiDung_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (BangNguoiDung.GetFocusedRowCellValue("MACANBO") != null)
                Process.Macanbo = BangNguoiDung.GetFocusedRowCellValue("MACANBO").ToString();
            if (BangNguoiDung.GetFocusedRowCellValue("MACANBO") == null)
                return;
            else
            {
                ctrl = new Process();
                macanbo = BangNguoiDung.GetFocusedRowCellValue("MACANBO").ToString();
                tblCanbo = ctrl.LayDuLieuCoDK("CANBO", "MACANBO='" + macanbo + "'");
                GanDuLieu(tblCanbo);
            }
        }
    }
}
