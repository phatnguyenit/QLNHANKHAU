using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Data.Filtering;
using System.Globalization;
using prjQLNK.QLNK;
using DevExpress.XtraGrid.Menu;
using DevExpress.Utils.Menu;
using DevExpress.XtraSplashScreen;

namespace prjQLNK
{
    public partial class frmTimKiemNK : XtraForm
    {
        public frmTimKiemNK()
        {
            InitializeComponent();
            //cboGT.Items.AddEnum(typeof(GioiTinh), true);
            LoadNhanKhau();
        }

        private void LoadNhanKhau()
        {
            var nhankhau_ = (from hk in xpHOKHAU.Cast<HOKHAU>()
                             join nk in xpNHANKHAU.Cast<NHANKHAU>() on hk.SOHOKHAU equals nk.SOHOKHAU
                             select new
                             {
                                 MAKHAISINH = nk.MAKHAISINH,
                                 HOTENKHAISINH = nk.HOTENKHAISINH,
                                 TENGOIKHAC = nk.TENGOIKHAC,
                                 NGAYSINH = nk.NGAYSINH.ToString("dd/MM/yyyy"),
                                 GIOITINH = nk.GIOITINH == 0 ? "Nam" : nk.GIOITINH == 1 ? "Nữ" : "",
                                 DANTOC = nk.DANTOC,
                                 TONGIAO = nk.TONGIAO,
                                 QUOCTICH = nk.QUOCTICH,
                                 SOCMND = nk.SOCMND,
                                 NGAYCAP = nk.NGAYCAP.ToString("dd/MM/yyyy"),
                                 NOICAP = nk.NOICAP,
                                 TRINHDO = nk.TRINHDO,
                                 TDCHUYENMON = nk.TDCHUYENMON,
                                 NGHENGHIEP = nk.NGHENGHIEP,
                                 NOILAMVIEC = nk.NOILAMVIEC,
                                 QUANHE = nk.QUANHE,
                                 BIETTIENGDANTOC = nk.BIETTIENGDANTOC,
                                 TDNGOAINGU = nk.TDNGOAINGU,
                                 SOHOKHAU = nk.SOHOKHAU,

                                 NOISINH = nk.DC1 + ", xã " + nk.IDXA1 + ", huyện " + nk.IDHUYEN1 + ", tỉnh " + nk.IDTINH1,
                                 NGUYENQUAN = nk.DC2 + ", xã " + nk.IDXA2 + ", huyện " + nk.IDHUYEN2 + ", tỉnh " + nk.IDTINH2,
                                 NOITHUONGTRU = nk.DC3 + ", xã " + nk.IDXA3 + ", huyện " + nk.IDHUYEN3 + ", tỉnh " + nk.IDTINH3,
                                 CHOOHIENHAN = nk.DC4 + ", xã " + nk.IDXA4 + ", huyện " + nk.IDHUYEN4 + ", tỉnh " + nk.IDTINH4,
                             }).ToList();
            gridControl1.DataSource = nhankhau_.ToList();
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var nhankhau_ = (from hk in xpHOKHAU.Cast<HOKHAU>()
                             join nk in xpNHANKHAU.Cast<NHANKHAU>() on hk.SOHOKHAU equals nk.SOHOKHAU
                             select new
                             {
                                 MAKHAISINH = nk.MAKHAISINH,
                                 HOTENKHAISINH = nk.HOTENKHAISINH,
                                 TENGOIKHAC = nk.TENGOIKHAC,
                                 NGAYSINH = nk.NGAYSINH,
                                 GIOITINH = nk.GIOITINH == 0 ? "Nam" : nk.GIOITINH == 1 ? "Nữ" : "",
                                 DANTOC = nk.DANTOC,
                                 TONGIAO = nk.TONGIAO,
                                 QUOCTICH = nk.QUOCTICH,
                                 SOCMND = nk.SOCMND,
                                 NGAYCAP = nk.NGAYCAP,
                                 NOICAP = nk.NOICAP,
                                 TRINHDO = nk.TRINHDO,
                                 TDCHUYENMON = nk.TDCHUYENMON,
                                 NGHENGHIEP = nk.NGHENGHIEP,
                                 NOILAMVIEC = nk.NOILAMVIEC,
                                 QUANHE = nk.QUANHE,
                                 BIETTIENGDANTOC = nk.BIETTIENGDANTOC,
                                 TDNGOAINGU = nk.TDNGOAINGU,
                                 SOHOKHAU = nk.SOHOKHAU,

                                 NOISINH = nk.DC1 + ", xã " + nk.IDXA1 + ", huyện " + nk.IDHUYEN1 + ", tỉnh " + nk.IDTINH1,
                                 NGUYENQUAN = nk.DC2 + ", xã " + nk.IDXA2 + ", huyện " + nk.IDHUYEN2 + ", tỉnh " + nk.IDTINH2,
                                 NOITHUONGTRU = nk.DC3 + ", xã " + nk.IDXA3 + ", huyện " + nk.IDHUYEN3 + ", tỉnh " + nk.IDTINH3,
                                 CHOOHIENHAN = nk.DC4 + ", xã " + nk.IDXA4 + ", huyện " + nk.IDHUYEN4 + ", tỉnh " + nk.IDTINH4,
                             }).ToList();
            gridControl1.DataSource = nhankhau_.ToList();

            if (txtCMND.Text != "" && txtHTKS.Text == "" && txtSDD.Text == "" && txtSHK.Text == "" && txtTGK.Text == "")
                gridControl1.DataSource = nhankhau_.Where(o => o.SOCMND == Convert.ToString(txtCMND.Text)).ToList();
            else if (txtCMND.Text == "" && txtHTKS.Text != "" && txtSDD.Text == "" && txtSHK.Text == "" && txtTGK.Text == "")
                gridControl1.DataSource = nhankhau_.Where(o => o.HOTENKHAISINH == Convert.ToString(txtHTKS.Text)).ToList();
            else if (txtCMND.Text == "" && txtHTKS.Text == "" && txtSDD.Text != "" && txtSHK.Text == "" && txtTGK.Text == "")
                gridControl1.DataSource = nhankhau_.Where(o => o.MAKHAISINH == Convert.ToString(txtSDD.Text)).ToList();
            else if (txtCMND.Text == "" && txtHTKS.Text == "" && txtSDD.Text == "" && txtSHK.Text != "" && txtTGK.Text == "")
                gridControl1.DataSource = nhankhau_.Where(o => o.SOHOKHAU == Convert.ToInt32(txtSHK.Text)).ToList();
            else if (txtCMND.Text == "" && txtHTKS.Text == "" && txtSDD.Text == "" && txtSHK.Text == "" && txtTGK.Text != "")
                gridControl1.DataSource = nhankhau_.Where(o => o.TENGOIKHAC == Convert.ToString(txtTGK.Text)).ToList();
            else
                LoadNhanKhau();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            LoadNhanKhau();
            txtCMND.Text = txtHTKS.Text = txtSDD.Text = txtSHK.Text = txtTGK.Text = "";
        }

        private void gridView1_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Row)
            {
                GridViewMenu menu = e.Menu as GridViewMenu;
                menu.Items.Clear();

                DXMenuItem itemSua = new DXMenuItem("Chi tiết nhân khẩu");
                itemSua.Image = imageCollection1.Images["edit"];
                itemSua.Click += new EventHandler(SuaNK);
                menu.Items.Add(itemSua);
            }
        }

        private void SuaNK(object sender, EventArgs e)
        {
            SplashScreenManager.ShowDefaultWaitForm("Đang tải", "Vui lòng chờ...");
            frmDmNhanKhau fr = new frmDmNhanKhau(gridView1.GetFocusedRowCellValue("MAKHAISINH") != null ? Convert.ToString(gridView1.GetFocusedRowCellValue("MAKHAISINH")) : "");
            fr.ShowDialog();
            SplashScreenManager.CloseDefaultSplashScreen();
            LoadNhanKhau();
            Bientoancuc.inSua = false;
        }

        private void layoutControlGroup2_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if (e.Button.Properties.Caption == "Làm mới")
            {
                LoadNhanKhau();
                alertControl1.Show(this, "Thông báo", "Đã làm mới");
            }
        }
    }
}
