using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using prjQLNK.Model;
using prjQLNK.Control;
using System.Data.SqlClient;
using prjQLNK.QLNK;
using DevExpress.XtraSplashScreen;
using DevExpress.Xpo;

namespace prjQLNK
{
    public partial class frmDKHoKhau : DevExpress.XtraEditors.XtraForm
    {
        HOKHAU hkhau;
        public frmDKHoKhau()
        {
            InitializeComponent();
            imageComboBoxEdit1.Properties.Items.AddEnum(typeof(GioiTinh), true);
            imageComboBoxEdit1.SelectedIndex = 0;
            LoadDanToc();
            hkhau = new HOKHAU(unitOfWork1);
            BindingsTab();
        }

        private void BindingsTab()
        {
            textEdit1.DataBindings.Clear();
            textEdit1.DataBindings.Add("EditValue", hkhau, "SOHOKHAU");
            dateEdit1.DataBindings.Clear();
            dateEdit1.DataBindings.Add("EditValue", hkhau, "NGAYDK");
        }
        private void LoadDanToc()
        {
            foreach (var item in new XPQuery<DANTOC>(Session.DefaultSession).Select(o => o.TENDANTOC).ToList())
            {
                comboBoxEdit1.Properties.Items.Add(item);
            }
        }

        private void frmDKHoKhau_Load(object sender, EventArgs e)
        {
            dateEdit1.EditValue = DateTime.Today;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textEdit2.Text == "")
                {
                    Messages.MessagesBox.Error("Vui lòng nhập tên chủ hộ!.");
                    textEdit2.Focus();
                }
                else
                {
                    try
                    {

                        NHANKHAU nhkh_ = new NHANKHAU(Session.DefaultSession);
                        nhkh_.SOHOKHAU = Convert.ToInt32(textEdit1.Text);
                        nhkh_.HOTENKHAISINH = textEdit2.Text;
                        if (imageComboBoxEdit1.EditValue != null)
                            nhkh_.GIOITINH = Convert.ToInt32(imageComboBoxEdit1.EditValue);
                        if (dateEdit2.EditValue != null)
                            nhkh_.NGAYSINH = Convert.ToDateTime(dateEdit2.EditValue);
                        if (dateEdit2.EditValue != null)
                            nhkh_.DANTOC = comboBoxEdit1.EditValue.ToString();
                        if (cboQT.EditValue != null)
                            nhkh_.QUOCTICH = cboQT.EditValue.ToString();
                        if (cb4.EditValue != null)
                            nhkh_.IDQG4 = cb4.EditValue.ToString();
                        if (cb42.EditValue != null)
                            nhkh_.IDTINH4 = cb42.EditValue.ToString();
                        if (cb43.EditValue != null)
                            nhkh_.IDHUYEN4 = cb43.EditValue.ToString();
                        if (cb44.EditValue != null)
                            nhkh_.IDXA4 = cb44.EditValue.ToString();
                        if (dc4.EditValue != null)
                            nhkh_.DC4 = dc4.EditValue.ToString();
                        nhkh_.QUANHE = "Chủ hộ";
                        nhkh_.Save();
                    }
                    catch (Exception)
                    {
                        XtraMessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    SplashScreenManager.ShowDefaultWaitForm("Đang tải", "Vui lòng chờ...");
                    try
                    {
                        unitOfWork1.CommitChanges();

                    }
                    catch (Exception)
                    { }

                    DialogResult h = XtraMessageBox.Show("Đã đăng ký hộ khẩu mới, vui lòng vào danh mục nhân khẩu để cập nhân thông tin chủ hộ (Số sổ hộ khẩu: " + textEdit1.Text + ")", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    SplashScreenManager.CloseDefaultWaitForm();
                }
            }
            catch (Exception)
            {
                return;
            }
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
    }
}