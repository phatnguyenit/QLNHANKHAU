using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using prjQLNK.Control;
using DevExpress.XtraEditors;

namespace prjQLNK
{
    public partial class frmDoiMatKhau : XtraForm
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        string err;
        public bool KiemTra()
        {
            string matkhaucu = txtMKC.Text;
            string matkhaumoi = txtMKM.Text;
            string nhaplaimk= txtNLMK.Text;
            if (matkhaucu == "")
            {
                err = "Nhập mật khẩu cũ.";
                txtMKC.Focus();
                return false;
            }
            if (matkhaucu.Length<5)
            {
                err = "Mật khẩu tối thiểu 5 ký tự!";
                txtMKC.Focus();
                return false;
            }
            else if (matkhaumoi == "")
            {
                err = "Nhập mật khẩu mới.";
                txtMKM.Focus();
                return false;
            }
            if (matkhaumoi.Length < 5)
            {
                err = "Mật khẩu tối thiểu 5 ký tự!";
                txtMKM.Focus();
                return false;
            }
            else if (nhaplaimk == "")
            {
                err = "Nhập lại mật khẩu mới.";
                txtNLMK.Focus();
                return false;
            }            
            else if (matkhaumoi != nhaplaimk)
            {
                err = "Mật khẩu mới không khớp.";
                txtNLMK.Focus();
                return false;
            }
            return true;
        }     

        Process ctrl; DataTable tblNguoiDung;
        private void DoimatkhauC1()
        {
            ctrl = new Process();
            tblNguoiDung = ctrl.LayDuLieuCoDK("NGUOIDUNG", "TAIKHOAN='" + ThongTinDN.Taikhoan + "'");
            CapNhatC1(tblNguoiDung);
            ctrl.CapNhatDuLieuBang1("NGUOIDUNG", "1=1", tblNguoiDung);
        }

        private void CapNhatC1(DataTable tbl)
        {
            DataRow Dong = tbl.Rows[0];
            Dong["MATKHAU"] = txtNLMK.Text;
        }

        private void DoimatkhauC2()
        {
            ctrl = new Process();
            tblNguoiDung = ctrl.LayDuLieuCoDK("NGUOIDUNG", "TAIKHOAN='" + ThongTinDN.Taikhoan + "'");
            CapNhatC2(tblNguoiDung);
            ctrl.CapNhatDuLieuBang1("NGUOIDUNG", "1=1", tblNguoiDung);
        }

        private void CapNhatC2(DataTable tbl)
        {
            DataRow Dong = tbl.Rows[0];
            Dong["MATKHAUCAP2"] = txtNLMK.Text;
        }

        private void KiemTraMKC2()
        {
            ctrl = new Process();
            tblNguoiDung = ctrl.LayDuLieuCoDK("NGUOIDUNG", "TAIKHOAN='" + ThongTinDN.Taikhoan + "' AND MATKHAUCAP2='" + txtMKC.Text + "'");
            KiemTraTonTai(tblNguoiDung);
        }

        bool t = false;
        private void KiemTraTonTai(DataTable tbl)
        {
            if (tbl.Rows.Count > 0)
                t = true;
            else
                t = false;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            txtMKC.Text="";
            txtMKM.Text="";
            txtNLMK.Text="";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (KiemTra())
            {
                if (radMKC1.Checked == true)
                {
                    if (txtMKC.Text == Control.ThongTinDN.Matkhau)
                    {
                        if (Messages.MessagesBox.YesNo("Đổi mật khẩu cấp 1 ?") == DialogResult.Yes)
                        {
                            DoimatkhauC1();
                            Messages.MessagesBox.Success("Đổi mật khẩu thành công.");
                            txtMKC.Text="";
                            txtMKM.Text="";
                            txtNLMK.Text="";
                        }
                    }
                    else
                    {
                        Messages.MessagesBox.Error("Mật khẩu cũ không đúng!.");
                        txtMKC.Focus();
                        return;
                    }
                }
                else
                {
                    KiemTraMKC2();
                    if (t == true)
                    {
                        if (Messages.MessagesBox.YesNo("Đổi mật khẩu cấp 2 ?") == DialogResult.Yes)
                        {
                            DoimatkhauC2();
                            Messages.MessagesBox.Success("Đổi mật khẩu thành công.");
                            txtMKC.Text="";
                            txtMKM.Text="";
                            txtNLMK.Text="";
                            t = false;
                        }
                    }
                    else
                    {
                        Messages.MessagesBox.Error("Mật khẩu cũ không đúng!.");
                        txtMKC.Focus();
                        return;
                    }
                }
            }
            else
                Messages.MessagesBox.Error(err);
        }
    }
}
