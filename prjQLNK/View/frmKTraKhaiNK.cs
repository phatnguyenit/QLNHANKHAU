using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using prjQLNK.QLNK;

namespace prjQLNK
{
    public partial class frmKTraKhaiNK : DevExpress.XtraEditors.XtraForm
    {
        public frmKTraKhaiNK()
        {
            InitializeComponent();
            LoadHoKhau();
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
                           });
            cboHoKhau.Properties.DataSource = hokhau_.ToList();
            cboHoKhau.Properties.ValueMember = "SOHOKHAU";
            cboHoKhau.Properties.DisplayMember = "SOHOKHAU";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (cboHoKhau.EditValue != null)
            {
                this.DialogResult = DialogResult.OK;
                Bientoancuc.sohokhau = Convert.ToInt32(cboHoKhau.EditValue);
                this.Close();
            }
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            frmDKHoKhau DKHK = new frmDKHoKhau();
            DKHK.ShowDialog();
            xpHOKHAU.Reload();
            xpNHANKHAU.Reload();
            LoadHoKhau();
        }
    }
}