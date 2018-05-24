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
using System.Text.RegularExpressions;

namespace prjQLNK
{
    public partial class frmDangKyND : DevExpress.XtraEditors.XtraForm
    {
        public frmDangKyND()
        {
            InitializeComponent();
        }

        private void frmDangKyND_Load(object sender, EventArgs e)
        {
            txtTaiKhoan.Focus();
            DataProvider.connecstring = Ketnoi.strConnection;
        }

        string err;
        private bool KiemtraNhapTK()
        {
            if (txtTaiKhoan.Text == "")
            {
                err = "Tài khoản không được bỏ trống!";
                txtTaiKhoan.Focus();
                return false;
            }
            else if (txtTaiKhoan.Text.Length < 5)
            {
                err = "Tên tài khoản quá ngắn (Tối thiểu 5 ký tự)!";
                txtTaiKhoan.Focus();
                return false;
            }
            else if (txtMatKhau.Text == "")
            {
                err = "Mật khẩu không được bỏ trống!";
                txtMatKhau.Focus();
                return false;
            }
            else if (txtMatKhau.Text.Length < 5)
            {
                err = "Mật khẩu tối thiểu 5 ký tự!";
                txtMatKhau.Focus();
                return false;
            }
            else if (txtNhaplaimk.Text == "")
            {
                err = "Nhập lại mật khẩu!";
                txtNhaplaimk.Focus();
                return false;
            }
            else if (txtNhaplaimk.Text != txtMatKhau.Text)
            {
                err = "Mật khẩu không khớp!";
                txtNhaplaimk.Focus();
                return false;
            }
            else if (txtMatkhaucap2.Text == "")
            {
                err = "Nhập mật khẩu cấp 2!";
                txtMatkhaucap2.Focus();
                return false;
            }
            else if (txtMatkhaucap2.Text.Length < 5)
            {
                err = "Mật khẩu tối thiểu 5 ký tự!";
                txtMatkhaucap2.Focus();
                return false;
            }
            else if (txtNhaplaimatkhaucap2.Text == "")
            {
                err = "Nhập lại mật khẩu cấp 2!";
                txtNhaplaimatkhaucap2.Focus();
                return false;
            }
            else if (txtNhaplaimatkhaucap2.Text != txtMatkhaucap2.Text)
            {
                err = "Mật khẩu cấp 2 không khớp!";
                txtNhaplaimatkhaucap2.Focus();
                return false;
            }
            else if (txtMaso.Text == "")
            {
                err = "Nhập mã số cán bộ!";
                txtMaso.Focus();
                return false;
            }
            else
                return true;
        }

        Process ctrl;
        DataTable tblTaiKhoan, tblCanBo, tblEmail;
        private void KiemTraTenTK()
        {
            ctrl = new Process();
            tblTaiKhoan = ctrl.LayDuLieuCoDK("NGUOIDUNG", "TAIKHOAN='" + txtTaiKhoan.Text + "'");
            KiemTraTonTai(tblTaiKhoan);
        }

        bool t = false;
        private void KiemTraTonTai(DataTable tbl)
        {
            if (tbl.Rows.Count > 0)
                t = true;
            else
                t = false;
        }

        private void KiemTraMaCB()
        {
            ctrl = new Process();
            tblCanBo = ctrl.LayDuLieuCoDK("CANBO", "MACANBO='" + txtMaso.Text + "'");
            KiemTraTonTai(tblCanBo);
        }

        private void KiemTraTrungEmail()
        {
            ctrl = new Process();
            tblEmail = ctrl.LayDuLieuCoDK("CANBO", "EMAIL='" + txtEmail.Text + "'");
            KiemTraTonTai(tblEmail);
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

        Canbo canbo;
        private void LayDuLieuTT()
        {
            canbo = new Canbo();
            canbo.Macanbo = txtMaso.Text;
            canbo.Tencanbo = txtHoten.Text;
            if (radioGT.SelectedIndex == 0)
                canbo.Gioitinh = 1;
            else
                canbo.Gioitinh = 0;
            canbo.Ngaysinh = Convert.ToDateTime(dpkNgaySinh.EditValue);
            canbo.Chucvu = txtChucvu.Text;
            canbo.Diachi = txtDiachi.Text;
            canbo.Sdt = txtSDT.Text;
            canbo.Email = txtEmail.Text;
            canbo.Quyenhan = "Tạm khóa";
        }

        Nguoidung nguoidung;
        private void LayDuLieuTK()
        {
            nguoidung = new Nguoidung();
            nguoidung.Taikhoan = txtTaiKhoan.Text;
            nguoidung.Matkhau = txtMatKhau.Text;
            nguoidung.Macanbo = txtMaso.Text;
            nguoidung.Matkhaucap2 = txtMatkhaucap2.Text;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDieuKhoan_Click(object sender, EventArgs e)
        {
            frmDieuKhoanSD DK = new frmDieuKhoanSD();
            DK.ShowDialog();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (KiemtraNhapTK())
            {
                KiemTraTenTK();
                if (t == false)
                {
                    KiemTraMaCB();
                    if (t == false)
                    {
                        if (KiemTraNhapTT())
                        {
                            KiemTraTrungEmail();
                            if (t == true)
                            {
                                Messages.MessagesBox.Error("Email đã tồn tại, nhập lại!");
                                txtEmail.SelectAll();
                                txtEmail.Focus();
                            }
                            else if (chkDieuKhoan.Checked == false)
                            {
                                Messages.MessagesBox.Error("Vui lòng chấp nhận điều khoản sử dụng!");
                                return;
                            }
                            else
                            {
                                if (Messages.MessagesBox.YesNo("Đăng ký tài khoản?") == DialogResult.Yes)
                                {
                                    ctrl = new Process();
                                    LayDuLieuTT();
                                    ctrl.Themcanbo(canbo.Macanbo, canbo.Tencanbo, canbo.Gioitinh, canbo.Ngaysinh, canbo.Chucvu, canbo.Diachi, canbo.Sdt, canbo.Email, canbo.Quyenhan);
                                    ctrl = new Process();
                                    LayDuLieuTK();
                                    ctrl.Themnguoidung(nguoidung.Taikhoan, nguoidung.Matkhau, nguoidung.Macanbo, nguoidung.Matkhaucap2);
                                    Messages.MessagesBox.Success("Đăng ký tài khoản thành công, vui lòng chờ xác nhận!");
                                    this.Close();
                                }
                            }
                        }
                        else
                            Messages.MessagesBox.Error(err);
                    }
                    else
                    {
                        Messages.MessagesBox.Error("Mã cán bộ tồn tại, nhập lại!");
                        txtMaso.SelectAll();
                        txtMaso.Focus();
                    }
                }
                else
                {
                    Messages.MessagesBox.Error("Tài khoản đã tồn tại, nhập lại!");
                    txtTaiKhoan.SelectAll();
                    txtTaiKhoan.Focus();
                }
            }
            else
                Messages.MessagesBox.Error(err);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                Messages.MessagesBox.Error("Vui lòng nhập số!.");
                e.Handled = true;
            }
        }

        private void txtTaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar > 127 || (((int)e.KeyChar >= 32) && (int)e.KeyChar <= 47) || (((int)e.KeyChar >= 58) && (int)e.KeyChar <= 64) || (((int)e.KeyChar >= 91) && (int)e.KeyChar <= 96) || (((int)e.KeyChar >= 123) && (int)e.KeyChar <= 126))
            {
                // Messages.MessagesBox.Error("Vui lòng nhập chữ không dấu!.");
                e.Handled = true;
            }
        }
    }
}