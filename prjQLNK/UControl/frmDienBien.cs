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
    public partial class frmDienBien : XtraForm
    {
        public frmDienBien()
        {
            InitializeComponent();
            //cboGT.Items.AddEnum(typeof(GioiTinh), true);
        }



        private void gridView1_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.MenuType == DevExpress.XtraGrid.Views.Grid.GridMenuType.Row)
            {
                GridViewMenu menu = e.Menu as GridViewMenu;
                menu.Items.Clear();

                DXMenuItem itemSua = new DXMenuItem("Xem thông tin");
                itemSua.Image = imageCollection1.Images["info"];
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
        }

        private void cboSODINHDANH_EditValueChanged(object sender, EventArgs e)
        {
           
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Delete)
            {
                if (XtraMessageBox.Show("Xoá diễn biến đang chọn?", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    gridView1.DeleteSelectedRows();
                    unitDIENBIEN.CommitChanges();
                }
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void layoutControlGroup3_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if (e.Button.Properties.Caption == "Làm mới")
            {
                xpDIENBIEN.Reload();
                alertControl1.Show(this, "Thông báo", "Đã làm mới");
            }
            if (e.Button.Properties.Caption == "Lưu")
            {
                SplashScreenManager.ShowDefaultWaitForm("Đang tải", "Vui lòng chờ...");
                try
                {
                    unitDIENBIEN.CommitChanges();
                    alertControl1.Show(this, "Thông báo", "Đã lưu");
                }
                catch (Exception)
                { }
                SplashScreenManager.CloseDefaultWaitForm();
            }
            if (e.Button.Properties.Caption == "Xoá")
            {
                if (gridView1.GetFocusedRowCellValue("MAKHAISINH") != null)
                {
                    if (XtraMessageBox.Show("Xóa diễn biến đang chọn?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        SplashScreenManager.ShowDefaultWaitForm("Đang xóa", "Vui lòng chờ");

                        gridView1.DeleteSelectedRows();
                        try
                        {
                            gridView1.DeleteSelectedRows();
                            unitDIENBIEN.CommitChanges();
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
            }
        }
    }
}
