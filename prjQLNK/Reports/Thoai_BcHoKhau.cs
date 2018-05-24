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
using prjQLNK.Control;

namespace prjQLNK
{
    public partial class Thoai_BcHoKhau : DevExpress.XtraEditors.XtraForm
    {
        public Thoai_BcHoKhau()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Thoai_BcHoKhau_Load(object sender, EventArgs e)
        {
            dpkNgayLap.EditValue = DateTime.Today;
            txtNguoiLap.Text = ThongTinDN.Tencanbo;
            dateEdit1.EditValue = Bientoancuc.NgayKXTu;
            dateEdit2.EditValue = Bientoancuc.NgayKXDen;
        }
    }
}