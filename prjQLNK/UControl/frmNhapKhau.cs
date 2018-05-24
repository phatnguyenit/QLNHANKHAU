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
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace prjQLNK
{
    public partial class frmNhapKhau : XtraForm
    {
        public frmNhapKhau()
        {
            InitializeComponent();
        }

        private void gridView1_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Row)
            {
                GridViewMenu menu = e.Menu as GridViewMenu;
                menu.Items.Clear();

                DXMenuItem itemSua = new DXMenuItem("Sửa");
                itemSua.Image = imageCollection1.Images["edit"];
                itemSua.Click += new EventHandler(SuaKB);
                menu.Items.Add(itemSua);

                DXMenuItem itemXoa = new DXMenuItem("Xoá");
                itemXoa.Image = imageCollection1.Images["delete"];
                itemXoa.Click += new EventHandler(XoaKB);
                menu.Items.Add(itemXoa);

                DXMenuItem itemXemTT = new DXMenuItem("Xem thông tin người này");
                itemXemTT.Image = imageCollection1.Images["info"];
                itemXemTT.Click += new EventHandler(Chitiet);
                menu.Items.Add(itemXemTT);
            }
        }

        private void SuaKB(object sender, EventArgs e)
        {
            var k = gridView1.GetFocusedRow() as NHAPKHAU;
            if (k == null) return;
            else
            {
                var fr = new frmNhapKhauInfo(k);
                fr.ShowDialog();
                xpNHAPKHAU.Reload();
            }
        }

        private void XoaKB(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Xóa?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SplashScreenManager.ShowDefaultWaitForm("Đang xóa", "Vui lòng chờ");
                gridView1.DeleteSelectedRows();
                try
                {
                    unitNHAPKHAU.CommitChanges();
                    alertControl1.Show(this, "Thông báo", "Xóa thành công");
                }
                catch (Exception)
                {
                    alertControl1.Show(this, "Thông báo", "Không thể xóa");
                    return;
                }
                SplashScreenManager.CloseDefaultWaitForm();
            }
        }

        private void Chitiet(object sender, EventArgs e)
        {
            SplashScreenManager.ShowDefaultWaitForm("Đang tải", "Vui lòng chờ...");
            frmDmNhanKhau fr = new frmDmNhanKhau(gridView1.GetFocusedRowCellValue("MAKHAISINH") != null ? Convert.ToString(gridView1.GetFocusedRowCellValue("MAKHAISINH")) : "");
            fr.ShowDialog();
            SplashScreenManager.CloseDefaultSplashScreen();
        }

        private void cboSODINHDANH_EditValueChanged(object sender, EventArgs e)
        {

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Delete)
            {
                if (XtraMessageBox.Show("Xoá?", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    gridView1.DeleteSelectedRows();
                    unitNHAPKHAU.CommitChanges();
                }
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        List<string> iList = new List<string>();
        private void layoutControlGroup3_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if (e.Button.Properties.Caption == "Làm mới")
            {
                xpNHAPKHAU.Reload();
                alertControl1.Show(this, "Thông báo", "Đã làm mới");
            }
            if (e.Button.Properties.Caption == "Thêm")
            {
                var fr = new frmNhapKhauInfo(null);
                fr.ShowDialog();
                xpNHAPKHAU.Reload();
            }

            if (e.Button.Properties.Caption == "Sửa")
            {
                var k = gridView1.GetFocusedRow() as NHAPKHAU;
                if (k == null) return;
                else
                {
                    var fr = new frmNhapKhauInfo(k);
                    fr.ShowDialog();
                    xpNHAPKHAU.Reload();
                }
            }
            if (e.Button.Properties.Caption == "Xoá")
            {
                if (XtraMessageBox.Show("Xóa?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SplashScreenManager.ShowDefaultWaitForm("Đang xóa", "Vui lòng chờ");
                    gridView1.DeleteSelectedRows();
                    try
                    {
                        unitNHAPKHAU.CommitChanges();
                        alertControl1.Show(this, "Thông báo", "Xóa thành công");
                    }
                    catch (Exception)
                    {
                        alertControl1.Show(this, "Thông báo", "Không thể xóa");
                        return;
                    }
                    SplashScreenManager.CloseDefaultWaitForm();
                }
            }
            xpNHAPKHAU.Reload();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            var k = gridView1.GetFocusedRow() as NHAPKHAU;
            if (k == null) return;
            else
            {
                GridHitInfo info = gridView1.CalcHitInfo(gridView1.GridControl.PointToClient(System.Windows.Forms.Control.MousePosition));
                if (info.InRow || info.InRowCell)
                {
                    var fr = new frmNhapKhauInfo(k);
                    fr.ShowDialog();
                    xpNHAPKHAU.Reload();
                }
            }
        }
    }
}
