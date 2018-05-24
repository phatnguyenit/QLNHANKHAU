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
using DevExpress.XtraSplashScreen;

namespace prjQLNK
{
    public partial class frmNhapKhauInfo : DevExpress.XtraEditors.XtraForm
    {
        NHAPKHAU _nk;
        public frmNhapKhauInfo(NHAPKHAU nk)
        {
            InitializeComponent();
            _nk = nk;
            Bindings();
            LoadHoKhau();
        }

        private void LoadHoKhau()
        {
            var hokhau_ = (from hk in xpHOKHAU.Cast<HOKHAU>()
                           join nk in xpNHANKHAU.Cast<NHANKHAU>().Where(o=>o.QUANHE== "Chủ hộ") on hk.SOHOKHAU equals nk.SOHOKHAU
                           select new
                           {
                               SOHOKHAU = hk.SOHOKHAU,
                               HOTENCHUHO = nk.HOTENKHAISINH,
                               NGAYDK = hk.NGAYDK
                           }).GroupBy(o => o.SOHOKHAU).Select(o => new
                           {
                               SOHOKHAU = o.Key,
                               HOTENCHUHO = o.Select(o1 => o1.HOTENCHUHO).FirstOrDefault(),
                           });
            searchLookUpEdit2.Properties.DataSource = hokhau_.ToList();
            searchLookUpEdit2.Properties.ValueMember = "SOHOKHAU";
            searchLookUpEdit2.Properties.DisplayMember = "SOHOKHAU";
        }
        private void Bindings()
        {
            if (_nk == null)
                _nk = new NHAPKHAU(unitNHAPKHAU);
            else
                _nk = unitNHAPKHAU.GetObjectByKey<NHAPKHAU>(_nk.ID);

            searchLookUpEdit1.DataBindings.Clear();
            searchLookUpEdit1.DataBindings.Add("EditValue", _nk, "MAKHAISINH");
            txtSHKHT.DataBindings.Clear();
            txtSHKHT.DataBindings.Add("EditValue", _nk, "SOHOKHAUHT");
            searchLookUpEdit2.DataBindings.Clear();
            searchLookUpEdit2.DataBindings.Add("EditValue", _nk, "SOHOKHAUNHAP");
            textEdit2.DataBindings.Clear();
            textEdit2.DataBindings.Add("EditValue", _nk, "QUANHEVOICH");
            dateEdit1.DataBindings.Clear();
            dateEdit1.DataBindings.Add("EditValue", _nk, "NGAYNHAP");
        }

        string makhaisinh;
        private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {


            if (!searchLookUpEdit1.IsModified) return;
            if (searchLookUpEdit1.EditValue == null || searchLookUpEdit1.EditValue == DBNull.Value) return;
            makhaisinh = searchLookUpEdit1.EditValue.ToString();
            var nk = xpNHANKHAU.Cast<NHANKHAU>().Where(o => o.MAKHAISINH == searchLookUpEdit1.EditValue.ToString()).FirstOrDefault();
            if (nk == null) return;
            _nk.MAKHAISINH = nk.MAKHAISINH;

            txtSHKHT.EditValue = _nk.SOHOKHAUHT = nk.SOHOKHAU;

        }

        private void btnSaveClose_Click(object sender, EventArgs e)
        {
            try
            {
                unitNHAPKHAU.CommitChanges();
                foreach (var item in xpNHANKHAU.Cast<NHANKHAU>().Where(o => o.MAKHAISINH == makhaisinh))
                {
                    item.SOHOKHAU = Convert.ToInt32(searchLookUpEdit2.EditValue);
                    item.QUANHE = textEdit2.Text;
                    if (txtSHKHT.EditValue != null)
                        item.GHICHU += " - Nhập khẩu từ hộ khẩu số " + txtSHKHT.Text;
                    item.Save();
                }

                alertControl1.Show(this, "Thông báo", "Đã lưu");
            }
            catch (Exception)
            { }
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            unitNHAPKHAU.CommitChanges();
            foreach (var item in xpNHANKHAU.Cast<NHANKHAU>().Where(o => o.MAKHAISINH == makhaisinh))
            {
                item.SOHOKHAU = Convert.ToInt32(searchLookUpEdit2.EditValue);
                if (txtSHKHT.EditValue != null)
                    item.GHICHU += "Nhập khẩu từ hộ khẩu số " + txtSHKHT.Text;
                item.Save();
            }
            _nk = null;
            Bindings();

            alertControl1.Show(this, "Thông báo", "Đã lưu");
        }
    }
}
