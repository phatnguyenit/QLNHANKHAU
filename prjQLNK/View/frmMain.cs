using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.UserSkins;
using DevExpress.XtraBars.Helpers;
using System.Threading;
using DevComponents.DotNetBar;
using DevExpress.LookAndFeel;
using System.Diagnostics;
using prjQLNK.Control;
using prjQLNK.Model;
using prjQLNK.Properties;
using DevExpress.XtraSplashScreen;
using DevExpress.Xpo;
using prjQLNK.QLNK;
using System.IO;
using FoxLearn.License;
using DevExpress.XtraEditors;

namespace prjQLNK
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        AddTab.TabAdd clsAddTab = new AddTab.TabAdd();
        public frmMain()
        {
            InitializeComponent();
            UserLookAndFeel.Default.StyleChanged += new EventHandler(Default_StyleChanged);
            SkinHelper.InitSkinGallery(skinTheme);
            UserLookAndFeel.Default.SkinName = Settings.Default["ApplicationSkinName"].ToString();
            acMenu.Enabled = false;
            btnDMK_.Enabled = false;
            btnDMK_.Visibility = BarItemVisibility.Never;

            //--------------
            LicenseAbout();
        }

        void Default_StyleChanged(object sender, EventArgs e)
        {
            UserLookAndFeel lf = (UserLookAndFeel)sender;
            foreach (DevExpress.XtraBars.Ribbon.GalleryItemGroup group in skinTheme.Gallery.Groups)
            {
                foreach (DevExpress.XtraBars.Ribbon.GalleryItem item in group.Items)
                {
                    if ((string)item.Tag == lf.ActiveSkinName)
                    {
                        item.Checked = true;
                        return;
                    }
                }
            }
        }

        private bool ExistForm(XtraForm fr)
        {
            foreach (var child in MdiChildren)
            {
                if (child.Name == fr.Name)
                {
                    child.Activate();
                    return true;
                }
            }
            return false;
        }

        int day = DateTime.Now.Day;
        int month = DateTime.Now.Month;
        int year = DateTime.Now.Year;

        private void frmChuongTrinhChinh_Load(object sender, EventArgs e)
        {
            var ng = new XPQuery<HETHONG>(Session.DefaultSession).Where(o => o.TENTINH != null && o.TENTINH != "").Select(o => new { o.TENTINH, o.NTTU, o.NTDEN }).ToList();
            if (ng.Count > 0)
            {
                this.Text = "PHẦN MỀM QUẢN LÝ NHÂN KHẨU TỈNH " + ng.Select(o => o.TENTINH).FirstOrDefault().ToUpper();
                Bientoancuc.NgayKXTu = ng.Select(o => o.NTTU).FirstOrDefault();
                Bientoancuc.NgayKXDen = ng.Select(o => o.NTDEN).FirstOrDefault();
            }
            ribQLNK.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            barNgaythang.Caption = "Ngày: " + DateTime.Today.ToString("dd/MM/yyyy") + "   |";
            barTime.Caption = "Giờ: " + DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void frmChuongTrinhChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Thoat == false)
                if (Messages.MessagesBox.YesNo("Xác nhận thoát chương trình ?") == DialogResult.Yes)
                {
                    Settings.Default["ApplicationSkinName"] = UserLookAndFeel.Default.SkinName;
                    Settings.Default.Save();
                }
                else
                    e.Cancel = true;
        }

        private void barBaoCao_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnDangNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowDefaultWaitForm("Đang tải", "Vui lòng chờ...");
            if (btnDangNhap.Caption == "Đăng nhập")
            {
                frmDangNhap DN = new frmDangNhap();
                DN.ShowDialog();

                LuuTKTableAdapters.QueriesTableAdapter q = new LuuTKTableAdapters.QueriesTableAdapter();
                if (q.Login(DN.txtTaiKhoan.Text, DN.txtMatKhau.Text) == 1 && ThongTinDN.Truycap == true)
                {
                    btnDuLieu.Enabled = true;
                    lblGioiThieu.Caption = ThongTinDN.QuyenHan + Control.ThongTinDN.Tencanbo;
                    btnDangNhap.Caption = "Đăng xuất";
                    btnDangNhap.LargeGlyph = Properties.Resources.Lock_Unlock_icon;
                    btnDK_.Enabled = true;
                    btnDMK_.Enabled = true;
                    btnDK_.Visibility = BarItemVisibility.Never;
                    btnDMK_.Visibility = BarItemVisibility.Always;
                    btnQMK_.Visibility = BarItemVisibility.Never;
                    ribQLNK.Enabled = true;

                    btnHuongDan.Enabled = true;
                    acMenu.Enabled = true;
                    btnDSND.Enabled = true;
                    //xtraTabControl1.Enabled = true;

                    //SplashScreenManager.ShowDefaultWaitForm("Đang tải", "Vui lòng chờ...");
                    //int t = 0;
                    //foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl1.TabPages)
                    //{
                    //    if (tab.Text == "Thêm mới công dân")
                    //    {
                    //        xtraTabControl1.SelectedTabPage = tab;
                    //        t = 1;
                    //    }
                    //}
                    //if (t == 1) { }
                    //else
                    //    clsAddTab.AddTab(xtraTabControl1, "", "Thêm mới công dân", new frmThemCongDan());
                    //lblGioiThieu.Caption = ThongTinDN.QuyenHan + ThongTinDN.Tencanbo + " | Bạn đang ở tab thêm công dân mới";
                    //SplashScreenManager.CloseDefaultWaitForm();


                    return;
                }
                btnDuLieu.Enabled = false;
                btnDangNhap.Caption = "Đăng nhập";
                btnDangNhap.LargeGlyph = Properties.Resources.Lock_Unlock_icon;
                ribQLNK.Enabled = false;

                btnHuongDan.Enabled = false;
                acMenu.Enabled = false;
                btnDSND.Enabled = false;
                documentManager1.View.Controller.CloseAll();
                btnDK.Visibility = BarItemVisibility.Always;
                btnQuenMK.Visibility = BarItemVisibility.Always;

                foreach (var item in new XPQuery<HETHONG>(Session.DefaultSession))
                {
                    item.TUDONGDN = false;
                    item.Save();
                }

            }
            else
            {
                btnDuLieu.Enabled = false;
                btnDangNhap.Caption = "Đăng nhập";
                ThongTinDN.QuyenHan = "";
                ThongTinDN.Quyenhan = 0;
                ThongTinDN.Tencanbo = "";
                btnDangNhap.LargeGlyph = Properties.Resources.Lock_Unlock_icon;
                btnHuongDan.Enabled = false;
                btnDMK_.Enabled = false;
                ribQLNK.Enabled = false;
                acMenu.Enabled = false;
                btnDSND.Enabled = false;
                documentManager1.View.Controller.CloseAll();
                lblGioiThieu.Caption = "Người dùng chưa đăng nhập";
                btnDK_.Visibility = BarItemVisibility.Always;
                btnQMK_.Visibility = BarItemVisibility.Always;

                foreach (var item in new XPQuery<HETHONG>(Session.DefaultSession))
                {
                    item.TUDONGDN = false;
                    item.Save();
                }
            }
            SplashScreenManager.CloseDefaultWaitForm();
        }

        private void btnDK__ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowDefaultWaitForm("Đang tải", "Vui lòng chờ...");
            frmDangKyND DK = new frmDangKyND();
            DK.ShowDialog();
            SplashScreenManager.CloseDefaultSplashScreen();
        }

        private void btnQMK__ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowDefaultWaitForm("Đang tải", "Vui lòng chờ...");
            frmQuenMK QMK = new frmQuenMK();
            QMK.ShowDialog();
            SplashScreenManager.CloseDefaultSplashScreen();
        }

        bool Thoat = false;
        private void btnThoat__ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Messages.MessagesBox.YesNo("Xác nhận thoát chương trình ?") == DialogResult.Yes)
            {
                Settings.Default["ApplicationSkinName"] = UserLookAndFeel.Default.SkinName;
                Settings.Default.Save();
                Thoat = true;
                Application.Exit();
            }
            else
                return;
        }

        private void btnDMK__ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowDefaultWaitForm("Đang tải", "Vui lòng chờ...");
            frmDoiMatKhau fr = new frmDoiMatKhau();
            fr.ShowDialog();
            SplashScreenManager.CloseDefaultSplashScreen();
        }

        int t = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            t += 1;
            if (t == 1)
            {
                btnDangNhap.PerformClick();
                timer2.Stop();
            }
        }

        public void LicenseAbout()
        {
            string LicensePath = Application.StartupPath + "\\License.lic";
            try
            {
                if (File.Exists(LicensePath))
                {
                    LicenseInfo lic = new LicenseInfo();
                    string ProductID = ComputerInfo.GetComputerId();
                    KeyManager km = new KeyManager(ProductID);
                    int value = km.LoadSuretyFile(string.Format(@"{0}\License.lic", Application.StartupPath), ref lic);
                    string productKey = lic.ProductKey;
                    KeyValuesClass kv = new KeyValuesClass();
                    if (km.DisassembleKey(productKey, ref kv))
                    {
                        if (kv.Type == LicenseType.TRIAL && (kv.Expiration - DateTime.Now.Date).Days > 0)
                            lblLicense.Caption = "Bản quyền: Thời gian còn " + string.Format("{0} ngày sử dụng", (kv.Expiration - DateTime.Now.Date).Days);
                        else
                            lblLicense.Caption = "Bản quyền: " + "Không giới hạn";
                        if ((kv.Expiration - DateTime.Now.Date).Days == 0 && kv.Type != LicenseType.FULL)
                        {
                            btnDangNhap.Enabled = false;
                            lblLicense.Caption = "Bản quyền: " + "Hết hạn";
                            alertControl1.Show(this, "Cảnh báo", "Bản quyền của bạn đã hết hạn, vui lòng cập nhật Key mới!");
                        }
                        if ((kv.Expiration - DateTime.Now.Date).Days < 10 && (kv.Expiration - DateTime.Now.Date).Days != 0 && kv.Type != LicenseType.FULL)
                        {
                            alertControl1.Show(this, "Cảnh báo", "Bản quyền của bạn sắp hết hạn, vui lòng cập nhật Key mới!");
                        }
                    }
                }
                else
                {
                    lblLicense.Caption = "Bản quyền: Chưa đăng ký";
                    btnDangNhap.Enabled = false;
                    alertControl1.Show(this, "Cảnh báo", "Bạn chưa đăng ký bản quyền. Vui lòng nhập key để tiếp tục sử dụng!");
                }
            }
            catch (Exception)
            {
                btnDangNhap.Enabled = false;
                XtraMessageBox.Show("Lỗi bản quyền, vui lòng Key mới để tiếp tục sử dụng!");
                return;
            }
        }

        private void accordionControlElement32_Click(object sender, EventArgs e)
        {
            frmTimKiemNK fr = new frmTimKiemNK();
            if (ExistForm(fr)) return;
            SplashScreenManager.ShowDefaultWaitForm("Đang tải", "Vui lòng chờ...");

            fr.MdiParent = this;
            fr.Show();
            SplashScreenManager.CloseDefaultWaitForm();
        }

        private void accordionControlElement33_Click(object sender, EventArgs e)
        {
            frmTimKiemHK fr = new frmTimKiemHK();
            if (ExistForm(fr)) return;
            SplashScreenManager.ShowDefaultWaitForm("Đang tải", "Vui lòng chờ...");

            fr.MdiParent = this;
            fr.Show();
            SplashScreenManager.CloseDefaultWaitForm();
        }

        private void accordionControlElement35_Click(object sender, EventArgs e)
        {
            frmKTraKhaiNK fr = new frmKTraKhaiNK();
            fr.ShowDialog();
            if (fr.DialogResult == DialogResult.OK)
            {
                frmThemCongDan fr1 = new frmThemCongDan();
                if (ExistForm(fr1)) return;
                SplashScreenManager.ShowDefaultWaitForm("Đang tải", "Vui lòng chờ...");
                fr1.xtraTabControl1.CustomHeaderButtonClick += new DevExpress.XtraTab.ViewInfo.CustomHeaderButtonEventHandler(xtraTabControl1_CustomHeaderButtonClick);
                fr1.MdiParent = this;
                fr1.Show();
                SplashScreenManager.CloseDefaultWaitForm();
            }
        }


        void xtraTabControl1_CustomHeaderButtonClick(object sender, DevExpress.XtraTab.ViewInfo.CustomHeaderButtonEventArgs e)
        {
            if (e.Button.Index == 0)
            {
                SplashScreenManager.ShowDefaultWaitForm("Đang tạo báo cáo", "Vui lòng chờ...");
                frmReport fr = new frmReport();
                fr.Text = "BẢN KHAI NHÂN KHẨU";
                BcBKNKnull re = new BcBKNKnull();
                fr.docView.PrintingSystem = re.PrintingSystem;
                re.CreateDocument();
                fr.MdiParent = this;
                fr.Show();
                SplashScreenManager.CloseDefaultWaitForm();
            }
        }


        private void accordionControlElement36_Click(object sender, EventArgs e)
        {
            frmNhapKhau fr = new frmNhapKhau();
            if (ExistForm(fr)) return;
            SplashScreenManager.ShowDefaultWaitForm("Đang tải", "Vui lòng chờ...");

            fr.MdiParent = this;
            fr.Show();
            SplashScreenManager.CloseDefaultWaitForm();
        }

        private void accordionControlElement37_Click(object sender, EventArgs e)
        {
            frmDienBien fr = new frmDienBien();
            if (ExistForm(fr)) return;
            SplashScreenManager.ShowDefaultWaitForm("Đang tải", "Vui lòng chờ...");

            fr.MdiParent = this;
            fr.Show();
            SplashScreenManager.CloseDefaultWaitForm();
        }

        private void accordionControlElement38_Click(object sender, EventArgs e)
        {
            frmTamVang fr = new frmTamVang();
            if (ExistForm(fr)) return;
            SplashScreenManager.ShowDefaultWaitForm("Đang tải", "Vui lòng chờ...");

            fr.MdiParent = this;
            fr.Show();
            SplashScreenManager.CloseDefaultWaitForm();
        }

        private void accordionControlElement39_Click(object sender, EventArgs e)
        {
            frmBaoTu fr = new frmBaoTu();
            if (ExistForm(fr)) return;
            SplashScreenManager.ShowDefaultWaitForm("Đang tải", "Vui lòng chờ...");

            fr.MdiParent = this;
            fr.Show();
            SplashScreenManager.CloseDefaultWaitForm();
        }

        private void accordionControlElement41_Click(object sender, EventArgs e)
        {
            //SplashScreenManager.ShowDefaultWaitForm("Đang tải", "Vui lòng chờ...");
            frmDKHoKhau DKHK = new frmDKHoKhau();
            DKHK.ShowDialog();
            //SplashScreenManager.CloseDefaultWaitForm();
        }

        private void accordionControlElement43_Click(object sender, EventArgs e)
        {
            frmDmNhanKhau fr = new frmDmNhanKhau("");
            if (ExistForm(fr)) return;
            SplashScreenManager.ShowDefaultWaitForm("Đang tải", "Vui lòng chờ...");

            fr.MdiParent = this;
            fr.Show();
            fr.xtraTabControl2.CustomHeaderButtonClick += new DevExpress.XtraTab.ViewInfo.CustomHeaderButtonEventHandler(xtraTabControl2_CustomHeaderButtonClick);
            SplashScreenManager.CloseDefaultWaitForm();
        }

        void xtraTabControl2_CustomHeaderButtonClick(object sender, DevExpress.XtraTab.ViewInfo.CustomHeaderButtonEventArgs e)
        {
            if (e.Button.Index == 1)
            {
                frmReport fr = new frmReport();
                fr.Text = "BẢN KHAI NHÂN KHẨU";
                if (Bientoancuc.IDNK != 0)
                {
                    Thoai_BcBKNhanKhau Bc = new Thoai_BcBKNhanKhau(Bientoancuc.IDNK);
                    Bc.ShowDialog();
                    if (Bc.DialogResult == DialogResult.OK)
                    {
                        SplashScreenManager.ShowDefaultWaitForm("Đang tạo báo cáo", "Vui lòng chờ...");
                        frmReport fr1 = new frmReport();
                        BcBKNK re = new BcBKNK(Bientoancuc.IDNK, Bc.txtNguoiLap.Text, Convert.ToDateTime(Bc.dpkNgayLap.EditValue), Bc.txtDiaChi.Text);
                        if (Bc.txtNguoiLap.EditValue != null && Bc.txtNguoiLap.Text != "")
                            re.NguoiLap_ = Bc.txtNguoiLap.Text;
                        if (Bc.dpkNgayLap.EditValue != null)
                            re.NgayLap_ = Convert.ToDateTime(Bc.dpkNgayLap.EditValue);
                        if (Bc.txtDiaChi.EditValue != null && Bc.txtDiaChi.Text != "")
                            re.DiaChi_ = Bc.txtDiaChi.Text;
                        fr1.Text = "BẢN KHAI NHÂN KHẨU";
                        fr1.docView.PrintingSystem = re.PrintingSystem;
                        re.CreateDocument();
                        fr1.MdiParent = this;
                        fr1.Show();
                        SplashScreenManager.CloseDefaultWaitForm();
                    }
                }
                else
                {
                    SplashScreenManager.ShowDefaultWaitForm("Đang tạo báo cáo", "Vui lòng chờ...");
                    BcBKNKnull re1 = new BcBKNKnull();
                    fr.docView.PrintingSystem = re1.PrintingSystem;
                    re1.CreateDocument();
                    fr.MdiParent = this;
                    fr.Show();
                    SplashScreenManager.CloseDefaultWaitForm();
                }
            }
        }

        private void accordionControlElement44_Click(object sender, EventArgs e)
        {
            frmDmHOKHAU fr = new frmDmHOKHAU(0);
            if (ExistForm(fr)) return;
            SplashScreenManager.ShowDefaultWaitForm("Đang tải", "Vui lòng chờ...");

            fr.MdiParent = this;
            fr.Show();
            SplashScreenManager.CloseDefaultWaitForm();
        }

        private void accordionControlElement46_Click(object sender, EventArgs e)
        {
            Thoai_BcNhanKhau fr = new Thoai_BcNhanKhau();
            fr.ShowDialog();
            if (fr.DialogResult == DialogResult.OK)
            {
                SplashScreenManager.ShowDefaultWaitForm("Đang tạo báo cáo", "Vui lòng chờ...");
                frmReport fr1 = new frmReport();
                BcNhanKhau re = new BcNhanKhau(fr.txtNguoiLap.Text, Convert.ToDateTime(fr.dpkNgayLap.EditValue), fr.txtDiaChi.Text);
                fr1.Text = "BÁO CÁO NHÂN KHẨU";
                fr1.docView.PrintingSystem = re.PrintingSystem;
                re.CreateDocument();
                fr1.MdiParent = this;
                fr1.Show();
                SplashScreenManager.CloseDefaultWaitForm();
            }
        }

        private void accordionControlElement47_Click(object sender, EventArgs e)
        {
            Thoai_BcHoKhau fr = new Thoai_BcHoKhau();
            fr.ShowDialog();
            if (fr.DialogResult == DialogResult.OK)
            {
                SplashScreenManager.ShowDefaultWaitForm("Đang tạo báo cáo", "Vui lòng chờ...");
                frmReport fr1 = new frmReport();
                BcHoKhau re = new BcHoKhau(fr.txtNguoiLap.Text, Convert.ToDateTime(fr.dpkNgayLap.EditValue), fr.txtDiaChi.Text);
                if (fr.dateEdit1.EditValue != null)
                    re.NgayTu = Convert.ToDateTime(fr.dateEdit1.EditValue);
                if (fr.dateEdit2.EditValue != null)
                    re.NgayDen = Convert.ToDateTime(fr.dateEdit2.EditValue);
                fr1.Text = "BÁO CÁO HỘ KHẨU";
                fr1.docView.PrintingSystem = re.PrintingSystem;
                re.CreateDocument();
                fr1.MdiParent = this;
                fr1.Show();
                SplashScreenManager.CloseDefaultWaitForm();
            }
        }

        private void accordionControlElement49_Click(object sender, EventArgs e)
        {
            frmCDHThong fr = new frmCDHThong();
            fr.ShowDialog();
            frmChuongTrinhChinh_Load(null, null);
        }

        private void accordionControlElement50_Click(object sender, EventArgs e)
        {
            frmThongTinNguoiDung fr = new frmThongTinNguoiDung();
            if (ExistForm(fr)) return;
            SplashScreenManager.ShowDefaultWaitForm("Đang tải", "Vui lòng chờ...");

            fr.MdiParent = this;
            fr.Show();
            SplashScreenManager.CloseDefaultWaitForm();
        }



        //---------------License---------------------------
        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowDefaultWaitForm("Đang tải", "Vui lòng chờ...");
            frmLicense fr = new frmLicense();
            fr.ShowDialog();
            SplashScreenManager.CloseDefaultWaitForm();
        }

        private void alertControl1_ButtonClick(object sender, DevExpress.XtraBars.Alerter.AlertButtonClickEventArgs e)
        {
            SplashScreenManager.ShowDefaultWaitForm("Đang tải", "Vui lòng chờ...");
            frmLicense fr = new frmLicense();
            fr.ShowDialog();
            SplashScreenManager.CloseDefaultWaitForm();
        }
    }
}