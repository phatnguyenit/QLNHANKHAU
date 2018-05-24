using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using prjQLNK.QLNK;
using DevExpress.Xpo;

namespace prjQLNK
{
    public partial class frmDmHOKHAU : XtraForm
    {
        public frmDmHOKHAU(int shk)
        {
            InitializeComponent();
            LoadHoKhau();

            if (shk != 0)
                for (int i = 0; i < gridView1.DataRowCount; i++)
                {
                    object b = gridView1.GetRowCellValue(i, "SOHOKHAU");
                    if (b != null && b.Equals(shk))
                    {
                        gridView1.FocusedRowHandle = i;
                        return;
                    }
                }
        }
        private void LoadHoKhau()
        {
            var hokhau_ = (from hk in xpHOKHAU.Cast<HOKHAU>()
                           join nk in xpNHANKHAU.Cast<NHANKHAU>().Where(o => o.QUANHE == "Chủ hộ") on hk.SOHOKHAU equals nk.SOHOKHAU
                           select new
                           {
                               SOHOKHAU = hk.SOHOKHAU,
                               HOTENCHUHO = nk.HOTENKHAISINH,
                               NGAYDK = hk.NGAYDK
                           }).GroupBy(o => o.SOHOKHAU).Select(o => new
                           {
                               SOHOKHAU = o.Key,
                               HOTENCHUHO = o.Select(o1 => o1.HOTENCHUHO).FirstOrDefault(),
                               NGAYDK = o.Select(o1 => o1.NGAYDK).FirstOrDefault()
                           });
            gridControl1.DataSource = hokhau_;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int SOHOKHAU_ = gridView1.GetFocusedRowCellValue("SOHOKHAU") != null ? Convert.ToInt32(gridView1.GetFocusedRowCellValue("SOHOKHAU")) : 0;
            var nk_ = (from a in xpNHANKHAU.Cast<NHANKHAU>().Where(o => o.SOHOKHAU == SOHOKHAU_)
                       select new
                       {
                           HOTENKHAISINH = a.HOTENKHAISINH,
                           GIOITINH = a.GIOITINH == 0 ? "Nam" : "Nữ",
                           NGAYSINH = a.NGAYSINH,
                           NOISINH = a.DC1 + ", xã " + a.IDXA1 + ", huyện " + a.IDHUYEN1 + ", tỉnh " + a.IDTINH1,
                           QUANHE = a.QUANHE,
                           DANTOC = a.DANTOC,
                           QUOCTICH = a.QUOCTICH,
                           DAMAT = a.DAMAT == true ? "Đã mất" : ""
                       }).ToList();
            gridControl2.DataSource = nk_;

            textEdit1.Text = SOHOKHAU_.ToString();
            textEdit2.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("HOTENCHUHO"));
            textEdit3.EditValue = Convert.ToDateTime(gridView1.GetFocusedRowCellValue("NGAYDK"));
        }

        private void layoutControlGroup2_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {

        }


        //if (e.Button.Properties.Caption == "Xoá")
        //    if (XtraMessageBox.Show("Xoá sổ hộ khẩu?", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //    {
        //        gridView1.DeleteSelectedRows();
        //        unitHOKHAU.CommitChanges();
        //        xpHOKHAU.Reload();
        //        XtraMessageBox.Show("Đã xoá sổ hộ khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        gridView1_FocusedRowChanged(null, null);
        //    }
        //if (e.Button.Properties.Caption == "Lưu")
        //{
        //    try
        //    {
        //        unitHOKHAU.CommitChanges();
        //        xpHOKHAU.Reload();
        //        XtraMessageBox.Show("Đã lưu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        gridView1_FocusedRowChanged(null, null);
        //    }
        //    catch (Exception)
        //    {
        //        return;
        //    }
        //}

        private void dockPanel1_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
        }

        private void layoutControlGroup2_CustomButtonClick_1(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if (e.Button.Properties.Caption == "Làm mới")
            {
                LoadHoKhau();
                alertControl1.Show(this, "Thông báo", "Đã làm mới");
            }
            if (e.Button.Properties.Caption == "Lưu")
            {
                if (textEdit1.Text != "0")
                {
                    foreach (var item in new XPQuery<HOKHAU>(Session.DefaultSession).Where(o => o.SOHOKHAU == Convert.ToInt32(textEdit1.Text)))
                    {
                        item.NGAYDK = Convert.ToDateTime(textEdit3.Text);
                        item.Save();
                    }

                }
                LoadHoKhau();
                alertControl1.Show(this, "Thông báo", "Đã lưu");
                gridView1_FocusedRowChanged(null, null);
            }
            if (e.Button.Properties.Caption == "Xoá")
                if (XtraMessageBox.Show("Xoá sổ hộ khẩu?", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (var item in new XPQuery<HOKHAU>(Session.DefaultSession).Where(o => o.SOHOKHAU == Convert.ToInt32(textEdit1.Text)))
                    {
                        item.Delete();
                    }
                    LoadHoKhau();
                    alertControl1.Show(this, "Thông báo", "Đã xoá sổ hộ khẩu");
                    gridView1_FocusedRowChanged(null, null);
                }

        }
    }
}