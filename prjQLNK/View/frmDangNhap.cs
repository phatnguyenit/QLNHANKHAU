using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Threading;
using prjQLNK.Control;
using System.Data.SqlClient;
using prjQLNK.Model;
using DevExpress.XtraSplashScreen;
using DevExpress.Xpo;
using prjQLNK.QLNK;

namespace prjQLNK
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtTaiKhoan.Text = Properties.Settings.Default.Taikhoan;
            txtMatKhau.Text = Properties.Settings.Default.Matkhau;
            DataProvider.connecstring = Ketnoi.strConnection;

            bool checkTDDN = new XPQuery<HETHONG>(Session.DefaultSession).Select(o => o.TUDONGDN).FirstOrDefault();
            if (checkTDDN && chkLuu.Checked)
                simpleButton1.PerformClick();
        }

        bool t = true;
        private void KiemTraTonTai(DataTable tbl)
        {
            if (tbl.Rows.Count > 0)
                t = true;
            else
                t = false;
        }

        Process ctrl;
        DataTable tblCanBo;
        private void KiemTraTruyCap() //Hàm kiểm tra được phép truy cập hay tạm khóa người dùng
        {
            ctrl = new Process();
            tblCanBo = ctrl.LayDuLieuCoDK("CANBO C, NGUOIDUNG N", "N.MACANBO =C.MACANBO  AND C.QUYENHAN=N'Tạm khóa' and N.TAIKHOAN='" + txtTaiKhoan.Text + "'");
            KiemTraTonTai(tblCanBo);
        }

        private void KiemTraQuyenHan() //Hàm kiểm tra quản trị hay người dùng
        {
            ctrl = new Process();
            tblCanBo = ctrl.LayDuLieuCoDK("CANBO C, NGUOIDUNG N", "N.MACANBO =C.MACANBO  AND C.QUYENHAN=N'Quản lý' and N.TAIKHOAN='" + txtTaiKhoan.Text + "'");
            KiemTraTonTai(tblCanBo);
        }

        DataTable tblCanbo;
        public static string macanbo, tencanbo;
        private void Nguoidung()
        {
            ctrl = new prjQLNK.Control.Process();
            tblCanbo = ctrl.LayDuLieuCoDK("CANBO, NGUOIDUNG", "CANBO.MACANBO=NGUOIDUNG.MACANBO AND NGUOIDUNG.TAIKHOAN='" + txtTaiKhoan.Text + "'");
            LayTT(tblCanbo);
        }

        private void LayTT(DataTable tbl)
        {
            if (tbl.Rows.Count > 0)
            {
                DataRow Dong = tbl.Rows[0];
                tencanbo = Dong["TENCANBO"].ToString();
                macanbo = Dong["MACANBO"].ToString();
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {

                //SplashScreenManager.ShowDefaultWaitForm("Đang kết nối", "Vui lòng chờ...");
                LuuTKTableAdapters.QueriesTableAdapter q = new LuuTKTableAdapters.QueriesTableAdapter();
                if (txtTaiKhoan.Text == "")
                {
                    Messages.MessagesBox.Error("Tài khoản không được bỏ trống.");
                    txtTaiKhoan.Focus();
                }
                else if (txtMatKhau.Text == "")
                {
                    Messages.MessagesBox.Error("Mật khẩu không được bỏ trống.");
                    txtMatKhau.Focus();
                }
                else
                {
                    if (q.Login(txtTaiKhoan.Text, txtMatKhau.Text) == 1)
                    {
                        SplashScreenManager.ShowDefaultWaitForm("Đang kết nối", "Vui lòng chờ...");
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        this.Close();
                        Nguoidung();
                        ThongTinDN.Taikhoan = txtTaiKhoan.Text;
                        ThongTinDN.Tencanbo = tencanbo;
                        ThongTinDN.Macanbo = macanbo;
                        ThongTinDN.Matkhau = txtMatKhau.Text;
                        KiemTraTruyCap();
                        if (t == false)
                        {
                            ThongTinDN.Truycap = true;
                            KiemTraQuyenHan();
                            if (t == true)
                            {
                                ThongTinDN.Quyenhan = 1;
                                ThongTinDN.QuyenHan = "Quản lý: ";
                            }
                            else
                            {
                                ThongTinDN.Quyenhan = 0;
                                ThongTinDN.QuyenHan = "Người dùng: ";
                            }
                        }
                        else
                        {
                            Messages.MessagesBox.Error("Người dùng đang tạm khóa, vui lòng liên hệ quản trị!");
                            ThongTinDN.Truycap = false;
                            return;
                        }

                        SplashScreenManager.CloseDefaultWaitForm();
                    }
                    else
                    {
                        Messages.MessagesBox.Error("Tài khoản hoặc mật khẩu không đúng.");
                        txtTaiKhoan.Text = "";
                        txtMatKhau.Text = "";
                        txtTaiKhoan.Focus();
                    }
                }

                //SplashScreenManager.CloseDefaultWaitForm();
            }
            catch
            {
                Messages.MessagesBox.Info("Lổi kết nối cơ sở dữ liệu.");
            }
            if (chkLuu.Checked)
            {
                Properties.Settings.Default.Taikhoan = txtTaiKhoan.Text;
                Properties.Settings.Default.Matkhau = txtMatKhau.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Taikhoan = "";
                Properties.Settings.Default.Matkhau = "";
                Properties.Settings.Default.Save();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            t = false;
            this.Close();
        }
    }
}