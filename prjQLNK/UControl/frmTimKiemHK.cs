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
    public partial class frmTimKiemHK : XtraForm
    {
        public frmTimKiemHK()
        {
            InitializeComponent();
            LoadHoKhau();
        }

        private void LoadHoKhau()
        {
            var hokhau_ = (from hk in xpHOKHAU.Cast<HOKHAU>()
                           join nk in xpNHANKHAU.Cast<NHANKHAU>() on hk.SOHOKHAU equals nk.SOHOKHAU
                           select new
                           {
                               SOHOKHAU = hk.SOHOKHAU,
                               HOTENCHUHO = nk.HOTENKHAISINH,
                               DIACHI = nk.DC1 + ", xã " + nk.IDXA1 + ", huyện " + nk.IDHUYEN1 + ", tỉnh " + nk.IDTINH1,
                               NGAYDK = hk.NGAYDK
                           }).GroupBy(o => o.SOHOKHAU).Select(o => new
                           {
                               SOHOKHAU = o.Key,
                               HOTENCHUHO = o.Select(o1 => o1.HOTENCHUHO).FirstOrDefault(),
                               NGAYDK = o.Select(o1 => o1.NGAYDK).FirstOrDefault(),
                               DIACHI = o.Select(o1 => o1.DIACHI).FirstOrDefault(),
                           });
            gridControl3.DataSource = hokhau_.ToList();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var hokhau_ = (from hk in xpHOKHAU.Cast<HOKHAU>()
                           join nk in xpNHANKHAU.Cast<NHANKHAU>() on hk.SOHOKHAU equals nk.SOHOKHAU
                           select new
                           {
                               SOHOKHAU = hk.SOHOKHAU,
                               HOTENCHUHO = nk.HOTENKHAISINH,
                               DIACHI = nk.DC1 + ", xã " + nk.IDXA1 + ", huyện " + nk.IDHUYEN1 + ", tỉnh " + nk.IDTINH1,
                               NGAYDK = hk.NGAYDK
                           }).GroupBy(o => o.SOHOKHAU).Select(o => new
                           {
                               SOHOKHAU = o.Key,
                               HOTENCHUHO = o.Select(o1 => o1.HOTENCHUHO).FirstOrDefault(),
                               NGAYDK = o.Select(o1 => o1.NGAYDK).FirstOrDefault(),
                               DIACHI = o.Select(o1 => o1.DIACHI).FirstOrDefault(),
                           });

            if (textEdit1.Text != "" && textEdit2.Text == "")
                gridControl3.DataSource = hokhau_.Where(o => o.SOHOKHAU == Convert.ToInt32(textEdit1.Text)).ToList();
            else if (textEdit2.Text != "" && textEdit1.Text == "")
                gridControl3.DataSource = hokhau_.Where(o => o.HOTENCHUHO == textEdit2.Text).ToList();
            else if (textEdit1.Text != "" && (textEdit2.Text != ""))
                gridControl3.DataSource = hokhau_.Where(o => o.SOHOKHAU == Convert.ToInt32(textEdit1.Text) && o.HOTENCHUHO == textEdit2.Text).ToList();
            else
                LoadHoKhau();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            LoadHoKhau();
            textEdit1.Text = textEdit2.Text = "";
        }

        private void gridView3_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Row)
            {
                GridViewMenu menu = e.Menu as GridViewMenu;
                menu.Items.Clear();

                DXMenuItem itemSua = new DXMenuItem("Chi tiết hộ khẩu");
                itemSua.Image = imageCollection1.Images["edit"];
                itemSua.Click += new EventHandler(SuaHK);
                menu.Items.Add(itemSua);
            }
        }
        private void SuaHK(object sender, EventArgs e)
        {
            SplashScreenManager.ShowDefaultWaitForm("Đang tải", "Vui lòng chờ...");
            frmDmHOKHAU fr = new frmDmHOKHAU(gridView3.GetFocusedRowCellValue("SOHOKHAU") != null ? Convert.ToInt32(gridView3.GetFocusedRowCellValue("SOHOKHAU")) : 0);
            fr.ShowDialog();
            SplashScreenManager.CloseDefaultSplashScreen();
            LoadHoKhau();
        }

        private void layoutControlGroup2_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if (e.Button.Properties.Caption == "Làm mới")
            {
                LoadHoKhau();
                alertControl1.Show(this, "Thông báo", "Đã làm mới");
            }
        }
    }
}
