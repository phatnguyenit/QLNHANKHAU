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
using DevExpress.XtraSplashScreen;

namespace prjQLNK
{
    public partial class frmDmNhanKhau : XtraForm
    {
        NHANKHAU ttnk;
        string sdd_;
        public frmDmNhanKhau(string sdd)
        {
            InitializeComponent();
            LoadDanToc();
            LoadTonGiao();
            cboGT.Properties.Items.AddEnum(typeof(GioiTinh), true);
            cboGTQH.Items.AddEnum(typeof(GioiTinh), true);
            cboGT.SelectedIndex = 0;

            sdd_ = sdd;
            if (unitDIENBIEN.TrackingChanges == true)
                xpDIENBIEN.Reload();
        }
        private void LoadDanToc()
        {
            foreach (var item in new XPQuery<DANTOC>(Session.DefaultSession).Select(o => o.TENDANTOC).ToList())
            {
                comboBoxEdit10.Properties.Items.Add(item);
                cboDTQH.Items.Add(item);
                chkCombo.Properties.Items.Add(item);
            }
        }
        private void LoadTonGiao()
        {
            foreach (var item in new XPQuery<TONGIAO>(Session.DefaultSession).Select(o => o.TENTONGIAO).ToList())
            {
                comboBoxEdit11.Properties.Items.Add(item);
            }
        }

        private void BindingsTab()
        {
            textEdit1.DataBindings.Clear();
            textEdit1.DataBindings.Add("EditValue", ttnk, "MAKHAISINH");
            textEdit2.DataBindings.Clear();
            textEdit2.DataBindings.Add("EditValue", ttnk, "HOTENKHAISINH");
            textEdit3.DataBindings.Clear();
            textEdit3.DataBindings.Add("EditValue", ttnk, "TENGOIKHAC");
            cboGT.DataBindings.Clear();
            cboGT.DataBindings.Add("EditValue", ttnk, "GIOITINH");
            dateEdit1.DataBindings.Clear();
            dateEdit1.DataBindings.Add("EditValue", ttnk, "NGAYSINH");
            textEdit9.DataBindings.Clear();
            comboBoxEdit10.DataBindings.Clear();
            comboBoxEdit10.DataBindings.Add("EditValue", ttnk, "DANTOC");
            comboBoxEdit11.DataBindings.Clear();
            comboBoxEdit11.DataBindings.Add("EditValue", ttnk, "TONGIAO");
            cboQT.DataBindings.Clear();
            cboQT.DataBindings.Add("EditValue", ttnk, "QUOCTICH");
            cb1.DataBindings.Clear();
            cb1.DataBindings.Add("EditValue", ttnk, "IDQG1");
            cb2.DataBindings.Clear();
            cb2.DataBindings.Add("EditValue", ttnk, "IDQG2");
            cb3.DataBindings.Clear();
            cb3.DataBindings.Add("EditValue", ttnk, "IDQG3");
            cb4.DataBindings.Clear();
            cb4.DataBindings.Add("EditValue", ttnk, "IDQG4");
            cb12.DataBindings.Clear();
            cb12.DataBindings.Add("EditValue", ttnk, "IDTINH1");
            cb22.DataBindings.Clear();
            cb22.DataBindings.Add("EditValue", ttnk, "IDTINH2");
            cb32.DataBindings.Clear();
            cb32.DataBindings.Add("EditValue", ttnk, "IDTINH3");
            cb42.DataBindings.Clear();
            cb42.DataBindings.Add("EditValue", ttnk, "IDTINH4");
            cb13.DataBindings.Clear();
            cb13.DataBindings.Add("EditValue", ttnk, "IDHUYEN1");
            cb23.DataBindings.Clear();
            cb23.DataBindings.Add("EditValue", ttnk, "IDHUYEN2");
            cb33.DataBindings.Clear();
            cb33.DataBindings.Add("EditValue", ttnk, "IDHUYEN3");
            cb43.DataBindings.Clear();
            cb43.DataBindings.Add("EditValue", ttnk, "IDHUYEN4");
            cb14.DataBindings.Clear();
            cb14.DataBindings.Add("EditValue", ttnk, "IDXA1");
            cb24.DataBindings.Clear();
            cb24.DataBindings.Add("EditValue", ttnk, "IDXA2");
            cb34.DataBindings.Clear();
            cb34.DataBindings.Add("EditValue", ttnk, "IDXA3");
            cb44.DataBindings.Clear();
            cb44.DataBindings.Add("EditValue", ttnk, "IDXA4");
            dc1.DataBindings.Clear();
            dc1.DataBindings.Add("EditValue", ttnk, "DC1");
            dc2.DataBindings.Clear();
            dc2.DataBindings.Add("EditValue", ttnk, "DC2");
            dc3.DataBindings.Clear();
            dc3.DataBindings.Add("EditValue", ttnk, "DC3");
            dc4.DataBindings.Clear();
            dc4.DataBindings.Add("EditValue", ttnk, "DC4");
            textEdit7.DataBindings.Clear();
            textEdit7.DataBindings.Add("EditValue", ttnk, "SOCMND");
            dateEdit2.DataBindings.Clear();
            dateEdit2.DataBindings.Add("EditValue", ttnk, "NGAYCAP");
            textEdit8.DataBindings.Clear();
            textEdit8.DataBindings.Add("EditValue", ttnk, "NOICAP");
            textEdit9.DataBindings.Add("EditValue", ttnk, "TRINHDO");
            textEdit10.DataBindings.Clear();
            textEdit10.DataBindings.Add("EditValue", ttnk, "TDCHUYENMON");
            textEdit11.DataBindings.Clear();
            textEdit11.DataBindings.Add("EditValue", ttnk, "NGHENGHIEP");
            textEdit12.DataBindings.Clear();
            textEdit12.DataBindings.Add("EditValue", ttnk, "NOILAMVIEC");
            picHA.DataBindings.Clear();
            picHA.DataBindings.Add("EditValue", ttnk, "HINHANHCD");
            textEdit4.DataBindings.Clear();
            textEdit4.DataBindings.Add("EditValue", ttnk, "QUANHE");
            chkCombo.DataBindings.Clear();
            chkCombo.DataBindings.Add("EditValue", ttnk, "BIETTIENGDANTOC");
            textEdit6.DataBindings.Clear();
            textEdit6.DataBindings.Add("EditValue", ttnk, "TDNGOAINGU");
            checkEdit1.DataBindings.Clear();
            checkEdit1.DataBindings.Add("EditValue", ttnk, "DAMAT");
            memoEdit1.DataBindings.Clear();
            memoEdit1.DataBindings.Add("EditValue", ttnk, "GHICHU");
            dxErrorProvider1.DataSource = ttnk;
        }
        private void xtraTabControl2_CustomHeaderButtonClick(object sender, DevExpress.XtraTab.ViewInfo.CustomHeaderButtonEventArgs e)
        {
            if (sdd_ != "" && e.Button.Caption == "In bản khai")
            {

                if (IDNK == 0)
                {
                    SplashScreenManager.ShowDefaultWaitForm("Đang tạo báo cáo", "Vui lòng chờ...");
                    frmReport fr = new frmReport();
                    fr.Text = "BẢN KHAI NHÂN KHẨU";
                    BcBKNKnull re = new BcBKNKnull();
                    fr.docView.PrintingSystem = re.PrintingSystem;
                    re.CreateDocument();
                    fr.ShowDialog();
                    SplashScreenManager.CloseDefaultWaitForm();
                }
                else
                {
                    Bientoancuc.inSua = true;
                    Thoai_BcBKNhanKhau fr1 = new Thoai_BcBKNhanKhau(IDNK);
                    fr1.ShowDialog();
                }
            }
            if (e.Button.Caption == "Lưu thông tin")
            {
                SplashScreenManager.ShowDefaultWaitForm("Đang tải", "Vui lòng chờ...");
                try
                {
                    unitNHANKHAU.CommitChanges();
                    unitQUATRINH.CommitChanges();
                    unitQUANHE.CommitChanges();
                    unitTIENAN.CommitChanges();
                    unitDIENBIEN.CommitChanges();
                    unitTAMVANG.CommitChanges();
                    alertControl1.Show(this, "Thông báo", "Đã lưu");
                }
                catch (Exception)
                { }
                SplashScreenManager.CloseDefaultWaitForm();
            }
            else if (e.Button.Caption == "Xoá nhân khẩu")
            {
                SplashScreenManager.ShowDefaultWaitForm("Đang tải", "Vui lòng chờ...");
                if (XtraMessageBox.Show("Xoá nhân khẩu đang chọn?", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (var item in new XPQuery<NHANKHAU>(Session.DefaultSession).Where(o => o.ID == IDNK).ToList())
                    {
                        item.Delete();
                    }
                    xpNHANKHAU.Reload();
                    gridView3_FocusedRowChanged(null, null);
                }
                SplashScreenManager.CloseDefaultWaitForm();
            }
            else if (e.Button.Caption == "Làm mới")
            {
                xpNHANKHAU.Reload();
                alertControl1.Show(this, "Thông báo", "Đã làm mới");
            }
        }
        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gridView1.SetFocusedRowCellValue("MAKHAISINH", textEdit1.EditValue);
        }

        private void gridView2_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gridView2.SetFocusedRowCellValue("MAKHAISINH", textEdit1.EditValue);
        }

        private void gridView21_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gridView21.SetFocusedRowCellValue("MAKHAISINH", textEdit1.EditValue);
        }

        private void gridView4_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gridView4.SetFocusedRowCellValue("MAKHAISINH", textEdit1.EditValue);
        }

        private void gridView6_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            gridView6.SetFocusedRowCellValue("MAKHAISINH", textEdit1.EditValue);
        }
        string select = "";
        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (textEdit1.EditValue != null)
            {
                SplashScreenManager.ShowDefaultWaitForm("Đang tải", "Vui lòng chờ...");
                switch (((DevExpress.XtraTab.XtraTabControl)sender).SelectedTabPageIndex)
                {
                    case 0:
                        {
                            select = "";
                            break;
                        }
                    case 1:
                        {
                            //xpQUATRINH.CriteriaString = "MAKHAISINH ='" + textEdit1.EditValue.ToString() + "'";
                            select = "qt";
                            break;
                        }
                    case 2:
                        {
                            //xpQUANHE.CriteriaString = "MAKHAISINH ='" + textEdit1.EditValue.ToString() + "'";
                            select = "qh";
                            break;
                        }
                    case 3:
                        {
                            //xpTIENAN.CriteriaString = "MAKHAISINH ='" + textEdit1.EditValue.ToString() + "'";
                            select = "ta";
                            break;
                        }
                    case 4:
                        {
                            //xpTIENAN.CriteriaString = "MAKHAISINH ='" + textEdit1.EditValue.ToString() + "'";
                            select = "db";
                            break;
                        }
                    case 5:
                        {
                            //xpTIENAN.CriteriaString = "MAKHAISINH ='" + textEdit1.EditValue.ToString() + "'";
                            select = "tv";
                            break;
                        }
                }
                SplashScreenManager.CloseDefaultWaitForm();
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Delete)
            {
                if (select == "qt")
                {
                    if (XtraMessageBox.Show("Xoá quá trình đang chọn?", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        gridView1.DeleteSelectedRows();
                        unitQUATRINH.CommitChanges();
                    }
                    return true;
                }
                if (select == "qh")
                {
                    if (XtraMessageBox.Show("Xoá quan hệ đang chọn?", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        gridView2.DeleteSelectedRows();
                        unitQUANHE.CommitChanges();
                    }
                    return true;
                }
                if (select == "ta")
                {
                    if (XtraMessageBox.Show("Xoá tiền án đang chọn?", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        gridView21.DeleteSelectedRows();
                        unitTIENAN.CommitChanges();
                    }
                    return true;
                }
                if (select == "db")
                {
                    if (XtraMessageBox.Show("Xoá diễn biến đang chọn?", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        gridView4.DeleteSelectedRows();
                        unitDIENBIEN.CommitChanges();
                    }
                    return true;
                }
                if (select == "tv")
                {
                    if (XtraMessageBox.Show("Xoá tạm trú-tạm vắng đang chọn?", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        gridView6.DeleteSelectedRows();
                        unitTAMVANG.CommitChanges();
                    }
                    return true;
                }
                if (keyData == (Keys.Control | Keys.S))
                {
                    SplashScreenManager.ShowDefaultWaitForm("Đang tải", "Vui lòng chờ...");
                    try
                    {
                        unitNHANKHAU.CommitChanges();
                        unitQUATRINH.CommitChanges();
                        unitQUANHE.CommitChanges();
                        unitTIENAN.CommitChanges();
                        unitDIENBIEN.CommitChanges();
                        unitTAMVANG.CommitChanges();
                        alertControl1.Show(this, "Thông báo", "Đã lưu");
                    }
                    catch (Exception)
                    { }
                    SplashScreenManager.CloseDefaultWaitForm();
                }
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public int IDNK = 0;
        private void gridView3_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            IDNK = gridView3.GetFocusedRowCellValue("ID") != null ? Convert.ToInt32(gridView3.GetFocusedRowCellValue("ID")) : 0;
            string MKS = gridView3.GetFocusedRowCellValue("MAKHAISINH") != null ? Convert.ToString(gridView3.GetFocusedRowCellValue("MAKHAISINH")) : "";
            xpQUATRINH.CriteriaString = "MAKHAISINH ='" + MKS + "'";
            xpQUANHE.CriteriaString = "MAKHAISINH ='" + MKS + "'";
            xpTIENAN.CriteriaString = "MAKHAISINH ='" + MKS + "'";
            xpDIENBIEN.CriteriaString = "MAKHAISINH ='" + MKS + "'";
            xpTAMVANG.CriteriaString = "MAKHAISINH ='" + MKS + "'";
            Bientoancuc.IDNK = IDNK;
            if (IDNK != 0)
            {
                ttnk = unitNHANKHAU.GetObjectByKey<NHANKHAU>(IDNK);
                BindingsTab();
            }
            else
            {
                textEdit1.EditValue = null;
                textEdit2.EditValue = null;
                textEdit3.EditValue = null;
                dateEdit1.EditValue = null;
                cboGT.EditValue = null;
                textEdit9.EditValue = null;
                comboBoxEdit10.EditValue = null;
                comboBoxEdit11.EditValue = null;
                cboQT.EditValue = null;
                cb1.EditValue = null;
                cb2.EditValue = null;
                cb3.EditValue = null;
                cb4.EditValue = null;
                cb12.EditValue = null;
                cb22.EditValue = null;
                cb32.EditValue = null;
                cb42.EditValue = null;
                cb13.EditValue = null;
                cb23.EditValue = null;
                cb33.EditValue = null;
                cb43.EditValue = null;
                cb14.EditValue = null;
                cb24.EditValue = null;
                cb34.EditValue = null;
                cb44.EditValue = null;
                dc1.EditValue = null;
                dc2.EditValue = null;
                dc3.EditValue = null;
                dc4.EditValue = null;
                textEdit7.EditValue = null;
                dateEdit2.EditValue = null;
                textEdit8.EditValue = null;
                textEdit10.EditValue = null;
                textEdit11.EditValue = null;
                textEdit12.EditValue = null;
                picHA.EditValue = null;
                textEdit4.EditValue = null;
            }
        }

        private void cb1_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit lk = sender as LookUpEdit;
            if (lk.Properties.GetDisplayText(lk.EditValue).ToString() != "")
            {
                int ID = xpQUOCTICH.Cast<QUOCTICH>().Where(o => o.TENQUOCTICH == lk.Properties.GetDisplayText(lk.EditValue).ToString()).Select(o => o.ID).FirstOrDefault();
                cb12.Properties.DataSource = xpTINH.Cast<TINH>().Where(o => o.IDQUOCGIA == ID).ToList();
            }
            else
            {
                cb12.Properties.DataSource = xpTINH.Cast<TINH>().Select(o => new { TENTINH = o.TENTINH }).ToList();
                cb13.Properties.DataSource = xpHUYEN.Cast<HUYEN>().Select(o => new { TENHUYEN = o.TENHUYEN }).ToList();
                cb14.Properties.DataSource = xpXA.Cast<XA>().Select(o => new { TENXA = o.TENXA }).ToList();
            }
        }

        private void cb12_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit lk = sender as LookUpEdit;
            if (lk.Properties.GetDisplayText(lk.EditValue).ToString() != "")
            {
                int ID = xpTINH.Cast<TINH>().Where(o => o.TENTINH == lk.Properties.GetDisplayText(lk.EditValue).ToString()).Select(o => o.MATINH).FirstOrDefault();
                cb13.Properties.DataSource = xpHUYEN.Cast<HUYEN>().Where(o => o.MATINH == ID).ToList();
            }
            else
            {
                cb13.Properties.DataSource = xpHUYEN.Cast<HUYEN>().Select(o => new { TENHUYEN = o.TENHUYEN }).ToList();
                cb14.Properties.DataSource = xpXA.Cast<XA>().Select(o => new { TENXA = o.TENXA }).ToList();
            }
        }

        private void cb13_EditValueChanged_1(object sender, EventArgs e)
        {
            LookUpEdit lk = sender as LookUpEdit;
            if (lk.Properties.GetDisplayText(lk.EditValue).ToString() != "")
            {
                int ID = xpHUYEN.Cast<HUYEN>().Where(o => o.TENHUYEN == lk.Properties.GetDisplayText(lk.EditValue).ToString()).Select(o => o.MAHUYEN).FirstOrDefault();
                cb14.Properties.DataSource = xpXA.Cast<XA>().Where(o => o.MAHUYEN == ID).ToList();
            }
            else
                cb14.Properties.DataSource = xpXA.Cast<XA>().Select(o => new { TENXA = o.TENXA }).ToList();
        }

        private void cb2_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit lk = sender as LookUpEdit;
            if (lk.Properties.GetDisplayText(lk.EditValue).ToString() != "")
            {
                int ID = xpQUOCTICH.Cast<QUOCTICH>().Where(o => o.TENQUOCTICH == lk.Properties.GetDisplayText(lk.EditValue).ToString()).Select(o => o.ID).FirstOrDefault();
                cb22.Properties.DataSource = xpTINH.Cast<TINH>().Where(o => o.IDQUOCGIA == ID).ToList();
            }
            else
            {
                cb22.Properties.DataSource = xpTINH.Cast<TINH>().Select(o => new { TENTINH = o.TENTINH }).ToList();
                cb23.Properties.DataSource = xpHUYEN.Cast<HUYEN>().Select(o => new { TENHUYEN = o.TENHUYEN }).ToList();
                cb24.Properties.DataSource = xpXA.Cast<XA>().Select(o => new { TENXA = o.TENXA }).ToList();
            }
        }

        private void cb22_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit lk = sender as LookUpEdit;
            if (lk.Properties.GetDisplayText(lk.EditValue).ToString() != "")
            {
                int ID = xpTINH.Cast<TINH>().Where(o => o.TENTINH == lk.Properties.GetDisplayText(lk.EditValue).ToString()).Select(o => o.MATINH).FirstOrDefault();
                cb23.Properties.DataSource = xpHUYEN.Cast<HUYEN>().Where(o => o.MATINH == ID).ToList();
            }
            else
            {
                cb23.Properties.DataSource = xpHUYEN.Cast<HUYEN>().Select(o => new { TENHUYEN = o.TENHUYEN }).ToList();
                cb24.Properties.DataSource = xpXA.Cast<XA>().Select(o => new { TENXA = o.TENXA }).ToList();
            }
        }

        private void cb23_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit lk = sender as LookUpEdit;
            if (lk.Properties.GetDisplayText(lk.EditValue).ToString() != "")
            {
                int ID = xpHUYEN.Cast<HUYEN>().Where(o => o.TENHUYEN == lk.Properties.GetDisplayText(lk.EditValue).ToString()).Select(o => o.MAHUYEN).FirstOrDefault();
                cb24.Properties.DataSource = xpXA.Cast<XA>().Where(o => o.MAHUYEN == ID).ToList();
            }
            else
                cb24.Properties.DataSource = xpXA.Cast<XA>().Select(o => new { TENXA = o.TENXA }).ToList();
        }

        private void cb3_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit lk = sender as LookUpEdit;
            if (lk.Properties.GetDisplayText(lk.EditValue).ToString() != "")
            {
                int ID = xpQUOCTICH.Cast<QUOCTICH>().Where(o => o.TENQUOCTICH == lk.Properties.GetDisplayText(lk.EditValue).ToString()).Select(o => o.ID).FirstOrDefault();
                cb32.Properties.DataSource = xpTINH.Cast<TINH>().Where(o => o.IDQUOCGIA == ID).ToList();
            }
            else
            {
                cb32.Properties.DataSource = xpTINH.Cast<TINH>().Select(o => new { TENTINH = o.TENTINH }).ToList();
                cb33.Properties.DataSource = xpHUYEN.Cast<HUYEN>().Select(o => new { TENHUYEN = o.TENHUYEN }).ToList();
                cb34.Properties.DataSource = xpXA.Cast<XA>().Select(o => new { TENXA = o.TENXA }).ToList();
            }
        }

        private void cb32_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit lk = sender as LookUpEdit;
            if (lk.Properties.GetDisplayText(lk.EditValue).ToString() != "")
            {
                int ID = xpTINH.Cast<TINH>().Where(o => o.TENTINH == lk.Properties.GetDisplayText(lk.EditValue).ToString()).Select(o => o.MATINH).FirstOrDefault();
                cb33.Properties.DataSource = xpHUYEN.Cast<HUYEN>().Where(o => o.MATINH == ID).ToList();
            }
            else
            {
                cb33.Properties.DataSource = xpHUYEN.Cast<HUYEN>().Select(o => new { TENHUYEN = o.TENHUYEN }).ToList();
                cb34.Properties.DataSource = xpXA.Cast<XA>().Select(o => new { TENXA = o.TENXA }).ToList();
            }
        }

        private void cb33_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit lk = sender as LookUpEdit;
            if (lk.Properties.GetDisplayText(lk.EditValue).ToString() != "")
            {
                int ID = xpHUYEN.Cast<HUYEN>().Where(o => o.TENHUYEN == lk.Properties.GetDisplayText(lk.EditValue).ToString()).Select(o => o.MAHUYEN).FirstOrDefault();
                cb34.Properties.DataSource = xpXA.Cast<XA>().Where(o => o.MAHUYEN == ID).ToList();
            }
            else
                cb34.Properties.DataSource = xpXA.Cast<XA>().Select(o => new { TENXA = o.TENXA }).ToList();
        }

        private void cb4_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit lk = sender as LookUpEdit;
            if (lk.Properties.GetDisplayText(lk.EditValue).ToString() != "")
            {
                int ID = xpQUOCTICH.Cast<QUOCTICH>().Where(o => o.TENQUOCTICH == lk.Properties.GetDisplayText(lk.EditValue).ToString()).Select(o => o.ID).FirstOrDefault();
                cb42.Properties.DataSource = xpTINH.Cast<TINH>().Where(o => o.IDQUOCGIA == ID).ToList();
            }
            else
            {
                cb42.Properties.DataSource = xpTINH.Cast<TINH>().Select(o => new { TENTINH = o.TENTINH }).ToList();
                cb43.Properties.DataSource = xpHUYEN.Cast<HUYEN>().Select(o => new { TENHUYEN = o.TENHUYEN }).ToList();
                cb44.Properties.DataSource = xpXA.Cast<XA>().Select(o => new { TENXA = o.TENXA }).ToList();
            }
        }

        private void cb42_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit lk = sender as LookUpEdit;
            if (lk.Properties.GetDisplayText(lk.EditValue).ToString() != "")
            {
                int ID = xpTINH.Cast<TINH>().Where(o => o.TENTINH == lk.Properties.GetDisplayText(lk.EditValue).ToString()).Select(o => o.MATINH).FirstOrDefault();
                cb43.Properties.DataSource = xpHUYEN.Cast<HUYEN>().Where(o => o.MATINH == ID).ToList();
            }
            else
            {
                cb43.Properties.DataSource = xpHUYEN.Cast<HUYEN>().Select(o => new { TENHUYEN = o.TENHUYEN }).ToList();
                cb44.Properties.DataSource = xpXA.Cast<XA>().Select(o => new { TENXA = o.TENXA }).ToList();
            }
        }

        private void cb43_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit lk = sender as LookUpEdit;
            if (lk.Properties.GetDisplayText(lk.EditValue).ToString() != "")
            {
                int ID = xpHUYEN.Cast<HUYEN>().Where(o => o.TENHUYEN == lk.Properties.GetDisplayText(lk.EditValue).ToString()).Select(o => o.MAHUYEN).FirstOrDefault();
                cb44.Properties.DataSource = xpXA.Cast<XA>().Where(o => o.MAHUYEN == ID).ToList();
            }
            else
                cb44.Properties.DataSource = xpXA.Cast<XA>().Select(o => new { TENXA = o.TENXA }).ToList();
        }

        private void frmDmNhanKhau_Load(object sender, EventArgs e)
        {
            gridView3.FocusedRowHandle = 0;
            if (sdd_ != "")
                for (int i = 0; i < gridView3.DataRowCount; i++)
                {
                    object b = gridView3.GetRowCellValue(i, "MAKHAISINH");
                    if (b != null && b.Equals(sdd_))
                    {
                        gridView3.FocusedRowHandle = i;
                        return;
                    }
                }
        }
    }
}