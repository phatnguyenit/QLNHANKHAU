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
    public partial class frmQuenMK : DevExpress.XtraEditors.XtraForm
    {
        public frmQuenMK()
        {
            InitializeComponent();
        }

        public bool KiemTraNhap()
        {
            if (txt1.Text == "")
            {
                err = "Nhập tài khoản!.";
                txt1.Focus();
                return false;
            }
            else if (txt1.Text.Length < 5)
            {
                err = "Tên tài khoản quá ngắn (Tối thiểu 5 ký tự)!";
                txt1.Focus();
                return false;
            }
            else if (txt2.Text == "")
            {
                err = "Nhập mật khẩu cấp 2!.";
                txt2.Focus();
                return false;
            }
            else if (txt2.Text.Length < 5)
            {
                err = "Mật khẩu tối thiểu 5 ký tự!";
                txt2.Focus();
                return false;
            }
            return true;
        }

        public bool KiemTraNhapMK()
        {
            if (txt1.Text == "")
            {
                err = "Nhập mật khẩu mới!.";
                txt1.Focus();
                return false;
            }
            else if (txt1.Text.Length < 5)
            {
                err = "Mật khẩu tối thiểu 5 ký tự!";
                txt1.Focus();
                return false;
            }
            else if (txt2.Text == "")
            {
                err = "Nhập lại mật khẩu mới!.";
                txt2.Focus();
                return false;
            }
            else if (txt1.Text !=txt2.Text)
            {
                err = "Mật khẩu mới không khớp!.";
                txt2.Focus();
                return false;
            }
            return true;
        }

        DataTable tblNguoiDung; string Taikhoan = "", Matkhau="";
        private void btnTimLai_Click(object sender, EventArgs e)
        {
            
        }

        private void Doimatkhau()
        {
            ctrl = new Process();
            tblNguoiDung = ctrl.LayDuLieuCoDK("NGUOIDUNG", "TAIKHOAN='" + Taikhoan + "'");
            CapNhat(tblNguoiDung);
            ctrl.CapNhatDuLieuBang1("NGUOIDUNG", "1=1", tblNguoiDung);
        }

        private void CapNhat(DataTable tbl)
        {
            DataRow Dong = tbl.Rows[0];
            Dong["MATKHAU"] = Matkhau;
        }

        Process ctrl;
        private void KiemTraTaiKhoan()
        {
            ctrl = new Process();
            tblNguoiDung = ctrl.LayDuLieuCoDK("NGUOIDUNG", "TAIKHOAN='" + txt1.Text + "'");
            KiemTraTonTai(tblNguoiDung);
        }

        private void KiemTraMKC2()
        {
            ctrl = new Process();
            tblNguoiDung = ctrl.LayDuLieuCoDK("NGUOIDUNG", "TAIKHOAN='" + txt1.Text + "' AND MATKHAUCAP2='" + txt2.Text + "'");
            KiemTraTonTai(tblNguoiDung);
        }

        string err; bool t = false;
        private void KiemTraTonTai(DataTable tbl)
        {
            if (tbl.Rows.Count > 0)
                t = true;
            else
                t = false;
        }

        private void frmQuenMK_Load(object sender, EventArgs e)
        {
            txt1.Focus();
            DataProvider.connecstring = Ketnoi.strConnection;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (btnTimLai.Text == "Kiểm tra")
            {
                if (KiemTraNhap())
                {
                    KiemTraTaiKhoan();
                    if (t == true)
                    {
                        t = false;
                        KiemTraMKC2();
                        if (t == true)
                        {
                            Taikhoan = txt1.Text;
                            txt1.Text = "";
                            txt2.Text = "";
                            txt1.Focus();
                            lbl1.Text = "Mật khẩu mới:";
                            lbl2.Text = "Nhập lại mật khẩu mới:";
                            //txt1.WatermarkText = "Mật khẩu mới";
                            txt1.Properties.PasswordChar = '*';
                            //txt2.WatermarkText = "Nhập lại mật khẩu mới";
                            btnTimLai.Text = "Đổi mật khẩu";
                            btnTimLai.Image = Properties.Resources.yes;
                        }
                        else
                        {
                            txt2.SelectAll();
                            txt2.Focus();
                            Messages.MessagesBox.Error("Mật khẩu cấp 2 không đúng!.");
                        }
                    }
                    else
                    {
                        txt1.SelectAll();
                        txt1.Focus();
                        Messages.MessagesBox.Error("Tài khoản " + txt1.Text + " không tồn tại!.");
                    }
                }
                else
                    Messages.MessagesBox.Error(err);
            }
            else if (btnTimLai.Text == "Đổi mật khẩu")
            {
                if (KiemTraNhapMK())
                {
                    Matkhau = txt2.Text;
                    if (Messages.MessagesBox.YesNo("Lưu mật khẩu mới ?") == DialogResult.Yes)
                    {
                        Doimatkhau();
                        Messages.MessagesBox.Success("Đổi mật khẩu thành công!.");
                        this.Close();
                    }
                }
                else
                    Messages.MessagesBox.Error(err);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}